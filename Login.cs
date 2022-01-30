using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;

namespace Slix_UI
{
    public partial class Login : Form
    {
        static string name = "";
        static string ownerid = "";
        static string secret = "";
        static string version = "1.0";
        // let me show you its correct
        public static api KeyAuthApp = new api(name, ownerid, secret, version);

        public Login()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));
            siticoneRoundedTextBox2.PasswordChar = '•';
        }
        Point lastPoint;

        public object MyGUI { get; }

        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
            if (KeyAuthApp.checkblack()) // check if hwid is blacklisted
            {
                Environment.Exit(0);
            }
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new UI();
            form2.Show();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(siticoneRoundedTextBox1.Text, siticoneRoundedTextBox2.Text);
            if (KeyAuthApp.response.success)
            {
                MessageBox.Show("Logged in Thanks for using Affinity");
                UI main = new UI();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("ERROR: " + KeyAuthApp.response.message);


            //this.Hide();
            //var form1 = new UI();
            //form1.Show();
        }

        private void siticoneImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/BwzVPr882W");
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCw9vMC3JpeOscmqsTUopcQA");
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://lightout.one");
        }

        private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox2_TextChanged(object sender, EventArgs e)
        {
            Font font = new Font("Qualy", 19.0f,
                        FontStyle.Bold | FontStyle.Bold | FontStyle.Bold);
            siticoneRoundedTextBox2.Font = font;
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {

        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            siticoneRoundedTextBox2.PasswordChar = checkBox1.Checked ? '\0' : '•';
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
