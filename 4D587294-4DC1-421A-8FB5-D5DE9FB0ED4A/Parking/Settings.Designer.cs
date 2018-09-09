namespace Parking
{
    partial class Settings
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
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFourWheelerParkingChargesPerHour = new System.Windows.Forms.TextBox();
            this.txtTwoWheelerParkingChargesPerHour = new System.Windows.Forms.TextBox();
            this.txtLostTicketPenalty = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtParkingPlaceName = new System.Windows.Forms.TextBox();
            this.txtParkingPlaceCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPLCBoardPortNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConnectPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(281, 376);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(147, 41);
            this.btnSaveSettings.TabIndex = 8;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Four Wheeler Parking Charges / Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Two Wheeler Parking Charges / Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lost Ticket Penalty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Company Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Parking Place Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Parking Place Code";
            // 
            // txtFourWheelerParkingChargesPerHour
            // 
            this.txtFourWheelerParkingChargesPerHour.Location = new System.Drawing.Point(282, 202);
            this.txtFourWheelerParkingChargesPerHour.Name = "txtFourWheelerParkingChargesPerHour";
            this.txtFourWheelerParkingChargesPerHour.Size = new System.Drawing.Size(146, 22);
            this.txtFourWheelerParkingChargesPerHour.TabIndex = 21;
            // 
            // txtTwoWheelerParkingChargesPerHour
            // 
            this.txtTwoWheelerParkingChargesPerHour.Location = new System.Drawing.Point(282, 246);
            this.txtTwoWheelerParkingChargesPerHour.Name = "txtTwoWheelerParkingChargesPerHour";
            this.txtTwoWheelerParkingChargesPerHour.Size = new System.Drawing.Size(146, 22);
            this.txtTwoWheelerParkingChargesPerHour.TabIndex = 22;
            // 
            // txtLostTicketPenalty
            // 
            this.txtLostTicketPenalty.Location = new System.Drawing.Point(282, 291);
            this.txtLostTicketPenalty.Name = "txtLostTicketPenalty";
            this.txtLostTicketPenalty.Size = new System.Drawing.Size(146, 22);
            this.txtLostTicketPenalty.TabIndex = 23;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(282, 67);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(146, 22);
            this.txtCompanyName.TabIndex = 24;
            // 
            // txtParkingPlaceName
            // 
            this.txtParkingPlaceName.Location = new System.Drawing.Point(282, 111);
            this.txtParkingPlaceName.Name = "txtParkingPlaceName";
            this.txtParkingPlaceName.Size = new System.Drawing.Size(146, 22);
            this.txtParkingPlaceName.TabIndex = 25;
            // 
            // txtParkingPlaceCode
            // 
            this.txtParkingPlaceCode.Location = new System.Drawing.Point(282, 158);
            this.txtParkingPlaceCode.Name = "txtParkingPlaceCode";
            this.txtParkingPlaceCode.Size = new System.Drawing.Size(146, 22);
            this.txtParkingPlaceCode.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(132, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Settings";
            // 
            // txtPLCBoardPortNumber
            // 
            this.txtPLCBoardPortNumber.Location = new System.Drawing.Point(281, 330);
            this.txtPLCBoardPortNumber.Name = "txtPLCBoardPortNumber";
            this.txtPLCBoardPortNumber.Size = new System.Drawing.Size(146, 22);
            this.txtPLCBoardPortNumber.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "PLC Board Port Number";
            // 
            // btnConnectPort
            // 
            this.btnConnectPort.Location = new System.Drawing.Point(31, 376);
            this.btnConnectPort.Name = "btnConnectPort";
            this.btnConnectPort.Size = new System.Drawing.Size(125, 41);
            this.btnConnectPort.TabIndex = 30;
            this.btnConnectPort.Text = "Test Port";
            this.btnConnectPort.UseVisualStyleBackColor = true;
            this.btnConnectPort.Click += new System.EventHandler(this.btnConnectPort_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 442);
            this.Controls.Add(this.btnConnectPort);
            this.Controls.Add(this.txtPLCBoardPortNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtParkingPlaceCode);
            this.Controls.Add(this.txtParkingPlaceName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtLostTicketPenalty);
            this.Controls.Add(this.txtTwoWheelerParkingChargesPerHour);
            this.Controls.Add(this.txtFourWheelerParkingChargesPerHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveSettings);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFourWheelerParkingChargesPerHour;
        private System.Windows.Forms.TextBox txtTwoWheelerParkingChargesPerHour;
        private System.Windows.Forms.TextBox txtLostTicketPenalty;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtParkingPlaceName;
        private System.Windows.Forms.TextBox txtParkingPlaceCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPLCBoardPortNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConnectPort;
    }
}

