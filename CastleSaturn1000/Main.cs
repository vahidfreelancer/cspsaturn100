using CastlePaySolutions.Saturn1X;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastlePaySolutions
{
    public partial class Main : Form
    {
        int lastTransId = 0;
        public Main()
        {
            InitializeComponent();
            _CONSOLE = LogConsole;

            TxbxTerminalIp.Text = CastlePaySolutions.Properties.Settings.Default.terminalIp;
            TxbxTerminalPort.Text = CastlePaySolutions.Properties.Settings.Default.TerminalPort.ToString();
            lastTransId = CastlePaySolutions.Properties.Settings.Default.trnsid;
            Log("Start");
        }
        public static RichTextBox _CONSOLE;
        public static void Log(object msg) 
        {
            if (_CONSOLE == null)
                return;
            else
                _CONSOLE.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}: {msg}");
        }

        private void BtnSaveSetting_Click(object sender, EventArgs e)
        {
            CastlePaySolutions.Properties.Settings.Default.terminalIp = TxbxTerminalIp.Text.Trim();
            CastlePaySolutions.Properties.Settings.Default.TerminalPort = int.Parse(TxbxTerminalPort.Text.Trim());
            CastlePaySolutions.Properties.Settings.Default.Save();
        }
        
        private void BtnSendSaleRequest_Click(object sender, EventArgs e)
        {
            var value=TxbxAmount.Text.Trim();
            var tip=TxbxTipAmount.Text.Trim();
            if (value.Length < 1)
                return;
            TransactionHandler th=new TransactionHandler("192.168.0.252",9090);

            
        }
    }
}
