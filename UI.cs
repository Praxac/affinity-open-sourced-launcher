using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slix_UI
{
    public partial class UI : Form
    {


        public UI()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 25, 25));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 25, 25));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 25, 25));
        }
        Point lastPoint;
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);



        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton6_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://lightout.one");
        }



        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/GjGTsQU5me");
        }

        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
            string html = string.Empty;
            string url = "https://pastebin.com/raw/Hsdjb9x2";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            WebClient D = new WebClient();
            string exe = ("Slix_Selfbot.exe");
            D.DownloadFile($"{html}", exe);
            Process start = new Process();
            start.StartInfo.FileName = "Cmd.exe";
            start.StartInfo.UseShellExecute = true;
            start.StartInfo.CreateNoWindow = true;
            start.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        }

        private void UI_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = w.DownloadString("https://pastebin.com/raw/qaERiSzv");
        }

        private void UI_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void UI_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void siticoneRoundedButton4_Click_1(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        WebClient w = new WebClient();
        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label7_load(object sender, EventArgs e)
        {

        }

        private void Slix_UI_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = w.DownloadString("https://pastebin.com/raw/qaERiSzv");
            richTextBox1.SelectAll();
            this.richTextBox1.Enabled = true;
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.GotFocus += new System.EventHandler(this.RTBGotFocus);

            string one = w.DownloadString("https://pastebin.com/raw/hpcfMmkV");

            if(one == "on")
            {
                richTextBox2.Text = "Online";
            }
            else
            {
                richTextBox2.Text = "Offline";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            numOnlineUsers.Text = "" + Login.KeyAuthApp.app_data.numOnlineUsers;
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {
            key.Text = Login.KeyAuthApp.user_data.username;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void RTBGotFocus(object sender, System.EventArgs e)
        {
            System.Windows.Forms.SendKeys.Send("{tab}");
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            this.richTextBox2.Enabled = true;
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.GotFocus += new System.EventHandler(this.RTBGotFocus);



        }



        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Gta5 main = new Gta5();
            main.Show();
            this.Hide();
        }
    }
}
