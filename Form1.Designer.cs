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
			this.textBoxInformacja = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button_plik = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxInformacja2 = new System.Windows.Forms.TextBox();
			this.textBoxZaszyfrowany2 = new System.Windows.Forms.TextBox();
			this.button_szyfrowanie_asymetryczne = new System.Windows.Forms.Button();
			this.button_close = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
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
			this.textBoxZaszyfrowany.Location = new System.Drawing.Point(7, 99);
			this.textBoxZaszyfrowany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxZaszyfrowany.Name = "textBoxZaszyfrowany";
			this.textBoxZaszyfrowany.Size = new System.Drawing.Size(205, 20);
			this.textBoxZaszyfrowany.TabIndex = 0;
			this.textBoxZaszyfrowany.TextChanged += new System.EventHandler(this.textBoxZaszyfrowany_TextChanged);
			// 
			// button_Szyfrowanie_Symetryczne
			// 
			this.button_Szyfrowanie_Symetryczne.Location = new System.Drawing.Point(239, 46);
			this.button_Szyfrowanie_Symetryczne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button_Szyfrowanie_Symetryczne.Name = "button_Szyfrowanie_Symetryczne";
			this.button_Szyfrowanie_Symetryczne.Size = new System.Drawing.Size(195, 39);
			this.button_Szyfrowanie_Symetryczne.TabIndex = 1;
			this.button_Szyfrowanie_Symetryczne.Text = "Szyfruj ";
			this.button_Szyfrowanie_Symetryczne.UseVisualStyleBackColor = true;
			this.button_Szyfrowanie_Symetryczne.Click += new System.EventHandler(this.button_Szyfrowanie_Symetryczne_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Szyfrowanie symetryczne(AES)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 82);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Zaszyfrowany:";
			// 
			// textBoxInformacja
			// 
			this.textBoxInformacja.Location = new System.Drawing.Point(7, 62);
			this.textBoxInformacja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxInformacja.Name = "textBoxInformacja";
			this.textBoxInformacja.Size = new System.Drawing.Size(205, 20);
			this.textBoxInformacja.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 46);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "tekst do zaszyfrowania";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// button_plik
			// 
			this.button_plik.Location = new System.Drawing.Point(239, 95);
			this.button_plik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button_plik.Name = "button_plik";
			this.button_plik.Size = new System.Drawing.Size(195, 44);
			this.button_plik.TabIndex = 8;
			this.button_plik.Text = "Otwórz plik i szyfruj ";
			this.button_plik.UseVisualStyleBackColor = true;
			this.button_plik.Click += new System.EventHandler(this.button_plik_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 269);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(159, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Szyfrowanie asymetryczne(RSA)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 311);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(114, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "tekst do zaszyfrowania";
			// 
			// textBoxInformacja2
			// 
			this.textBoxInformacja2.Location = new System.Drawing.Point(14, 327);
			this.textBoxInformacja2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxInformacja2.Name = "textBoxInformacja2";
			this.textBoxInformacja2.Size = new System.Drawing.Size(198, 20);
			this.textBoxInformacja2.TabIndex = 11;
			// 
			// textBoxZaszyfrowany2
			// 
			this.textBoxZaszyfrowany2.Location = new System.Drawing.Point(14, 364);
			this.textBoxZaszyfrowany2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxZaszyfrowany2.Name = "textBoxZaszyfrowany2";
			this.textBoxZaszyfrowany2.Size = new System.Drawing.Size(198, 20);
			this.textBoxZaszyfrowany2.TabIndex = 12;
			// 
			// button_szyfrowanie_asymetryczne
			// 
			this.button_szyfrowanie_asymetryczne.Location = new System.Drawing.Point(238, 327);
			this.button_szyfrowanie_asymetryczne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button_szyfrowanie_asymetryczne.Name = "button_szyfrowanie_asymetryczne";
			this.button_szyfrowanie_asymetryczne.Size = new System.Drawing.Size(196, 29);
			this.button_szyfrowanie_asymetryczne.TabIndex = 14;
			this.button_szyfrowanie_asymetryczne.Text = "Szyfruj";
			this.button_szyfrowanie_asymetryczne.UseVisualStyleBackColor = true;
			this.button_szyfrowanie_asymetryczne.Click += new System.EventHandler(this.button_szyfrowanie_asymetryczne_Click);
			// 
			// button_close
			// 
			this.button_close.Location = new System.Drawing.Point(309, 541);
			this.button_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button_close.Name = "button_close";
			this.button_close.Size = new System.Drawing.Size(140, 36);
			this.button_close.TabIndex = 15;
			this.button_close.Text = "Zamknij";
			this.button_close.UseVisualStyleBackColor = true;
			this.button_close.Click += new System.EventHandler(this.button_close_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 348);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Zaszyfrowany:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(11, 393);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "Klucz publiczny:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(9, 434);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 13);
			this.label10.TabIndex = 19;
			this.label10.Text = "Klucz prywatny:";
			// 
			// textBoxKluczPubliczny
			// 
			this.textBoxKluczPubliczny.Location = new System.Drawing.Point(13, 409);
			this.textBoxKluczPubliczny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxKluczPubliczny.Name = "textBoxKluczPubliczny";
			this.textBoxKluczPubliczny.Size = new System.Drawing.Size(198, 20);
			this.textBoxKluczPubliczny.TabIndex = 20;
			// 
			// textBoxKluczPrywatny
			// 
			this.textBoxKluczPrywatny.Location = new System.Drawing.Point(13, 449);
			this.textBoxKluczPrywatny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxKluczPrywatny.Name = "textBoxKluczPrywatny";
			this.textBoxKluczPrywatny.Size = new System.Drawing.Size(198, 20);
			this.textBoxKluczPrywatny.TabIndex = 21;
			// 
			// button_plik2
			// 
			this.button_plik2.Location = new System.Drawing.Point(239, 361);
			this.button_plik2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button_plik2.Name = "button_plik2";
			this.button_plik2.Size = new System.Drawing.Size(195, 32);
			this.button_plik2.TabIndex = 22;
			this.button_plik2.Text = "Otwórz plik i szyfruj";
			this.button_plik2.UseVisualStyleBackColor = true;
			this.button_plik2.Click += new System.EventHandler(this.button_plik2_Click);
			// 
			// button_wyczysc_asymetryczne
			// 
			this.button_wyczysc_asymetryczne.Location = new System.Drawing.Point(239, 398);
			this.button_wyczysc_asymetryczne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button_wyczysc_asymetryczne.Name = "button_wyczysc_asymetryczne";
			this.button_wyczysc_asymetryczne.Size = new System.Drawing.Size(195, 61);
			this.button_wyczysc_asymetryczne.TabIndex = 24;
			this.button_wyczysc_asymetryczne.Text = "Wyczyść szyfrowanie";
			this.button_wyczysc_asymetryczne.UseVisualStyleBackColor = true;
			this.button_wyczysc_asymetryczne.Click += new System.EventHandler(this.button_wyczysc_asymetryczne_Click);
			// 
			// button_wyczysc_szyfrowanie_symetryczne
			// 
			this.button_wyczysc_szyfrowanie_symetryczne.Location = new System.Drawing.Point(239, 148);
			this.button_wyczysc_szyfrowanie_symetryczne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button_wyczysc_szyfrowanie_symetryczne.Name = "button_wyczysc_szyfrowanie_symetryczne";
			this.button_wyczysc_szyfrowanie_symetryczne.Size = new System.Drawing.Size(195, 42);
			this.button_wyczysc_szyfrowanie_symetryczne.TabIndex = 25;
			this.button_wyczysc_szyfrowanie_symetryczne.Text = "Wyczyść szyfrowanie";
			this.button_wyczysc_szyfrowanie_symetryczne.UseVisualStyleBackColor = true;
			this.button_wyczysc_szyfrowanie_symetryczne.Click += new System.EventHandler(this.button_wyczysc_szyfrowanie_symetryczne_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 588);
			this.Controls.Add(this.button_wyczysc_szyfrowanie_symetryczne);
			this.Controls.Add(this.button_wyczysc_asymetryczne);
			this.Controls.Add(this.button_plik2);
			this.Controls.Add(this.textBoxKluczPrywatny);
			this.Controls.Add(this.textBoxKluczPubliczny);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button_close);
			this.Controls.Add(this.button_szyfrowanie_asymetryczne);
			this.Controls.Add(this.textBoxZaszyfrowany2);
			this.Controls.Add(this.textBoxInformacja2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button_plik);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxInformacja);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_Szyfrowanie_Symetryczne);
			this.Controls.Add(this.textBoxZaszyfrowany);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox textBoxInformacja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_plik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInformacja2;
        private System.Windows.Forms.TextBox textBoxZaszyfrowany2;
        private System.Windows.Forms.Button button_szyfrowanie_asymetryczne;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxKluczPubliczny;
        private System.Windows.Forms.TextBox textBoxKluczPrywatny;
        private System.Windows.Forms.Button button_plik2;
        private System.Windows.Forms.Button button_wyczysc_asymetryczne;
        private System.Windows.Forms.Button button_wyczysc_szyfrowanie_symetryczne;
    }
}

