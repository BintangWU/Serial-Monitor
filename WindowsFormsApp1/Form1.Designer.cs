namespace SerialMonitor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_comPort = new System.Windows.Forms.ComboBox();
            this.tb_baud = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_scan = new System.Windows.Forms.Button();
            this.tb_debug = new System.Windows.Forms.TextBox();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud:";
            // 
            // cbo_comPort
            // 
            this.cbo_comPort.FormattingEnabled = true;
            this.cbo_comPort.Location = new System.Drawing.Point(53, 10);
            this.cbo_comPort.Name = "cbo_comPort";
            this.cbo_comPort.Size = new System.Drawing.Size(100, 21);
            this.cbo_comPort.TabIndex = 2;
            // 
            // tb_baud
            // 
            this.tb_baud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_baud.Location = new System.Drawing.Point(202, 11);
            this.tb_baud.Name = "tb_baud";
            this.tb_baud.Size = new System.Drawing.Size(100, 20);
            this.tb_baud.TabIndex = 3;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(375, 10);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(64, 23);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "OPEN";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(308, 10);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(61, 23);
            this.btn_scan.TabIndex = 5;
            this.btn_scan.Text = "SCAN";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // tb_debug
            // 
            this.tb_debug.BackColor = System.Drawing.Color.White;
            this.tb_debug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_debug.Location = new System.Drawing.Point(16, 37);
            this.tb_debug.Multiline = true;
            this.tb_debug.Name = "tb_debug";
            this.tb_debug.ReadOnly = true;
            this.tb_debug.Size = new System.Drawing.Size(423, 269);
            this.tb_debug.TabIndex = 6;
            // 
            // tb_message
            // 
            this.tb_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_message.Location = new System.Drawing.Point(16, 340);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(353, 20);
            this.tb_message.TabIndex = 7;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(378, 340);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(61, 23);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(16, 312);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(423, 23);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "CLEAR DEBUGING";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 377);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.tb_debug);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.tb_baud);
            this.Controls.Add(this.cbo_comPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Serial Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_comPort;
        private System.Windows.Forms.TextBox tb_baud;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.TextBox tb_debug;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_clear;
    }
}

