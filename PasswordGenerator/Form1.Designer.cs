namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Butt_Generate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MD5_tabPage = new System.Windows.Forms.TabPage();
            this.PasssVisible = new System.Windows.Forms.CheckBox();
            this.Butt_Copy = new System.Windows.Forms.Button();
            this.GeneratedPassField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QR_tabPage = new System.Windows.Forms.TabPage();
            this.Butt_QrGenerate = new System.Windows.Forms.Button();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.MD5_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(25, 51);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(135, 22);
            this.PasswordField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your password:";
            // 
            // Butt_Generate
            // 
            this.Butt_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Butt_Generate.Location = new System.Drawing.Point(183, 40);
            this.Butt_Generate.Name = "Butt_Generate";
            this.Butt_Generate.Size = new System.Drawing.Size(86, 33);
            this.Butt_Generate.TabIndex = 3;
            this.Butt_Generate.Text = "Generate";
            this.Butt_Generate.UseVisualStyleBackColor = true;
            this.Butt_Generate.Click += new System.EventHandler(this.Butt_Generate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MD5_tabPage);
            this.tabControl1.Controls.Add(this.QR_tabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 361);
            this.tabControl1.TabIndex = 4;
            // 
            // MD5_tabPage
            // 
            this.MD5_tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.MD5_tabPage.Controls.Add(this.pictureBoxQRCode);
            this.MD5_tabPage.Controls.Add(this.Butt_QrGenerate);
            this.MD5_tabPage.Controls.Add(this.PasssVisible);
            this.MD5_tabPage.Controls.Add(this.Butt_Copy);
            this.MD5_tabPage.Controls.Add(this.Butt_Generate);
            this.MD5_tabPage.Controls.Add(this.label1);
            this.MD5_tabPage.Controls.Add(this.PasswordField);
            this.MD5_tabPage.Controls.Add(this.GeneratedPassField);
            this.MD5_tabPage.Controls.Add(this.label2);
            this.MD5_tabPage.Location = new System.Drawing.Point(4, 25);
            this.MD5_tabPage.Name = "MD5_tabPage";
            this.MD5_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MD5_tabPage.Size = new System.Drawing.Size(676, 332);
            this.MD5_tabPage.TabIndex = 0;
            this.MD5_tabPage.Text = "MD5";
            // 
            // PasssVisible
            // 
            this.PasssVisible.AutoSize = true;
            this.PasssVisible.Location = new System.Drawing.Point(183, 80);
            this.PasssVisible.Name = "PasssVisible";
            this.PasssVisible.Size = new System.Drawing.Size(73, 20);
            this.PasssVisible.TabIndex = 7;
            this.PasssVisible.Text = "visible";
            this.PasssVisible.UseVisualStyleBackColor = true;
            this.PasssVisible.CheckedChanged += new System.EventHandler(this.PasssVisible_CheckedChanged);
            // 
            // Butt_Copy
            // 
            this.Butt_Copy.Location = new System.Drawing.Point(25, 195);
            this.Butt_Copy.Name = "Butt_Copy";
            this.Butt_Copy.Size = new System.Drawing.Size(87, 49);
            this.Butt_Copy.TabIndex = 6;
            this.Butt_Copy.Text = "Copy";
            this.Butt_Copy.UseVisualStyleBackColor = true;
            // 
            // GeneratedPassField
            // 
            this.GeneratedPassField.Location = new System.Drawing.Point(25, 126);
            this.GeneratedPassField.Multiline = true;
            this.GeneratedPassField.Name = "GeneratedPassField";
            this.GeneratedPassField.ReadOnly = true;
            this.GeneratedPassField.Size = new System.Drawing.Size(207, 63);
            this.GeneratedPassField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Generated password:";
            // 
            // QR_tabPage
            // 
            this.QR_tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.QR_tabPage.Location = new System.Drawing.Point(4, 25);
            this.QR_tabPage.Name = "QR_tabPage";
            this.QR_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.QR_tabPage.Size = new System.Drawing.Size(676, 332);
            this.QR_tabPage.TabIndex = 1;
            this.QR_tabPage.Text = "QR code";
            // 
            // Butt_QrGenerate
            // 
            this.Butt_QrGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Butt_QrGenerate.Location = new System.Drawing.Point(238, 134);
            this.Butt_QrGenerate.Name = "Butt_QrGenerate";
            this.Butt_QrGenerate.Size = new System.Drawing.Size(86, 55);
            this.Butt_QrGenerate.TabIndex = 8;
            this.Butt_QrGenerate.Text = "Generate QR";
            this.Butt_QrGenerate.UseVisualStyleBackColor = true;
            this.Butt_QrGenerate.Click += new System.EventHandler(this.Butt_QrGenerate_Click);
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(453, 126);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(188, 148);
            this.pictureBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQRCode.TabIndex = 9;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.MD5_tabPage.ResumeLayout(false);
            this.MD5_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Butt_Generate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MD5_tabPage;
        private System.Windows.Forms.Button Butt_Copy;
        private System.Windows.Forms.TextBox GeneratedPassField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage QR_tabPage;
        private System.Windows.Forms.CheckBox PasssVisible;
        private System.Windows.Forms.Button Butt_QrGenerate;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
    }
}

