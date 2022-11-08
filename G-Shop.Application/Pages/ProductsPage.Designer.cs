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
            this.comboBoxBecom = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listViewPoducts = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productControl1 = new G_Shop.Application.Controls.ProductControl();
            this.productEditControl1 = new G_Shop.Application.Controls.ProductEditControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.pictureBoxChange = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
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
            // listViewPoducts
            // 
            this.listViewPoducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPoducts.LargeImageList = this.imageList;
            this.listViewPoducts.Location = new System.Drawing.Point(3, 43);
            this.listViewPoducts.Name = "listViewPoducts";
            this.listViewPoducts.Size = new System.Drawing.Size(550, 526);
            this.listViewPoducts.TabIndex = 18;
            this.listViewPoducts.UseCompatibleStateImageBehavior = false;
            this.listViewPoducts.SelectedIndexChanged += new System.EventHandler(this.ListViewPoducts_SelectedIndexChanged);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(60, 60);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.comboBoxBecom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 34);
            this.panel1.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
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
            this.panel3.Controls.Add(this.productControl1);
            this.panel3.Controls.Add(this.productEditControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(559, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 526);
            this.panel3.TabIndex = 23;
            // 
            // productControl1
            // 
            this.productControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productControl1.Location = new System.Drawing.Point(0, 0);
            this.productControl1.Name = "productControl1";
            this.productControl1.Size = new System.Drawing.Size(294, 526);
            this.productControl1.TabIndex = 22;
            // 
            // productEditControl1
            // 
            this.productEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productEditControl1.Location = new System.Drawing.Point(0, 0);
            this.productEditControl1.Name = "productEditControl1";
            this.productEditControl1.Size = new System.Drawing.Size(294, 526);
            this.productEditControl1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxAdd);
            this.panel2.Controls.Add(this.pictureBoxChange);
            this.panel2.Controls.Add(this.pictureBoxDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(559, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 34);
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
            this.pictureBoxChange.Click += new System.EventHandler(this.PictureBoxChange_Click);
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
            this.pictureBoxDelete.Click += new System.EventHandler(this.PictureBoxDelete_Click);
            // 
            // ProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductsPage";
            this.Size = new System.Drawing.Size(856, 572);
            this.Load += new System.EventHandler(this.ProductsPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxBecom;
        private TextBox textBoxSearch;
        private ListView listViewPoducts;
        private ImageList imageList;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBoxDelete;
        private PictureBox pictureBoxAdd;
        private PictureBox pictureBoxChange;
        private Controls.ProductControl productControl1;
        private Controls.ProductEditControl productEditControl1;
    }
}
