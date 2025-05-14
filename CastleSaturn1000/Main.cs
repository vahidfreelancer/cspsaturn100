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
        public Main()
        {
            InitializeComponent();
            _CONSOLE = LogConsole;


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
    }
}
