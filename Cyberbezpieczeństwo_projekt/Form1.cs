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
                string password = "UKWUKW";
                byte[] Salt = SymmetricEncryption.GenerateSalt(); //generowanie soli, dla hasla
                byte[] IV = SymmetricEncryption.GenerateIV(); //generowanie IV
                byte[] key = SymmetricEncryption.CreateKey(password, Salt); //tworzenie klucza na podstawie hasla i soli. To moze potrwac.
                string Encrypted = SymmetricEncryption.EncryptString(toEncrypt, key, IV);
                textBoxZaszyfrowany.Text = Encrypted;
                textBoxOdszyfrowany.Text = SymmetricEncryption.DecryptString(Encrypted, key, IV);
            
         
            
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
                    string password = "UKWUKW!";
                    byte[] Salt = SymmetricEncryption.GenerateSalt(); //generowanie soli, dla hasla
                    byte[] IV = SymmetricEncryption.GenerateIV(); //generowanie IV
                    byte[] key = SymmetricEncryption.CreateKey(password, Salt); //tworzenie klucza na podstawie hasla i soli. To moze potrwac.
                    string Encrypted = SymmetricEncryption.EncryptString(toEncrypt, key, IV);
                    textBoxZaszyfrowany.Text =   Encrypted;
                    textBoxOdszyfrowany.Text = SymmetricEncryption.DecryptString(Encrypted, key, IV);
                }
           


    }

        private void button_szyfrowanie_asymetryczne_Click(object sender, EventArgs e)
        {
            var cryptoServiceProvider = new RSACryptoServiceProvider(2048); //2048 - Długość klucza
            var privateKey = cryptoServiceProvider.ExportParameters(true); //Generowanie klucza prywatnego
            var publicKey = cryptoServiceProvider.ExportParameters(false); //Generowanie klucza publiczny

            string publicKeyString = AssymetricEncryption.GetKeyString(publicKey);
            string privateKeyString = AssymetricEncryption.GetKeyString(privateKey);


            textBoxKluczPubliczny.Text = publicKeyString;
            textBoxKluczPrywatny.Text = privateKeyString;
            string textToEncrypt = textBoxInformacja2.Text;
            string encryptedText = AssymetricEncryption.Encrypt(textToEncrypt, publicKeyString); //Szyfrowanie za pomocą klucza publicznego
            textBoxZaszyfrowany2.Text = encryptedText;
            string decryptedText = AssymetricEncryption.Decrypt(encryptedText, privateKeyString); //Odszyfrowywanie za pomocą klucza prywatnego
            textBoxOdszyfrowany2.Text = decryptedText;
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
                var cryptoServiceProvider = new RSACryptoServiceProvider(2048); //2048 - Długość klucza
                var privateKey = cryptoServiceProvider.ExportParameters(true); //Generowanie klucza prywatnego
                var publicKey = cryptoServiceProvider.ExportParameters(false); //Generowanie klucza publiczny

                string publicKeyString = AssymetricEncryption.GetKeyString(publicKey);
                string privateKeyString = AssymetricEncryption.GetKeyString(privateKey);


                textBoxKluczPubliczny.Text = publicKeyString;
                textBoxKluczPrywatny.Text = privateKeyString;
                string encryptedText = AssymetricEncryption.Encrypt(fileToEncrypt, publicKeyString); //Szyfrowanie za pomocą klucza publicznego
                textBoxZaszyfrowany2.Text = encryptedText;
                string decryptedText = AssymetricEncryption.Decrypt(encryptedText, privateKeyString); //Odszyfrowywanie za pomocą klucza prywatnego
                textBoxOdszyfrowany2.Text = decryptedText;
            }
        }



        private void button_wyczysc_asymetryczne_Click(object sender, EventArgs e)
        {
            textBoxInformacja2.Clear();
            textBoxZaszyfrowany2.Clear();
            textBoxOdszyfrowany2.Clear();
            textBoxKluczPubliczny.Clear();
            textBoxKluczPrywatny.Clear();
        }

        private void button_wyczysc_szyfrowanie_symetryczne_Click(object sender, EventArgs e)
        {

            textBoxInformacja.Clear();
            textBoxZaszyfrowany.Clear();
            textBoxOdszyfrowany.Clear();
        }
    }
}
