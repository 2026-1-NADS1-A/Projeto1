using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Drawing;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List<string> logs = new List<string>();

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(
            IntPtr hwnd,
            int dwAttribute,
            ref int pvAttribute,
            int cbAttribute);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        public Form1()
        {
            InitializeComponent();
            AplicarEstiloTela();
        }

        private void AplicarTitleBarPreta()
        {
            int valor = 1;
            DwmSetWindowAttribute(
                this.Handle,
                DWMWA_USE_IMMERSIVE_DARK_MODE,
                ref valor,
                sizeof(int));
        }

        private void AplicarEstiloTela()
        {
            this.BackColor = Color.White;

            EstilizarBotao(btIP);
            EstilizarBotao(btvalidar);
            EstilizarBotao(btlog);
        }

        private void EstilizarBotao(Button botao)
        {
            botao.BackColor = Color.Black;
            botao.ForeColor = Color.White;
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.UseVisualStyleBackColor = false;
        }

        private void btIP_Click(object sender, EventArgs e)
        {
            string ip = ObterIP();

            Clipboard.SetText(ip);

            MessageBox.Show(
                "Seu IP: " + ip + "\n\n(IP copiado. Use CTRL + V para colar)",
                "IP da máquina",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private string ObterIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }

            return "IP não encontrado";
        }

        private void btvalidar_Click(object sender, EventArgs e)
        {
            string ipDigitado = txtIP.Text.Trim();
            string meuIP = ObterIP();
            string status;

            if (!IPAddress.TryParse(ipDigitado, out _))
            {
                status = "Não autorizado";
                logs.Add($"{DateTime.Now:dd/MM/yyyy HH:mm:ss} | {ipDigitado} | {status}");
                MessageBox.Show("Não autorizado");
                return;
            }

            if (ipDigitado == meuIP)
                status = "Autorizado";
            else
                status = "Não autorizado";

            logs.Add($"{DateTime.Now:dd/MM/yyyy HH:mm:ss} | {ipDigitado} | {status}");

            MessageBox.Show(status);
        }

        private void btlog_Click(object sender, EventArgs e)
        {
            if (logs.Count == 0)
            {
                MessageBox.Show("Nenhuma tentativa registrada.", "Logs");
                return;
            }

            var ultimos10 = logs.TakeLast(10);
            string mensagem = string.Join(Environment.NewLine, ultimos10);

            MessageBox.Show(mensagem, "Últimas 10 tentativas");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AplicarTitleBarPreta();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}