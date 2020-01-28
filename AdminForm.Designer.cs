namespace ParkMeter
{
    partial class AdminForm
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
            this.dollarScrollBar = new System.Windows.Forms.VScrollBar();
            this.centsScrollBar = new System.Windows.Forms.VScrollBar();
            this.newDollarsLabel = new System.Windows.Forms.Label();
            this.newCentsLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dollarScrollBar
            // 
            this.dollarScrollBar.LargeChange = 1;
            this.dollarScrollBar.Location = new System.Drawing.Point(180, 200);
            this.dollarScrollBar.Maximum = 25;
            this.dollarScrollBar.Name = "dollarScrollBar";
            this.dollarScrollBar.Size = new System.Drawing.Size(74, 186);
            this.dollarScrollBar.TabIndex = 0;
            this.dollarScrollBar.Value = 25;
            this.dollarScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dollarScrollBar_Scroll);
            // 
            // centsScrollBar
            // 
            this.centsScrollBar.LargeChange = 1;
            this.centsScrollBar.Location = new System.Drawing.Point(387, 200);
            this.centsScrollBar.Maximum = 99;
            this.centsScrollBar.Name = "centsScrollBar";
            this.centsScrollBar.Size = new System.Drawing.Size(74, 186);
            this.centsScrollBar.TabIndex = 1;
            this.centsScrollBar.Value = 99;
            this.centsScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.centsScrollBar_Scroll);
            // 
            // newDollarsLabel
            // 
            this.newDollarsLabel.AutoSize = true;
            this.newDollarsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDollarsLabel.Location = new System.Drawing.Point(257, 260);
            this.newDollarsLabel.Name = "newDollarsLabel";
            this.newDollarsLabel.Size = new System.Drawing.Size(70, 31);
            this.newDollarsLabel.TabIndex = 2;
            this.newDollarsLabel.Text = "$ 00";
            // 
            // newCentsLabel
            // 
            this.newCentsLabel.AutoSize = true;
            this.newCentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCentsLabel.Location = new System.Drawing.Point(321, 260);
            this.newCentsLabel.Name = "newCentsLabel";
            this.newCentsLabel.Size = new System.Drawing.Size(63, 31);
            this.newCentsLabel.TabIndex = 3;
            this.newCentsLabel.Text = ". 00";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(227, 408);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(176, 59);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Set New Parking Rate";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.newCentsLabel);
            this.Controls.Add(this.newDollarsLabel);
            this.Controls.Add(this.centsScrollBar);
            this.Controls.Add(this.dollarScrollBar);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar dollarScrollBar;
        private System.Windows.Forms.VScrollBar centsScrollBar;
        private System.Windows.Forms.Label newDollarsLabel;
        private System.Windows.Forms.Label newCentsLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label1;
    }
}