
(function () {
    
    let wpcounter = 1;
    let mapInstance = null;
    let waypointObjects = [];
    let ihaMarker = null;

    const START_LAT = 41.017415;
    const START_LNG = 28.986562;

    
    function getMap() {
        if (typeof map !== 'undefined' && map !== null) return map;  //Harita oluþutrma
        if (mapInstance) return mapInstance;

        mapInstance = L.map('map').setView([START_LAT, START_LNG], 13);
        L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
            maxZoom: 19,
            attribution: '&copy; OpenStreetMap'
        }).addTo(mapInstance);

        return mapInstance;
    }

    
    function init() {
        const m = getMap();

        //Drone imleci
        const planeSvg = `
      <div id="drone-wrapper" style="width:46px;height:46px;display:flex;align-items:center;justify-content:center;transform-origin:center;">
      <svg xmlns="http://www.w3.org/2000/svg" width="100" height="100" viewBox="0 0 100 100" fill="none">
  <g fill="#1EB0F6" fill-rule="evenodd">

    <path d="M0 100L50 0L100 100L50 74.0507L0 100Z"/><path d="M50 74.0507L92.4509 96.0821L100 100L96.1963 92.3927L52.7952 5.59021L50 0L47.2048 5.59021L3.80371 92.3927L0 100L7.54907 96.0821L50 74.0507ZM11.3528 88.4748L50 68.4174L88.6472 88.4748L50 11.1804L11.3528 88.4748Z" fill="#F1F1F1" fill-rule="evenodd"/>
  </g>

         <g xmlns="http://www.w3.org/2000/svg" fill="#1EB0F6" fill-rule="evenodd">
        <path d="M0 100L50 0L100 100L50 74.0507L0 100Z"/><path d="M50 74.0507L92.4509 96.0821L100 100L96.1963 92.3927L52.7952 5.59021L50 0L47.2048 5.59021L3.80371 92.3927L0 100L7.54907 96.0821L50 74.0507ZM11.3528 88.4748L50 68.4174L88.6472 88.4748L50 11.1804L11.3528 88.4748Z" fill="#F1F1F1" fill-rule="evenodd"/>
  </g>
  </svg>
      </div>

`       ;

        ihaMarker = L.marker([START_LAT, START_LNG], {
            icon: L.divIcon({ className: '', html: planeSvg,  iconAnchor: [28, 28] })
        }).addTo(m);

        // Fare imleci (küçük nokta,siyah takip eder)
        /*let cursorMarker = null;
        function ensureCursorMarker() {
            if (!cursorMarker) {
                cursorMarker = L.marker([0, 0], {
                    interactive: false,
                    icon: L.divIcon({
                        className: '',
                        html: '<div style="width:8px;height:8px;border-radius:50%;background:#222;opacity:0.9;box-shadow:0 0 3px rgba(0,0,0,0.4)"></div>',
                        iconSize: [8, 8],
                        iconAnchor: [4, 4]
                    })
                }).addTo(m);
            }
        }

        m.on('mousemove', function (e) { ensureCursorMarker(); cursorMarker.setLatLng(e.latlng); });
        m.on('mouseout', function () { if (cursorMarker) { m.removeLayer(cursorMarker); cursorMarker = null; } });*/

        //waypoint ekleme
        m.on('click', function (e) {
            addWaypoint(e.latlng);
        });
    }

    // UID üretici
    function generateUid() {
        return 'wp_' + Date.now().toString(36) + '_' + Math.floor(Math.random() * 10000).toString(36);
    }

    // Waypoint ekle
    function addWaypoint(latlng) {
        if (!latlng || typeof latlng.lat !== 'number' || typeof latlng.lng !== 'number') return;

        const uid = generateUid();

        const wpMarker = L.circleMarker(latlng, {
            radius: 6,
            color: '#ff0000',
            weight: 2,
            fillColor: '#ff6666',
            fillOpacity: 1
        }).addTo(getMap());

        wpMarker.bindTooltip('WP-' + wpcounter, { permanent: true, direction: 'bottom', className: 'my-tooltip' }).openTooltip();

        waypointObjects.push({ id: uid, latlng: latlng, marker: wpMarker });
        const idx = waypointObjects.length - 1;
        wpcounter = waypointObjects.length + 1;

        // Loglama yeri
        console.log('addWaypoint -> idx:', idx, 'id:', uid, 'lat:', latlng.lat, 'lng:', latlng.lng);

        // C#'a gönderme yeri
        sendMessageToCSharp({ action: 'add', idx: idx, id: uid, lat: Number(latlng.lat), lng: Number(latlng.lng) });
    }

    // remove: id veya idx ile çalýþýr. JS tarafýnda haritadan sil ve C#'a 'removed' bildir.
    window.removeWaypointFromJS = function (idOrIdx) {
        try {
            if (!Array.isArray(waypointObjects)) waypointObjects = [];

            let removedUid = null;
            if (typeof idOrIdx === 'string') {
                // uid ile sil
                const uid = idOrIdx;
                const index = waypointObjects.findIndex(o => o.id === uid);
                if (index === -1) {
                    console.warn('removeWaypointFromJS: uid bulunamadý:', uid);
                    return;
                }
                const obj = waypointObjects[index];
                getMap().removeLayer(obj.marker);
                waypointObjects.splice(index, 1);
                removedUid = uid;
            } else {
                // sayýsal idx ile sil (fallback)
                const idx = Number(idOrIdx);
                if (Number.isNaN(idx) || idx < 0 || idx >= waypointObjects.length) {
                    console.warn('removeWaypointFromJS: geçersiz idx:', idOrIdx);
                    return;
                }
                const obj = waypointObjects[idx];
                getMap().removeLayer(obj.marker);
                waypointObjects.splice(idx, 1);
                removedUid = obj.id;
            }

            // Tooltip metinlerini güncelle (WP-#)
            for (let i = 0; i < waypointObjects.length; i++) {
                const m = waypointObjects[i].marker;
                m.unbindTooltip();
                m.bindTooltip('WP-' + (i + 1), { permanent: true, direction: 'bottom', className: 'my-tooltip' }).openTooltip();
            }

            // counter güncelle
            wpcounter = waypointObjects.length + 1;

            console.log('removeWaypointFromJS -> removed UID:', removedUid);

            // C#'a silindiðini bildir — id ile
            sendMessageToCSharp({ action: 'removed', id: removedUid });
        } catch (err) {
            console.error('removeWaypointFromJS hata:', err);
        }
    };

    // C# -> JS: IHA pozisyonunu güncelle (alt ignor edilir), yaw derece ile döndürür
    window.updateIhaPosition = function (lng, lat, alt, yaw, pitch, roll) {
        try {
            if (!ihaMarker) init();

            const nLat = (lat == null ? START_LAT : Number(lat));
            const nLng = (lng == null ? START_LNG : Number(lng));
            const nYaw = (yaw == null ? 0 : Number(yaw));

            if (Number.isNaN(nLat) || Number.isNaN(nLng)) {
                console.warn('updateIhaPosition: geçersiz lat/lng', lat, lng);
                return;
            }

            ihaMarker.setLatLng([nLat, nLng]);

            const droneEl = document.getElementById('drone-wrapper');
            if (droneEl) {
                // rotate merkezini koru
                droneEl.style.transform = `rotate(${nYaw}deg)`;
            }
        } catch (e) {
            console.error('updateIhaPosition hata:', e);
        }
    };

    // WebView2 ile C#'a güvenli postMessage; ayrýca console.log fallback
    function sendMessageToCSharp(obj) {
        try {
            // sayýsal alanlarý garanti altýna al
            if (obj && typeof obj.lat !== 'undefined') obj.lat = Number(obj.lat);
            if (obj && typeof obj.lng !== 'undefined') obj.lng = Number(obj.lng);

            // JSON stringify burada yapýlacak (webview.postMessage bazen nesne kabul eder ama güven için string)
            const payload = obj;

            if (window.chrome?.webview) {
                // WebView2'ye obje olarak gönderilebilir
                window.chrome.webview.postMessage(payload);
            } else {
                // Geliþtirme aþamasýnda görülsün
                console.log('toCSharp:', payload);
            }
        } catch (e) {
            console.error('sendMessageToCSharp hata:', e);
        }
    }

    // Minimal dýþ API
    window.ihaLeaflet = {
        addWaypoint: function (lat, lng) { addWaypoint(L.latLng(Number(lat), Number(lng))); },
        getWaypoints: function () {
            // return shallow copy of objects with id + lat/lng
            return waypointObjects.map(o => ({ id: o.id, lat: o.latlng.lat, lng: o.latlng.lng }));
        },
        focusIha: function () { if (ihaMarker) getMap().setView(ihaMarker.getLatLng(), 18); }
    };

    // Auto init
    if (document.readyState === 'loading') document.addEventListener('DOMContentLoaded', init); else init();

})();
