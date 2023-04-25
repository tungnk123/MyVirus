using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVirus
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Blue;
            this.TopMost = true;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("ERROR", "ERROR");
        }
    }
}
