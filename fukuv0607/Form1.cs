using System.Net.WebSockets;

namespace fukuv0607
{
    public partial class Form1 : Form
    {
        int vx = random.Next(-4, 5);
        int vy = random.Next(-4, 5);
        int counter = 0;
        static Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            label1.Left = random.Next(ClientSize.Width);
            label1.Top = random.Next(ClientSize.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label3.Text = $"{counter}";

            var fpos = PointToClient(MousePosition);
            //label1.Text = $"{fpos.X}, {fpos.Y}";
            label2.Left = fpos.X;
            label2.Top = fpos.Y;

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

            if ((fpos.X > label1.Left)
                && (fpos.X < label1.Right)
                && (fpos.Y > label1.Top)
                && (fpos.Y < label1.Bottom))
            {
                timer1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "‚½‚È‚©";
        }
    }
}