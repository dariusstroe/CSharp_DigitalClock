using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public ContentAlignment ToolBarTextAlign { get; private set; }
        public ContentAlignment TextAlign { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AutoSize = false;
            TextAlign = ContentAlignment.MiddleCenter;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AutoSize = false;
            ToolBarTextAlign = ContentAlignment.MiddleCenter;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSeconds.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDayOfWeek.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }
    }
}
