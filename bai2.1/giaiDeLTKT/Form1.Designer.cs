namespace giaiDeLTKT
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
            this.nand = new System.Windows.Forms.CheckBox();
            this.c = new System.Windows.Forms.CheckBox();
            this.b = new System.Windows.Forms.CheckBox();
            this.a = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.or = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(887, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "???";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Truth table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notA
            // 
            this.notA.AutoSize = true;
            this.notA.Location = new System.Drawing.Point(155, 30);
            this.notA.Name = "notA";
            this.notA.Size = new System.Drawing.Size(18, 17);
            this.notA.TabIndex = 17;
            this.notA.UseVisualStyleBackColor = true;
            this.notA.CheckedChanged += new System.EventHandler(this.someThinkChanged);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(747, 124);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(18, 17);
            this.X.TabIndex = 16;
            this.X.UseVisualStyleBackColor = true;
            this.X.CheckedChanged += new System.EventHandler(this.someThinkChanged);
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(747, 224);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(18, 17);
            this.Y.TabIndex = 15;
            this.Y.UseVisualStyleBackColor = true;
            this.Y.CheckedChanged += new System.EventHandler(this.someThinkChanged);
            // 
            // nand
            // 
            this.nand.AutoSize = true;
            this.nand.Location = new System.Drawing.Point(341, 62);
            this.nand.Name = "nand";
            this.nand.Size = new System.Drawing.Size(18, 17);
            this.nand.TabIndex = 14;
            this.nand.UseVisualStyleBackColor = true;
            this.nand.CheckedChanged += new System.EventHandler(this.someThinkChanged);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(21, 152);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(18, 17);
            this.c.TabIndex = 13;
            this.c.UseVisualStyleBackColor = true;
            this.c.CheckedChanged += new System.EventHandler(this.someThinkChanged);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(21, 107);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(18, 17);
            this.b.TabIndex = 12;
            this.b.UseVisualStyleBackColor = true;
            this.b.CheckedChanged += new System.EventHandler(this.someThinkChanged);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(21, 52);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(18, 17);
            this.a.TabIndex = 11;
            this.a.UseVisualStyleBackColor = true;
            this.a.CheckedChanged += new System.EventHandler(this.someThinkChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::giaiDeLTKT.Properties.Resources.Screenshot;
            this.pictureBox1.Location = new System.Drawing.Point(45, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(836, 334);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // or
            // 
            this.or.AutoSize = true;
            this.or.Location = new System.Drawing.Point(341, 207);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(18, 17);
            this.or.TabIndex = 20;
            this.or.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 450);
            this.Controls.Add(this.or);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notA);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.nand);
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
        private System.Windows.Forms.CheckBox nand;
        private System.Windows.Forms.CheckBox c;
        private System.Windows.Forms.CheckBox b;
        private System.Windows.Forms.CheckBox a;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox or;
    }
}

