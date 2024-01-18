using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Principal;
using System.Runtime.InteropServices;

namespace RegistrarClevert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            // Digite aqui seu texto zedendagua 

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = textBox1.Text;
            if (File.Exists(fileName))
            {
                Process.Start(fileName);
            }
            else
            {
                MessageBox.Show("Verifique o Camoinho Digitado, *Arquivo não Encontrado*!");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\SGLinx\registrar.bat"; // Replace with your file path
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\SGLinx\Logs\LogMonitor.txt"; // Replace with your file path
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\LinxOS\registrar.bat"; // Replace with your file path
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Projetos\SGLinx\registrar.bat"; // Replace with your file path
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string emailAddress = "mailto:cleverton.silva@linearsistemas.com.br";
            System.Diagnostics.Process.Start(emailAddress);
        }
    }
}
