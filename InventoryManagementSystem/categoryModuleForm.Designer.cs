namespace InventoryManagementSystem
{
    partial class categoryModuleForm
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
            this.applicationCloseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNameCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddcategory = new System.Windows.Forms.Button();
            this.btnUpdatecategory = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.category_id_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.applicationCloseButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 43);
            this.panel1.TabIndex = 22;
            // 
            // applicationCloseButton
            // 
            this.applicationCloseButton.BackColor = System.Drawing.Color.Red;
            this.applicationCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationCloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.applicationCloseButton.Location = new System.Drawing.Point(381, 5);
            this.applicationCloseButton.Name = "applicationCloseButton";
            this.applicationCloseButton.Size = new System.Drawing.Size(30, 30);
            this.applicationCloseButton.TabIndex = 12;
            this.applicationCloseButton.Text = "X";
            this.applicationCloseButton.UseVisualStyleBackColor = false;
            this.applicationCloseButton.Click += new System.EventHandler(this.applicationCloseButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(146, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Category Module";
            // 
            // textBoxNameCategory
            // 
            this.textBoxNameCategory.Location = new System.Drawing.Point(137, 84);
            this.textBoxNameCategory.Name = "textBoxNameCategory";
            this.textBoxNameCategory.Size = new System.Drawing.Size(251, 20);
            this.textBoxNameCategory.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name : ";
            // 
            // btnAddcategory
            // 
            this.btnAddcategory.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddcategory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddcategory.Location = new System.Drawing.Point(97, 149);
            this.btnAddcategory.Name = "btnAddcategory";
            this.btnAddcategory.Size = new System.Drawing.Size(90, 36);
            this.btnAddcategory.TabIndex = 25;
            this.btnAddcategory.Text = "Add";
            this.btnAddcategory.UseVisualStyleBackColor = false;
            this.btnAddcategory.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdatecategory
            // 
            this.btnUpdatecategory.BackColor = System.Drawing.Color.YellowGreen;
            this.btnUpdatecategory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdatecategory.Location = new System.Drawing.Point(200, 149);
            this.btnUpdatecategory.Name = "btnUpdatecategory";
            this.btnUpdatecategory.Size = new System.Drawing.Size(90, 36);
            this.btnUpdatecategory.TabIndex = 24;
            this.btnUpdatecategory.Text = "Update";
            this.btnUpdatecategory.UseVisualStyleBackColor = false;
            this.btnUpdatecategory.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(298, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 36);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // category_id_label
            // 
            this.category_id_label.AutoSize = true;
            this.category_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_id_label.ForeColor = System.Drawing.SystemColors.Control;
            this.category_id_label.Location = new System.Drawing.Point(19, 114);
            this.category_id_label.Name = "category_id_label";
            this.category_id_label.Size = new System.Drawing.Size(0, 20);
            this.category_id_label.TabIndex = 26;
            // 
            // categoryModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 204);
            this.Controls.Add(this.category_id_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxNameCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddcategory);
            this.Controls.Add(this.btnUpdatecategory);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoryModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoryModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button applicationCloseButton;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxNameCategory;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAddcategory;
        public System.Windows.Forms.Button btnUpdatecategory;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Label category_id_label;
    }
}