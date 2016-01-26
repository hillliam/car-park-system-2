namespace car_park_prototype
{
    partial class Power_Outtage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cam1 = new System.Windows.Forms.Button();
            this.Cam2 = new System.Windows.Forms.Button();
            this.Cam3 = new System.Windows.Forms.Button();
            this.Cam4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 24);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "open exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "close exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter the exit number you would like to control manually";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(688, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "emergency resolved";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Cam1
            // 
            this.Cam1.Location = new System.Drawing.Point(365, 238);
            this.Cam1.Name = "Cam1";
            this.Cam1.Size = new System.Drawing.Size(87, 35);
            this.Cam1.TabIndex = 6;
            this.Cam1.Text = "Cam1";
            this.Cam1.UseVisualStyleBackColor = true;
            this.Cam1.Click += new System.EventHandler(this.Cam1_Click);
            // 
            // Cam2
            // 
            this.Cam2.Location = new System.Drawing.Point(365, 300);
            this.Cam2.Name = "Cam2";
            this.Cam2.Size = new System.Drawing.Size(87, 29);
            this.Cam2.TabIndex = 7;
            this.Cam2.Text = "Cam2";
            this.Cam2.UseVisualStyleBackColor = true;
            this.Cam2.Click += new System.EventHandler(this.Cam2_Click);
            // 
            // Cam3
            // 
            this.Cam3.Location = new System.Drawing.Point(365, 356);
            this.Cam3.Name = "Cam3";
            this.Cam3.Size = new System.Drawing.Size(87, 35);
            this.Cam3.TabIndex = 8;
            this.Cam3.Text = "Cam3";
            this.Cam3.UseVisualStyleBackColor = true;
            this.Cam3.Click += new System.EventHandler(this.Cam3_Click);
            // 
            // Cam4
            // 
            this.Cam4.Location = new System.Drawing.Point(365, 420);
            this.Cam4.Name = "Cam4";
            this.Cam4.Size = new System.Drawing.Size(87, 38);
            this.Cam4.TabIndex = 9;
            this.Cam4.Text = "Cam4";
            this.Cam4.UseVisualStyleBackColor = true;
            this.Cam4.Click += new System.EventHandler(this.Cam4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "CCTV Camera feed";
            // 
            // Power_Outtage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cam4);
            this.Controls.Add(this.Cam3);
            this.Controls.Add(this.Cam2);
            this.Controls.Add(this.Cam1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Power_Outtage";
            this.Text = "Power_Outtage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Cam1;
        private System.Windows.Forms.Button Cam2;
        private System.Windows.Forms.Button Cam3;
        private System.Windows.Forms.Button Cam4;
        private System.Windows.Forms.Label label2;
    }
}