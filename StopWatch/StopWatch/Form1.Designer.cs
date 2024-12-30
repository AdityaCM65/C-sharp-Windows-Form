namespace StopWatch
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblheading = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.Location = new System.Drawing.Point(147, 52);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(145, 29);
            this.lblheading.TabIndex = 0;
            this.lblheading.Text = "Stop Watch";
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnstart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnstart.Location = new System.Drawing.Point(70, 247);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(113, 46);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnstop.ForeColor = System.Drawing.SystemColors.Control;
            this.btnstop.Location = new System.Drawing.Point(258, 247);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(113, 46);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(213, 159);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(18, 20);
            this.lblres.TabIndex = 3;
            this.lblres.Text = "0";
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Chartreuse;
            this.btnreset.Location = new System.Drawing.Point(170, 326);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(113, 40);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(443, 408);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblheading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button btnreset;
    }
}

