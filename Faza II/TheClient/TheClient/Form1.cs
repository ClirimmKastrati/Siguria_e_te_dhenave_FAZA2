using System.Net;
using System.Net.Sockets;
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace TheClient
{
    public partial class Client : Form
    {

        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
       

        string publicKeyOfClientFile = "D:\\Celesat_e_klientit\\publicKeyOfClient.xml";
        string privateKeyOfClientFile = "D:\\Celesat_e_klientit\\privateKeyOfClient.xml";

        string publicKeyOfServerFile = "D:\\Celesat_e_serverit\\publicKeyOfServer.xml";
        string privateKeyOfServerFile = "D:\\Celesat_e_serverit\\privateKeyOfServer.xml";

        public Client()
        {
            InitializeComponent();
        }

        private UdpClient server;
        private IPEndPoint Klienti;
        private string IPAdresa = "127.0.0.1";
        private int port = 6000;
        private string dergesa = "";

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] eardhura = new byte[128];
            server = new UdpClient(IPAdresa, port);
            Klienti = new IPEndPoint(IPAddress.Any, port);

            try
            {
                    
                        if (txtCiphertext.Text == "")
                            MessageBox.Show("Duhet ta shkruani mesazhin!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            dergesa = txtCiphertext.Text;
                            send(dergesa);
                        }
                    
                
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void send(string dergesa)
        {
            try
            {
                server.Send(Encoding.ASCII.GetBytes(dergesa), dergesa.Length);
             
            }
            catch (Exception)
            {
                MessageBox.Show("Kerkesa nuk ka mundur te dergohet", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
       
        private void gjenero_Click(object sender, EventArgs e)
        {
            RSAParameters objParametrat = rsa.ExportParameters(true);
             txtP.Text = BitConverter.ToString(objParametrat.P);
             txtQ.Text = BitConverter.ToString(objParametrat.Q);
             txtE.Text = BitConverter.ToString(objParametrat.Exponent);
             txtD.Text = BitConverter.ToString(objParametrat.D);
        }


        private void enkripto_Click(object sender, EventArgs e)
        {

            byte[] mesazhi = Encoding.UTF8.GetBytes(txtPlaintext.Text);
            generateClientKeys(publicKeyOfClientFile, privateKeyOfClientFile);
            byte[] encrypted = Encrypt(publicKeyOfClientFile, mesazhi);
            txtCiphertext.Text = Convert.ToBase64String(encrypted);

        }
        private static void generateClientKeys(string publicKeyOfClientFile , string privateKeyOfClientFile)
        {
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                if (File.Exists(publicKeyOfClientFile)) { File.Delete(publicKeyOfClientFile); }       //per te gjeneruar celesa te ri pas cdo ekzekutimi
                if (File.Exists(privateKeyOfClientFile)) { File.Delete(privateKeyOfClientFile); }     //per te gjeneruar celesa te ri pas cdo ekzekutimi

                string publicKey = rsa.ToXmlString(false);
                File.WriteAllText(publicKeyOfClientFile, publicKey);

                string privateKey = rsa.ToXmlString(true);
                File.WriteAllText(privateKeyOfClientFile, privateKey);

            }
        }
        public static byte[] Encrypt(string publicKeyOfClientFile , byte[] plain)
        {
            byte[] encrypted;
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                string publicKey = File.ReadAllText(publicKeyOfClientFile);
                rsa.FromXmlString(publicKey);
                encrypted = rsa.Encrypt(plain, true);
            }
                return encrypted;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
        private void prano()
        {
            Byte[] bPergjigjia = new Byte[128];
            bPergjigjia = server.Receive(ref Klienti);
            textBox1.Text =Encoding.UTF8.GetString(bPergjigjia);
        }

        private void btnPrano_Click(object sender, EventArgs e)
        {
            prano();
        }

        public static byte[] Decrypt(string privateKeyOfServerFile, byte[] plain)
        {
            byte[] decrypted;
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                string privateKey = File.ReadAllText(privateKeyOfServerFile);
                rsa.FromXmlString(privateKey);
                decrypted = rsa.Decrypt(plain, true);
            }
            return decrypted;
        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            byte[] mesazhi = Convert.FromBase64String(textBox1.Text);

            byte[] decrypted = Decrypt(privateKeyOfServerFile, mesazhi);
            textBox2.Text = Encoding.UTF8.GetString(decrypted);
        }
    }
}
