namespace G_Shop.Application.Pages
{
    partial class ChekPage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDeleteSetSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDeleteSetSale
            // 
            this.buttonDeleteSetSale.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteSetSale.Location = new System.Drawing.Point(634, 232);
            this.buttonDeleteSetSale.Name = "buttonDeleteSetSale";
            this.buttonDeleteSetSale.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteSetSale.TabIndex = 0;
            this.buttonDeleteSetSale.Text = "Видалити";
            this.buttonDeleteSetSale.UseVisualStyleBackColor = true;
            this.buttonDeleteSetSale.Click += new System.EventHandler(this.buttonDeleteSetSale_Click);
            // 
            // ChekPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDeleteSetSale);
            this.Name = "ChekPage";
            this.Size = new System.Drawing.Size(900, 614);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonDeleteSetSale;
    }
}
