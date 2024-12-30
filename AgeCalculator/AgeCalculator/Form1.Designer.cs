namespace AgeCalculator
{
    partial class Form1
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
            this.lblheading = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblmonth = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.dtimepicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblheading.Location = new System.Drawing.Point(234, 32);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(184, 29);
            this.lblheading.TabIndex = 0;
            this.lblheading.Text = "Age Calculator";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(153, 123);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(118, 20);
            this.lbldate.TabIndex = 1;
            this.lbldate.Text = "Select DOB : ";
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Location = new System.Drawing.Point(453, 226);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(45, 20);
            this.lbldays.TabIndex = 2;
            this.lbldays.Text = "Days";
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Location = new System.Drawing.Point(311, 226);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(54, 20);
            this.lblmonth.TabIndex = 3;
            this.lblmonth.Text = "Month";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Location = new System.Drawing.Point(153, 226);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(43, 20);
            this.lblyear.TabIndex = 4;
            this.lblyear.Text = "Year";
            // 
            // txtyear
            // 
            this.txtyear.Enabled = false;
            this.txtyear.Location = new System.Drawing.Point(130, 260);
            this.txtyear.Name = "txtyear";
            this.txtyear.ReadOnly = true;
            this.txtyear.Size = new System.Drawing.Size(100, 26);
            this.txtyear.TabIndex = 5;
            // 
            // txtmonth
            // 
            this.txtmonth.Enabled = false;
            this.txtmonth.Location = new System.Drawing.Point(286, 260);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.ReadOnly = true;
            this.txtmonth.Size = new System.Drawing.Size(100, 26);
            this.txtmonth.TabIndex = 6;
            // 
            // txtdays
            // 
            this.txtdays.Enabled = false;
            this.txtdays.Location = new System.Drawing.Point(432, 260);
            this.txtdays.Name = "txtdays";
            this.txtdays.ReadOnly = true;
            this.txtdays.Size = new System.Drawing.Size(100, 26);
            this.txtdays.TabIndex = 7;
            // 
            // dtimepicker
            // 
            this.dtimepicker.Location = new System.Drawing.Point(286, 118);
            this.dtimepicker.Name = "dtimepicker";
            this.dtimepicker.Size = new System.Drawing.Size(200, 26);
            this.dtimepicker.TabIndex = 8;
            this.dtimepicker.ValueChanged += new System.EventHandler(this.dtimepicker_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(674, 420);
            this.Controls.Add(this.dtimepicker);
            this.Controls.Add(this.txtdays);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblmonth);
            this.Controls.Add(this.lbldays);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblheading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.DateTimePicker dtimepicker;
    }
}

