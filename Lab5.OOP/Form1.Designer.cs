namespace Lab5.OOP
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
            this.btnOperators = new System.Windows.Forms.Button();
            this.btnAgeCategory = new System.Windows.Forms.Button();
            this.btnMultiplicationTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOperators
            // 
            this.btnOperators.Location = new System.Drawing.Point(58, 100);
            this.btnOperators.Name = "btnOperators";
            this.btnOperators.Size = new System.Drawing.Size(75, 23);
            this.btnOperators.TabIndex = 0;
            this.btnOperators.Text = "Operators";
            this.btnOperators.UseVisualStyleBackColor = true;
            this.btnOperators.Click += new System.EventHandler(this.btnOperators_Click);
            // 
            // btnAgeCategory
            // 
            this.btnAgeCategory.Location = new System.Drawing.Point(194, 100);
            this.btnAgeCategory.Name = "btnAgeCategory";
            this.btnAgeCategory.Size = new System.Drawing.Size(80, 23);
            this.btnAgeCategory.TabIndex = 1;
            this.btnAgeCategory.Text = "AgeCategory";
            this.btnAgeCategory.UseVisualStyleBackColor = true;
            this.btnAgeCategory.Click += new System.EventHandler(this.btnAgeCategory_Click);
            // 
            // btnMultiplicationTable
            // 
            this.btnMultiplicationTable.Location = new System.Drawing.Point(329, 100);
            this.btnMultiplicationTable.Name = "btnMultiplicationTable";
            this.btnMultiplicationTable.Size = new System.Drawing.Size(109, 23);
            this.btnMultiplicationTable.TabIndex = 2;
            this.btnMultiplicationTable.Text = "MultiplicationTable";
            this.btnMultiplicationTable.UseVisualStyleBackColor = true;
            this.btnMultiplicationTable.Click += new System.EventHandler(this.btnMultiplicationTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 227);
            this.Controls.Add(this.btnMultiplicationTable);
            this.Controls.Add(this.btnAgeCategory);
            this.Controls.Add(this.btnOperators);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOperators;
        private System.Windows.Forms.Button btnAgeCategory;
        private System.Windows.Forms.Button btnMultiplicationTable;
    }
}

