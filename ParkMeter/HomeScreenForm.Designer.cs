namespace ParkMeter
{
    partial class HomeScreenForm
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
            this.purchaseTicket = new System.Windows.Forms.Button();
            this.returnTicket = new System.Windows.Forms.Button();
            this.administrator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // purchaseTicket
            // 
            this.purchaseTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseTicket.Location = new System.Drawing.Point(164, 193);
            this.purchaseTicket.Name = "purchaseTicket";
            this.purchaseTicket.Size = new System.Drawing.Size(340, 78);
            this.purchaseTicket.TabIndex = 0;
            this.purchaseTicket.Text = "Purchase New Ticket";
            this.purchaseTicket.UseVisualStyleBackColor = true;
            this.purchaseTicket.Click += new System.EventHandler(this.purchaseTicket_Click);
            // 
            // returnTicket
            // 
            this.returnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTicket.Location = new System.Drawing.Point(164, 293);
            this.returnTicket.Name = "returnTicket";
            this.returnTicket.Size = new System.Drawing.Size(340, 78);
            this.returnTicket.TabIndex = 1;
            this.returnTicket.Text = "Return Ticket";
            this.returnTicket.UseVisualStyleBackColor = true;
            this.returnTicket.Click += new System.EventHandler(this.returnTicket_Click);
            // 
            // administrator
            // 
            this.administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrator.Location = new System.Drawing.Point(164, 388);
            this.administrator.Name = "administrator";
            this.administrator.Size = new System.Drawing.Size(340, 79);
            this.administrator.TabIndex = 2;
            this.administrator.Text = "Administrator";
            this.administrator.UseVisualStyleBackColor = true;
            this.administrator.Click += new System.EventHandler(this.administrator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "JWMS PARKING METER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rate:";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(293, 104);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(136, 31);
            this.rateLabel.TabIndex = 5;
            this.rateLabel.Text = "rateLabel";
            // 
            // HomeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 479);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.administrator);
            this.Controls.Add(this.returnTicket);
            this.Controls.Add(this.purchaseTicket);
            this.Name = "HomeScreenForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button purchaseTicket;
        private System.Windows.Forms.Button returnTicket;
        private System.Windows.Forms.Button administrator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rateLabel;
    }
}

