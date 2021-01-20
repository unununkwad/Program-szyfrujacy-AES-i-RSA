using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using System.Security.Cryptography;

namespace Cyberbezpieczeństwo_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxZaszyfrowany_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Szyfrowanie_Symetryczne_Click(object sender, EventArgs e)
        {
            
            
                string toEncrypt = textBoxInformacja.Text;
                string password = "AES";
                byte[] Salt = SymmetricEncryption.GenerateSalt();
                byte[] IV = SymmetricEncryption.GenerateIV();
                byte[] key = SymmetricEncryption.CreateKey(password, Salt);
                string Encrypted = SymmetricEncryption.EncryptString(toEncrypt, key, IV);
                textBoxZaszyfrowany.Text = Encrypted;
            
         
            
        }
        
        private void button_plik_Click(object sender, EventArgs e)
        {
          
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Pliki textowe (txt)|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                textBoxInformacja.Text = File.ReadAllText(dialog.FileName);
                    string fileToEncrypt = File.ReadAllText(dialog.FileName);
                    string toEncrypt = fileToEncrypt;
                    string password = "AES";
                    byte[] Salt = SymmetricEncryption.GenerateSalt(); 
                    byte[] IV = SymmetricEncryption.GenerateIV();
                    byte[] key = SymmetricEncryption.CreateKey(password, Salt);
                    string Encrypted = SymmetricEncryption.EncryptString(toEncrypt, key, IV);
                    textBoxZaszyfrowany.Text =   Encrypted;
                }
           


    }

        private void button_szyfrowanie_asymetryczne_Click(object sender, EventArgs e)
        {
            var cryptoServiceProvider = new RSACryptoServiceProvider(2048);
            var privateKey = cryptoServiceProvider.ExportParameters(true);
            var publicKey = cryptoServiceProvider.ExportParameters(false);

            string publicKeyString = AssymetricEncryption.GetKeyString(publicKey);
            string privateKeyString = AssymetricEncryption.GetKeyString(privateKey);


            textBoxKluczPubliczny.Text = publicKeyString;
            textBoxKluczPrywatny.Text = privateKeyString;
            string textToEncrypt = textBoxInformacja2.Text;
            string encryptedText = AssymetricEncryption.Encrypt(textToEncrypt, publicKeyString);
            textBoxZaszyfrowany2.Text = encryptedText;
            string decryptedText = AssymetricEncryption.Decrypt(encryptedText, privateKeyString);
        }
        
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button_plik2_Click(object sender, EventArgs e)
        {   
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki textowe (txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxInformacja2.Text = File.ReadAllText(dialog.FileName);
                string fileToEncrypt = File.ReadAllText(dialog.FileName);
                string toEncrypt = fileToEncrypt;
                var cryptoServiceProvider = new RSACryptoServiceProvider(2048);
                var privateKey = cryptoServiceProvider.ExportParameters(true);
                var publicKey = cryptoServiceProvider.ExportParameters(false);

                string publicKeyString = AssymetricEncryption.GetKeyString(publicKey);
                string privateKeyString = AssymetricEncryption.GetKeyString(privateKey);


                textBoxKluczPubliczny.Text = publicKeyString;
                textBoxKluczPrywatny.Text = privateKeyString;
                string encryptedText = AssymetricEncryption.Encrypt(fileToEncrypt, publicKeyString);
                textBoxZaszyfrowany2.Text = encryptedText;
                string decryptedText = AssymetricEncryption.Decrypt(encryptedText, privateKeyString);
            }
        }



        private void button_wyczysc_asymetryczne_Click(object sender, EventArgs e)
        {
            textBoxInformacja2.Clear();
            textBoxZaszyfrowany2.Clear();
            textBoxKluczPubliczny.Clear();
            textBoxKluczPrywatny.Clear();
        }

        private void button_wyczysc_szyfrowanie_symetryczne_Click(object sender, EventArgs e)
        {

            textBoxInformacja.Clear();
            textBoxZaszyfrowany.Clear();
        }

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
