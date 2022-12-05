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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonUpdateSale = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(189)))), ((int)(((byte)(125)))));
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Left;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "ReportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(550, 463);
            this.reportViewer.TabIndex = 0;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClearAll.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearAll.Location = new System.Drawing.Point(3, 3);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(133, 26);
            this.buttonClearAll.TabIndex = 1;
            this.buttonClearAll.Text = "Clear all";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonUpdateSale
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonUpdateSale, 2);
            this.buttonUpdateSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUpdateSale.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdateSale.Location = new System.Drawing.Point(3, 3);
            this.buttonUpdateSale.Name = "buttonUpdateSale";
            this.buttonUpdateSale.Size = new System.Drawing.Size(133, 123);
            this.buttonUpdateSale.TabIndex = 2;
            this.buttonUpdateSale.Text = "Update";
            this.buttonUpdateSale.UseVisualStyleBackColor = true;
            this.buttonUpdateSale.Click += new System.EventHandler(this.buttonUpdateSale_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonUpdateSale, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(550, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(139, 129);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonClearAll, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(550, 129);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(139, 334);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // ChekPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.reportViewer);
            this.Name = "ChekPage";
            this.Size = new System.Drawing.Size(689, 463);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Button buttonClearAll;
        private Button buttonUpdateSale;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
