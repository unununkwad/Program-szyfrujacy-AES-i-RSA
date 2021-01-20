namespace Cyberbezpieczeństwo_projekt
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxZaszyfrowany = new System.Windows.Forms.TextBox();
            this.button_Szyfrowanie_Symetryczne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOdszyfrowany = new System.Windows.Forms.TextBox();
            this.textBoxInformacja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_plik = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInformacja2 = new System.Windows.Forms.TextBox();
            this.textBoxZaszyfrowany2 = new System.Windows.Forms.TextBox();
            this.textBoxOdszyfrowany2 = new System.Windows.Forms.TextBox();
            this.button_szyfrowanie_asymetryczne = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxKluczPubliczny = new System.Windows.Forms.TextBox();
            this.textBoxKluczPrywatny = new System.Windows.Forms.TextBox();
            this.button_plik2 = new System.Windows.Forms.Button();
            this.button_wyczysc_asymetryczne = new System.Windows.Forms.Button();
            this.button_wyczysc_szyfrowanie_symetryczne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxZaszyfrowany
            // 
            this.textBoxZaszyfrowany.Location = new System.Drawing.Point(9, 109);
            this.textBoxZaszyfrowany.Name = "textBoxZaszyfrowany";
            this.textBoxZaszyfrowany.Size = new System.Drawing.Size(230, 22);
            this.textBoxZaszyfrowany.TabIndex = 0;
            this.textBoxZaszyfrowany.TextChanged += new System.EventHandler(this.textBoxZaszyfrowany_TextChanged);
            // 
            // button_Szyfrowanie_Symetryczne
            // 
            this.button_Szyfrowanie_Symetryczne.Location = new System.Drawing.Point(9, 182);
            this.button_Szyfrowanie_Symetryczne.Name = "button_Szyfrowanie_Symetryczne";
            this.button_Szyfrowanie_Symetryczne.Size = new System.Drawing.Size(227, 64);
            this.button_Szyfrowanie_Symetryczne.TabIndex = 1;
            this.button_Szyfrowanie_Symetryczne.Text = "Szyfruj symetrycznie";
            this.button_Szyfrowanie_Symetryczne.UseVisualStyleBackColor = true;
            this.button_Szyfrowanie_Symetryczne.Click += new System.EventHandler(this.button_Szyfrowanie_Symetryczne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Szyfrowanie symetryczne(AES)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zaszyfrowany:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Odszyfrowany:";
            // 
            // textBoxOdszyfrowany
            // 
            this.textBoxOdszyfrowany.Location = new System.Drawing.Point(9, 154);
            this.textBoxOdszyfrowany.Name = "textBoxOdszyfrowany";
            this.textBoxOdszyfrowany.Size = new System.Drawing.Size(227, 22);
            this.textBoxOdszyfrowany.TabIndex = 5;
            // 
            // textBoxInformacja
            // 
            this.textBoxInformacja.Location = new System.Drawing.Point(9, 64);
            this.textBoxInformacja.Name = "textBoxInformacja";
            this.textBoxInformacja.Size = new System.Drawing.Size(230, 22);
            this.textBoxInformacja.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Co chcesz zaszyfrować?";
            // 
            // button_plik
            // 
            this.button_plik.Location = new System.Drawing.Point(9, 303);
            this.button_plik.Name = "button_plik";
            this.button_plik.Size = new System.Drawing.Size(227, 54);
            this.button_plik.TabIndex = 8;
            this.button_plik.Text = "Otwórz plik i szyfruj symetrycznie";
            this.button_plik.UseVisualStyleBackColor = true;
            this.button_plik.Click += new System.EventHandler(this.button_plik_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Szyfrowanie asymetryczne(RSA)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Co chcesz zaszyfrować?";
            // 
            // textBoxInformacja2
            // 
            this.textBoxInformacja2.Location = new System.Drawing.Point(266, 64);
            this.textBoxInformacja2.Name = "textBoxInformacja2";
            this.textBoxInformacja2.Size = new System.Drawing.Size(262, 22);
            this.textBoxInformacja2.TabIndex = 11;
            // 
            // textBoxZaszyfrowany2
            // 
            this.textBoxZaszyfrowany2.Location = new System.Drawing.Point(266, 109);
            this.textBoxZaszyfrowany2.Name = "textBoxZaszyfrowany2";
            this.textBoxZaszyfrowany2.Size = new System.Drawing.Size(262, 22);
            this.textBoxZaszyfrowany2.TabIndex = 12;
            // 
            // textBoxOdszyfrowany2
            // 
            this.textBoxOdszyfrowany2.Location = new System.Drawing.Point(266, 154);
            this.textBoxOdszyfrowany2.Name = "textBoxOdszyfrowany2";
            this.textBoxOdszyfrowany2.Size = new System.Drawing.Size(262, 22);
            this.textBoxOdszyfrowany2.TabIndex = 13;
            // 
            // button_szyfrowanie_asymetryczne
            // 
            this.button_szyfrowanie_asymetryczne.Location = new System.Drawing.Point(266, 276);
            this.button_szyfrowanie_asymetryczne.Name = "button_szyfrowanie_asymetryczne";
            this.button_szyfrowanie_asymetryczne.Size = new System.Drawing.Size(262, 36);
            this.button_szyfrowanie_asymetryczne.TabIndex = 14;
            this.button_szyfrowanie_asymetryczne.Text = "Szyfrowanie asymetryczne";
            this.button_szyfrowanie_asymetryczne.UseVisualStyleBackColor = true;
            this.button_szyfrowanie_asymetryczne.Click += new System.EventHandler(this.button_szyfrowanie_asymetryczne_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(601, 394);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(187, 44);
            this.button_close.TabIndex = 15;
            this.button_close.Text = "Zamknij";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Zaszyfrowany:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Odszyfrowany:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Klucz publiczny:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Klucz prywatny:";
            // 
            // textBoxKluczPubliczny
            // 
            this.textBoxKluczPubliczny.Location = new System.Drawing.Point(266, 199);
            this.textBoxKluczPubliczny.Name = "textBoxKluczPubliczny";
            this.textBoxKluczPubliczny.Size = new System.Drawing.Size(262, 22);
            this.textBoxKluczPubliczny.TabIndex = 20;
            // 
            // textBoxKluczPrywatny
            // 
            this.textBoxKluczPrywatny.Location = new System.Drawing.Point(266, 249);
            this.textBoxKluczPrywatny.Name = "textBoxKluczPrywatny";
            this.textBoxKluczPrywatny.Size = new System.Drawing.Size(262, 22);
            this.textBoxKluczPrywatny.TabIndex = 21;
            // 
            // button_plik2
            // 
            this.button_plik2.Location = new System.Drawing.Point(268, 318);
            this.button_plik2.Name = "button_plik2";
            this.button_plik2.Size = new System.Drawing.Size(260, 39);
            this.button_plik2.TabIndex = 22;
            this.button_plik2.Text = "Otwórz plik i szyfruj asymetrycznie";
            this.button_plik2.UseVisualStyleBackColor = true;
            this.button_plik2.Click += new System.EventHandler(this.button_plik2_Click);
            // 
            // button_wyczysc_asymetryczne
            // 
            this.button_wyczysc_asymetryczne.Location = new System.Drawing.Point(268, 363);
            this.button_wyczysc_asymetryczne.Name = "button_wyczysc_asymetryczne";
            this.button_wyczysc_asymetryczne.Size = new System.Drawing.Size(260, 75);
            this.button_wyczysc_asymetryczne.TabIndex = 24;
            this.button_wyczysc_asymetryczne.Text = "Wyczyść szyfrowanie asymetryczne";
            this.button_wyczysc_asymetryczne.UseVisualStyleBackColor = true;
            this.button_wyczysc_asymetryczne.Click += new System.EventHandler(this.button_wyczysc_asymetryczne_Click);
            // 
            // button_wyczysc_szyfrowanie_symetryczne
            // 
            this.button_wyczysc_szyfrowanie_symetryczne.Location = new System.Drawing.Point(15, 378);
            this.button_wyczysc_szyfrowanie_symetryczne.Name = "button_wyczysc_szyfrowanie_symetryczne";
            this.button_wyczysc_szyfrowanie_symetryczne.Size = new System.Drawing.Size(224, 44);
            this.button_wyczysc_szyfrowanie_symetryczne.TabIndex = 25;
            this.button_wyczysc_szyfrowanie_symetryczne.Text = "Wyczyść szyfrowanie symetryczne";
            this.button_wyczysc_szyfrowanie_symetryczne.UseVisualStyleBackColor = true;
            this.button_wyczysc_szyfrowanie_symetryczne.Click += new System.EventHandler(this.button_wyczysc_szyfrowanie_symetryczne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_wyczysc_szyfrowanie_symetryczne);
            this.Controls.Add(this.button_wyczysc_asymetryczne);
            this.Controls.Add(this.button_plik2);
            this.Controls.Add(this.textBoxKluczPrywatny);
            this.Controls.Add(this.textBoxKluczPubliczny);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_szyfrowanie_asymetryczne);
            this.Controls.Add(this.textBoxOdszyfrowany2);
            this.Controls.Add(this.textBoxZaszyfrowany2);
            this.Controls.Add(this.textBoxInformacja2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_plik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxInformacja);
            this.Controls.Add(this.textBoxOdszyfrowany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Szyfrowanie_Symetryczne);
            this.Controls.Add(this.textBoxZaszyfrowany);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxZaszyfrowany;
        private System.Windows.Forms.Button button_Szyfrowanie_Symetryczne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOdszyfrowany;
        private System.Windows.Forms.TextBox textBoxInformacja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_plik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInformacja2;
        private System.Windows.Forms.TextBox textBoxZaszyfrowany2;
        private System.Windows.Forms.TextBox textBoxOdszyfrowany2;
        private System.Windows.Forms.Button button_szyfrowanie_asymetryczne;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxKluczPubliczny;
        private System.Windows.Forms.TextBox textBoxKluczPrywatny;
        private System.Windows.Forms.Button button_plik2;
        private System.Windows.Forms.Button button_wyczysc_asymetryczne;
        private System.Windows.Forms.Button button_wyczysc_szyfrowanie_symetryczne;
    }
}

