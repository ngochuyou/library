namespace library.application.forms {
    partial class EmployeeForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label2 = new System.Windows.Forms.Label();
            this.landingFormLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeModelFullnameInput = new System.Windows.Forms.TextBox();
            this.employeeModelAddressInput = new System.Windows.Forms.TextBox();
            this.employeeModelPhoneInput = new System.Windows.Forms.TextBox();
            this.employeeModelDobInput = new System.Windows.Forms.DateTimePicker();
            this.employeeModelTitleComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.returnToDashboardButton = new System.Windows.Forms.Button();
            this.employeeModelEditButton = new System.Windows.Forms.Button();
            this.employeeModelRemoveButton = new System.Windows.Forms.Button();
            this.employeeModelAddButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.employeesSet = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(138, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // landingFormLabel
            // 
            this.landingFormLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.landingFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landingFormLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.landingFormLabel.Location = new System.Drawing.Point(12, 9);
            this.landingFormLabel.Name = "landingFormLabel";
            this.landingFormLabel.Size = new System.Drawing.Size(120, 38);
            this.landingFormLabel.TabIndex = 4;
            this.landingFormLabel.Text = "eLibrarian";
            this.landingFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.landingFormLabel.Click += new System.EventHandler(this.landingFormLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeModelTitleComboBox);
            this.groupBox1.Controls.Add(this.employeeModelDobInput);
            this.groupBox1.Controls.Add(this.employeeModelPhoneInput);
            this.groupBox1.Controls.Add(this.employeeModelAddressInput);
            this.groupBox1.Controls.Add(this.employeeModelFullnameInput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Informations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fullname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Title";
            // 
            // employeeModelFullnameInput
            // 
            this.employeeModelFullnameInput.Location = new System.Drawing.Point(75, 25);
            this.employeeModelFullnameInput.Name = "employeeModelFullnameInput";
            this.employeeModelFullnameInput.Size = new System.Drawing.Size(263, 21);
            this.employeeModelFullnameInput.TabIndex = 4;
            this.employeeModelFullnameInput.TextChanged += new System.EventHandler(this.employeeModelFullnameInput_TextChanged);
            // 
            // employeeModelAddressInput
            // 
            this.employeeModelAddressInput.Location = new System.Drawing.Point(75, 89);
            this.employeeModelAddressInput.Name = "employeeModelAddressInput";
            this.employeeModelAddressInput.Size = new System.Drawing.Size(263, 21);
            this.employeeModelAddressInput.TabIndex = 5;
            this.employeeModelAddressInput.TextChanged += new System.EventHandler(this.employeeModelAddressInput_TextChanged);
            // 
            // employeeModelPhoneInput
            // 
            this.employeeModelPhoneInput.Location = new System.Drawing.Point(421, 25);
            this.employeeModelPhoneInput.Name = "employeeModelPhoneInput";
            this.employeeModelPhoneInput.Size = new System.Drawing.Size(263, 21);
            this.employeeModelPhoneInput.TabIndex = 6;
            this.employeeModelPhoneInput.TextChanged += new System.EventHandler(this.employeeModelPhoneInput_TextChanged);
            // 
            // employeeModelDobInput
            // 
            this.employeeModelDobInput.Location = new System.Drawing.Point(75, 57);
            this.employeeModelDobInput.Name = "employeeModelDobInput";
            this.employeeModelDobInput.Size = new System.Drawing.Size(263, 21);
            this.employeeModelDobInput.TabIndex = 1;
            this.employeeModelDobInput.ValueChanged += new System.EventHandler(this.employeeModelDobInput_ValueChanged);
            // 
            // employeeModelTitleComboBox
            // 
            this.employeeModelTitleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeModelTitleComboBox.FormattingEnabled = true;
            this.employeeModelTitleComboBox.Location = new System.Drawing.Point(421, 55);
            this.employeeModelTitleComboBox.Name = "employeeModelTitleComboBox";
            this.employeeModelTitleComboBox.Size = new System.Drawing.Size(263, 23);
            this.employeeModelTitleComboBox.TabIndex = 1;
            this.employeeModelTitleComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeModelTitleComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.employeeModelAddButton);
            this.panel2.Controls.Add(this.employeeModelRemoveButton);
            this.panel2.Controls.Add(this.employeeModelEditButton);
            this.panel2.Controls.Add(this.returnToDashboardButton);
            this.panel2.Location = new System.Drawing.Point(3, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 71);
            this.panel2.TabIndex = 1;
            // 
            // returnToDashboardButton
            // 
            this.returnToDashboardButton.BackColor = System.Drawing.Color.White;
            this.returnToDashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnToDashboardButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returnToDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnToDashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToDashboardButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.returnToDashboardButton.Location = new System.Drawing.Point(588, 15);
            this.returnToDashboardButton.Name = "returnToDashboardButton";
            this.returnToDashboardButton.Size = new System.Drawing.Size(96, 43);
            this.returnToDashboardButton.TabIndex = 1;
            this.returnToDashboardButton.Text = "Quit";
            this.returnToDashboardButton.UseVisualStyleBackColor = false;
            this.returnToDashboardButton.Click += new System.EventHandler(this.returnToDashboardButton_Click);
            // 
            // employeeModelEditButton
            // 
            this.employeeModelEditButton.BackColor = System.Drawing.Color.White;
            this.employeeModelEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeModelEditButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.employeeModelEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeModelEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeModelEditButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.employeeModelEditButton.Location = new System.Drawing.Point(486, 15);
            this.employeeModelEditButton.Name = "employeeModelEditButton";
            this.employeeModelEditButton.Size = new System.Drawing.Size(96, 43);
            this.employeeModelEditButton.TabIndex = 3;
            this.employeeModelEditButton.Text = "Edit";
            this.employeeModelEditButton.UseVisualStyleBackColor = false;
            this.employeeModelEditButton.Click += new System.EventHandler(this.employeeModelEditButton_Click);
            // 
            // employeeModelRemoveButton
            // 
            this.employeeModelRemoveButton.BackColor = System.Drawing.Color.White;
            this.employeeModelRemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeModelRemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.employeeModelRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeModelRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeModelRemoveButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.employeeModelRemoveButton.Location = new System.Drawing.Point(384, 15);
            this.employeeModelRemoveButton.Name = "employeeModelRemoveButton";
            this.employeeModelRemoveButton.Size = new System.Drawing.Size(96, 43);
            this.employeeModelRemoveButton.TabIndex = 4;
            this.employeeModelRemoveButton.Text = "Remove";
            this.employeeModelRemoveButton.UseVisualStyleBackColor = false;
            this.employeeModelRemoveButton.Click += new System.EventHandler(this.employeeModelRemoveButton_Click);
            // 
            // employeeModelAddButton
            // 
            this.employeeModelAddButton.BackColor = System.Drawing.Color.White;
            this.employeeModelAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeModelAddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.employeeModelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeModelAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeModelAddButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.employeeModelAddButton.Location = new System.Drawing.Point(282, 15);
            this.employeeModelAddButton.Name = "employeeModelAddButton";
            this.employeeModelAddButton.Size = new System.Drawing.Size(96, 43);
            this.employeeModelAddButton.TabIndex = 5;
            this.employeeModelAddButton.Text = "Add";
            this.employeeModelAddButton.UseVisualStyleBackColor = false;
            this.employeeModelAddButton.Click += new System.EventHandler(this.employeeModelAddButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.employeesSet);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General Informations";
            // 
            // employeesSet
            // 
            this.employeesSet.AllowUserToAddRows = false;
            this.employeesSet.AllowUserToDeleteRows = false;
            this.employeesSet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeesSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesSet.GridColor = System.Drawing.SystemColors.ControlLight;
            this.employeesSet.Location = new System.Drawing.Point(3, 20);
            this.employeesSet.Name = "employeesSet";
            this.employeesSet.ReadOnly = true;
            this.employeesSet.Size = new System.Drawing.Size(681, 215);
            this.employeesSet.TabIndex = 0;
            this.employeesSet.SelectionChanged += new System.EventHandler(this.employeesSet_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(11, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 457);
            this.panel1.TabIndex = 6;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.landingFormLabel);
            this.Name = "EmployeeForm";
            this.Text = "eLibrarian - Employee";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label landingFormLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox employeeModelTitleComboBox;
        private System.Windows.Forms.DateTimePicker employeeModelDobInput;
        private System.Windows.Forms.TextBox employeeModelPhoneInput;
        private System.Windows.Forms.TextBox employeeModelAddressInput;
        private System.Windows.Forms.TextBox employeeModelFullnameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button employeeModelAddButton;
        private System.Windows.Forms.Button employeeModelRemoveButton;
        private System.Windows.Forms.Button employeeModelEditButton;
        private System.Windows.Forms.Button returnToDashboardButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView employeesSet;
        private System.Windows.Forms.Panel panel1;
    }
}