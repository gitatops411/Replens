using System;
using System.Threading;
using System.Windows.Forms;

namespace Replens
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshTimer_Tick(sender, e);
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            DateTime temptime = DateTime.Now;
            int hour          = temptime.Hour;
            int minute        = temptime.Minute;
            string ampm       = "am";

            RefreshTimer.Enabled = false;
            if(hour > 12)
            {
                ampm = "pm";
                hour -= 12;
            }
            string datestr = string.Format("{0}:{1:D2} {2}", hour, minute, ampm);


            try
            {
                _ = v_KDB_Zone_ReplensTableAdapter.Fill(Dataset.v_KDB_Zone_Replens);
                NetworkErrorMsg.Visible = NetworkRetrySecs.Visible = false;
                ClockDisplay.Text = datestr;
                RefreshTimer.Interval = 20000; /* 20 seconds */
            }

            catch(Exception)
            {
                NetworkErrorMsg.Text = "\r\nThe network connection was lost or interrupted.\r\nA new connection attempt will occur in\r\n       seconds";
                NetworkErrorMsg.Visible = NetworkRetrySecs.Visible = true;
                for(int i = 30; i > 0; i--)
                {
                    NetworkRetrySecs.Text = i.ToString();
                    Refresh();
                    Thread.Sleep(1000);
                }
                NetworkRetrySecs.Visible = false;
                NetworkErrorMsg.Text = "\r\n\r\n... attempting to reconnect to the network ...";
                Refresh();
                RefreshTimer.Interval = 500; /*   1/2 second   */
            }
            RefreshTimer.Enabled = true;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
