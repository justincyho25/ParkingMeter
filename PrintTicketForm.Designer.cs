namespace ParkMeter
{
    partial class PrintTicketForm
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
            this.printTicket = new System.Windows.Forms.Button();
            this.printProgress = new System.Windows.Forms.ProgressBar();
            this.PrintTicketCheck = new System.Windows.Forms.CheckBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment has been processed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printTicket
            // 
            this.printTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTicket.Location = new System.Drawing.Point(209, 176);
            this.printTicket.Name = "printTicket";
            this.printTicket.Size = new System.Drawing.Size(236, 54);
            this.printTicket.TabIndex = 1;
            this.printTicket.Text = "Print Ticket";
            this.printTicket.UseVisualStyleBackColor = true;
            this.printTicket.Click += new System.EventHandler(this.printTicket_Click);
            // 
            // printProgress
            // 
            this.printProgress.Location = new System.Drawing.Point(209, 176);
            this.printProgress.Name = "printProgress";
            this.printProgress.Size = new System.Drawing.Size(236, 54);
            this.printProgress.TabIndex = 2;
            // 
            // PrintTicketCheck
            // 
            this.PrintTicketCheck.AutoSize = true;
            this.PrintTicketCheck.Location = new System.Drawing.Point(154, 310);
            this.PrintTicketCheck.Name = "PrintTicketCheck";
            this.PrintTicketCheck.Size = new System.Drawing.Size(318, 17);
            this.PrintTicketCheck.TabIndex = 3;
            this.PrintTicketCheck.Text = "I wish to receive a text message ten minutes before expiration ";
            this.PrintTicketCheck.UseVisualStyleBackColor = true;
            this.PrintTicketCheck.CheckedChanged += new System.EventHandler(this.PrintTicketCheck_CheckedChanged);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PhoneNumber.Location = new System.Drawing.Point(197, 352);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(236, 20);
            this.PhoneNumber.TabIndex = 4;
            this.PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumber_KeyPress);
            // 
            // PrintTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 479);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.PrintTicketCheck);
            this.Controls.Add(this.printProgress);
            this.Controls.Add(this.printTicket);
            this.Controls.Add(this.label1);
            this.Name = "PrintTicketForm";
            this.Text = "PrintTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printTicket;
        private System.Windows.Forms.ProgressBar printProgress;
        private System.Windows.Forms.CheckBox PrintTicketCheck;
        private System.Windows.Forms.TextBox PhoneNumber;
    }
}