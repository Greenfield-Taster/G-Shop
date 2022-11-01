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
            this.productsPage1 = new G_Shop.Application.Pages.ProductsPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonChek = new System.Windows.Forms.Button();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsPage1
            // 
            this.productsPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(189)))), ((int)(((byte)(125)))));
            this.productsPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsPage1.Location = new System.Drawing.Point(242, 0);
            this.productsPage1.Name = "productsPage1";
            this.productsPage1.Size = new System.Drawing.Size(900, 614);
            this.productsPage1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.buttonProducts);
            this.panel1.Controls.Add(this.buttonChek);
            this.panel1.Controls.Add(this.buttonLogIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 614);
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
            this.buttonProducts.Location = new System.Drawing.Point(21, 118);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(216, 66);
            this.buttonProducts.TabIndex = 6;
            this.buttonProducts.Text = "                Products";
            this.buttonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.UseVisualStyleBackColor = true;
            // 
            // buttonChek
            // 
            this.buttonChek.FlatAppearance.BorderSize = 0;
            this.buttonChek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChek.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChek.ForeColor = System.Drawing.Color.Black;
            this.buttonChek.Image = global::G_Shop.Application.Properties.Resources.Label_printer_25;
            this.buttonChek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChek.Location = new System.Drawing.Point(21, 213);
            this.buttonChek.Name = "buttonChek";
            this.buttonChek.Size = new System.Drawing.Size(216, 66);
            this.buttonChek.TabIndex = 5;
            this.buttonChek.Text = "                Chek";
            this.buttonChek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChek.UseVisualStyleBackColor = true;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.FlatAppearance.BorderSize = 0;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogIn.ForeColor = System.Drawing.Color.Black;
            this.buttonLogIn.Image = global::G_Shop.Application.Properties.Resources.User_menu_male_25;
            this.buttonLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogIn.Location = new System.Drawing.Point(21, 32);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(216, 66);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "                Log in";
            this.buttonLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogIn.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 614);
            this.Controls.Add(this.productsPage1);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Pages.ProductsPage productsPage1;
        private Panel panel1;
        private Button buttonProducts;
        private Button buttonChek;
        private Button buttonLogIn;
    }
}