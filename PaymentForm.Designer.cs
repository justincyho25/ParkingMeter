namespace ParkMeter
{
    partial class PaymentForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.debitPayment = new System.Windows.Forms.Button();
            this.creditPayment = new System.Windows.Forms.Button();
            this.coinPayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amountOwing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // debitPayment
            // 
            this.debitPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitPayment.Location = new System.Drawing.Point(204, 218);
            this.debitPayment.Name = "debitPayment";
            this.debitPayment.Size = new System.Drawing.Size(233, 70);
            this.debitPayment.TabIndex = 1;
            this.debitPayment.Text = "Debit Card";
            this.debitPayment.UseVisualStyleBackColor = true;
            this.debitPayment.Click += new System.EventHandler(this.debitPayment_Click);
            // 
            // creditPayment
            // 
            this.creditPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditPayment.Location = new System.Drawing.Point(204, 306);
            this.creditPayment.Name = "creditPayment";
            this.creditPayment.Size = new System.Drawing.Size(233, 70);
            this.creditPayment.TabIndex = 2;
            this.creditPayment.Text = "Credit Card";
            this.creditPayment.UseVisualStyleBackColor = true;
            this.creditPayment.Click += new System.EventHandler(this.creditPayment_Click);
            // 
            // coinPayment
            // 
            this.coinPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinPayment.Location = new System.Drawing.Point(204, 397);
            this.coinPayment.Name = "coinPayment";
            this.coinPayment.Size = new System.Drawing.Size(233, 70);
            this.coinPayment.TabIndex = 3;
            this.coinPayment.Text = "Coins";
            this.coinPayment.UseVisualStyleBackColor = true;
            this.coinPayment.Click += new System.EventHandler(this.coinPayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select your preferred method of payment:";
            // 
            // amountOwing
            // 
            this.amountOwing.AutoSize = true;
            this.amountOwing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOwing.Location = new System.Drawing.Point(220, 106);
            this.amountOwing.Name = "amountOwing";
            this.amountOwing.Size = new System.Drawing.Size(92, 31);
            this.amountOwing.TabIndex = 5;
            this.amountOwing.Text = "label2";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 479);
            this.Controls.Add(this.amountOwing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coinPayment);
            this.Controls.Add(this.creditPayment);
            this.Controls.Add(this.debitPayment);
            this.Controls.Add(this.backButton);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button debitPayment;
        private System.Windows.Forms.Button creditPayment;
        private System.Windows.Forms.Button coinPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amountOwing;
    }
}