namespace G_Shop.Application.Controls
{
    partial class ProductControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMyCategory = new System.Windows.Forms.Label();
            this.labelMyPrice = new System.Windows.Forms.Label();
            this.labelMySeason = new System.Windows.Forms.Label();
            this.labelMyCount = new System.Windows.Forms.Label();
            this.sizesControl1 = new G_Shop.Application.Controls.SizesControl();
            this.labelCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelSeason = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMyCountry = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelMyCategory
            // 
            this.labelMyCategory.AutoSize = true;
            this.labelMyCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMyCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyCategory.Location = new System.Drawing.Point(3, 240);
            this.labelMyCategory.Name = "labelMyCategory";
            this.labelMyCategory.Size = new System.Drawing.Size(144, 25);
            this.labelMyCategory.TabIndex = 1;
            this.labelMyCategory.Text = "Категорія";
            // 
            // labelMyPrice
            // 
            this.labelMyPrice.AutoSize = true;
            this.labelMyPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMyPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyPrice.Location = new System.Drawing.Point(3, 315);
            this.labelMyPrice.Name = "labelMyPrice";
            this.labelMyPrice.Size = new System.Drawing.Size(144, 25);
            this.labelMyPrice.TabIndex = 2;
            this.labelMyPrice.Text = "Ціна";
            // 
            // labelMySeason
            // 
            this.labelMySeason.AutoSize = true;
            this.labelMySeason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMySeason.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMySeason.Location = new System.Drawing.Point(3, 290);
            this.labelMySeason.Name = "labelMySeason";
            this.labelMySeason.Size = new System.Drawing.Size(144, 25);
            this.labelMySeason.TabIndex = 3;
            this.labelMySeason.Text = "Сезон";
            // 
            // labelMyCount
            // 
            this.labelMyCount.AutoSize = true;
            this.labelMyCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMyCount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyCount.Location = new System.Drawing.Point(3, 555);
            this.labelMyCount.Name = "labelMyCount";
            this.labelMyCount.Size = new System.Drawing.Size(144, 30);
            this.labelMyCount.TabIndex = 17;
            this.labelMyCount.Text = "Количество";
            // 
            // sizesControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.sizesControl1, 2);
            this.sizesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizesControl1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizesControl1.Location = new System.Drawing.Point(3, 513);
            this.sizesControl1.Name = "sizesControl1";
            this.sizesControl1.Size = new System.Drawing.Size(294, 39);
            this.sizesControl1.TabIndex = 19;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCount.Location = new System.Drawing.Point(153, 555);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(144, 30);
            this.labelCount.TabIndex = 20;
            this.labelCount.Text = "labelCount";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelDescription, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMyCount, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelPrice, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.sizesControl1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelSeason, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelCountry, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelMyCountry, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelMyCategory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelMyPrice, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelCategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelMySeason, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelCount, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 585);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelDescription, 2);
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(3, 340);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(294, 170);
            this.labelDescription.TabIndex = 28;
            this.labelDescription.Text = "Опис";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(153, 315);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(144, 25);
            this.labelPrice.TabIndex = 23;
            this.labelPrice.Text = "500 грн";
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSeason.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSeason.Location = new System.Drawing.Point(153, 290);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(144, 25);
            this.labelSeason.TabIndex = 24;
            this.labelSeason.Text = "Зима/лето";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountry.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCountry.Location = new System.Drawing.Point(153, 265);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(144, 25);
            this.labelCountry.TabIndex = 27;
            this.labelCountry.Text = "Україна";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelName, 2);
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(3, 200);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(294, 40);
            this.labelName.TabIndex = 25;
            this.labelName.Text = "Назва";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMyCountry
            // 
            this.labelMyCountry.AutoSize = true;
            this.labelMyCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMyCountry.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyCountry.Location = new System.Drawing.Point(3, 265);
            this.labelMyCountry.Name = "labelMyCountry";
            this.labelMyCountry.Size = new System.Drawing.Size(144, 25);
            this.labelMyCountry.TabIndex = 26;
            this.labelMyCountry.Text = "Країна";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(153, 240);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(144, 25);
            this.labelCategory.TabIndex = 22;
            this.labelCategory.Text = "Man/woman";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(300, 585);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelMyCategory;
        private Label labelMyPrice;
        private Label labelMySeason;
        private Label labelMyCount;
        private SizesControl sizesControl1;
        private Label labelCount;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelCategory;
        private Label labelPrice;
        private Label labelSeason;
        private Label labelName;
        private Label labelMyCountry;
        private Label labelCountry;
        private Label labelDescription;
    }
}
