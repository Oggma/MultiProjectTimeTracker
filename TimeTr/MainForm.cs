using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool isProject1TrackerRun = false;
        bool isProject2TrackerRun = false;

        DateTime project1Timer = DateTime.MinValue;
        DateTime project2Timer = DateTime.MinValue;

        private async void project1Btn_Click(object sender, EventArgs e)
        {
            isProject1TrackerRun = true;
            while (isProject1TrackerRun)
            {
                project1Timer = project1Timer.AddSeconds(1);
                textBox1.Text = project1Timer.TimeOfDay.ToString();
                await Task.Delay(1000);
            }
        }

        private async void project2Btn_Click(object sender, EventArgs e)
        {
            isProject2TrackerRun = true;
            while (isProject2TrackerRun)
            {
                project2Timer = project2Timer.AddSeconds(1);
                textBox2.Text = project2Timer.TimeOfDay.ToString();
                await Task.Delay(1000);
            }
        }

        private void project1Pause_Click(object sender, EventArgs e)
        {
            isProject1TrackerRun = false;
        }

        private void project2Pause_Click(object sender, EventArgs e)
        {
            isProject2TrackerRun = false;
        }
    }
}
