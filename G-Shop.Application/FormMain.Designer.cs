namespace G_Shop.Application
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonChek = new System.Windows.Forms.Button();
            this.productsPage1 = new G_Shop.Application.Pages.ProductsPage();
            this.chekPage1 = new G_Shop.Application.Pages.ChekPage();
            this.userPage1 = new G_Shop.Application.Pages.UserPage();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.buttonProducts);
            this.panel1.Controls.Add(this.buttonChek);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 572);
            this.panel1.TabIndex = 1;
            // 
            // buttonProducts
            // 
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProducts.ForeColor = System.Drawing.Color.Black;
            this.buttonProducts.Image = global::G_Shop.Application.Properties.Resources.Trolley_25;
            this.buttonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.Location = new System.Drawing.Point(21, 13);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(216, 66);
            this.buttonProducts.TabIndex = 6;
            this.buttonProducts.Text = "                Products";
            this.buttonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Visible = false;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonChek
            // 
            this.buttonChek.FlatAppearance.BorderSize = 0;
            this.buttonChek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChek.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChek.ForeColor = System.Drawing.Color.Black;
            this.buttonChek.Image = global::G_Shop.Application.Properties.Resources.Label_printer_25;
            this.buttonChek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChek.Location = new System.Drawing.Point(21, 86);
            this.buttonChek.Name = "buttonChek";
            this.buttonChek.Size = new System.Drawing.Size(216, 66);
            this.buttonChek.TabIndex = 5;
            this.buttonChek.Text = "                Chek";
            this.buttonChek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChek.UseVisualStyleBackColor = true;
            this.buttonChek.Visible = false;
            this.buttonChek.Click += new System.EventHandler(this.buttonChek_Click);
            // 
            // productsPage1
            // 
            this.productsPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(189)))), ((int)(((byte)(125)))));
            this.productsPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsPage1.Location = new System.Drawing.Point(242, 0);
            this.productsPage1.Name = "productsPage1";
            this.productsPage1.Size = new System.Drawing.Size(833, 572);
            this.productsPage1.TabIndex = 2;
            // 
            // chekPage1
            // 
            this.chekPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chekPage1.Location = new System.Drawing.Point(0, 0);
            this.chekPage1.Name = "chekPage1";
            this.chekPage1.Size = new System.Drawing.Size(1075, 572);
            this.chekPage1.TabIndex = 3;
            // 
            // userPage1
            // 
            this.userPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(189)))), ((int)(((byte)(125)))));
            this.userPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPage1.Location = new System.Drawing.Point(242, 0);
            this.userPage1.Name = "userPage1";
            this.userPage1.Size = new System.Drawing.Size(833, 572);
            this.userPage1.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 572);
            this.Controls.Add(this.userPage1);
            this.Controls.Add(this.productsPage1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chekPage1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button buttonProducts;
        private Button buttonChek;
        private Pages.ProductsPage productsPage1;
        private Pages.ChekPage chekPage1;
        private Pages.UserPage userPage1;
    }
}