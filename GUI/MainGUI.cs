using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoApp
{
    public partial class GUI : Form
    {
        Color Colorize = Color.FromArgb(0, 0, 0);
        
        public GUI()
        {
            InitializeComponent();

            InterfaceGUI.Manager InterfaceManager = new InterfaceGUI.Manager();
            InterfaceManager.Start();
            foreach (String S in SerialPort.GetPortNames())
            {
                comPortList.Items.Add(S);
            }
        }

        private void GUI_MouseClick(object sender, MouseEventArgs e)
        {
            // this is a test function
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                RedChannelValue.Text = colorPicker.Color.R.ToString();
                GreenChannelValue.Text = colorPicker.Color.G.ToString();
                BlueChannelValue.Text = colorPicker.Color.B.ToString();

                //WhiteChannelValue.Text = colorPicker.Color.A.ToString();
                redTrackBar.Value = Convert.ToInt32(RedChannelValue.Text);
                greenTrackBar.Value = Convert.ToInt32(GreenChannelValue.Text);
                blueTrackBar.Value = Convert.ToInt32(BlueChannelValue.Text);

            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comPortList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comPortList.SelectedItems.Count > 0 && comPortList.SelectedItem.ToString() != InterfaceGUI.Manager.comPort) // prevents trying to load empty or already selected
            {
                InterfaceGUI.Manager.comPort = comPortList.SelectedItem.ToString();
                InterfaceGUI.Manager.DllConnection._Connect(InterfaceGUI.Manager.comPort);
            }
        }

        private void logoImageText_Click(object sender, EventArgs e)
        {

        }

        private void WhiteChannelValue_TextChanged(object sender, EventArgs e)
        {
            int newVal = InterfaceGUI.Utils.parseIntForTextbox(WhiteChannelValue.Text);
            if (newVal > -1)
            {
                whiteTrackBar.Value = newVal;
                //colorArray[4] = whiteTrackBar.Value;
                livePreviewUpdate();

                WhiteChannelValue.Focus();
                WhiteChannelValue.SelectionStart = WhiteChannelValue.Text.Length;
            }
        }

        private void RedChannelValue_TextChanged(object sender, EventArgs e)
        {
            int newVal = InterfaceGUI.Utils.parseIntForTextbox(RedChannelValue.Text);
            if (newVal > -1)
            {
                redTrackBar.Value = newVal;
                InterfaceGUI.Manager.Storage.currentColors[0] = redTrackBar.Value;
                livePreviewUpdate();

                RedChannelValue.Focus();
                RedChannelValue.SelectionStart = RedChannelValue.Text.Length;
            }
        }

        private void GreenChannelValue_TextChanged(object sender, EventArgs e)
        {
            int newVal = InterfaceGUI.Utils.parseIntForTextbox(GreenChannelValue.Text);
            if (newVal > -1)
            {
                greenTrackBar.Value = newVal;
                InterfaceGUI.Manager.Storage.currentColors[1] = greenTrackBar.Value;
                livePreviewUpdate();

                GreenChannelValue.Focus();
                GreenChannelValue.SelectionStart = GreenChannelValue.Text.Length;
            }
        }

        private void BlueChannelValue_TextChanged(object sender, EventArgs e)
        {
            int newVal = InterfaceGUI.Utils.parseIntForTextbox(BlueChannelValue.Text);
            if (newVal > -1)
            {
                blueTrackBar.Value = newVal;
                InterfaceGUI.Manager.Storage.currentColors[2] = blueTrackBar.Value;
                livePreviewUpdate();

                BlueChannelValue.Focus();
                BlueChannelValue.SelectionStart = BlueChannelValue.Text.Length;
            }
        }

        private void livePreviewUpdate()
        {
            int[] colors = InterfaceGUI.Manager.Storage.currentColors;
            Colorize = Color.FromArgb(colors[0], colors[1], colors[2]);
            livePreview.BackColor = Colorize;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            WhiteChannelValue.Text = whiteTrackBar.Value.ToString();
        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            RedChannelValue.Text = redTrackBar.Value.ToString();
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            GreenChannelValue.Text = greenTrackBar.Value.ToString();
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            BlueChannelValue.Text = blueTrackBar.Value.ToString();
        }

        private void livePreview_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                RedChannelValue.Text = colorPicker.Color.R.ToString();
                GreenChannelValue.Text = colorPicker.Color.G.ToString();
                BlueChannelValue.Text = colorPicker.Color.B.ToString();

                //WhiteChannelValue.Text = colorPicker.Color.A.ToString();
                redTrackBar.Value = colorPicker.Color.R;
                greenTrackBar.Value = colorPicker.Color.G;
                blueTrackBar.Value = colorPicker.Color.B;
            }
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(InterfaceGUI.Properties.Resources.BUTTON_CLOSE_HOVER));
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(InterfaceGUI.Properties.Resources.BUTTON_CLOSE));
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
           this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(InterfaceGUI.Properties.Resources.BUTTON_MINIMIZE_HOVER));
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(InterfaceGUI.Properties.Resources.BUTTON_MINIMIZE));
        }
    }
}
