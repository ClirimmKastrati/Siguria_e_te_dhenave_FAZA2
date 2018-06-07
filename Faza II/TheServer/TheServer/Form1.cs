using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Security.Cryptography;

namespace TheServer
{
    public partial class Server : Form
    {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

        string publicKeyOfClientFile = "D:\\Celesat_e_klientit\\publicKeyOfClient.xml";
        string privateKeyOfClientFile = "D:\\Celesat_e_klientit\\privateKeyOfClient.xml";

        string publicKeyOfServerFile = "D:\\Celesat_e_serverit\\publicKeyOfServer.xml";
        string privateKeyOfServerFile = "D:\\Celesat_e_serverit\\privateKeyOfServer.xml";

        public Server()
        {
            InitializeComponent();
        }

        private UdpClient server;
        private IPEndPoint Klienti;
        private Thread UdpThread;
        private string IPAdresa = "127.0.0.1";
        private int port = 6000;
        private string dergesa = "";

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnStop.Visible = true;

            IPEndPoint IPKlienti = new IPEndPoint(IPAddress.Any, 6000);
            server = new UdpClient(IPKlienti);
            Klienti = new IPEndPoint(IPAddress.Any, 6000);

            UdpThread = new Thread(new ThreadStart(startlisten));
            UdpThread.Start();
            MessageBox.Show("Serveri u startua", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        delegate void TXTKERKESACallback(string teksti);
        private void TXTKERKESA(string teksti)
        {
            if (textBox1.InvokeRequired)
            {
                this.Invoke(new TXTKERKESACallback(TXTKERKESA), new object[] { teksti });
            }
            else
            {
                textBox1.Text = teksti;


            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            UdpThread.Abort();
            server.Close();

            btnStart.Visible = true;
            btnStop.Visible = false;
            MessageBox.Show("Serveri u ndalua", "Serveri u ndalua", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static byte[] Decrypt(string privateKeyOfClientFile, byte[] plain)
        {
            byte[] decrypted;
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                string privateKey = File.ReadAllText(privateKeyOfClientFile);
                rsa.FromXmlString(privateKey);
                decrypted = rsa.Decrypt(plain, true);
            }
            return decrypted;
        }



        private void Server_Load(object sender, EventArgs e)
        {

        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {

            byte[] mesazhi = Convert.FromBase64String(textBox1.Text);

            byte[] decrypted = Decrypt(privateKeyOfClientFile, mesazhi);
            textBox2.Text = Encoding.UTF8.GetString(decrypted);

        }
        private static void generateServerKeys(string publicKeyOfServerFile, string privateKeyOfServerFile)
        {
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                if (File.Exists(publicKeyOfServerFile)) { File.Delete(publicKeyOfServerFile); }       //per te gjeneruar celesa te ri pas cdo ekzekutimi
                if (File.Exists(privateKeyOfServerFile)) { File.Delete(privateKeyOfServerFile); }     //per te gjeneruar celesa te ri pas cdo ekzekutimi

                string publicKey = rsa.ToXmlString(false);
                File.WriteAllText(publicKeyOfServerFile, publicKey);

                string privateKey = rsa.ToXmlString(true);
                File.WriteAllText(privateKeyOfServerFile, privateKey);

            }
        }
        public static byte[] Encrypt(string publicKeyOfServerFile, byte[] plain)
        {
            byte[] encrypted;
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                string publicKey = File.ReadAllText(publicKeyOfServerFile);
                rsa.FromXmlString(publicKey);
                encrypted = rsa.Encrypt(plain, true);
            }
            return encrypted;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            byte[] mesazhi = Encoding.UTF8.GetBytes(txtPlaintext.Text);
            generateServerKeys(publicKeyOfServerFile, privateKeyOfServerFile);
            byte[] encrypted = Encrypt(publicKeyOfServerFile, mesazhi);
            txtCiphertext.Text = Convert.ToBase64String(encrypted);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] bufer1 = new byte[128];
            bufer1 = Encoding.ASCII.GetBytes(txtCiphertext.Text);
            server.Send(bufer1, bufer1.Length, Klienti);
            
        }
        private void startlisten()
        {
            string kerkesa = "";
            while (true)
            {
                try
                {
                    Byte[] bPranimi = new Byte[128];
                    bPranimi = server.Receive(ref Klienti);
                    kerkesa = Encoding.UTF8.GetString(bPranimi, 0, bPranimi.Length);
                    string pergjigjja = "Nuk kemi kerkese valide";

                    TXTKERKESA(kerkesa);

                    pergjigjja = kerkesa;


                    byte[] bufer1 = new byte[128];
                    bufer1 = Encoding.UTF8.GetBytes(txtCiphertext.Text);
                    server.Send(bufer1, bufer1.Length, Klienti);
                    Thread.Sleep(500);

                }
                catch (Exception m)
                {
                }

            }
        }
    }
}
