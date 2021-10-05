
namespace task2window
{
    partial class CaesarCipherForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.initialTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encodedTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ключ шифрования";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(141, 191);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(167, 22);
            this.passwordInput.TabIndex = 2;
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(202, 230);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(100, 22);
            this.keyInput.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(67, 287);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(92, 33);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "ОК";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // initialTextBox
            // 
            this.initialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.initialTextBox.Location = new System.Drawing.Point(67, 44);
            this.initialTextBox.Multiline = true;
            this.initialTextBox.Name = "initialTextBox";
            this.initialTextBox.Size = new System.Drawing.Size(594, 128);
            this.initialTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Исходный текст";
            // 
            // encodedTextBox
            // 
            this.encodedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encodedTextBox.Location = new System.Drawing.Point(67, 382);
            this.encodedTextBox.Multiline = true;
            this.encodedTextBox.Name = "encodedTextBox";
            this.encodedTextBox.ReadOnly = true;
            this.encodedTextBox.Size = new System.Drawing.Size(594, 124);
            this.encodedTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Закодированный текст";
            // 
            // CaesarCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 559);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.encodedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.initialTextBox);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CaesarCipherForm";
            this.Text = "Шифр Цезаря";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox initialTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encodedTextBox;
        private System.Windows.Forms.Label label4;
    }
}

