using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspanGround_2
{
    
    public partial class Intro : Form
    {
        private Timer _timer;
        public Intro()
        {
            InitializeComponent();
           
            _timer = new Timer { Interval = 2000 };
            _timer.Tick += (s, e) =>
            {
                _timer.Stop();
                this.Close();
            };
            _timer.Start();
        }
    }
}
    

