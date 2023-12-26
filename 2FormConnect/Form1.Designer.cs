
namespace _2FormConnect
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.txbDataReturn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRead = new System.Windows.Forms.Button();
            this.cbDatasend = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTestAutoClose = new System.Windows.Forms.Button();
            this.btnByte = new System.Windows.Forms.Button();
            this.btnCmd = new System.Windows.Forms.Button();
            this.btnA11T = new System.Windows.Forms.Button();
            this.btnA21T = new System.Windows.Forms.Button();
            this.btnA10T = new System.Windows.Forms.Button();
            this.btnA20T = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn901 = new System.Windows.Forms.Button();
            this.cbBaurate = new System.Windows.Forms.ComboBox();
            this.btnRespond = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(14, 16);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(116, 35);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(154, 16);
            this.cbPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(265, 28);
            this.cbPort.TabIndex = 1;
            this.cbPort.SelectedIndexChanged += new System.EventHandler(this.cbPort_SelectedIndexChanged);
            // 
            // txbDataReturn
            // 
            this.txbDataReturn.Location = new System.Drawing.Point(330, 167);
            this.txbDataReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDataReturn.Name = "txbDataReturn";
            this.txbDataReturn.ReadOnly = true;
            this.txbDataReturn.Size = new System.Drawing.Size(265, 26);
            this.txbDataReturn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "DataSend";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "DataReturn";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(14, 59);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(116, 35);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(14, 289);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(96, 35);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(154, 52);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(96, 35);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Refresh COM";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click_1);
            // 
            // cbDatasend
            // 
            this.cbDatasend.FormattingEnabled = true;
            this.cbDatasend.Items.AddRange(new object[] {
            "open",
            "close",
            "A11T",
            "A21T",
            "A10T",
            "A20T"});
            this.cbDatasend.Location = new System.Drawing.Point(14, 167);
            this.cbDatasend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDatasend.Name = "cbDatasend";
            this.cbDatasend.Size = new System.Drawing.Size(247, 28);
            this.cbDatasend.TabIndex = 5;
            this.cbDatasend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbDatasend_KeyDown);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(330, 332);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(96, 35);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(433, 332);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTestAutoClose
            // 
            this.btnTestAutoClose.Location = new System.Drawing.Point(14, 332);
            this.btnTestAutoClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTestAutoClose.Name = "btnTestAutoClose";
            this.btnTestAutoClose.Size = new System.Drawing.Size(114, 41);
            this.btnTestAutoClose.TabIndex = 6;
            this.btnTestAutoClose.Text = "AutoClose";
            this.btnTestAutoClose.UseVisualStyleBackColor = true;
            this.btnTestAutoClose.Click += new System.EventHandler(this.btnTestAutoClose_Click);
            // 
            // btnByte
            // 
            this.btnByte.Location = new System.Drawing.Point(124, 128);
            this.btnByte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnByte.Name = "btnByte";
            this.btnByte.Size = new System.Drawing.Size(65, 35);
            this.btnByte.TabIndex = 4;
            this.btnByte.Text = "Byte";
            this.btnByte.UseVisualStyleBackColor = true;
            this.btnByte.Click += new System.EventHandler(this.btnByte_Click);
            // 
            // btnCmd
            // 
            this.btnCmd.Location = new System.Drawing.Point(196, 128);
            this.btnCmd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(65, 35);
            this.btnCmd.TabIndex = 4;
            this.btnCmd.Text = "Cmd";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnA11T
            // 
            this.btnA11T.Location = new System.Drawing.Point(328, 223);
            this.btnA11T.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnA11T.Name = "btnA11T";
            this.btnA11T.Size = new System.Drawing.Size(96, 35);
            this.btnA11T.TabIndex = 4;
            this.btnA11T.Text = "A11T";
            this.btnA11T.UseVisualStyleBackColor = true;
            this.btnA11T.Click += new System.EventHandler(this.btnA11T_Click);
            // 
            // btnA21T
            // 
            this.btnA21T.Location = new System.Drawing.Point(432, 223);
            this.btnA21T.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnA21T.Name = "btnA21T";
            this.btnA21T.Size = new System.Drawing.Size(96, 35);
            this.btnA21T.TabIndex = 4;
            this.btnA21T.Text = "A21T";
            this.btnA21T.UseVisualStyleBackColor = true;
            // 
            // btnA10T
            // 
            this.btnA10T.Location = new System.Drawing.Point(330, 265);
            this.btnA10T.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnA10T.Name = "btnA10T";
            this.btnA10T.Size = new System.Drawing.Size(96, 35);
            this.btnA10T.TabIndex = 4;
            this.btnA10T.Text = "A10T";
            this.btnA10T.UseVisualStyleBackColor = true;
            this.btnA10T.Click += new System.EventHandler(this.btnA10T_Click);
            // 
            // btnA20T
            // 
            this.btnA20T.Location = new System.Drawing.Point(433, 265);
            this.btnA20T.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnA20T.Name = "btnA20T";
            this.btnA20T.Size = new System.Drawing.Size(96, 35);
            this.btnA20T.TabIndex = 4;
            this.btnA20T.Text = "A2T";
            this.btnA20T.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 340);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btn901
            // 
            this.btn901.Location = new System.Drawing.Point(124, 289);
            this.btn901.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn901.Name = "btn901";
            this.btn901.Size = new System.Drawing.Size(96, 35);
            this.btn901.TabIndex = 4;
            this.btn901.Text = "901";
            this.btn901.UseVisualStyleBackColor = true;
            this.btn901.Click += new System.EventHandler(this.btn901_Click);
            // 
            // cbBaurate
            // 
            this.cbBaurate.FormattingEnabled = true;
            this.cbBaurate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "57600",
            "115200"});
            this.cbBaurate.Location = new System.Drawing.Point(445, 17);
            this.cbBaurate.Name = "cbBaurate";
            this.cbBaurate.Size = new System.Drawing.Size(149, 28);
            this.cbBaurate.TabIndex = 8;
            // 
            // btnRespond
            // 
            this.btnRespond.Location = new System.Drawing.Point(14, 246);
            this.btnRespond.Name = "btnRespond";
            this.btnRespond.Size = new System.Drawing.Size(183, 36);
            this.btnRespond.TabIndex = 9;
            this.btnRespond.Text = "ReadRespond";
            this.btnRespond.UseVisualStyleBackColor = true;
            this.btnRespond.Click += new System.EventHandler(this.btnRespond_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(454, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(139, 82);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 393);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnRespond);
            this.Controls.Add(this.cbBaurate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTestAutoClose);
            this.Controls.Add(this.cbDatasend);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnA20T);
            this.Controls.Add(this.btnA21T);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCmd);
            this.Controls.Add(this.btnA10T);
            this.Controls.Add(this.btnA11T);
            this.Controls.Add(this.btnByte);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btn901);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDataReturn);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.TextBox txbDataReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnSend;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ComboBox cbDatasend;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTestAutoClose;
        private System.Windows.Forms.Button btnByte;
        private System.Windows.Forms.Button btnCmd;
        private System.Windows.Forms.Button btnA11T;
        private System.Windows.Forms.Button btnA21T;
        private System.Windows.Forms.Button btnA10T;
        private System.Windows.Forms.Button btnA20T;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn901;
        private System.Windows.Forms.ComboBox cbBaurate;
        private System.Windows.Forms.Button btnRespond;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

