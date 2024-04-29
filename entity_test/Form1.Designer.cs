namespace entity_test
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonSendPassword = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "mail";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(13, 38);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(293, 22);
            this.textBoxMail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(13, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(13, 93);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(293, 22);
            this.textBoxPassword.TabIndex = 10;
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(11, 134);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(295, 28);
            this.buttonSign.TabIndex = 11;
            this.buttonSign.Text = "sign in";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // buttonSendPassword
            // 
            this.buttonSendPassword.Location = new System.Drawing.Point(13, 178);
            this.buttonSendPassword.Name = "buttonSendPassword";
            this.buttonSendPassword.Size = new System.Drawing.Size(124, 31);
            this.buttonSendPassword.TabIndex = 12;
            this.buttonSendPassword.Text = "забыли пароль";
            this.buttonSendPassword.UseVisualStyleBackColor = true;
            this.buttonSendPassword.Click += new System.EventHandler(this.buttonSendPassword_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(184, 178);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(122, 31);
            this.buttonRegistration.TabIndex = 13;
            this.buttonRegistration.Text = "регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 231);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonSendPassword);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonSendPassword;
        private System.Windows.Forms.Button buttonRegistration;
    }
}

