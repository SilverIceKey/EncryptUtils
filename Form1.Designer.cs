namespace EncryptUtils
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.encryptFunCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.encryptModeCB = new System.Windows.Forms.ComboBox();
            this.encryptFillModeCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.encryptKeyTB = new System.Windows.Forms.TextBox();
            this.contentWaitToDeal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contentResult = new System.Windows.Forms.TextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.encryptIVTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encryptFunCB
            // 
            this.encryptFunCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptFunCB.FormattingEnabled = true;
            this.encryptFunCB.Location = new System.Drawing.Point(117, 6);
            this.encryptFunCB.Name = "encryptFunCB";
            this.encryptFunCB.Size = new System.Drawing.Size(121, 27);
            this.encryptFunCB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "加解密方法：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "加解密模式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "填充模式：";
            // 
            // encryptModeCB
            // 
            this.encryptModeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptModeCB.FormattingEnabled = true;
            this.encryptModeCB.Location = new System.Drawing.Point(349, 6);
            this.encryptModeCB.Name = "encryptModeCB";
            this.encryptModeCB.Size = new System.Drawing.Size(121, 27);
            this.encryptModeCB.TabIndex = 0;
            // 
            // encryptFillModeCB
            // 
            this.encryptFillModeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptFillModeCB.FormattingEnabled = true;
            this.encryptFillModeCB.Location = new System.Drawing.Point(566, 6);
            this.encryptFillModeCB.Name = "encryptFillModeCB";
            this.encryptFillModeCB.Size = new System.Drawing.Size(178, 27);
            this.encryptFillModeCB.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "密钥：";
            // 
            // encryptKeyTB
            // 
            this.encryptKeyTB.Location = new System.Drawing.Point(83, 42);
            this.encryptKeyTB.Name = "encryptKeyTB";
            this.encryptKeyTB.Size = new System.Drawing.Size(387, 27);
            this.encryptKeyTB.TabIndex = 3;
            // 
            // contentWaitToDeal
            // 
            this.contentWaitToDeal.Location = new System.Drawing.Point(12, 133);
            this.contentWaitToDeal.MaxLength = 32767000;
            this.contentWaitToDeal.Multiline = true;
            this.contentWaitToDeal.Name = "contentWaitToDeal";
            this.contentWaitToDeal.Size = new System.Drawing.Size(1036, 256);
            this.contentWaitToDeal.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "待处理内容：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "结果：";
            // 
            // contentResult
            // 
            this.contentResult.BackColor = System.Drawing.SystemColors.Window;
            this.contentResult.Location = new System.Drawing.Point(14, 414);
            this.contentResult.MaxLength = 32767000;
            this.contentResult.Multiline = true;
            this.contentResult.Name = "contentResult";
            this.contentResult.ReadOnly = true;
            this.contentResult.Size = new System.Drawing.Size(1034, 227);
            this.contentResult.TabIndex = 4;
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(476, 41);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 26);
            this.encryptBtn.TabIndex = 6;
            this.encryptBtn.Text = "加密";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(566, 41);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 26);
            this.decryptBtn.TabIndex = 7;
            this.decryptBtn.Text = "解密";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "偏移量：";
            // 
            // encryptIVTB
            // 
            this.encryptIVTB.Location = new System.Drawing.Point(83, 79);
            this.encryptIVTB.Name = "encryptIVTB";
            this.encryptIVTB.ReadOnly = true;
            this.encryptIVTB.Size = new System.Drawing.Size(387, 27);
            this.encryptIVTB.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1060, 653);
            this.Controls.Add(this.encryptIVTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contentResult);
            this.Controls.Add(this.contentWaitToDeal);
            this.Controls.Add(this.encryptKeyTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptFillModeCB);
            this.Controls.Add(this.encryptModeCB);
            this.Controls.Add(this.encryptFunCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox encryptFunCB;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox encryptModeCB;
        private ComboBox encryptFillModeCB;
        private Label label4;
        private TextBox encryptKeyTB;
        private TextBox contentWaitToDeal;
        private Label label5;
        private Label label6;
        private TextBox contentResult;
        private Button encryptBtn;
        private Button decryptBtn;
        private Label label7;
        private TextBox encryptIVTB;
    }
}