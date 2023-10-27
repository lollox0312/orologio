using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orologio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = (this.Width - (ClientSize.Height * 3 / 4)) / 2;
            int y =(ClientSize.Height - (ClientSize.Height * 3/ 4)) / 2;
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(Pens.Black, x, y, ClientSize.Height*3/4, ClientSize.Height*3/4 );
        }
    }
}
