using System;
using System.Windows.Forms;
using ScreenGrabber.Properties;

namespace ScreenGrabber
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }


        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            int id = 0;     // The id of the hotkey. 
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Control, Keys.D4.GetHashCode());       // Register Shift + A as global hotkey. 
        }



        private void Form1_Load(object sender, EventArgs e){
            notifyIcon1.Visible = true;
            chkboxcopytoclipboard.Checked = Settings.Default.copytoclipboard;
            chkboxopenibrowser.Checked = Settings.Default.openlinkinbrowser;
            chkmodeset.Text = Settings.Default.copymode;
        }

        //private void Form1_Resize(object sender, EventArgs e){
        //if (this.WindowState == FormWindowState.Minimized)
        //{
        //this.Hide();
        //notifyIcon1.Visible = true;
        //}
        //}


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x0312)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);
                int id = m.WParam.ToInt32();
                CaptureWindow capture = new CaptureWindow();
                capture.Show();
            }
        }

        private void captureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureWindow capture = new CaptureWindow();
            capture.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            UnregisterHotKey(this.Handle, 0);
            Settings.Default.Save();
        }

        private void captureToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CaptureWindow capture = new CaptureWindow();
            capture.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void showToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CaptureWindow capture = new CaptureWindow();
            capture.Show();
        }
        private void butdone_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            notifyIcon1.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }



        private void chkmodeset_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (chkmodeset.Text.Contains("Link"))
            {
                chkboxopenibrowser.Enabled = true;
                Settings.Default.copymode = "Link Mode";
                lbltext.Text = "Link Mode: Enabled";

            }
            if (chkmodeset.Text.Contains("Image")) {
                Settings.Default.copymode = "Image Mode";
                chkboxopenibrowser.Enabled = false;
                chkboxopenibrowser.Checked = false;
                lbltext.Text = "Image Mode: Enabled";
            }
            Settings.Default.Save();
        }

        private void chkboxopenibrowser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxopenibrowser.Checked == true){
                Settings.Default.openlinkinbrowser = true;
                lbltext.Text = "Open in Browser: Enabled";
            } else {
                Settings.Default.openlinkinbrowser = false;
                lbltext.Text = "Open in Browser: Disabled";
            }
            Settings.Default.Save();
        }

        private void chkboxcopytoclipboard_CheckedChanged(object sender, EventArgs e){
            if (chkboxcopytoclipboard.Checked) {
                Settings.Default.copytoclipboard = true;
                lbltext.Text = "Copy to Clipboard: Enabled";
            } else{
                Settings.Default.copytoclipboard = false;
                lbltext.Text = "Copy to Clipboard: Disabled";
            }
            Settings.Default.Save();
        }
    }
}