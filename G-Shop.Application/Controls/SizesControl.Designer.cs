namespace G_Shop.Application.Controls
{
    partial class SizesControl
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
            this.panelSizes = new System.Windows.Forms.Panel();
            this.radioButtonXXXL = new System.Windows.Forms.RadioButton();
            this.radioButtonL = new System.Windows.Forms.RadioButton();
            this.radioButtonS = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonXXL = new System.Windows.Forms.RadioButton();
            this.radioButtonXS = new System.Windows.Forms.RadioButton();
            this.radioButtonXL = new System.Windows.Forms.RadioButton();
            this.panelSizes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSizes
            // 
            this.panelSizes.AutoScroll = true;
            this.panelSizes.Controls.Add(this.radioButtonXXXL);
            this.panelSizes.Controls.Add(this.radioButtonL);
            this.panelSizes.Controls.Add(this.radioButtonS);
            this.panelSizes.Controls.Add(this.radioButtonM);
            this.panelSizes.Controls.Add(this.radioButtonXXL);
            this.panelSizes.Controls.Add(this.radioButtonXS);
            this.panelSizes.Controls.Add(this.radioButtonXL);
            this.panelSizes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSizes.Location = new System.Drawing.Point(0, 0);
            this.panelSizes.Name = "panelSizes";
            this.panelSizes.Size = new System.Drawing.Size(386, 23);
            this.panelSizes.TabIndex = 17;
            // 
            // radioButtonXXXL
            // 
            this.radioButtonXXXL.AutoSize = true;
            this.radioButtonXXXL.Location = new System.Drawing.Point(329, 2);
            this.radioButtonXXXL.Name = "radioButtonXXXL";
            this.radioButtonXXXL.Size = new System.Drawing.Size(52, 19);
            this.radioButtonXXXL.TabIndex = 13;
            this.radioButtonXXXL.Text = "XXXL";
            this.radioButtonXXXL.UseVisualStyleBackColor = true;
            this.radioButtonXXXL.CheckedChanged += new System.EventHandler(this.RadioButtonXXXL_CheckedChanged);
            // 
            // radioButtonL
            // 
            this.radioButtonL.AutoSize = true;
            this.radioButtonL.Location = new System.Drawing.Point(161, 2);
            this.radioButtonL.Name = "radioButtonL";
            this.radioButtonL.Size = new System.Drawing.Size(31, 19);
            this.radioButtonL.TabIndex = 7;
            this.radioButtonL.Text = "L";
            this.radioButtonL.UseVisualStyleBackColor = true;
            this.radioButtonL.CheckedChanged += new System.EventHandler(this.RadioButtonL_CheckedChanged);
            // 
            // radioButtonS
            // 
            this.radioButtonS.AutoSize = true;
            this.radioButtonS.Location = new System.Drawing.Point(58, 2);
            this.radioButtonS.Name = "radioButtonS";
            this.radioButtonS.Size = new System.Drawing.Size(31, 19);
            this.radioButtonS.TabIndex = 8;
            this.radioButtonS.Text = "S";
            this.radioButtonS.UseVisualStyleBackColor = true;
            this.radioButtonS.CheckedChanged += new System.EventHandler(this.RadioButtonS_CheckedChanged);
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(107, 2);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(36, 19);
            this.radioButtonM.TabIndex = 9;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            this.radioButtonM.CheckedChanged += new System.EventHandler(this.RadioButtonM_CheckedChanged);
            // 
            // radioButtonXXL
            // 
            this.radioButtonXXL.AutoSize = true;
            this.radioButtonXXL.Location = new System.Drawing.Point(266, 2);
            this.radioButtonXXL.Name = "radioButtonXXL";
            this.radioButtonXXL.Size = new System.Drawing.Size(45, 19);
            this.radioButtonXXL.TabIndex = 12;
            this.radioButtonXXL.Text = "XXL";
            this.radioButtonXXL.UseVisualStyleBackColor = true;
            this.radioButtonXXL.CheckedChanged += new System.EventHandler(this.RadioButtonXXL_CheckedChanged);
            // 
            // radioButtonXS
            // 
            this.radioButtonXS.AutoSize = true;
            this.radioButtonXS.Checked = true;
            this.radioButtonXS.Location = new System.Drawing.Point(2, 2);
            this.radioButtonXS.Name = "radioButtonXS";
            this.radioButtonXS.Size = new System.Drawing.Size(38, 19);
            this.radioButtonXS.TabIndex = 10;
            this.radioButtonXS.TabStop = true;
            this.radioButtonXS.Text = "XS";
            this.radioButtonXS.UseVisualStyleBackColor = true;
            this.radioButtonXS.CheckedChanged += new System.EventHandler(this.RadioButtonXS_CheckedChanged);
            // 
            // radioButtonXL
            // 
            this.radioButtonXL.AutoSize = true;
            this.radioButtonXL.Location = new System.Drawing.Point(210, 2);
            this.radioButtonXL.Name = "radioButtonXL";
            this.radioButtonXL.Size = new System.Drawing.Size(38, 19);
            this.radioButtonXL.TabIndex = 11;
            this.radioButtonXL.Text = "XL";
            this.radioButtonXL.UseVisualStyleBackColor = true;
            this.radioButtonXL.CheckedChanged += new System.EventHandler(this.RadioButtonXL_CheckedChanged);
            // 
            // SizesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSizes);
            this.Name = "SizesControl";
            this.Size = new System.Drawing.Size(386, 23);
            this.panelSizes.ResumeLayout(false);
            this.panelSizes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSizes;
        private RadioButton radioButtonXXXL;
        private RadioButton radioButtonL;
        private RadioButton radioButtonS;
        private RadioButton radioButtonM;
        private RadioButton radioButtonXXL;
        private RadioButton radioButtonXS;
        private RadioButton radioButtonXL;
    }
}
