namespace LiveStockFarm_Project
{
    partial class Report10
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
            this.label6 = new System.Windows.Forms.Label();
            this.taxperday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalincome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalmilk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yeartax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Total Tax (per day)  : ";
            // 
            // taxperday
            // 
            this.taxperday.Location = new System.Drawing.Point(252, 233);
            this.taxperday.Name = "taxperday";
            this.taxperday.ReadOnly = true;
            this.taxperday.Size = new System.Drawing.Size(118, 20);
            this.taxperday.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Total Income (per day)  : ";
            // 
            // totalincome
            // 
            this.totalincome.Location = new System.Drawing.Point(252, 188);
            this.totalincome.Name = "totalincome";
            this.totalincome.ReadOnly = true;
            this.totalincome.Size = new System.Drawing.Size(118, 20);
            this.totalincome.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Total Milk (per day)  : ";
            // 
            // totalmilk
            // 
            this.totalmilk.Location = new System.Drawing.Point(252, 139);
            this.totalmilk.Name = "totalmilk";
            this.totalmilk.ReadOnly = true;
            this.totalmilk.Size = new System.Drawing.Size(118, 20);
            this.totalmilk.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 42);
            this.label1.TabIndex = 66;
            this.label1.Text = "Total Tax for Jersy Cows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Total Tax (per year)  : ";
            // 
            // yeartax
            // 
            this.yeartax.Location = new System.Drawing.Point(252, 291);
            this.yeartax.Name = "yeartax";
            this.yeartax.ReadOnly = true;
            this.yeartax.Size = new System.Drawing.Size(118, 20);
            this.yeartax.TabIndex = 74;
            // 
            // Report10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yeartax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.taxperday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalincome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalmilk);
            this.Controls.Add(this.label1);
            this.Name = "Report10";
            this.Text = "Report10";
            this.Load += new System.EventHandler(this.Report10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalincome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalmilk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yeartax;
        private System.Windows.Forms.TextBox taxperday;
    }
}