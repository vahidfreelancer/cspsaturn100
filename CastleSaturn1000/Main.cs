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
            TransactionHandler.ITransactionId = lastTransId;
            Log("Start");
        }
        public static RichTextBox _CONSOLE;
        public static void Log(object msg) 
        {
            if (_CONSOLE == null)
                return;
            else
                _CONSOLE.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}: {msg}\r\n");
        }

        private void BtnSaveSetting_Click(object sender, EventArgs e)
        {
            CastlePaySolutions.Properties.Settings.Default.terminalIp = TxbxTerminalIp.Text.Trim();
            CastlePaySolutions.Properties.Settings.Default.TerminalPort = int.Parse(TxbxTerminalPort.Text.Trim());
            CastlePaySolutions.Properties.Settings.Default.Save();
        }
        
        private async void BtnSendSaleRequest_Click(object sender, EventArgs e)
        {
            var value=TxbxAmount.Text.Trim();
            var tip=TxbxTipAmount.Text.Trim();
            if (value.Length < 1)
                return;
            string IP = TxbxTerminalIp.Text.Trim();
            int port = int.Parse(TxbxTerminalPort.Text.Trim());
            TransactionHandler th = new TransactionHandler(IP, port);
            th.Sell(value, tip);

        }

        private void BtnCheckTerminalStatus_Click(object sender, EventArgs e)
        {
            //string IP = TxbxTerminalIp.Text.Trim();
            //int port = int.Parse(TxbxTerminalPort.Text.Trim());
            //TransactionHandler th = new TransactionHandler(IP, port);
            //th.
        }
    }
}
