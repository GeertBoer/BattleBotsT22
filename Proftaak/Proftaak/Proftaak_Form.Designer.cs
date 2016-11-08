namespace Proftaak
{
    partial class Proftaak_Form
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
            this.lblTriggerLeft = new System.Windows.Forms.Label();
            this.lblTriggerRight = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tUpdate = new System.Windows.Forms.Timer(this.components);
            this.cbCOMPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblController = new System.Windows.Forms.Label();
            this.lblRP6 = new System.Windows.Forms.Label();
            this.btnConnectToRP6 = new System.Windows.Forms.Button();
            this.lblSpeedString = new System.Windows.Forms.Label();
            this.lblDirectionString = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTriggerLeft
            // 
            this.lblTriggerLeft.AutoSize = true;
            this.lblTriggerLeft.Location = new System.Drawing.Point(12, 95);
            this.lblTriggerLeft.Name = "lblTriggerLeft";
            this.lblTriggerLeft.Size = new System.Drawing.Size(64, 13);
            this.lblTriggerLeft.TabIndex = 0;
            this.lblTriggerLeft.Text = "TriggerLeft: ";
            // 
            // lblTriggerRight
            // 
            this.lblTriggerRight.AutoSize = true;
            this.lblTriggerRight.Location = new System.Drawing.Point(12, 117);
            this.lblTriggerRight.Name = "lblTriggerRight";
            this.lblTriggerRight.Size = new System.Drawing.Size(71, 13);
            this.lblTriggerRight.TabIndex = 1;
            this.lblTriggerRight.Text = "TriggerRight: ";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(12, 140);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(55, 13);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.Text = "Direction: ";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(12, 162);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(44, 13);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "Speed: ";
            // 
            // tUpdate
            // 
            this.tUpdate.Enabled = true;
            this.tUpdate.Interval = 10;
            this.tUpdate.Tick += new System.EventHandler(this.tUpdate_Tick);
            // 
            // cbCOMPorts
            // 
            this.cbCOMPorts.FormattingEnabled = true;
            this.cbCOMPorts.Location = new System.Drawing.Point(12, 24);
            this.cbCOMPorts.Name = "cbCOMPorts";
            this.cbCOMPorts.Size = new System.Drawing.Size(121, 21);
            this.cbCOMPorts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM Port";
            // 
            // lblController
            // 
            this.lblController.AutoSize = true;
            this.lblController.Location = new System.Drawing.Point(12, 48);
            this.lblController.Name = "lblController";
            this.lblController.Size = new System.Drawing.Size(57, 13);
            this.lblController.TabIndex = 6;
            this.lblController.Text = "Controller: ";
            // 
            // lblRP6
            // 
            this.lblRP6.AutoSize = true;
            this.lblRP6.Location = new System.Drawing.Point(12, 72);
            this.lblRP6.Name = "lblRP6";
            this.lblRP6.Size = new System.Drawing.Size(34, 13);
            this.lblRP6.TabIndex = 7;
            this.lblRP6.Text = "RP6: ";
            // 
            // btnConnectToRP6
            // 
            this.btnConnectToRP6.Location = new System.Drawing.Point(139, 22);
            this.btnConnectToRP6.Name = "btnConnectToRP6";
            this.btnConnectToRP6.Size = new System.Drawing.Size(75, 23);
            this.btnConnectToRP6.TabIndex = 8;
            this.btnConnectToRP6.Text = "Connect";
            this.btnConnectToRP6.UseVisualStyleBackColor = true;
            this.btnConnectToRP6.Click += new System.EventHandler(this.btnConnectToRP6_Click);
            // 
            // lblSpeedString
            // 
            this.lblSpeedString.AutoSize = true;
            this.lblSpeedString.Location = new System.Drawing.Point(12, 184);
            this.lblSpeedString.Name = "lblSpeedString";
            this.lblSpeedString.Size = new System.Drawing.Size(71, 13);
            this.lblSpeedString.TabIndex = 10;
            this.lblSpeedString.Text = "SpeedString: ";
            // 
            // lblDirectionString
            // 
            this.lblDirectionString.AutoSize = true;
            this.lblDirectionString.Location = new System.Drawing.Point(12, 203);
            this.lblDirectionString.Name = "lblDirectionString";
            this.lblDirectionString.Size = new System.Drawing.Size(82, 13);
            this.lblDirectionString.TabIndex = 11;
            this.lblDirectionString.Text = "DirectionString: ";
            // 
            // Proftaak_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 225);
            this.Controls.Add(this.lblDirectionString);
            this.Controls.Add(this.lblSpeedString);
            this.Controls.Add(this.btnConnectToRP6);
            this.Controls.Add(this.lblRP6);
            this.Controls.Add(this.lblController);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCOMPorts);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblTriggerRight);
            this.Controls.Add(this.lblTriggerLeft);
            this.Name = "Proftaak_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTriggerLeft;
        private System.Windows.Forms.Label lblTriggerRight;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Timer tUpdate;
        private System.Windows.Forms.ComboBox cbCOMPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblController;
        private System.Windows.Forms.Label lblRP6;
        private System.Windows.Forms.Button btnConnectToRP6;
        private System.Windows.Forms.Label lblSpeedString;
        private System.Windows.Forms.Label lblDirectionString;
    }
}

