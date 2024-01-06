namespace DZ_7._1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.engRadioButton = new System.Windows.Forms.RadioButton();
            this.ukrRadioButton = new System.Windows.Forms.RadioButton();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.engRadioButton);
            this.groupBox1.Controls.Add(this.ukrRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Виберіть мову шифрування";
            // 
            // engRadioButton
            // 
            this.engRadioButton.AutoSize = true;
            this.engRadioButton.Location = new System.Drawing.Point(7, 63);
            this.engRadioButton.Name = "engRadioButton";
            this.engRadioButton.Size = new System.Drawing.Size(79, 27);
            this.engRadioButton.TabIndex = 2;
            this.engRadioButton.TabStop = true;
            this.engRadioButton.Text = "English";
            this.engRadioButton.UseVisualStyleBackColor = true;
            // 
            // ukrRadioButton
            // 
            this.ukrRadioButton.AutoSize = true;
            this.ukrRadioButton.Location = new System.Drawing.Point(6, 29);
            this.ukrRadioButton.Name = "ukrRadioButton";
            this.ukrRadioButton.Size = new System.Drawing.Size(109, 27);
            this.ukrRadioButton.TabIndex = 1;
            this.ukrRadioButton.TabStop = true;
            this.ukrRadioButton.Text = "Українська";
            this.ukrRadioButton.UseVisualStyleBackColor = true;
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(30, 146);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(391, 30);
            this.sourceTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введіть слово ао фразу, яку ви хочете закодувати";
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(30, 196);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(169, 37);
            this.codeButton.TabIndex = 4;
            this.codeButton.Text = "Закодувати";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(242, 196);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(179, 37);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Очистити";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(30, 250);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.codeTextBox.Size = new System.Drawing.Size(391, 94);
            this.codeTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 356);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.codeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton engRadioButton;
        private System.Windows.Forms.RadioButton ukrRadioButton;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox codeTextBox;
    }
}

