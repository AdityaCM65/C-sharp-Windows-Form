namespace PictureBox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnpreious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PictureBox.Properties.Resources._20220418_144302;
            this.pictureBox1.Location = new System.Drawing.Point(181, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 285);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnpreious
            // 
            this.btnpreious.Location = new System.Drawing.Point(181, 361);
            this.btnpreious.Name = "btnpreious";
            this.btnpreious.Size = new System.Drawing.Size(101, 44);
            this.btnpreious.TabIndex = 1;
            this.btnpreious.Text = "Preivous";
            this.btnpreious.UseVisualStyleBackColor = true;
            this.btnpreious.Click += new System.EventHandler(this.btnpreious_Click_1);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(506, 361);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(101, 44);
            this.btnnext.TabIndex = 2;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnpreious);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "d";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnpreious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.ImageList imageList1;
    }
}

