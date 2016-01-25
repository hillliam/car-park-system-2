namespace car_park_prototype
{
    partial class Fire_emergency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fire_emergency));
            this.increment = new System.Windows.Forms.Button();
            this.Decrement = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Sprinkler = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // increment
            // 
            this.increment.BackColor = System.Drawing.SystemColors.Info;
            this.increment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.increment.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increment.Image = ((System.Drawing.Image)(resources.GetObject("increment.Image")));
            this.increment.Location = new System.Drawing.Point(425, 345);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(120, 112);
            this.increment.TabIndex = 0;
            this.increment.Text = "Increment";
            this.increment.UseVisualStyleBackColor = false;
            this.increment.Click += new System.EventHandler(this.increment_Click);
            // 
            // Decrement
            // 
            this.Decrement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrement.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrement.Image = ((System.Drawing.Image)(resources.GetObject("Decrement.Image")));
            this.Decrement.Location = new System.Drawing.Point(94, 345);
            this.Decrement.Name = "Decrement";
            this.Decrement.Size = new System.Drawing.Size(118, 112);
            this.Decrement.TabIndex = 3;
            this.Decrement.Text = "Decrement";
            this.Decrement.UseVisualStyleBackColor = true;
            this.Decrement.Click += new System.EventHandler(this.Decrement_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Sprinkler
            // 
            this.Sprinkler.Location = new System.Drawing.Point(943, 99);
            this.Sprinkler.Name = "Sprinkler";
            this.Sprinkler.Size = new System.Drawing.Size(172, 71);
            this.Sprinkler.TabIndex = 5;
            this.Sprinkler.Text = "Sprinkler";
            this.Sprinkler.UseVisualStyleBackColor = true;
            this.Sprinkler.Click += new System.EventHandler(this.Sprinkler_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 297);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1145, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 164);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(943, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Emegency resolved";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fire_emergency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1431, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sprinkler);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Decrement);
            this.Controls.Add(this.increment);
            this.Name = "Fire_emergency";
            this.Text = "Fire_emergency";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.Button Decrement;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Sprinkler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}