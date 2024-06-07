using System.Net.WebSockets;

namespace fukuv0607
{
    public partial class Form1 : Form
    {
        int vx = -8;
        int vy = -4;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Left + label1.Width > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Top + label1.Height > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "‚½‚È‚©";
        }
    }
}