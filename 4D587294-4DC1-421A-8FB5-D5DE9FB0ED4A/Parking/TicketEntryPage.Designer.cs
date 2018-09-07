namespace Parking
{
    partial class TicketEntryPage
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
            this.tbxVehicleNumber = new System.Windows.Forms.TextBox();
            this.labelVehicleEntry = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxVehicleNumber
            // 
            this.tbxVehicleNumber.Location = new System.Drawing.Point(393, 72);
            this.tbxVehicleNumber.Name = "tbxVehicleNumber";
            this.tbxVehicleNumber.Size = new System.Drawing.Size(112, 22);
            this.tbxVehicleNumber.TabIndex = 0;
            this.tbxVehicleNumber.TextChanged += new System.EventHandler(this.tbxVehicleNumber_TextChanged);
            // 
            // labelVehicleEntry
            // 
            this.labelVehicleEntry.AutoSize = true;
            this.labelVehicleEntry.Location = new System.Drawing.Point(207, 76);
            this.labelVehicleEntry.Name = "labelVehicleEntry";
            this.labelVehicleEntry.Size = new System.Drawing.Size(146, 17);
            this.labelVehicleEntry.TabIndex = 1;
            this.labelVehicleEntry.Text = "Enter Vehicle Number";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(565, 72);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // TicketEntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.labelVehicleEntry);
            this.Controls.Add(this.tbxVehicleNumber);
            this.Name = "TicketEntryPage";
            this.Text = "TicketEntryPage";
            this.Load += new System.EventHandler(this.TicketEntryPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxVehicleNumber;
        private System.Windows.Forms.Label labelVehicleEntry;
        private System.Windows.Forms.Button btnPrint;
    }
}