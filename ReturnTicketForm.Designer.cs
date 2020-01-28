namespace ParkMeter
{
    partial class ReturnTicketForm
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
            this.refundAmountLabel = new System.Windows.Forms.Label();
            this.refundProgress = new System.Windows.Forms.ProgressBar();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Refund:";
            // 
            // refundAmountLabel
            // 
            this.refundAmountLabel.AutoSize = true;
            this.refundAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundAmountLabel.Location = new System.Drawing.Point(324, 194);
            this.refundAmountLabel.Name = "refundAmountLabel";
            this.refundAmountLabel.Size = new System.Drawing.Size(85, 29);
            this.refundAmountLabel.TabIndex = 1;
            this.refundAmountLabel.Text = "label2";
            // 
            // refundProgress
            // 
            this.refundProgress.Location = new System.Drawing.Point(193, 250);
            this.refundProgress.Name = "refundProgress";
            this.refundProgress.Size = new System.Drawing.Size(236, 54);
            this.refundProgress.TabIndex = 3;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(193, 250);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(236, 54);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please confirm to process refund";
            // 
            // ticketNumberLabel
            // 
            this.ticketNumberLabel.AutoSize = true;
            this.ticketNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketNumberLabel.Location = new System.Drawing.Point(378, 9);
            this.ticketNumberLabel.Name = "ticketNumberLabel";
            this.ticketNumberLabel.Size = new System.Drawing.Size(85, 29);
            this.ticketNumberLabel.TabIndex = 6;
            this.ticketNumberLabel.Text = "label3";
            // 
            // ReturnTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 479);
            this.Controls.Add(this.ticketNumberLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.refundProgress);
            this.Controls.Add(this.refundAmountLabel);
            this.Controls.Add(this.label1);
            this.Name = "ReturnTicketForm";
            this.Text = "ReturnTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label refundAmountLabel;
        private System.Windows.Forms.ProgressBar refundProgress;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ticketNumberLabel;
    }
}