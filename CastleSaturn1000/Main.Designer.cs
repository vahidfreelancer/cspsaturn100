namespace CastlePaySolutions
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LogConsole = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabTransaction = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxbxTerminalPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbxTerminalIp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxbxAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSaveSetting = new System.Windows.Forms.Button();
            this.TxbxTipAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSendSaleRequest = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabTransaction.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "Statuse: None";
            // 
            // LogConsole
            // 
            this.LogConsole.BackColor = System.Drawing.Color.Black;
            this.LogConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogConsole.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogConsole.ForeColor = System.Drawing.Color.Lime;
            this.LogConsole.Location = new System.Drawing.Point(0, 306);
            this.LogConsole.Name = "LogConsole";
            this.LogConsole.Size = new System.Drawing.Size(684, 249);
            this.LogConsole.TabIndex = 1;
            this.LogConsole.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabTransaction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 306);
            this.panel1.TabIndex = 2;
            // 
            // TabTransaction
            // 
            this.TabTransaction.Controls.Add(this.tabPage1);
            this.TabTransaction.Controls.Add(this.tabPage2);
            this.TabTransaction.Controls.Add(this.tabPage3);
            this.TabTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabTransaction.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTransaction.Location = new System.Drawing.Point(0, 0);
            this.TabTransaction.Name = "TabTransaction";
            this.TabTransaction.SelectedIndex = 0;
            this.TabTransaction.Size = new System.Drawing.Size(684, 306);
            this.TabTransaction.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transaction";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtnSaveSetting);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(676, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Config";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxbxTerminalPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxbxTerminalIp);
            this.groupBox1.Location = new System.Drawing.Point(46, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // TxbxTerminalPort
            // 
            this.TxbxTerminalPort.Location = new System.Drawing.Point(61, 74);
            this.TxbxTerminalPort.Name = "TxbxTerminalPort";
            this.TxbxTerminalPort.Size = new System.Drawing.Size(117, 20);
            this.TxbxTerminalPort.TabIndex = 2;
            this.TxbxTerminalPort.Text = "9090";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // TxbxTerminalIp
            // 
            this.TxbxTerminalIp.Location = new System.Drawing.Point(61, 37);
            this.TxbxTerminalIp.Name = "TxbxTerminalIp";
            this.TxbxTerminalIp.Size = new System.Drawing.Size(117, 20);
            this.TxbxTerminalIp.TabIndex = 0;
            this.TxbxTerminalIp.Text = "192.168.0.252";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSendSaleRequest);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxbxTipAmount);
            this.groupBox2.Controls.Add(this.TxbxAmount);
            this.groupBox2.Location = new System.Drawing.Point(67, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 114);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale";
            // 
            // TxbxAmount
            // 
            this.TxbxAmount.Location = new System.Drawing.Point(61, 29);
            this.TxbxAmount.Name = "TxbxAmount";
            this.TxbxAmount.Size = new System.Drawing.Size(100, 20);
            this.TxbxAmount.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount";
            // 
            // BtnSaveSetting
            // 
            this.BtnSaveSetting.Location = new System.Drawing.Point(496, 241);
            this.BtnSaveSetting.Name = "BtnSaveSetting";
            this.BtnSaveSetting.Size = new System.Drawing.Size(172, 23);
            this.BtnSaveSetting.TabIndex = 1;
            this.BtnSaveSetting.Text = "Save";
            this.BtnSaveSetting.UseVisualStyleBackColor = true;
            this.BtnSaveSetting.Click += new System.EventHandler(this.BtnSaveSetting_Click);
            // 
            // TxbxTipAmount
            // 
            this.TxbxTipAmount.Location = new System.Drawing.Point(61, 55);
            this.TxbxTipAmount.Name = "TxbxTipAmount";
            this.TxbxTipAmount.Size = new System.Drawing.Size(100, 20);
            this.TxbxTipAmount.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tip";
            // 
            // BtnSendSaleRequest
            // 
            this.BtnSendSaleRequest.Location = new System.Drawing.Point(74, 83);
            this.BtnSendSaleRequest.Name = "BtnSendSaleRequest";
            this.BtnSendSaleRequest.Size = new System.Drawing.Size(75, 23);
            this.BtnSendSaleRequest.TabIndex = 2;
            this.BtnSendSaleRequest.Text = "Send";
            this.BtnSendSaleRequest.UseVisualStyleBackColor = true;
            this.BtnSendSaleRequest.Click += new System.EventHandler(this.BtnSendSaleRequest_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 577);
            this.Controls.Add(this.LogConsole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Castle Saturn 1000 ECR Demo .NET V0.0.1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.TabTransaction.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox LogConsole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabTransaction;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxbxTerminalIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbxTerminalPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbxAmount;
        private System.Windows.Forms.Button BtnSaveSetting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbxTipAmount;
        private System.Windows.Forms.Button BtnSendSaleRequest;
    }
}

