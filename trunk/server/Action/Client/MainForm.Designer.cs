﻿namespace Client
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCmdId1 = new System.Windows.Forms.TextBox();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddlParamType2 = new System.Windows.Forms.ComboBox();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParam2 = new System.Windows.Forms.TextBox();
            this.txtCmdId2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ddlParamType3 = new System.Windows.Forms.ComboBox();
            this.btnSend3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCmdId3 = new System.Windows.Forms.TextBox();
            this.iListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(412, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(35, 23);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(204, 21);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(329, 23);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(63, 21);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "1808";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(493, 21);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "CommandId";
            // 
            // txtCmdId1
            // 
            this.txtCmdId1.Location = new System.Drawing.Point(79, 20);
            this.txtCmdId1.Name = "txtCmdId1";
            this.txtCmdId1.Size = new System.Drawing.Size(110, 21);
            this.txtCmdId1.TabIndex = 7;
            // 
            // btnSend1
            // 
            this.btnSend1.Location = new System.Drawing.Point(207, 20);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(75, 23);
            this.btnSend1.TabIndex = 8;
            this.btnSend1.Text = "Send";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCmdId1);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 52);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Only CommandID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ddlParamType2);
            this.groupBox2.Controls.Add(this.btnSend2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtParam2);
            this.groupBox2.Controls.Add(this.txtCmdId2);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 104);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CommandID with one value";
            // 
            // ddlParamType2
            // 
            this.ddlParamType2.DataSource = this.iListBindingSource;
            this.ddlParamType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlParamType2.FormattingEnabled = true;
            this.ddlParamType2.Location = new System.Drawing.Point(79, 47);
            this.ddlParamType2.Name = "ddlParamType2";
            this.ddlParamType2.Size = new System.Drawing.Size(121, 20);
            this.ddlParamType2.TabIndex = 10;
            // 
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(207, 73);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(75, 23);
            this.btnSend2.TabIndex = 8;
            this.btnSend2.Text = "Send";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "ParamValue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "ParamType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "CommandId";
            // 
            // txtParam2
            // 
            this.txtParam2.Location = new System.Drawing.Point(79, 73);
            this.txtParam2.Name = "txtParam2";
            this.txtParam2.Size = new System.Drawing.Size(110, 21);
            this.txtParam2.TabIndex = 7;
            // 
            // txtCmdId2
            // 
            this.txtCmdId2.Location = new System.Drawing.Point(79, 20);
            this.txtCmdId2.Name = "txtCmdId2";
            this.txtCmdId2.Size = new System.Drawing.Size(110, 21);
            this.txtCmdId2.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ddlParamType3);
            this.groupBox3.Controls.Add(this.btnSend3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtCmdId3);
            this.groupBox3.Location = new System.Drawing.Point(12, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 200);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CommandID with Protocol Buffers";
            // 
            // ddlParamType3
            // 
            this.ddlParamType3.DisplayMember = "Key";
            this.ddlParamType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlParamType3.FormattingEnabled = true;
            this.ddlParamType3.Items.AddRange(new object[] {
            ""});
            this.ddlParamType3.Location = new System.Drawing.Point(263, 20);
            this.ddlParamType3.Name = "ddlParamType3";
            this.ddlParamType3.Size = new System.Drawing.Size(304, 20);
            this.ddlParamType3.TabIndex = 10;
            this.ddlParamType3.ValueMember = "Value";
            // 
            // btnSend3
            // 
            this.btnSend3.Location = new System.Drawing.Point(492, 159);
            this.btnSend3.Name = "btnSend3";
            this.btnSend3.Size = new System.Drawing.Size(75, 23);
            this.btnSend3.TabIndex = 8;
            this.btnSend3.Text = "Send";
            this.btnSend3.UseVisualStyleBackColor = true;
            this.btnSend3.Click += new System.EventHandler(this.btnSend3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "ParamType";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "CommandId";
            // 
            // txtCmdId3
            // 
            this.txtCmdId3.Location = new System.Drawing.Point(79, 20);
            this.txtCmdId3.Name = "txtCmdId3";
            this.txtCmdId3.Size = new System.Drawing.Size(110, 21);
            this.txtCmdId3.TabIndex = 7;
            // 
            // iListBindingSource
            // 
            this.iListBindingSource.DataSource = typeof(System.Collections.IList);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 439);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Name = "MainForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCmdId1;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ddlParamType2;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParam2;
        private System.Windows.Forms.TextBox txtCmdId2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ddlParamType3;
        private System.Windows.Forms.Button btnSend3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCmdId3;
        private System.Windows.Forms.BindingSource iListBindingSource;
    }
}

