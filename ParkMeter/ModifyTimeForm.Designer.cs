namespace ParkMeter
{
    partial class ModifyTimeForm
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
            this.hoursScrollBar = new System.Windows.Forms.VScrollBar();
            this.minutesScrollBar = new System.Windows.Forms.VScrollBar();
            this.backButton = new System.Windows.Forms.Button();
            this.newHoursLabel = new System.Windows.Forms.Label();
            this.newMinLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursScrollBar
            // 
            this.hoursScrollBar.LargeChange = 1;
            this.hoursScrollBar.Location = new System.Drawing.Point(141, 118);
            this.hoursScrollBar.Maximum = 24;
            this.hoursScrollBar.Name = "hoursScrollBar";
            this.hoursScrollBar.Size = new System.Drawing.Size(63, 200);
            this.hoursScrollBar.TabIndex = 0;
            this.hoursScrollBar.Value = 24;
            this.hoursScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hoursScrollBar_Scroll);
            // 
            // minutesScrollBar
            // 
            this.minutesScrollBar.LargeChange = 1;
            this.minutesScrollBar.Location = new System.Drawing.Point(435, 118);
            this.minutesScrollBar.Maximum = 59;
            this.minutesScrollBar.Name = "minutesScrollBar";
            this.minutesScrollBar.Size = new System.Drawing.Size(63, 200);
            this.minutesScrollBar.TabIndex = 1;
            this.minutesScrollBar.Value = 59;
            this.minutesScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.minutesScrollBar_Scroll);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newHoursLabel
            // 
            this.newHoursLabel.AutoSize = true;
            this.newHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newHoursLabel.Location = new System.Drawing.Point(124, 334);
            this.newHoursLabel.Name = "newHoursLabel";
            this.newHoursLabel.Size = new System.Drawing.Size(92, 31);
            this.newHoursLabel.TabIndex = 3;
            this.newHoursLabel.Text = "label1";
            // 
            // newMinLabel
            // 
            this.newMinLabel.AutoSize = true;
            this.newMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMinLabel.Location = new System.Drawing.Point(419, 334);
            this.newMinLabel.Name = "newMinLabel";
            this.newMinLabel.Size = new System.Drawing.Size(92, 31);
            this.newMinLabel.TabIndex = 4;
            this.newMinLabel.Text = "label2";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(222, 414);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(194, 53);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "How many hours would you like to purchase?";
            // 
            // ModifyTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.newMinLabel);
            this.Controls.Add(this.newHoursLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.minutesScrollBar);
            this.Controls.Add(this.hoursScrollBar);
            this.Name = "ModifyTimeForm";
            this.Text = "ModifyTimeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar hoursScrollBar;
        private System.Windows.Forms.VScrollBar minutesScrollBar;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label newHoursLabel;
        private System.Windows.Forms.Label newMinLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label1;
    }
}