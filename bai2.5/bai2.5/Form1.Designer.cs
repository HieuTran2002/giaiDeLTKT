namespace bai2._5
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.notA = new System.Windows.Forms.CheckBox();
            this.X = new System.Windows.Forms.CheckBox();
            this.Y = new System.Windows.Forms.CheckBox();
            this.and = new System.Windows.Forms.CheckBox();
            this.c = new System.Windows.Forms.CheckBox();
            this.b = new System.Windows.Forms.CheckBox();
            this.a = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(878, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "???";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(878, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "Truth table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notA
            // 
            this.notA.AutoSize = true;
            this.notA.Location = new System.Drawing.Point(239, 142);
            this.notA.Name = "notA";
            this.notA.Size = new System.Drawing.Size(18, 17);
            this.notA.TabIndex = 37;
            this.notA.UseVisualStyleBackColor = true;
            this.notA.CheckedChanged += new System.EventHandler(this.X_CheckedChanged);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(702, 117);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(18, 17);
            this.X.TabIndex = 36;
            this.X.UseVisualStyleBackColor = true;
            this.X.CheckedChanged += new System.EventHandler(this.X_CheckedChanged);
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(702, 250);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(18, 17);
            this.Y.TabIndex = 35;
            this.Y.UseVisualStyleBackColor = true;
            this.Y.CheckedChanged += new System.EventHandler(this.X_CheckedChanged);
            // 
            // and
            // 
            this.and.AutoSize = true;
            this.and.Location = new System.Drawing.Point(366, 34);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(18, 17);
            this.and.TabIndex = 34;
            this.and.UseVisualStyleBackColor = true;
            this.and.CheckedChanged += new System.EventHandler(this.X_CheckedChanged);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(12, 106);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(18, 17);
            this.c.TabIndex = 33;
            this.c.UseVisualStyleBackColor = true;
            this.c.CheckedChanged += new System.EventHandler(this.X_CheckedChanged);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(12, 68);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(18, 17);
            this.b.TabIndex = 32;
            this.b.UseVisualStyleBackColor = true;
            this.b.CheckedChanged += new System.EventHandler(this.X_CheckedChanged);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(12, 34);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(18, 17);
            this.a.TabIndex = 31;
            this.a.UseVisualStyleBackColor = true;
            this.a.CheckedChanged += new System.EventHandler(this.X_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bai2._5.Properties.Resources.Screenshot_2022_05_01_085218;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(836, 334);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notA);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.and);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox notA;
        private System.Windows.Forms.CheckBox X;
        private System.Windows.Forms.CheckBox Y;
        private System.Windows.Forms.CheckBox and;
        private System.Windows.Forms.CheckBox c;
        private System.Windows.Forms.CheckBox b;
        private System.Windows.Forms.CheckBox a;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

