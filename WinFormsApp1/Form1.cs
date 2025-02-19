using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1

{

    public partial class Form1 : Form

    {

        private bool iranyFel = true, iranyBalra = true;

        private int lepesFel = 20, lepesOldalt = 30;

        public Form1()

        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)

        {

            Point point = button1.Location;

            if (this.iranyFel && (point.Y - this.lepesFel) <= 0)

            {

                this.iranyFel = false;

            }

            if (iranyBalra && (point.X - lepesOldalt) <= 0)

            {

                iranyBalra = false;

            }

            if (!iranyFel && ((point.Y - Height) + lepesFel) <= Height)

            {

                iranyFel = true;

            }

            if (!iranyBalra && ((point.X - Width) + lepesOldalt) <= Width)

            {

                iranyBalra = true;

            }

            point.X += this.iranyBalra ? -this.lepesOldalt : this.lepesOldalt;

            point.Y += this.iranyFel ? -this.lepesFel : this.lepesFel;

            button1.Location = point;

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

            button1.BackColor = Color.LightBlue;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            button1.BackColor = Color.AntiqueWhite;

            button1.Text = "Kattints rám!";

        }

    }

}

