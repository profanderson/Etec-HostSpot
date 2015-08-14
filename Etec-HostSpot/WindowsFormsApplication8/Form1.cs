using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics; // Classe .Net para chamadas de comandos do Windows.
using System.IO; // classe para entrade e saida de dados do sistema, usado para ler o arquivo log.txt

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String NomeDaRede = TxtNomeDaRede.Text;
            String SenhaDaRede = TxtSenha.Text;

            if (NomeDaRede == "") { MessageBox.Show("Defina o nome da Rede"); TxtNomeDaRede.Focus(); return; }
            if (SenhaDaRede == "") { MessageBox.Show("Defina a senha da Rede"); TxtSenha.Focus(); return; }
            
            
            //-> Inicia o arquivo de log que será exibido no ListBox.
            ProcessStartInfo IniciarLogData = new ProcessStartInfo();
            IniciarLogData.WindowStyle = ProcessWindowStyle.Hidden;
            IniciarLogData.FileName = "cmd.exe";
            IniciarLogData.Arguments = "/c date /t > log.txt";
            try
            {
                using (Process exeProcess = Process.Start(IniciarLogData))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch {  }

            ProcessStartInfo IniciarLogHora = new ProcessStartInfo();
            IniciarLogHora.WindowStyle = ProcessWindowStyle.Hidden;
            IniciarLogHora.FileName = "cmd.exe";
            IniciarLogHora.Arguments = "/c time /t >> log.txt";
            try
            {
                using (Process exeProcess = Process.Start(IniciarLogHora))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch {  }

            //->  Passo 1 - Parar qualquer rede Ad Hoc que existir.            
            ProcessStartInfo PararAdHoc = new ProcessStartInfo();
            PararAdHoc.WindowStyle = ProcessWindowStyle.Hidden;
            PararAdHoc.FileName = "cmd.exe";
            PararAdHoc.Arguments = "/c netsh wlan stop hostednetwork >> log.txt";
            try
            {
                using (Process exeProcess = Process.Start(PararAdHoc))
                {
                    exeProcess.WaitForExit();                    
                }
            }
            catch { lstLog.Items.Add("Me desculpe! Algo aconteceu e não consegui limpar suas conefigurações antigas redes hospedadas"); }

            //Passo 2 - Definir uma nova rede AdHoc.
            ProcessStartInfo startInfo = new ProcessStartInfo();            
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            String cmdCriarAdHoc = "netsh wlan set hostednetwork mode=allow ssid=" + NomeDaRede + " key=" + SenhaDaRede + ">> log.txt";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c " + cmdCriarAdHoc;            
            try  {
	            using (Process exeProcess = Process.Start(startInfo)) {
		            exeProcess.WaitForExit();                    
                }
            }
            catch { lstLog.Items.Add("Me desculpe! Não consegui definir os valores da rede Ad Hoc"); }

            //Passo 3 - Iniciar a rede
            ProcessStartInfo startAdHoc = new ProcessStartInfo();
            startAdHoc.WindowStyle = ProcessWindowStyle.Hidden;
            startAdHoc.FileName = "cmd.exe";
            startAdHoc.Arguments = "/c netsh wlan start hostednetwork >> log.txt";
            try
            {
                using (Process exeProcess = Process.Start(startAdHoc))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch { lstLog.Items.Add("Me desculpe! Não consegui criar a rede Ad Hoc"); }


            // Ler arquivo de log gerado pelo CMD.            
            string linha;
            using (StreamReader LerTxt = new StreamReader("log.txt"))
            { 
                linha = LerTxt.ReadLine();
                lstLog.Items.Add(linha);
                while ((linha = LerTxt.ReadLine()) != null)
                {
                    lstLog.Items.Add(linha);
                    string[] words = linha.Split(' ');
                    if (words[0] == "Valor")
                    { 
                        if (words[3] == "\"key\"") MessageBox.Show(words[3] + "\n Senha deve ter de 8 a 63 caracteres.");
                        lstDetalhes.Items.Clear();
                        lstLog.Items.Clear();
                        TxtSenha.Focus();
                        return;
                    }                    
                }
                lstLog.Items.Add("Você pode encerrar este aplicativo, sua rede já está funcionando!");
            }
            
            // Capturar detalhes dos adaptadores
            ProcessStartInfo detalhesAdHoc = new ProcessStartInfo();
            detalhesAdHoc.WindowStyle = ProcessWindowStyle.Hidden;
            detalhesAdHoc.FileName = "cmd.exe";
            detalhesAdHoc.Arguments = "/c " + " netsh wlan show hostednetwork > detalhes.txt";

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch {  }

            // ler arquivo txt detalhes.txt
            using (StreamReader LerTxt = new StreamReader("detalhes.txt"))
            {
                linha = LerTxt.ReadLine();
                lstDetalhes.Items.Add(linha);
                while ((linha = LerTxt.ReadLine()) != null)
                {
                    lstDetalhes.Items.Add(linha);
                }
                lstDetalhes.Items.Add("Você pode encerrar este aplicativo, sua rede já está funcionando!");
            }

            // compartilhar a internet
            ProcessStartInfo compartilhaNet = new ProcessStartInfo();
            compartilhaNet.WindowStyle = ProcessWindowStyle.Hidden;
            compartilhaNet.FileName = "cmd.exe";
            compartilhaNet.Arguments = "/c " + "sc config SharedAccess start= auto >> log.txt";
            try
            {
                using (Process exeProcess = Process.Start(compartilhaNet))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch { }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //-> Excluir a Rede AD HOC
            lstLog.Items.Clear();
            ProcessStartInfo CancelarAdHoc = new ProcessStartInfo();
            CancelarAdHoc.WindowStyle = ProcessWindowStyle.Hidden;
            CancelarAdHoc.FileName = "cmd.exe";
            CancelarAdHoc.Arguments = "/c netsh wlan set hostednetwork mode=disallow > log.txt";
            try
            {
                using (Process exeProcess = Process.Start(CancelarAdHoc))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch { }

            lstDetalhes.Items.Clear();

            // ler arquivo log.txt
            string linha;
            using (StreamReader LerTxt = new StreamReader("log.txt"))
            {
                linha = LerTxt.ReadLine();
                lstLog.Items.Add(linha);
                while ((linha = LerTxt.ReadLine()) != null)
                {
                    lstLog.Items.Add(linha);
                }                
            }


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("ncpa.cpl");
        }

        private void verificarConexõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            ProcessStartInfo PausarAdHoc = new ProcessStartInfo();
            PausarAdHoc.WindowStyle = ProcessWindowStyle.Hidden;
            PausarAdHoc.FileName = "cmd.exe";
            PausarAdHoc.Arguments = "/c netsh wlan stop hostednetwork >> log.txt";
            try
            {
                using (Process exeProcess = Process.Start(PausarAdHoc))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch { lstLog.Items.Add("Me desculpe! Algo aconteceu e não consegui limpar suas conefigurações antigas redes hospedadas"); }


            lstLog.Items.Clear();
            lstDetalhes.Items.Clear();

            string linha;
            using (StreamReader LerTxt = new StreamReader("log.txt"))
            {
                linha = LerTxt.ReadLine();
                lstLog.Items.Add(linha);
                while ((linha = LerTxt.ReadLine()) != null)
                {
                    lstLog.Items.Add(linha);
                }
                lstLog.Items.Add("Você pode encerrar este aplicativo, sua rede já está funcionando!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("tenso");
        }
    }
}
