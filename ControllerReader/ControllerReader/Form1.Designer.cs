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
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnSendTrigger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(12, 12);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPort.TabIndex = 0;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnSendTrigger
            // 
            this.btnSendTrigger.Location = new System.Drawing.Point(12, 41);
            this.btnSendTrigger.Name = "btnSendTrigger";
            this.btnSendTrigger.Size = new System.Drawing.Size(75, 23);
            this.btnSendTrigger.TabIndex = 1;
            this.btnSendTrigger.Text = "SendTrigger";
            this.btnSendTrigger.UseVisualStyleBackColor = true;
            this.btnSendTrigger.Click += new System.EventHandler(this.btnSendTrigger_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arduino returns:";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(180, 17);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(35, 13);
            this.lblReturn.TabIndex = 3;
            this.lblReturn.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendTrigger);
            this.Controls.Add(this.btnOpenPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnSendTrigger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReturn;
    }
}

