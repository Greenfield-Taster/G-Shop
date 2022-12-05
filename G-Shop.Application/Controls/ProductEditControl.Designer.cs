namespace G_Shop.Application.Controls
{
    partial class ProductEditControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEditControl));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelMyCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSeason = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelMyPrice = new System.Windows.Forms.Label();
            this.labelMySeason = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelMyCategory = new System.Windows.Forms.Label();
            this.labelMyCountry = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.sizesControl = new G_Shop.Application.Controls.SizesControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxName, 2);
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(3, 128);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 22);
            this.textBoxName.TabIndex = 46;
            // 
            // richTextBoxDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBoxDescription, 2);
            this.richTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDescription.Location = new System.Drawing.Point(3, 278);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(294, 186);
            this.richTextBoxDescription.TabIndex = 43;
            this.richTextBoxDescription.Text = "";
            // 
            // labelMyCount
            // 
            this.labelMyCount.AutoSize = true;
            this.labelMyCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMyCount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyCount.Location = new System.Drawing.Point(3, 512);
            this.labelMyCount.Name = "labelMyCount";
            this.labelMyCount.Size = new System.Drawing.Size(144, 23);
            this.labelMyCount.TabIndex = 20;
            this.labelMyCount.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Опис";
            // 
            // comboBoxSeason
            // 
            this.comboBoxSeason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSeason.FormattingEnabled = true;
            this.comboBoxSeason.Location = new System.Drawing.Point(153, 209);
            this.comboBoxSeason.Name = "comboBoxSeason";
            this.comboBoxSeason.Size = new System.Drawing.Size(144, 23);
            this.comboBoxSeason.TabIndex = 41;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrice.Location = new System.Drawing.Point(153, 232);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(144, 22);
            this.textBoxPrice.TabIndex = 38;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(153, 163);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(144, 23);
            this.comboBoxCategory.TabIndex = 40;
            // 
            // labelMyPrice
            // 
            this.labelMyPrice.AutoSize = true;
            this.labelMyPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMyPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyPrice.Location = new System.Drawing.Point(3, 229);
            this.labelMyPrice.Name = "labelMyPrice";
            this.labelMyPrice.Size = new System.Drawing.Size(144, 23);
            this.labelMyPrice.TabIndex = 30;
            this.labelMyPrice.Text = "Ціна";
            // 
            // labelMySeason
            // 
            this.labelMySeason.AutoSize = true;
            this.labelMySeason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMySeason.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMySeason.Location = new System.Drawing.Point(3, 206);
            this.labelMySeason.Name = "labelMySeason";
            this.labelMySeason.Size = new System.Drawing.Size(144, 23);
            this.labelMySeason.TabIndex = 31;
            this.labelMySeason.Text = "Сезон";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCountry.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountry.Location = new System.Drawing.Point(153, 186);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(144, 22);
            this.textBoxCountry.TabIndex = 36;
            // 
            // labelMyCategory
            // 
            this.labelMyCategory.AutoSize = true;
            this.labelMyCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMyCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyCategory.Location = new System.Drawing.Point(3, 160);
            this.labelMyCategory.Name = "labelMyCategory";
            this.labelMyCategory.Size = new System.Drawing.Size(144, 23);
            this.labelMyCategory.TabIndex = 29;
            this.labelMyCategory.Text = "Категорія";
            // 
            // labelMyCountry
            // 
            this.labelMyCountry.AutoSize = true;
            this.labelMyCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMyCountry.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyCountry.Location = new System.Drawing.Point(3, 183);
            this.labelMyCountry.Name = "labelMyCountry";
            this.labelMyCountry.Size = new System.Drawing.Size(144, 23);
            this.labelMyCountry.TabIndex = 33;
            this.labelMyCountry.Text = "Країна";
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Image = global::G_Shop.Application.Properties.Resources.Toolbox_16;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(153, 538);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(144, 44);
            this.buttonEdit.TabIndex = 44;
            this.buttonEdit.Text = "Відмінити";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Image = global::G_Shop.Application.Properties.Resources.Toolbox_16;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(3, 538);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(144, 44);
            this.buttonCancel.TabIndex = 45;
            this.buttonCancel.Text = "Готово";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.buttonEdit, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMyCountry, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelMyCategory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCountry, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelMySeason, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelMyPrice, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPrice, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSeason, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelMyCount, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxDescription, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownCount, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.sizesControl, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 585);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownCount.Location = new System.Drawing.Point(153, 515);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(144, 23);
            this.numericUpDownCount.TabIndex = 47;
            this.numericUpDownCount.ValueChanged += new System.EventHandler(this.NumericUpDownCount_ValueChanged);
            // 
            // sizesControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.sizesControl, 2);
            this.sizesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizesControl.Location = new System.Drawing.Point(3, 470);
            this.sizesControl.Name = "sizesControl";
            this.sizesControl.Size = new System.Drawing.Size(294, 39);
            this.sizesControl.TabIndex = 48;
            // 
            // ProductEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductEditControl";
            this.Size = new System.Drawing.Size(300, 585);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBoxName;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonCancel;
        private Button buttonEdit;
        private PictureBox pictureBox1;
        private Label labelMyCountry;
        private Label labelMyCategory;
        private TextBox textBoxCountry;
        private Label labelMySeason;
        private Label labelMyPrice;
        private ComboBox comboBoxCategory;
        private TextBox textBoxPrice;
        private ComboBox comboBoxSeason;
        private Label label1;
        private Label labelMyCount;
        private RichTextBox richTextBoxDescription;
        private NumericUpDown numericUpDownCount;
        private SizesControl sizesControl;
    }
}
