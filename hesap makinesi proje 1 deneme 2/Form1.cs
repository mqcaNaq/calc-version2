using Microsoft.VisualBasic.Logging;

namespace hesap_makinesi_proje_1_deneme_2
{
    //uygulamanın ana formu:
    public partial class Form1 : Form
    {
        //islem gecmisini saklamak icin string turunde liste tanimlaniyor
        List<string> islemGecmisi = new List<string>();

        //islemde kullanilacak iki sayi ve operator degiskenleri
        double ilkDegeriGir, ikinciDegeriGir;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        //form yuklendiginde calisacak olan metot. form ve txtSonuc genislikleri burada ayarlaniyor
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 360;//form genisligini 360 px ayarlar (eski deger 816 idi)
            txtSonuc.Width = 318;//sonuc textbox'inin genisligini 318 px ayarlar
        }

        //sayi butonlarına (0-9) basildiginda calisacak olan metot
        //basilan sayiyi veya virgulu txtSonuc'a ekler
        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender; //tiklanan butonu alir

            //eger txtSonuc sifir iceriyorsa temizler
            if (txtSonuc.Text == "0")
                txtSonuc.Text = "";
            {
                //eger tiklanan buton virgul ise ve virgul zaten yoksa ekler
                if (num.Text == ",")
                {
                    if (!txtSonuc.Text.Contains(","))
                        txtSonuc.Text = txtSonuc.Text + num.Text;
                }
                else
                {
                    //diger durumlarda butonun degerini metne ekler
                    txtSonuc.Text = txtSonuc.Text + num.Text;
                }
            }
        }

        //islem operator butonlarina basildiginda calisir
        //ilk girilen sayiyi saklar, secilen operatoru alir ve txtSonuc'u temizler
        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            ilkDegeriGir = Convert.ToDouble(txtSonuc.Text);
            op = num.Text;
            txtSonuc.Text = "";
        }

        //"=" butonuna basildiginda calisir ve switch - case'deki islemi gerceklestirir
        private void btnEsittir_Click(object sender, EventArgs e)
        {
            ikinciDegeriGir = Convert.ToDouble(txtSonuc.Text);

            string islem = ""; //islem ifadesini saklamak icin tanimlandi
            double sonuc = 0; //sonuc degeri icin tanimlanan degisken

            //secilen operatore gore hesaplamayi gerceklestirir
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
                    //sifira bolme kontrolu
                    if (ikinciDegeriGir == 0)
                    {
                        txtSonuc.Text = "Sıfıra bölünemez!";
                        return; //hata  durumunda metottan cikar
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
                    //for dongusu sayesinde ilk degiskeni ikinci degisken kadar kendisiyle carpar
                    sonuc = 1;
                    for (int n = 0; n < ikinciDegeriGir; n++)
                    {
                        sonuc *= ilkDegeriGir;
                    }
                    break;

                default:
                    break;
            }

            //hesaplanan sonucu ekrana yazdirir
            txtSonuc.Text = sonuc.ToString();

            //islemin detayli aciklamasini olusturur ve gecmise eker
            islem = ilkDegeriGir.ToString() + " " + op + " " + ikinciDegeriGir.ToString() + " = " + sonuc.ToString();
            islemGecmisi.Add(islem);

            //gecmisteki kayit sayisi 10'u astiysa ilk kaydi siler
            //ve her yeni kayit icin bu sekilde devam eder
            if (islemGecmisi.Count > 10)
            {
                islemGecmisi.RemoveAt(0);
            }
        }

        //clear butonuna basildiginda txtSonuc'u sifirlar
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        //clear entry butonuna basildiginda txtSonuc sifirlanir ve ilk veya ikinci
        //degerlerin kopyasi temizlenir
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";

            String f, s;

            f = Convert.ToString(ilkDegeriGir);
            s = Convert.ToString(ikinciDegeriGir);

            f = "";
            s = "";
        }

        //girilen sayinin isaretini tersine cevirir
        private void btnAE_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = Convert.ToString(-1 * q);
        }

        //sil butonu txtSonuc'un son karakterini siler
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text.Length > 0)
            {
                txtSonuc.Text = txtSonuc.Text.Remove(txtSonuc.Text.Length - 1, 1);
            }

            //eger tum karakterler silinmisse txtSonuc 0 olur
            if (txtSonuc.Text == "")
            {
                txtSonuc.Text = "0";
            }
        }

        //genis ekran gecis yapar (bilimsel menu secenegi)
        private void scToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 715; //form genisligini 715 px ayarlar
            txtSonuc.Width = 665; // txtSonuc genisligini 665 px ayarlar
        }

        //standart ekrana geri doner (standart menu secenegi)
        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 360; //form genisligini 360 px yapar
            txtSonuc.Width = 318; //txtSonuc genisligini 318 px yapar
        }

        //exit menu secenegi: kullaniciya cikis onayi sorar ve cevap evet ise uygulama sonlanir
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

        //pi butonuna basildiginda txtSonuc'a pi'yi yazar
        private void btnPi_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "3.141592653589976323";
        }

        //girilen degerin derece cinsinden tanjantini hesaplar
        private void btnTan_Click(object sender, EventArgs e)
        {
            double aci = Convert.ToDouble(txtSonuc.Text);
            double tan = Math.Tan(Convert.ToDouble(txtSonuc.Text) * Math.PI / 180);
            tan = Math.Round(tan, 5);
            txtSonuc.Text = Convert.ToString(tan);

            //islem gecmisine ekler
            string islem = "tan(" + aci + ") = " + tan;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //girilen degerin 10 tabanindaki logaritmasini hesaplar
        private void btnLog_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double logg = Convert.ToDouble(txtSonuc.Text);
            logg = Math.Log10(logg);
            txtSonuc.Text = Convert.ToString(logg);

            //islem gecmisine ekler
            string islem = "log(" + sayi + ") = " + logg;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //girilen degerin karekokunu hesaplar
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double sq = Convert.ToDouble(txtSonuc.Text);
            sq = Math.Sqrt(sq);
            txtSonuc.Text = Convert.ToString(sq);

            //islem gecmisine ekler
            string islem = "√" + sayi + " = " + sq;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //girilen degerin karesini hesaplar
        private void btnKare_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double x;
            x = Convert.ToDouble(txtSonuc.Text) * Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = Convert.ToString(x);

            //islem gecmisine ekler
            string islem = "(" + sayi + ")^2 = " + x;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //girilen degerin derece cinsinden sinus degerini hesaplar
        private void btnSin_Click(object sender, EventArgs e)
        {
            double aci = Convert.ToDouble(txtSonuc.Text);
            double sin = Math.Sin(Convert.ToDouble(txtSonuc.Text) * Math.PI / 180);
            sin = Math.Round(sin, 5);
            txtSonuc.Text = Convert.ToString(sin);

            //islem gecmisine ekler
            string islem = "sin(" + aci + ") = " + sin;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //girilen degerin derece cinsinden cosinusunu hesaplar
        private void btnCos_Click(object sender, EventArgs e)
        {
            double aci = Convert.ToDouble(txtSonuc.Text);
            double cos = Math.Cos(Convert.ToDouble(txtSonuc.Text) * Math.PI / 180);
            cos = Math.Round(cos, 5);
            txtSonuc.Text = Convert.ToString(cos);

            //islem gecmisine ekler
            string islem = "cos(" + aci + ") = " + cos;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //girilen degerin radyan cinsinden sinusunu hesaplar
        private void btnSinRad_Click(object sender, EventArgs e)
        {
            double rad = Convert.ToDouble(txtSonuc.Text);
            double sin = Convert.ToDouble(txtSonuc.Text);
            sin = Math.Sin(sin);
            sin = Math.Round(sin, 5);
            txtSonuc.Text = Convert.ToString(sin);

            //islem gecmisine ekler
            string islem = "sin(rad=" + rad + ") = " + sin;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //girilen degerin radyan cinsinden cosinusunu hesaplar
        private void btnCosRad_Click(object sender, EventArgs e)
        {
            double rad = Convert.ToDouble(txtSonuc.Text);
            double cos = Convert.ToDouble(txtSonuc.Text);
            cos = Math.Cos(cos);
            cos = Math.Round(cos, 5);
            txtSonuc.Text = Convert.ToString(cos);

            //islem gecmisine ekler
            string islem = "cos(rad=" + rad + ") = " + cos;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //girilen degerin radyan cinsinden tanjantini hesaplar
        private void btnTanRad_Click(object sender, EventArgs e)
        {
            double rad = Convert.ToDouble(txtSonuc.Text);
            double tan = Convert.ToDouble(txtSonuc.Text);
            tan = Math.Tan(tan);
            tan = Math.Round(tan, 5);
            txtSonuc.Text = Convert.ToString(tan);

            //islem gecmisine ekler
            string islem = "tan(rad=" + rad + ") = " + tan;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //girilen degerin radyan cinsinden cotanjantini hesaplar
        private void btnCotRad_Click(object sender, EventArgs e)
        {
            double rad = Convert.ToDouble(txtSonuc.Text);
            double cot = Convert.ToDouble(txtSonuc.Text);
            cot = (1 / Math.Tan(cot));
            cot = Math.Round(cot, 5);
            txtSonuc.Text = Convert.ToString(cot);

            //islem gecmisine ekler
            string islem = "cot(rad=" + rad + ") = " + cot;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //girilen degerin derece cinsinden cotanjantini hesaplar
        private void btnCot_Click(object sender, EventArgs e)
        {
            double aci = Convert.ToDouble(txtSonuc.Text);
            double cot = (1 / Math.Tan(Convert.ToDouble(txtSonuc.Text) * Math.PI / 180));
            cot = Math.Round(cot, 5);
            txtSonuc.Text = Convert.ToString(cot);

            //islem gecmisine ekler
            string islem = "cot(" + aci + ") = " + cot;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //girilen sayiyi yuzdeye cevirir
        private void btnYuzde_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtSonuc.Text) / Convert.ToDouble(100);
            txtSonuc.Text = Convert.ToString(a);
        }

        //girilen sayinin kupunu alir
        private void btnKup_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double x;
            x = Convert.ToDouble(txtSonuc.Text) * Convert.ToDouble(txtSonuc.Text)
                * Convert.ToDouble(txtSonuc.Text);
            txtSonuc.Text = Convert.ToString(x);

            //islem gecmisine ekler
            string islem = "" + sayi + "^3 = " + x;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //girilen sayinin dogal logaritmasini hesaplar
        private void btnLnx_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double lnx = Convert.ToDouble(txtSonuc.Text);
            lnx = Math.Log(lnx);
            txtSonuc.Text = Convert.ToString(lnx);

            //islem gecmisine ekler
            string islem = "ln(" + sayi + ") = " + lnx;
            islemGecmisi.Add(islem);
            if (islemGecmisi.Count > 10)
                islemGecmisi.RemoveAt(0);
        }

        //gecmis panelinin gorunurlugunu degistirir ve gecmisi listbox'a aktarir
        private void btnIslemGecmisi_Click(object sender, EventArgs e)
        {
            // panel gorunurlugunu tersine cevirir
            pnlIslemGecmisi.Visible = !pnlIslemGecmisi.Visible;

            // eger panel gorunur haldeyse gecmis kayitlarini listbox'a ekler
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
