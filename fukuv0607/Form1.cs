namespace fukuv0607
{
    public partial class Form1 : Form
    {
        int vx = -4;
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
                vx = -vx;
            }
            if (label1.Top < 0)
            {
                vy = -vy;
            }
            if (label1.Left > 358)
            {
                vx = -vx;
            }
            if (label1.Top > 278)
            {
                vy = -vy;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "‚½‚È‚©";
        }
    }
}