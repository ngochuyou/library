namespace library.application.forms {
    partial class CustomerForm {
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
            System.Windows.Forms.GroupBox groupBox1;
            this.customerModelexpiredDateInput = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.customerModelEmailInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerModelAddressInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerModelDobInput = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.customerModelFullnameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.landingFormLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customerSet = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customerModelAddButton = new System.Windows.Forms.Button();
            this.customerModelRemoveButton = new System.Windows.Forms.Button();
            this.customerModelEditButton = new System.Windows.Forms.Button();
            this.returnToDashboardButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.customerModelexpiredDateInput);
            groupBox1.Controls.Add(this.label6);
            groupBox1.Controls.Add(this.customerModelEmailInput);
            groupBox1.Controls.Add(this.label5);
            groupBox1.Controls.Add(this.customerModelAddressInput);
            groupBox1.Controls.Add(this.label4);
            groupBox1.Controls.Add(this.customerModelDobInput);
            groupBox1.Controls.Add(this.label3);
            groupBox1.Controls.Add(this.customerModelFullnameInput);
            groupBox1.Controls.Add(this.label1);
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(690, 127);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Informations";
            // 
            // customerModelexpiredDateInput
            // 
            this.customerModelexpiredDateInput.Location = new System.Drawing.Point(421, 57);
            this.customerModelexpiredDateInput.Name = "customerModelexpiredDateInput";
            this.customerModelexpiredDateInput.Size = new System.Drawing.Size(263, 21);
            this.customerModelexpiredDateInput.TabIndex = 10;
            this.customerModelexpiredDateInput.ValueChanged += new System.EventHandler(this.customerModelexpiredDateInput_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Expiry Date";
            // 
            // customerModelEmailInput
            // 
            this.customerModelEmailInput.Location = new System.Drawing.Point(421, 25);
            this.customerModelEmailInput.Name = "customerModelEmailInput";
            this.customerModelEmailInput.Size = new System.Drawing.Size(263, 21);
            this.customerModelEmailInput.TabIndex = 9;
            this.customerModelEmailInput.TextChanged += new System.EventHandler(this.customerModelEmailInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // customerModelAddressInput
            // 
            this.customerModelAddressInput.Location = new System.Drawing.Point(75, 89);
            this.customerModelAddressInput.Name = "customerModelAddressInput";
            this.customerModelAddressInput.Size = new System.Drawing.Size(263, 21);
            this.customerModelAddressInput.TabIndex = 7;
            this.customerModelAddressInput.TextChanged += new System.EventHandler(this.customerModelAddressInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // customerModelDobInput
            // 
            this.customerModelDobInput.Location = new System.Drawing.Point(75, 57);
            this.customerModelDobInput.Name = "customerModelDobInput";
            this.customerModelDobInput.Size = new System.Drawing.Size(263, 21);
            this.customerModelDobInput.TabIndex = 2;
            this.customerModelDobInput.ValueChanged += new System.EventHandler(this.customerModelDobInput_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "DOB";
            // 
            // customerModelFullnameInput
            // 
            this.customerModelFullnameInput.Location = new System.Drawing.Point(75, 25);
            this.customerModelFullnameInput.Name = "customerModelFullnameInput";
            this.customerModelFullnameInput.Size = new System.Drawing.Size(263, 21);
            this.customerModelFullnameInput.TabIndex = 5;
            this.customerModelFullnameInput.TextChanged += new System.EventHandler(this.customerModelFullnameInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fullname";
            // 
            // landingFormLabel
            // 
            this.landingFormLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.landingFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landingFormLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.landingFormLabel.Location = new System.Drawing.Point(12, 9);
            this.landingFormLabel.Name = "landingFormLabel";
            this.landingFormLabel.Size = new System.Drawing.Size(120, 38);
            this.landingFormLabel.TabIndex = 5;
            this.landingFormLabel.Text = "eLibrarian";
            this.landingFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.landingFormLabel.Click += new System.EventHandler(this.landingFormLabel_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(138, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(groupBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 457);
            this.panel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customerSet);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 241);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General Informations";
            // 
            // customerSet
            // 
            this.customerSet.AllowUserToAddRows = false;
            this.customerSet.AllowUserToDeleteRows = false;
            this.customerSet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerSet.GridColor = System.Drawing.SystemColors.ControlLight;
            this.customerSet.Location = new System.Drawing.Point(3, 20);
            this.customerSet.Name = "customerSet";
            this.customerSet.ReadOnly = true;
            this.customerSet.Size = new System.Drawing.Size(681, 215);
            this.customerSet.TabIndex = 0;
            this.customerSet.SelectionChanged += new System.EventHandler(this.customerSet_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customerModelAddButton);
            this.panel2.Controls.Add(this.customerModelRemoveButton);
            this.panel2.Controls.Add(this.customerModelEditButton);
            this.panel2.Controls.Add(this.returnToDashboardButton);
            this.panel2.Location = new System.Drawing.Point(3, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 71);
            this.panel2.TabIndex = 2;
            // 
            // customerModelAddButton
            // 
            this.customerModelAddButton.BackColor = System.Drawing.Color.White;
            this.customerModelAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerModelAddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.customerModelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerModelAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerModelAddButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.customerModelAddButton.Location = new System.Drawing.Point(282, 15);
            this.customerModelAddButton.Name = "customerModelAddButton";
            this.customerModelAddButton.Size = new System.Drawing.Size(96, 43);
            this.customerModelAddButton.TabIndex = 5;
            this.customerModelAddButton.Text = "Add";
            this.customerModelAddButton.UseVisualStyleBackColor = false;
            this.customerModelAddButton.Click += new System.EventHandler(this.customerModelAddButton_Click);
            // 
            // customerModelRemoveButton
            // 
            this.customerModelRemoveButton.BackColor = System.Drawing.Color.White;
            this.customerModelRemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerModelRemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.customerModelRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerModelRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerModelRemoveButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.customerModelRemoveButton.Location = new System.Drawing.Point(384, 15);
            this.customerModelRemoveButton.Name = "customerModelRemoveButton";
            this.customerModelRemoveButton.Size = new System.Drawing.Size(96, 43);
            this.customerModelRemoveButton.TabIndex = 4;
            this.customerModelRemoveButton.Text = "Remove";
            this.customerModelRemoveButton.UseVisualStyleBackColor = false;
            this.customerModelRemoveButton.Click += new System.EventHandler(this.customerModelRemoveButton_Click);
            // 
            // customerModelEditButton
            // 
            this.customerModelEditButton.BackColor = System.Drawing.Color.White;
            this.customerModelEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerModelEditButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.customerModelEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerModelEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerModelEditButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.customerModelEditButton.Location = new System.Drawing.Point(486, 15);
            this.customerModelEditButton.Name = "customerModelEditButton";
            this.customerModelEditButton.Size = new System.Drawing.Size(96, 43);
            this.customerModelEditButton.TabIndex = 3;
            this.customerModelEditButton.Text = "Edit";
            this.customerModelEditButton.UseVisualStyleBackColor = false;
            this.customerModelEditButton.Click += new System.EventHandler(this.customerModelEditButton_Click);
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
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.landingFormLabel);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label landingFormLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerModelFullnameInput;
        private System.Windows.Forms.DateTimePicker customerModelDobInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerModelAddressInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerModelEmailInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker customerModelexpiredDateInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button customerModelAddButton;
        private System.Windows.Forms.Button customerModelRemoveButton;
        private System.Windows.Forms.Button customerModelEditButton;
        private System.Windows.Forms.Button returnToDashboardButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView customerSet;
    }
}