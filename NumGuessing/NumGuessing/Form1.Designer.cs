namespace NumGuessing
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
            this.lblres = new System.Windows.Forms.Label();
            this.lblheading = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnguess = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblhead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(150, 269);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(55, 20);
            this.lblres.TabIndex = 0;
            this.lblres.Text = "Result";
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.Location = new System.Drawing.Point(55, 25);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(247, 25);
            this.lblheading.TabIndex = 1;
            this.lblheading.Text = "Number Guessing Game";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(104, 97);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(154, 26);
            this.txtnum.TabIndex = 2;
            this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnguess
            // 
            this.btnguess.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnguess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnguess.Location = new System.Drawing.Point(124, 189);
            this.btnguess.Name = "btnguess";
            this.btnguess.Size = new System.Drawing.Size(107, 47);
            this.btnguess.TabIndex = 3;
            this.btnguess.Text = "Guess";
            this.btnguess.UseVisualStyleBackColor = false;
            this.btnguess.Click += new System.EventHandler(this.btnguess_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(82, 145);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(204, 20);
            this.lbltime.TabIndex = 4;
            this.lbltime.Text = "Enter Number , Click Guess";
            // 
            // lblhead
            // 
            this.lblhead.AutoSize = true;
            this.lblhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.Location = new System.Drawing.Point(150, 62);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(67, 20);
            this.lblhead.TabIndex = 5;
            this.lblhead.Text = "(1 - 10)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(369, 335);
            this.Controls.Add(this.lblhead);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnguess);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblheading);
            this.Controls.Add(this.lblres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnguess;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblhead;
    }
}

