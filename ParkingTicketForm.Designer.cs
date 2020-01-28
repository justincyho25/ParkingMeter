namespace ParkMeter
{
    partial class ParkingTicketForm
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
            this.ticketNumber = new System.Windows.Forms.Label();
            this.issueDate = new System.Windows.Forms.Label();
            this.expiryDate = new System.Windows.Forms.Label();
            this.amountPaid = new System.Windows.Forms.Label();
            this.TextSend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "JWMS PARKING TICKET";
            // 
            // ticketNumber
            // 
            this.ticketNumber.AutoSize = true;
            this.ticketNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketNumber.Location = new System.Drawing.Point(93, 150);
            this.ticketNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ticketNumber.Name = "ticketNumber";
            this.ticketNumber.Size = new System.Drawing.Size(101, 36);
            this.ticketNumber.TabIndex = 1;
            this.ticketNumber.Text = "label2";
            // 
            // issueDate
            // 
            this.issueDate.AutoSize = true;
            this.issueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDate.Location = new System.Drawing.Point(93, 245);
            this.issueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.issueDate.Name = "issueDate";
            this.issueDate.Size = new System.Drawing.Size(101, 36);
            this.issueDate.TabIndex = 2;
            this.issueDate.Text = "label3";
            // 
            // expiryDate
            // 
            this.expiryDate.AutoSize = true;
            this.expiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDate.Location = new System.Drawing.Point(93, 352);
            this.expiryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.Size = new System.Drawing.Size(101, 36);
            this.expiryDate.TabIndex = 3;
            this.expiryDate.Text = "label4";
            // 
            // amountPaid
            // 
            this.amountPaid.AutoSize = true;
            this.amountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaid.Location = new System.Drawing.Point(93, 453);
            this.amountPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountPaid.Name = "amountPaid";
            this.amountPaid.Size = new System.Drawing.Size(101, 36);
            this.amountPaid.TabIndex = 4;
            this.amountPaid.Text = "label2";
            // 
            // TextSend
            // 
            this.TextSend.AutoSize = true;
            this.TextSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.TextSend.Location = new System.Drawing.Point(93, 538);
            this.TextSend.Name = "TextSend";
            this.TextSend.Size = new System.Drawing.Size(101, 36);
            this.TextSend.TabIndex = 5;
            this.TextSend.Text = "label2";
            // 
            // ParkingTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 672);
            this.Controls.Add(this.TextSend);
            this.Controls.Add(this.amountPaid);
            this.Controls.Add(this.expiryDate);
            this.Controls.Add(this.issueDate);
            this.Controls.Add(this.ticketNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParkingTicketForm";
            this.Text = "ParkingTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ticketNumber;
        private System.Windows.Forms.Label issueDate;
        private System.Windows.Forms.Label expiryDate;
        private System.Windows.Forms.Label amountPaid;
        private System.Windows.Forms.Label TextSend;
    }
}