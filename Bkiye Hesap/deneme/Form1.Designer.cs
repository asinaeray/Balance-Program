namespace deneme
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ib = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.odeme = new System.Windows.Forms.Button();
            this.y50 = new System.Windows.Forms.Button();
            this.y100 = new System.Windows.Forms.Button();
            this.y200 = new System.Windows.Forms.Button();
            this.para = new System.Windows.Forms.Label();
            this.og = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bakiye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.og);
            this.groupBox1.Controls.Add(this.ib);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme";
            // 
            // ib
            // 
            this.ib.AutoSize = true;
            this.ib.Location = new System.Drawing.Point(36, 55);
            this.ib.Name = "ib";
            this.ib.Size = new System.Drawing.Size(60, 17);
            this.ib.TabIndex = 2;
            this.ib.TabStop = true;
            this.ib.Text = "İlk biniş";
            this.ib.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.y200);
            this.groupBox2.Controls.Add(this.y100);
            this.groupBox2.Controls.Add(this.y50);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(379, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yükleme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 1;
            // 
            // odeme
            // 
            this.odeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odeme.Location = new System.Drawing.Point(453, 49);
            this.odeme.Name = "odeme";
            this.odeme.Size = new System.Drawing.Size(137, 44);
            this.odeme.TabIndex = 4;
            this.odeme.Text = "Ödeme";
            this.odeme.UseVisualStyleBackColor = true;
            this.odeme.Click += new System.EventHandler(this.odeme_Click);
            // 
            // y50
            // 
            this.y50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y50.Location = new System.Drawing.Point(63, 61);
            this.y50.Name = "y50";
            this.y50.Size = new System.Drawing.Size(166, 44);
            this.y50.TabIndex = 5;
            this.y50.Text = "50 Lira Yükle";
            this.y50.UseVisualStyleBackColor = true;
            this.y50.Click += new System.EventHandler(this.y50_Click);
            // 
            // y100
            // 
            this.y100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y100.Location = new System.Drawing.Point(63, 127);
            this.y100.Name = "y100";
            this.y100.Size = new System.Drawing.Size(166, 44);
            this.y100.TabIndex = 6;
            this.y100.Text = "100 Lira Yükle";
            this.y100.UseVisualStyleBackColor = true;
            this.y100.Click += new System.EventHandler(this.y100_Click);
            // 
            // y200
            // 
            this.y200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y200.Location = new System.Drawing.Point(63, 188);
            this.y200.Name = "y200";
            this.y200.Size = new System.Drawing.Size(166, 44);
            this.y200.TabIndex = 7;
            this.y200.Text = "200 Lira Yükle";
            this.y200.UseVisualStyleBackColor = true;
            this.y200.Click += new System.EventHandler(this.y200_Click);
            // 
            // para
            // 
            this.para.AutoSize = true;
            this.para.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.para.Location = new System.Drawing.Point(36, 61);
            this.para.Name = "para";
            this.para.Size = new System.Drawing.Size(20, 24);
            this.para.TabIndex = 5;
            this.para.Text = "0";
            // 
            // og
            // 
            this.og.AutoSize = true;
            this.og.Location = new System.Drawing.Point(36, 88);
            this.og.Name = "og";
            this.og.Size = new System.Drawing.Size(62, 17);
            this.og.TabIndex = 3;
            this.og.TabStop = true;
            this.og.Text = "Öğrenci";
            this.og.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 421);
            this.Controls.Add(this.para);
            this.Controls.Add(this.odeme);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ib;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button odeme;
        private System.Windows.Forms.Button y200;
        private System.Windows.Forms.Button y100;
        private System.Windows.Forms.Button y50;
        private System.Windows.Forms.Label para;
        private System.Windows.Forms.RadioButton og;
    }
}

