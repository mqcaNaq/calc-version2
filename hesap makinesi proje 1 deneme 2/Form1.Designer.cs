namespace hesap_makinesi_proje_1_deneme_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSil = new Button();
            txtSonuc = new TextBox();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnAE = new Button();
            btn7 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btnArti = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btnEksi = new Button();
            btnCarpi = new Button();
            btn0 = new Button();
            btnEsittir = new Button();
            btnNokta = new Button();
            btnBolu = new Button();
            menuStrip1 = new MenuStrip();
            modeToolStripMenuItem = new ToolStripMenuItem();
            standartToolStripMenuItem = new ToolStripMenuItem();
            scToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            btnPi = new Button();
            btnLog = new Button();
            btnSqrt = new Button();
            btnKare = new Button();
            btnSin = new Button();
            btnCos = new Button();
            btnTan = new Button();
            btnUs = new Button();
            btnMod = new Button();
            btnYuzde = new Button();
            btnExp = new Button();
            btnSinRad = new Button();
            btnCosRad = new Button();
            btnTanRad = new Button();
            btnCotRad = new Button();
            btnCot = new Button();
            btnKup = new Button();
            btnLnx = new Button();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Font = new Font("Wingdings", 18F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(12, 96);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 75);
            btnSil.TabIndex = 0;
            btnSil.Text = "";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtSonuc
            // 
            txtSonuc.BackColor = SystemColors.InactiveCaption;
            txtSonuc.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            txtSonuc.Location = new Point(12, 53);
            txtSonuc.Multiline = true;
            txtSonuc.Name = "txtSonuc";
            txtSonuc.Size = new Size(665, 37);
            txtSonuc.TabIndex = 1;
            txtSonuc.Text = "0";
            txtSonuc.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = Color.DarkGray;
            btnClearEntry.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnClearEntry.ForeColor = Color.White;
            btnClearEntry.Location = new Point(93, 96);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(75, 75);
            btnClearEntry.TabIndex = 0;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkGray;
            btnClear.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(174, 96);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 75);
            btnClear.TabIndex = 0;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAE
            // 
            btnAE.BackColor = Color.FromArgb(255, 128, 0);
            btnAE.FlatStyle = FlatStyle.Flat;
            btnAE.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnAE.ForeColor = Color.White;
            btnAE.Location = new Point(255, 96);
            btnAE.Name = "btnAE";
            btnAE.Size = new Size(75, 75);
            btnAE.TabIndex = 0;
            btnAE.Text = "±";
            btnAE.UseVisualStyleBackColor = false;
            btnAE.Click += btnAE_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btn7.Location = new Point(12, 177);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 75);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += EnterNumbers;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btn9.Location = new Point(174, 177);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 75);
            btn9.TabIndex = 0;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += EnterNumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btn8.Location = new Point(93, 177);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 75);
            btn8.TabIndex = 0;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += EnterNumbers;
            // 
            // btnArti
            // 
            btnArti.BackColor = Color.FromArgb(255, 128, 0);
            btnArti.FlatStyle = FlatStyle.Flat;
            btnArti.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnArti.ForeColor = Color.White;
            btnArti.Location = new Point(255, 177);
            btnArti.Name = "btnArti";
            btnArti.Size = new Size(75, 75);
            btnArti.TabIndex = 0;
            btnArti.Text = "+";
            btnArti.UseVisualStyleBackColor = false;
            btnArti.Click += numberOper;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btn4.Location = new Point(12, 258);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 75);
            btn4.TabIndex = 0;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += EnterNumbers;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btn1.Location = new Point(12, 339);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 75);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += EnterNumbers;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btn6.Location = new Point(174, 258);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 75);
            btn6.TabIndex = 0;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += EnterNumbers;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btn3.Location = new Point(174, 339);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 75);
            btn3.TabIndex = 0;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += EnterNumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btn5.Location = new Point(93, 258);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 75);
            btn5.TabIndex = 0;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += EnterNumbers;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btn2.Location = new Point(93, 339);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 75);
            btn2.TabIndex = 0;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += EnterNumbers;
            // 
            // btnEksi
            // 
            btnEksi.BackColor = Color.FromArgb(255, 128, 0);
            btnEksi.FlatStyle = FlatStyle.Flat;
            btnEksi.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnEksi.ForeColor = Color.White;
            btnEksi.Location = new Point(255, 258);
            btnEksi.Name = "btnEksi";
            btnEksi.Size = new Size(75, 75);
            btnEksi.TabIndex = 0;
            btnEksi.Text = "-";
            btnEksi.UseVisualStyleBackColor = false;
            btnEksi.Click += numberOper;
            // 
            // btnCarpi
            // 
            btnCarpi.BackColor = Color.FromArgb(255, 128, 0);
            btnCarpi.FlatStyle = FlatStyle.Flat;
            btnCarpi.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnCarpi.ForeColor = Color.White;
            btnCarpi.Location = new Point(255, 339);
            btnCarpi.Name = "btnCarpi";
            btnCarpi.Size = new Size(75, 75);
            btnCarpi.TabIndex = 0;
            btnCarpi.Text = "*";
            btnCarpi.UseVisualStyleBackColor = false;
            btnCarpi.Click += numberOper;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btn0.Location = new Point(12, 420);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 75);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += EnterNumbers;
            // 
            // btnEsittir
            // 
            btnEsittir.BackColor = Color.FromArgb(255, 128, 0);
            btnEsittir.FlatStyle = FlatStyle.Flat;
            btnEsittir.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnEsittir.ForeColor = Color.White;
            btnEsittir.Location = new Point(174, 420);
            btnEsittir.Name = "btnEsittir";
            btnEsittir.Size = new Size(75, 75);
            btnEsittir.TabIndex = 0;
            btnEsittir.Text = "=";
            btnEsittir.UseVisualStyleBackColor = false;
            btnEsittir.Click += btnEsittir_Click;
            // 
            // btnNokta
            // 
            btnNokta.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnNokta.Location = new Point(93, 420);
            btnNokta.Name = "btnNokta";
            btnNokta.Size = new Size(75, 75);
            btnNokta.TabIndex = 0;
            btnNokta.Text = ",";
            btnNokta.UseVisualStyleBackColor = true;
            btnNokta.Click += EnterNumbers;
            // 
            // btnBolu
            // 
            btnBolu.BackColor = Color.FromArgb(255, 128, 0);
            btnBolu.FlatStyle = FlatStyle.Flat;
            btnBolu.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnBolu.ForeColor = Color.White;
            btnBolu.Location = new Point(255, 420);
            btnBolu.Name = "btnBolu";
            btnBolu.Size = new Size(75, 75);
            btnBolu.TabIndex = 0;
            btnBolu.Text = "/";
            btnBolu.UseVisualStyleBackColor = false;
            btnBolu.Click += numberOper;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { modeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(692, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // modeToolStripMenuItem
            // 
            modeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standartToolStripMenuItem, scToolStripMenuItem, exitToolStripMenuItem });
            modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            modeToolStripMenuItem.Size = new Size(57, 20);
            modeToolStripMenuItem.Text = "Modlar";
            modeToolStripMenuItem.Click += modeToolStripMenuItem_Click;
            // 
            // standartToolStripMenuItem
            // 
            standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            standartToolStripMenuItem.Size = new Size(118, 22);
            standartToolStripMenuItem.Text = "Standart";
            standartToolStripMenuItem.Click += standartToolStripMenuItem_Click;
            // 
            // scToolStripMenuItem
            // 
            scToolStripMenuItem.Name = "scToolStripMenuItem";
            scToolStripMenuItem.Size = new Size(118, 22);
            scToolStripMenuItem.Text = "Bilimsel";
            scToolStripMenuItem.Click += scToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(118, 22);
            exitToolStripMenuItem.Text = "Çıkış";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // btnPi
            // 
            btnPi.Font = new Font("Centaur", 16F, FontStyle.Bold);
            btnPi.Location = new Point(359, 96);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(75, 75);
            btnPi.TabIndex = 0;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = true;
            btnPi.Click += btnPi_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnLog.Location = new Point(440, 96);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(75, 75);
            btnLog.TabIndex = 0;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnSqrt.Location = new Point(521, 96);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(75, 75);
            btnSqrt.TabIndex = 0;
            btnSqrt.Text = "Sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnKare
            // 
            btnKare.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnKare.Location = new Point(440, 420);
            btnKare.Name = "btnKare";
            btnKare.Size = new Size(75, 75);
            btnKare.TabIndex = 0;
            btnKare.Text = "x²";
            btnKare.UseVisualStyleBackColor = true;
            btnKare.Click += btnKare_Click;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btnSin.Location = new Point(359, 177);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(75, 75);
            btnSin.TabIndex = 0;
            btnSin.Text = "Sin (Deg)";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btnCos.Location = new Point(440, 177);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(75, 75);
            btnCos.TabIndex = 0;
            btnCos.Text = "Cos (Deg)";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // btnTan
            // 
            btnTan.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btnTan.Location = new Point(521, 177);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(75, 75);
            btnTan.TabIndex = 0;
            btnTan.Text = "Tan (Deg)";
            btnTan.UseVisualStyleBackColor = true;
            btnTan.Click += btnTan_Click;
            // 
            // btnUs
            // 
            btnUs.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnUs.Location = new Point(602, 339);
            btnUs.Name = "btnUs";
            btnUs.Size = new Size(75, 75);
            btnUs.TabIndex = 0;
            btnUs.Text = "x^x";
            btnUs.UseVisualStyleBackColor = true;
            btnUs.Click += numberOper;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnMod.Location = new Point(440, 339);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 75);
            btnMod.TabIndex = 0;
            btnMod.Text = "Mod";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += numberOper;
            // 
            // btnYuzde
            // 
            btnYuzde.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnYuzde.Location = new Point(521, 339);
            btnYuzde.Name = "btnYuzde";
            btnYuzde.Size = new Size(75, 75);
            btnYuzde.TabIndex = 0;
            btnYuzde.Text = "%";
            btnYuzde.UseVisualStyleBackColor = true;
            btnYuzde.Click += btnYuzde_Click;
            // 
            // btnExp
            // 
            btnExp.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnExp.Location = new Point(359, 339);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(75, 75);
            btnExp.TabIndex = 0;
            btnExp.Text = "Exp";
            btnExp.UseVisualStyleBackColor = true;
            btnExp.Click += numberOper;
            // 
            // btnSinRad
            // 
            btnSinRad.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btnSinRad.Location = new Point(359, 258);
            btnSinRad.Name = "btnSinRad";
            btnSinRad.Size = new Size(75, 75);
            btnSinRad.TabIndex = 0;
            btnSinRad.Text = "Sin (Rad)";
            btnSinRad.UseVisualStyleBackColor = true;
            btnSinRad.Click += btnSinRad_Click;
            // 
            // btnCosRad
            // 
            btnCosRad.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btnCosRad.Location = new Point(440, 258);
            btnCosRad.Name = "btnCosRad";
            btnCosRad.Size = new Size(75, 75);
            btnCosRad.TabIndex = 0;
            btnCosRad.Text = "Cos (Rad)";
            btnCosRad.UseVisualStyleBackColor = true;
            btnCosRad.Click += btnCosRad_Click;
            // 
            // btnTanRad
            // 
            btnTanRad.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btnTanRad.Location = new Point(521, 258);
            btnTanRad.Name = "btnTanRad";
            btnTanRad.Size = new Size(75, 75);
            btnTanRad.TabIndex = 0;
            btnTanRad.Text = "Tan (Rad)";
            btnTanRad.UseVisualStyleBackColor = true;
            btnTanRad.Click += btnTanRad_Click;
            // 
            // btnCotRad
            // 
            btnCotRad.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btnCotRad.Location = new Point(602, 258);
            btnCotRad.Name = "btnCotRad";
            btnCotRad.Size = new Size(75, 75);
            btnCotRad.TabIndex = 0;
            btnCotRad.Text = "Cot (Rad)";
            btnCotRad.UseVisualStyleBackColor = true;
            btnCotRad.Click += btnCotRad_Click;
            // 
            // btnCot
            // 
            btnCot.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btnCot.Location = new Point(602, 177);
            btnCot.Name = "btnCot";
            btnCot.Size = new Size(75, 75);
            btnCot.TabIndex = 0;
            btnCot.Text = "Cot (Deg)";
            btnCot.UseVisualStyleBackColor = true;
            btnCot.Click += btnCot_Click;
            // 
            // btnKup
            // 
            btnKup.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnKup.Location = new Point(521, 420);
            btnKup.Name = "btnKup";
            btnKup.Size = new Size(75, 75);
            btnKup.TabIndex = 0;
            btnKup.Text = "x³";
            btnKup.UseVisualStyleBackColor = true;
            btnKup.Click += btnKup_Click_1;
            // 
            // btnLnx
            // 
            btnLnx.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnLnx.Location = new Point(602, 96);
            btnLnx.Name = "btnLnx";
            btnLnx.Size = new Size(75, 75);
            btnLnx.TabIndex = 0;
            btnLnx.Text = "ln x";
            btnLnx.UseVisualStyleBackColor = true;
            btnLnx.Click += btnLnx_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            button3.Location = new Point(359, 788);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 0;
            button3.Text = "x²";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnKare_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 534);
            Controls.Add(txtSonuc);
            Controls.Add(btnBolu);
            Controls.Add(btnCarpi);
            Controls.Add(btnArti);
            Controls.Add(btnEksi);
            Controls.Add(btnYuzde);
            Controls.Add(btnUs);
            Controls.Add(button3);
            Controls.Add(btnLnx);
            Controls.Add(btnKup);
            Controls.Add(btnKare);
            Controls.Add(btnMod);
            Controls.Add(btnTan);
            Controls.Add(btnSin);
            Controls.Add(btnSqrt);
            Controls.Add(btnCos);
            Controls.Add(btnLog);
            Controls.Add(btnPi);
            Controls.Add(btnExp);
            Controls.Add(btnCot);
            Controls.Add(btnCotRad);
            Controls.Add(btnTanRad);
            Controls.Add(btnCosRad);
            Controls.Add(btnSinRad);
            Controls.Add(btnAE);
            Controls.Add(btnNokta);
            Controls.Add(btn2);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btnClearEntry);
            Controls.Add(btnEsittir);
            Controls.Add(btn3);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btnSil);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hesap Makinesi";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSil;
        private TextBox txtSonuc;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnAE;
        private Button btn7;
        private Button btn9;
        private Button btn8;
        private Button btnArti;
        private Button btn4;
        private Button btn1;
        private Button btn6;
        private Button btn3;
        private Button btn5;
        private Button btn2;
        private Button btnEksi;
        private Button btnCarpi;
        private Button btn0;
        private Button btnEsittir;
        private Button btnNokta;
        private Button btnBolu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem modeToolStripMenuItem;
        private ToolStripMenuItem standartToolStripMenuItem;
        private ToolStripMenuItem scToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnPi;
        private Button btnLog;
        private Button btnSqrt;
        private Button btnKare;
        private Button btnSin;
        private Button btnCos;
        private Button btnTan;
        private Button btnUs;
        private Button btnMod;
        private Button btnYuzde;
        private Button btnExp;
        private Button btnSinRad;
        private Button btnCosRad;
        private Button btnTanRad;
        private Button btnCotRad;
        private Button btnCot;
        private Button btnKup;
        private Button btnLnx;
        private Button button3;
    }
}
