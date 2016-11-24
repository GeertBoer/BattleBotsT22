namespace T22Hub
{
    partial class MainForm
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
            this.nudGroupNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisconnectHub = new System.Windows.Forms.Button();
            this.btnConnectController = new System.Windows.Forms.Button();
            this.txtComPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOverrideStart = new System.Windows.Forms.Button();
            this.btnDisconnectController = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTimesHitSomeone = new System.Windows.Forms.Label();
            this.lblTimesGotHit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroupNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudGroupNumber
            // 
            this.nudGroupNumber.Location = new System.Drawing.Point(90, 19);
            this.nudGroupNumber.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudGroupNumber.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudGroupNumber.Name = "nudGroupNumber";
            this.nudGroupNumber.Size = new System.Drawing.Size(100, 20);
            this.nudGroupNumber.TabIndex = 0;
            this.nudGroupNumber.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group Number:";
            // 
            // txtIPAdress
            // 
            this.txtIPAdress.Location = new System.Drawing.Point(90, 45);
            this.txtIPAdress.Name = "txtIPAdress";
            this.txtIPAdress.Size = new System.Drawing.Size(100, 20);
            this.txtIPAdress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP adress:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(115, 88);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisconnectHub);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.nudGroupNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIPAdress);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect to central hub";
            // 
            // btnDisconnectHub
            // 
            this.btnDisconnectHub.Location = new System.Drawing.Point(8, 88);
            this.btnDisconnectHub.Name = "btnDisconnectHub";
            this.btnDisconnectHub.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnectHub.TabIndex = 6;
            this.btnDisconnectHub.Text = "Disconnect";
            this.btnDisconnectHub.UseVisualStyleBackColor = true;
            this.btnDisconnectHub.Click += new System.EventHandler(this.btnDisconnectHub_Click);
            // 
            // btnConnectController
            // 
            this.btnConnectController.Location = new System.Drawing.Point(119, 45);
            this.btnConnectController.Name = "btnConnectController";
            this.btnConnectController.Size = new System.Drawing.Size(75, 23);
            this.btnConnectController.TabIndex = 6;
            this.btnConnectController.Text = "Connect";
            this.btnConnectController.UseVisualStyleBackColor = true;
            this.btnConnectController.Click += new System.EventHandler(this.btnConnectController_Click);
            // 
            // txtComPort
            // 
            this.txtComPort.Location = new System.Drawing.Point(106, 19);
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(88, 20);
            this.txtComPort.TabIndex = 7;
            this.txtComPort.Text = "18";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Arduino COM port:";
            // 
            // btnOverrideStart
            // 
            this.btnOverrideStart.Location = new System.Drawing.Point(109, 88);
            this.btnOverrideStart.Name = "btnOverrideStart";
            this.btnOverrideStart.Size = new System.Drawing.Size(85, 23);
            this.btnOverrideStart.TabIndex = 10;
            this.btnOverrideStart.Text = "Override start";
            this.btnOverrideStart.UseVisualStyleBackColor = true;
            this.btnOverrideStart.Click += new System.EventHandler(this.btnOverrideStart_Click);
            // 
            // btnDisconnectController
            // 
            this.btnDisconnectController.Location = new System.Drawing.Point(9, 45);
            this.btnDisconnectController.Name = "btnDisconnectController";
            this.btnDisconnectController.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnectController.TabIndex = 11;
            this.btnDisconnectController.Text = "Disconnect";
            this.btnDisconnectController.UseVisualStyleBackColor = true;
            this.btnDisconnectController.Click += new System.EventHandler(this.btnDisconnectController_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtComPort);
            this.groupBox2.Controls.Add(this.btnOverrideStart);
            this.groupBox2.Controls.Add(this.btnDisconnectController);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnConnectController);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 117);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controller Operations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Times hit someone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Times got hit:";
            // 
            // lblTimesHitSomeone
            // 
            this.lblTimesHitSomeone.AutoSize = true;
            this.lblTimesHitSomeone.Location = new System.Drawing.Point(113, 141);
            this.lblTimesHitSomeone.Name = "lblTimesHitSomeone";
            this.lblTimesHitSomeone.Size = new System.Drawing.Size(13, 13);
            this.lblTimesHitSomeone.TabIndex = 15;
            this.lblTimesHitSomeone.Text = "0";
            // 
            // lblTimesGotHit
            // 
            this.lblTimesGotHit.AutoSize = true;
            this.lblTimesGotHit.Location = new System.Drawing.Point(113, 154);
            this.lblTimesGotHit.Name = "lblTimesGotHit";
            this.lblTimesGotHit.Size = new System.Drawing.Size(13, 13);
            this.lblTimesGotHit.TabIndex = 16;
            this.lblTimesGotHit.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 177);
            this.Controls.Add(this.lblTimesGotHit);
            this.Controls.Add(this.lblTimesHitSomeone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "T22/6 RP6 Hub";
            ((System.ComponentModel.ISupportInitialize)(this.nudGroupNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudGroupNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisconnectHub;
        private System.Windows.Forms.Button btnConnectController;
        private System.Windows.Forms.TextBox txtComPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOverrideStart;
        private System.Windows.Forms.Button btnDisconnectController;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTimesHitSomeone;
        private System.Windows.Forms.Label lblTimesGotHit;
    }
}

