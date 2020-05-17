namespace library.application.forms {
    partial class LendingForm {
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
            this.landingFormButton = new System.Windows.Forms.Button();
            this.customerPickerOpenButton = new System.Windows.Forms.Button();
            this.returnDatePicker = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeSet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerInformation = new System.Windows.Forms.TextBox();
            this.submitLendingButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bookSet = new System.Windows.Forms.DataGridView();
            this.bookQueryInput = new System.Windows.Forms.TextBox();
            this.itemSet = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.itemRemoveButton = new System.Windows.Forms.Button();
            this.returnDatePicker.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(138, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lending";
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
            this.landingFormLabel.TabIndex = 9;
            this.landingFormLabel.Text = "eLibrarian";
            this.landingFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.landingFormLabel.Click += new System.EventHandler(this.landingFormLabel_Click);
            // 
            // landingFormButton
            // 
            this.landingFormButton.BackColor = System.Drawing.Color.White;
            this.landingFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.landingFormButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.landingFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.landingFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landingFormButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.landingFormButton.Location = new System.Drawing.Point(611, 10);
            this.landingFormButton.Name = "landingFormButton";
            this.landingFormButton.Size = new System.Drawing.Size(96, 43);
            this.landingFormButton.TabIndex = 7;
            this.landingFormButton.Text = "Back";
            this.landingFormButton.UseVisualStyleBackColor = false;
            this.landingFormButton.Click += new System.EventHandler(this.landingFormButton_Click);
            // 
            // customerPickerOpenButton
            // 
            this.customerPickerOpenButton.BackColor = System.Drawing.Color.White;
            this.customerPickerOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerPickerOpenButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.customerPickerOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerPickerOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPickerOpenButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.customerPickerOpenButton.Location = new System.Drawing.Point(272, 34);
            this.customerPickerOpenButton.Name = "customerPickerOpenButton";
            this.customerPickerOpenButton.Size = new System.Drawing.Size(64, 29);
            this.customerPickerOpenButton.TabIndex = 11;
            this.customerPickerOpenButton.Text = "Select";
            this.customerPickerOpenButton.UseVisualStyleBackColor = false;
            this.customerPickerOpenButton.Click += new System.EventHandler(this.customerPickerOpenButton_Click);
            // 
            // returnDatePicker
            // 
            this.returnDatePicker.Controls.Add(this.dateTimePicker1);
            this.returnDatePicker.Controls.Add(this.label4);
            this.returnDatePicker.Controls.Add(this.employeeSet);
            this.returnDatePicker.Controls.Add(this.label3);
            this.returnDatePicker.Controls.Add(this.label1);
            this.returnDatePicker.Controls.Add(this.customerInformation);
            this.returnDatePicker.Controls.Add(this.customerPickerOpenButton);
            this.returnDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDatePicker.Location = new System.Drawing.Point(12, 54);
            this.returnDatePicker.Name = "returnDatePicker";
            this.returnDatePicker.Size = new System.Drawing.Size(695, 127);
            this.returnDatePicker.TabIndex = 12;
            this.returnDatePicker.TabStop = false;
            this.returnDatePicker.Text = "Mandatories";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(326, 29);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(360, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Return date";
            // 
            // employeeSet
            // 
            this.employeeSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.employeeSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSet.FormattingEnabled = true;
            this.employeeSet.Location = new System.Drawing.Point(6, 84);
            this.employeeSet.Name = "employeeSet";
            this.employeeSet.Size = new System.Drawing.Size(330, 32);
            this.employeeSet.TabIndex = 13;
            this.employeeSet.SelectedIndexChanged += new System.EventHandler(this.employeeSet_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer";
            // 
            // customerInformation
            // 
            this.customerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformation.Location = new System.Drawing.Point(9, 34);
            this.customerInformation.Name = "customerInformation";
            this.customerInformation.ReadOnly = true;
            this.customerInformation.Size = new System.Drawing.Size(257, 29);
            this.customerInformation.TabIndex = 0;
            // 
            // submitLendingButton
            // 
            this.submitLendingButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitLendingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitLendingButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submitLendingButton.FlatAppearance.BorderSize = 0;
            this.submitLendingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitLendingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitLendingButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.submitLendingButton.Location = new System.Drawing.Point(12, 516);
            this.submitLendingButton.Name = "submitLendingButton";
            this.submitLendingButton.Size = new System.Drawing.Size(120, 43);
            this.submitLendingButton.TabIndex = 14;
            this.submitLendingButton.Text = "Submit Lending";
            this.submitLendingButton.UseVisualStyleBackColor = false;
            this.submitLendingButton.Click += new System.EventHandler(this.submitLendingButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bookSet);
            this.panel1.Controls.Add(this.bookQueryInput);
            this.panel1.Location = new System.Drawing.Point(12, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 323);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(5, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Search";
            // 
            // bookSet
            // 
            this.bookSet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookSet.Location = new System.Drawing.Point(5, 35);
            this.bookSet.MultiSelect = false;
            this.bookSet.Name = "bookSet";
            this.bookSet.ReadOnly = true;
            this.bookSet.RowHeadersWidth = 30;
            this.bookSet.Size = new System.Drawing.Size(423, 285);
            this.bookSet.TabIndex = 17;
            this.bookSet.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bookSet_RowHeaderMouseDoubleClick);
            // 
            // bookQueryInput
            // 
            this.bookQueryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookQueryInput.Location = new System.Drawing.Point(77, 3);
            this.bookQueryInput.Name = "bookQueryInput";
            this.bookQueryInput.Size = new System.Drawing.Size(351, 29);
            this.bookQueryInput.TabIndex = 18;
            this.bookQueryInput.TextChanged += new System.EventHandler(this.bookQueryInput_TextChanged);
            // 
            // itemSet
            // 
            this.itemSet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemSet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.itemSet.Location = new System.Drawing.Point(446, 190);
            this.itemSet.Name = "itemSet";
            this.itemSet.RowHeadersWidth = 30;
            this.itemSet.Size = new System.Drawing.Size(261, 282);
            this.itemSet.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button3.Location = new System.Drawing.Point(638, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.itemSetClearButton_Click);
            // 
            // itemRemoveButton
            // 
            this.itemRemoveButton.BackColor = System.Drawing.Color.White;
            this.itemRemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemRemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.itemRemoveButton.FlatAppearance.BorderSize = 0;
            this.itemRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemRemoveButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.itemRemoveButton.Location = new System.Drawing.Point(563, 478);
            this.itemRemoveButton.Name = "itemRemoveButton";
            this.itemRemoveButton.Size = new System.Drawing.Size(69, 32);
            this.itemRemoveButton.TabIndex = 21;
            this.itemRemoveButton.Text = "Remove";
            this.itemRemoveButton.UseVisualStyleBackColor = false;
            this.itemRemoveButton.Click += new System.EventHandler(this.itemRemoveButton_Click);
            // 
            // LendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 567);
            this.Controls.Add(this.itemRemoveButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.itemSet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.submitLendingButton);
            this.Controls.Add(this.returnDatePicker);
            this.Controls.Add(this.landingFormButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.landingFormLabel);
            this.Name = "LendingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LendingForm_Load);
            this.returnDatePicker.ResumeLayout(false);
            this.returnDatePicker.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label landingFormLabel;
        private System.Windows.Forms.Button landingFormButton;
        private System.Windows.Forms.Button customerPickerOpenButton;
        private System.Windows.Forms.GroupBox returnDatePicker;
        private System.Windows.Forms.TextBox customerInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox employeeSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button submitLendingButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView bookSet;
        private System.Windows.Forms.TextBox bookQueryInput;
        private System.Windows.Forms.DataGridView itemSet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button itemRemoveButton;
    }
}