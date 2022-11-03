namespace G_Shop.Application.Pages
{
    partial class ProductsPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsPage));
            this.comboBoxBecom = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.sizesControl1 = new G_Shop.Application.Controls.SizesControl();
            this.listViewPoducts = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonChek = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.pictureBoxChange = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBecom
            // 
            this.comboBoxBecom.FormattingEnabled = true;
            this.comboBoxBecom.Items.AddRange(new object[] {
            "Мужское",
            "Женское"});
            this.comboBoxBecom.Location = new System.Drawing.Point(12, 3);
            this.comboBoxBecom.Name = "comboBoxBecom";
            this.comboBoxBecom.Size = new System.Drawing.Size(125, 23);
            this.comboBoxBecom.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(164, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(414, 23);
            this.textBoxSearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Описание товара 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Количество";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(105, 320);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 23);
            this.textBoxCount.TabIndex = 15;
            // 
            // sizesControl1
            // 
            this.sizesControl1.Location = new System.Drawing.Point(14, 255);
            this.sizesControl1.Name = "sizesControl1";
            this.sizesControl1.Size = new System.Drawing.Size(202, 38);
            this.sizesControl1.TabIndex = 16;
            // 
            // listViewPoducts
            // 
            this.listViewPoducts.LargeImageList = this.imageList;
            this.listViewPoducts.Location = new System.Drawing.Point(3, 43);
            this.listViewPoducts.Name = "listViewPoducts";
            this.listViewPoducts.Size = new System.Drawing.Size(600, 526);
            this.listViewPoducts.TabIndex = 18;
            this.listViewPoducts.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(60, 60);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Описание товара 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Описание товара 3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.comboBoxBecom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 34);
            this.panel1.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listViewPoducts, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 572);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonChek);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxCount);
            this.panel3.Controls.Add(this.sizesControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(609, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 526);
            this.panel3.TabIndex = 23;
            // 
            // buttonChek
            // 
            this.buttonChek.FlatAppearance.BorderSize = 0;
            this.buttonChek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChek.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChek.ForeColor = System.Drawing.Color.Black;
            this.buttonChek.Image = global::G_Shop.Application.Properties.Resources.Toolbox_16;
            this.buttonChek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChek.Location = new System.Drawing.Point(14, 436);
            this.buttonChek.Name = "buttonChek";
            this.buttonChek.Size = new System.Drawing.Size(216, 66);
            this.buttonChek.TabIndex = 21;
            this.buttonChek.Text = "         Добавить в заказ";
            this.buttonChek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChek.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxAdd);
            this.panel2.Controls.Add(this.pictureBoxChange);
            this.panel2.Controls.Add(this.pictureBoxDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(609, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 34);
            this.panel2.TabIndex = 23;
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Image = global::G_Shop.Application.Properties.Resources.Plus_math_100;
            this.pictureBoxAdd.Location = new System.Drawing.Point(195, 2);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdd.TabIndex = 23;
            this.pictureBoxAdd.TabStop = false;
            // 
            // pictureBoxChange
            // 
            this.pictureBoxChange.Image = global::G_Shop.Application.Properties.Resources.Edit_100;
            this.pictureBoxChange.Location = new System.Drawing.Point(107, 2);
            this.pictureBoxChange.Name = "pictureBoxChange";
            this.pictureBoxChange.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChange.TabIndex = 22;
            this.pictureBoxChange.TabStop = false;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Image = global::G_Shop.Application.Properties.Resources.Trash_100;
            this.pictureBoxDelete.Location = new System.Drawing.Point(14, 2);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDelete.TabIndex = 21;
            this.pictureBoxDelete.TabStop = false;
            // 
            // ProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductsPage";
            this.Size = new System.Drawing.Size(856, 572);
            this.Load += new System.EventHandler(this.ProductsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxBecom;
        private TextBox textBoxSearch;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxCount;
        private Controls.SizesControl sizesControl1;
        private ListView listViewPoducts;
        private ImageList imageList;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBoxDelete;
        private PictureBox pictureBoxAdd;
        private PictureBox pictureBoxChange;
        private Button buttonChek;
    }
}
