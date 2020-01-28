namespace ParkMeter
{
    partial class CoinDispenseForm
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
            this.changeLabel = new System.Windows.Forms.Label();
            this.printProgress = new System.Windows.Forms.ProgressBar();
            this.printTicketButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Processed and Dispensing Change";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(170, 160);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(85, 29);
            this.changeLabel.TabIndex = 1;
            this.changeLabel.Text = "label2";
            // 
            // printProgress
            // 
            this.printProgress.Location = new System.Drawing.Point(204, 230);
            this.printProgress.Name = "printProgress";
            this.printProgress.Size = new System.Drawing.Size(236, 54);
            this.printProgress.TabIndex = 3;
            // 
            // printTicketButton
            // 
            this.printTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTicketButton.Location = new System.Drawing.Point(204, 230);
            this.printTicketButton.Name = "printTicketButton";
            this.printTicketButton.Size = new System.Drawing.Size(236, 54);
            this.printTicketButton.TabIndex = 4;
            this.printTicketButton.Text = "Print Ticket";
            this.printTicketButton.UseVisualStyleBackColor = true;
            this.printTicketButton.Click += new System.EventHandler(this.printTicketButton_Click);
            // 
            // CoinDispenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 479);
            this.Controls.Add(this.printTicketButton);
            this.Controls.Add(this.printProgress);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.label1);
            this.Name = "CoinDispenseForm";
            this.Text = "CoinDispenseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.ProgressBar printProgress;
        private System.Windows.Forms.Button printTicketButton;
    }
}