namespace ControllerReader
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.btnStartSending = new System.Windows.Forms.Button();
            this.btnStopSending = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(118, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(12, 12);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(100, 20);
            this.txtCom.TabIndex = 2;
            this.txtCom.Text = "18";
            // 
            // btnStartSending
            // 
            this.btnStartSending.Location = new System.Drawing.Point(12, 38);
            this.btnStartSending.Name = "btnStartSending";
            this.btnStartSending.Size = new System.Drawing.Size(87, 23);
            this.btnStartSending.TabIndex = 3;
            this.btnStartSending.Text = "Start sending";
            this.btnStartSending.UseVisualStyleBackColor = true;
            this.btnStartSending.Click += new System.EventHandler(this.btnStartSending_Click);
            // 
            // btnStopSending
            // 
            this.btnStopSending.Location = new System.Drawing.Point(106, 38);
            this.btnStopSending.Name = "btnStopSending";
            this.btnStopSending.Size = new System.Drawing.Size(87, 23);
            this.btnStopSending.TabIndex = 4;
            this.btnStopSending.Text = "Stop sending";
            this.btnStopSending.UseVisualStyleBackColor = true;
            this.btnStopSending.Click += new System.EventHandler(this.btnStopSending_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(199, 10);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnStopSending);
            this.Controls.Add(this.btnStartSending);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Button btnStartSending;
        private System.Windows.Forms.Button btnStopSending;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button button1;
    }
}

