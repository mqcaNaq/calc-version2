using Microsoft.VisualBasic.Logging;

namespace hesap_makinesi_proje_1_deneme_2
{
    public partial class Form1 : Form
    {
        List<string> islemGecmisi = new List<string>();

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

            string islem = "";
            double sonuc = 0;

            switch (op)
            {
                case "+":
                    sonuc = ilkDegeriGir + ikinciDegeriGir;
                    break;

                case "-":
                    sonuc = ilkDegeriGir - ikinciDegeriGir;
                    break;

                case "*":
                    sonuc = ilkDegeriGir * ikinciDegeriGir;
                    break;

                case "/":
                    if (ikinciDegeriGir == 0)
                    {
                        txtSonuc.Text = "Sıfıra bölünemez!";
                        return; // İşleme devam etme, methodu sonlandır.
                    }
                    else
                    {
                        sonuc = ilkDegeriGir / ikinciDegeriGir;
                    }
                    break;

                case "Mod":
                    sonuc = ilkDegeriGir % ikinciDegeriGir;
                    break;

                case "Exp":
                    // Bu örnekte Exp işlemi için farklı bir hesaplama örneği veriliyor.
                    // İstediğiniz hesaplama mantığına göre düzenleyebilirsiniz.
                    sonuc = Math.Exp(ilkDegeriGir * Math.Log(ikinciDegeriGir));
                    break;

                case "x^x":
                    sonuc = 1;
                    for (int n = 0; n < ikinciDegeriGir; n++)
                    {
                        sonuc *= ilkDegeriGir;
                    }
                    break;

                default:
                    break;
            }

            txtSonuc.Text = sonuc.ToString();

            islem = ilkDegeriGir.ToString() + " " + op + " " + ikinciDegeriGir.ToString() + " = " + sonuc.ToString();
            islemGecmisi.Add(islem);

            if (islemGecmisi.Count > 10)
            {
                islemGecmisi.RemoveAt(0);
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

            exitCal = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Hesap Makinesi",
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
            double aci = Convert.ToDouble(txtSonuc.Text);
            double tan = Math.Tan(Convert.ToDouble(txtSonuc.Text) * Math.PI / 180);
            tan = Math.Round(tan, 5);
            txtSonuc.Text = Convert.ToString(tan);

            string islem = "tan(" + aci + ") = " + tan;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double logg = Convert.ToDouble(txtSonuc.Text);
            logg = Math.Log10(logg);
            txtSonuc.Text = Convert.ToString(logg);

            string islem = "log(" + sayi + ") = " + logg;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double sq = Convert.ToDouble(txtSonuc.Text);
            sq = Math.Sqrt(sq);
            txtSonuc.Text = Convert.ToString(sq);

            string islem = "√" + sayi + " = " + sq;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double x;
            x = Convert.ToDouble(txtSonuc.Text) * Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = Convert.ToString(x);

            string islem = "(" + sayi + ")^2 = " + x;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
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
            double aci = Convert.ToDouble(txtSonuc.Text);
            double sin = Math.Sin(Convert.ToDouble(txtSonuc.Text) * Math.PI / 180);
            sin = Math.Round(sin, 5);
            txtSonuc.Text = Convert.ToString(sin);

            string islem = "sin(" + aci + ") = " + sin;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double aci = Convert.ToDouble(txtSonuc.Text);
            double cos = Math.Cos(Convert.ToDouble(txtSonuc.Text) * Math.PI / 180);
            cos = Math.Round(cos, 5);
            txtSonuc.Text = Convert.ToString(cos);

            string islem = "cos(" + aci + ") = " + cos;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        private void btnSinRad_Click(object sender, EventArgs e)
        {
            double rad = Convert.ToDouble(txtSonuc.Text);
            double sin = Convert.ToDouble(txtSonuc.Text);
            sin = Math.Sin(sin);
            sin = Math.Round(sin, 5);
            txtSonuc.Text = Convert.ToString(sin);

            string islem = "sin(rad=" + rad + ") = " + sin;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        private void btnCosRad_Click(object sender, EventArgs e)
        {
            double rad = Convert.ToDouble(txtSonuc.Text);
            double cos = Convert.ToDouble(txtSonuc.Text);
            cos = Math.Cos(cos);
            cos = Math.Round(cos, 5);
            txtSonuc.Text = Convert.ToString(cos);

            string islem = "cos(rad=" + rad + ") = " + cos;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        private void btnTanRad_Click(object sender, EventArgs e)
        {
            double rad = Convert.ToDouble(txtSonuc.Text);
            double tan = Convert.ToDouble(txtSonuc.Text);
            tan = Math.Tan(tan);
            tan = Math.Round(tan, 5);
            txtSonuc.Text = Convert.ToString(tan);

            string islem = "tan(rad=" + rad + ") = " + tan;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        private void btnCotRad_Click(object sender, EventArgs e)
        {
            double rad = Convert.ToDouble(txtSonuc.Text);
            double cot = Convert.ToDouble(txtSonuc.Text);
            cot = (1 / Math.Tan(cot));
            cot = Math.Round(cot, 5);
            txtSonuc.Text = Convert.ToString(cot);

            string islem = "cot(rad=" + rad + ") = " + cot;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            double aci = Convert.ToDouble(txtSonuc.Text);
            double cot = (1 / Math.Tan(Convert.ToDouble(txtSonuc.Text) * Math.PI / 180));
            cot = Math.Round(cot, 5);
            txtSonuc.Text = Convert.ToString(cot);

            string islem = "cot(" + aci + ") = " + cot;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        private void btnYuzde_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtSonuc.Text) / Convert.ToDouble(100);
            txtSonuc.Text = Convert.ToString(a);
        }

        private void btnKup_Click_1(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double x;
            x = Convert.ToDouble(txtSonuc.Text) * Convert.ToDouble(txtSonuc.Text)
                * Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = Convert.ToString(x);

            string islem = "(" + sayi + ")^3 = " + x;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        private void btnLnx_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double lnx = Convert.ToDouble(txtSonuc.Text);
            lnx = Math.Log(lnx);
            txtSonuc.Text = Convert.ToString(lnx);

            string islem = "ln(" + sayi + ") = " + lnx;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIslemGecmisi_Click(object sender, EventArgs e)
        {
            // Panel görünürlüğünü kontrol edip tersine çeviriyoruz
            pnlIslemGecmisi.Visible = !pnlIslemGecmisi.Visible;

            // Eğer panel görünür hale geldiyse, ListBox'ı güncelleyin.
            if (pnlIslemGecmisi.Visible)
            {
                lstIslemGecmisi.Items.Clear();
                foreach (string kayit in islemGecmisi)
                {
                    lstIslemGecmisi.Items.Add(kayit);
                }
            }
        }
    }
}
