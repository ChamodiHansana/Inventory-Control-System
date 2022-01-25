namespace InventoryManagementSystem
{
    partial class customerModuleForm
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
            this.textBoxPhoneCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddcustomer = new System.Windows.Forms.Button();
            this.btnUpdatecustomer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCId = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(414, 43);
            this.panel1.TabIndex = 22;
            // 
            // applicationCloseButton
            // 
            this.applicationCloseButton.BackColor = System.Drawing.Color.Red;
            this.applicationCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationCloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.applicationCloseButton.Location = new System.Drawing.Point(372, 5);
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
            this.label5.Location = new System.Drawing.Point(138, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Customer Module";
            // 
            // textBoxPhoneCustomer
            // 
            this.textBoxPhoneCustomer.Location = new System.Drawing.Point(142, 104);
            this.textBoxPhoneCustomer.Name = "textBoxPhoneCustomer";
            this.textBoxPhoneCustomer.Size = new System.Drawing.Size(251, 20);
            this.textBoxPhoneCustomer.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Phone:";
            // 
            // textBoxNameCustomer
            // 
            this.textBoxNameCustomer.Location = new System.Drawing.Point(142, 67);
            this.textBoxNameCustomer.Name = "textBoxNameCustomer";
            this.textBoxNameCustomer.Size = new System.Drawing.Size(251, 20);
            this.textBoxNameCustomer.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name : ";
            // 
            // btnAddcustomer
            // 
            this.btnAddcustomer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddcustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddcustomer.Location = new System.Drawing.Point(113, 150);
            this.btnAddcustomer.Name = "btnAddcustomer";
            this.btnAddcustomer.Size = new System.Drawing.Size(90, 33);
            this.btnAddcustomer.TabIndex = 25;
            this.btnAddcustomer.Text = "Add";
            this.btnAddcustomer.UseVisualStyleBackColor = false;
            this.btnAddcustomer.Click += new System.EventHandler(this.btnAddcustomer_Click);
            // 
            // btnUpdatecustomer
            // 
            this.btnUpdatecustomer.BackColor = System.Drawing.Color.YellowGreen;
            this.btnUpdatecustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdatecustomer.Location = new System.Drawing.Point(209, 150);
            this.btnUpdatecustomer.Name = "btnUpdatecustomer";
            this.btnUpdatecustomer.Size = new System.Drawing.Size(90, 33);
            this.btnUpdatecustomer.TabIndex = 24;
            this.btnUpdatecustomer.Text = "Update";
            this.btnUpdatecustomer.UseVisualStyleBackColor = false;
            this.btnUpdatecustomer.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(305, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 33);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCId
            // 
            this.lblCId.AutoSize = true;
            this.lblCId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCId.Location = new System.Drawing.Point(24, 150);
            this.lblCId.Name = "lblCId";
            this.lblCId.Size = new System.Drawing.Size(0, 20);
            this.lblCId.TabIndex = 26;
            // 
            // customerModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 202);
            this.Controls.Add(this.lblCId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPhoneCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddcustomer);
            this.Controls.Add(this.btnUpdatecustomer);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customerModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button applicationCloseButton;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxPhoneCustomer;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxNameCustomer;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAddcustomer;
        public System.Windows.Forms.Button btnUpdatecustomer;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Label lblCId;
    }
}