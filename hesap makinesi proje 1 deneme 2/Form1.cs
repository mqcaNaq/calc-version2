namespace hesap_makinesi_proje_1_deneme_2
{
    public partial class Form1 : Form
    {
        double ilkDegeriGir, ikinciDegeriGir;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 360; //816
            txtSonuc.Width = 318;
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtSonuc.Text == "0")
                txtSonuc.Text = "";
            {
                if (num.Text == ",")
                {
                    if (!txtSonuc.Text.Contains(","))
                        txtSonuc.Text = txtSonuc.Text + num.Text;
                }
                else
                {
                    txtSonuc.Text = txtSonuc.Text + num.Text;
                }
            }
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            ilkDegeriGir = Convert.ToDouble(txtSonuc.Text);
            op = num.Text;
            txtSonuc.Text = "";
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            ikinciDegeriGir = Convert.ToDouble(txtSonuc.Text);


            switch (op)
            {
                case "+":
                    txtSonuc.Text = (ilkDegeriGir + ikinciDegeriGir).ToString();

                    break;

                case "-":
                    txtSonuc.Text = (ilkDegeriGir - ikinciDegeriGir).ToString();

                    break;

                case "*":
                    txtSonuc.Text = (ilkDegeriGir * ikinciDegeriGir).ToString();

                    break;

                case "/":
                    if (ikinciDegeriGir == 0)
                    {
                        txtSonuc.Text = "Sýfýra bölünemez!";
                    }
                    else
                    {
                        double sonuc = ilkDegeriGir / ikinciDegeriGir;
                        txtSonuc.Text = sonuc.ToString(); 
                    }


                    break;

                case "Mod":
                    txtSonuc.Text = (ilkDegeriGir % ikinciDegeriGir).ToString();

                    break;

                case "Exp":
                    double i = Convert.ToDouble(txtSonuc.Text);
                    double j;
                    j = ikinciDegeriGir;


                    txtSonuc.Text = Math.Exp(i * Math.Log(j * 4)).ToString();

                    break;

                case "x^x":
                    int n;
                    double gecici = 1;
                    for (n = 0; n < ikinciDegeriGir; n++)
                    {
                        gecici *= ilkDegeriGir;
                    }
                    txtSonuc.Text = gecici.ToString();

                    break;


                default:

                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";

            String f, s;

            f = Convert.ToString(ilkDegeriGir);
            s = Convert.ToString(ikinciDegeriGir);

            f = "";
            s = "";
        }

        private void btnAE_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = Convert.ToString(-1 * q);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text.Length > 0)
            {
                txtSonuc.Text = txtSonuc.Text.Remove(txtSonuc.Text.Length - 1, 1);
            }

            if (txtSonuc.Text == "")
            {
                txtSonuc.Text = "0";
            }
        }

        private void scToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 715; //816
            txtSonuc.Width = 665;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 360; //816
            txtSonuc.Width = 318;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;

            exitCal = MessageBox.Show("Çýkýþ yapmak istediðinizi doðrulayýn.", "Hesap Makinesi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void modeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "3.141592653589976323";
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tan = Math.Tan(Convert.ToDouble(txtSonuc.Text) * Math.PI / 180);
            txtSonuc.Text = Convert.ToString(tan);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtSonuc.Text);
            logg = Math.Log10(logg);
            txtSonuc.Text = Convert.ToString(logg);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtSonuc.Text);
            sq = Math.Sqrt(sq);
            txtSonuc.Text = Convert.ToString(sq);
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtSonuc.Text) * Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = Convert.ToString(x);
        }

        private void btnKup_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtSonuc.Text) * Convert.ToDouble(txtSonuc.Text)
                * Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = Convert.ToString(x);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Math.Sin(Convert.ToDouble(txtSonuc.Text) * Math.PI / 180);
            txtSonuc.Text = Convert.ToString(sin);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cos = Math.Cos(Convert.ToDouble(txtSonuc.Text) * Math.PI / 180);
            txtSonuc.Text = Convert.ToString(cos);
        }

        private void btnSinRad_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtSonuc.Text);
            sin = Math.Sin(sin);
            txtSonuc.Text = Convert.ToString(sin);
        }

        private void btnCosRad_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtSonuc.Text);
            cos = Math.Cos(cos);
            txtSonuc.Text = Convert.ToString(cos);
        }

        private void btnTanRad_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtSonuc.Text);
            tan = Math.Tan(tan);
            txtSonuc.Text = Convert.ToString(tan);
        }

        private void btnCotRad_Click(object sender, EventArgs e)
        {
            double cot = Convert.ToDouble(txtSonuc.Text);
            cot = (1 / Math.Tan(cot));
            txtSonuc.Text = Convert.ToString(cot);
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            double cot = (1 / Math.Tan(Convert.ToDouble(txtSonuc.Text) * Math.PI / 180));
            txtSonuc.Text = Convert.ToString(cot);
        }

        private void btnYuzde_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtSonuc.Text) / Convert.ToDouble(100);
            txtSonuc.Text = Convert.ToString(a);
        }

        private void btnKup_Click_1(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtSonuc.Text) * Convert.ToDouble(txtSonuc.Text)
                * Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = Convert.ToString(x);
        }

        private void btnLnx_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtSonuc.Text);
            lnx = Math.Log(lnx);
            txtSonuc.Text = Convert.ToString(lnx);
        }
    }
}
