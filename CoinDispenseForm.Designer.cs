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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Processed and Dispensing Change";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(227, 197);
            this.changeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(101, 36);
            this.changeLabel.TabIndex = 1;
            this.changeLabel.Text = "label2";
            // 
            // printProgress
            // 
            this.printProgress.Location = new System.Drawing.Point(272, 283);
            this.printProgress.Margin = new System.Windows.Forms.Padding(4);
            this.printProgress.Name = "printProgress";
            this.printProgress.Size = new System.Drawing.Size(315, 66);
            this.printProgress.TabIndex = 3;
            // 
            // printTicketButton
            // 
            this.printTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTicketButton.Location = new System.Drawing.Point(272, 283);
            this.printTicketButton.Margin = new System.Windows.Forms.Padding(4);
            this.printTicketButton.Name = "printTicketButton";
            this.printTicketButton.Size = new System.Drawing.Size(315, 66);
            this.printTicketButton.TabIndex = 4;
            this.printTicketButton.Text = "Print Ticket";
            this.printTicketButton.UseVisualStyleBackColor = true;
            this.printTicketButton.Click += new System.EventHandler(this.printTicketButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(233, 417);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(420, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "I wish to receive a text message ten minutes before expiration ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PhoneNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.PhoneNumber.Location = new System.Drawing.Point(293, 464);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Size = new System.Drawing.Size(300, 22);
            this.PhoneNumber.TabIndex = 6;
            this.PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumber_KeyPress);
            // 
            // CoinDispenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 590);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.printTicketButton);
            this.Controls.Add(this.printProgress);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox PhoneNumber;
    }
}