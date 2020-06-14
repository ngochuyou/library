namespace library.application.forms {
    partial class BookForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bookModelPriceInput = new System.Windows.Forms.NumericUpDown();
            this.bookModelPublisherInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bookModelStockedDateInput = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.bookModelPublishedDateInput = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.bookModelAuthorInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookModelNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookSet = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookModelAddButton = new System.Windows.Forms.Button();
            this.bookModelRemoveButton = new System.Windows.Forms.Button();
            this.bookModelEditButton = new System.Windows.Forms.Button();
            this.returnToDashboardButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookModelPriceInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(138, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Book Management";
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
            this.landingFormLabel.TabIndex = 7;
            this.landingFormLabel.Text = "eLibrarian";
            this.landingFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.landingFormLabel.Click += new System.EventHandler(this.landingFormLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(11, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 457);
            this.panel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bookModelPriceInput);
            this.groupBox2.Controls.Add(this.bookModelPublisherInput);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.bookModelStockedDateInput);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bookModelPublishedDateInput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bookModelAuthorInput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bookModelNameInput);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 127);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Informations";
            // 
            // bookModelPriceInput
            // 
            this.bookModelPriceInput.Location = new System.Drawing.Point(421, 25);
            this.bookModelPriceInput.Name = "bookModelPriceInput";
            this.bookModelPriceInput.Size = new System.Drawing.Size(263, 21);
            this.bookModelPriceInput.TabIndex = 6;
            this.bookModelPriceInput.ValueChanged += new System.EventHandler(this.bookModelPriceInput_ValueChanged);
            // 
            // bookModelPublisherInput
            // 
            this.bookModelPublisherInput.Location = new System.Drawing.Point(421, 57);
            this.bookModelPublisherInput.Name = "bookModelPublisherInput";
            this.bookModelPublisherInput.Size = new System.Drawing.Size(263, 21);
            this.bookModelPublisherInput.TabIndex = 16;
            this.bookModelPublisherInput.TextChanged += new System.EventHandler(this.bookModelPublisherInput_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Publisher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price";
            // 
            // bookModelStockedDateInput
            // 
            this.bookModelStockedDateInput.Location = new System.Drawing.Point(421, 89);
            this.bookModelStockedDateInput.Name = "bookModelStockedDateInput";
            this.bookModelStockedDateInput.Size = new System.Drawing.Size(263, 21);
            this.bookModelStockedDateInput.TabIndex = 11;
            this.bookModelStockedDateInput.ValueChanged += new System.EventHandler(this.bookModelStockedDateInput_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stocked date";
            // 
            // bookModelPublishedDateInput
            // 
            this.bookModelPublishedDateInput.Location = new System.Drawing.Point(75, 89);
            this.bookModelPublishedDateInput.Name = "bookModelPublishedDateInput";
            this.bookModelPublishedDateInput.Size = new System.Drawing.Size(263, 21);
            this.bookModelPublishedDateInput.TabIndex = 9;
            this.bookModelPublishedDateInput.ValueChanged += new System.EventHandler(this.bookModelPublishedDateInput_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publish date";
            // 
            // bookModelAuthorInput
            // 
            this.bookModelAuthorInput.Location = new System.Drawing.Point(75, 57);
            this.bookModelAuthorInput.Name = "bookModelAuthorInput";
            this.bookModelAuthorInput.Size = new System.Drawing.Size(263, 21);
            this.bookModelAuthorInput.TabIndex = 8;
            this.bookModelAuthorInput.TextChanged += new System.EventHandler(this.bookModelAuthorInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author";
            // 
            // bookModelNameInput
            // 
            this.bookModelNameInput.Location = new System.Drawing.Point(75, 25);
            this.bookModelNameInput.Name = "bookModelNameInput";
            this.bookModelNameInput.Size = new System.Drawing.Size(263, 21);
            this.bookModelNameInput.TabIndex = 6;
            this.bookModelNameInput.TextChanged += new System.EventHandler(this.bookModelNameInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookSet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 241);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Informations";
            // 
            // bookSet
            // 
            this.bookSet.AllowUserToAddRows = false;
            this.bookSet.AllowUserToDeleteRows = false;
            this.bookSet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookSet.GridColor = System.Drawing.SystemColors.ControlLight;
            this.bookSet.Location = new System.Drawing.Point(3, 20);
            this.bookSet.MultiSelect = false;
            this.bookSet.Name = "bookSet";
            this.bookSet.ReadOnly = true;
            this.bookSet.Size = new System.Drawing.Size(681, 215);
            this.bookSet.TabIndex = 5;
            this.bookSet.SelectionChanged += new System.EventHandler(this.bookSet_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bookModelAddButton);
            this.panel2.Controls.Add(this.bookModelRemoveButton);
            this.panel2.Controls.Add(this.bookModelEditButton);
            this.panel2.Controls.Add(this.returnToDashboardButton);
            this.panel2.Location = new System.Drawing.Point(3, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 71);
            this.panel2.TabIndex = 3;
            // 
            // bookModelAddButton
            // 
            this.bookModelAddButton.BackColor = System.Drawing.Color.White;
            this.bookModelAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookModelAddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bookModelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookModelAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookModelAddButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bookModelAddButton.Location = new System.Drawing.Point(282, 15);
            this.bookModelAddButton.Name = "bookModelAddButton";
            this.bookModelAddButton.Size = new System.Drawing.Size(96, 43);
            this.bookModelAddButton.TabIndex = 5;
            this.bookModelAddButton.Text = "Add";
            this.bookModelAddButton.UseVisualStyleBackColor = false;
            this.bookModelAddButton.Click += new System.EventHandler(this.bookModelAddButton_Click);
            // 
            // bookModelRemoveButton
            // 
            this.bookModelRemoveButton.BackColor = System.Drawing.Color.White;
            this.bookModelRemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookModelRemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bookModelRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookModelRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookModelRemoveButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bookModelRemoveButton.Location = new System.Drawing.Point(384, 15);
            this.bookModelRemoveButton.Name = "bookModelRemoveButton";
            this.bookModelRemoveButton.Size = new System.Drawing.Size(96, 43);
            this.bookModelRemoveButton.TabIndex = 4;
            this.bookModelRemoveButton.Text = "Remove";
            this.bookModelRemoveButton.UseVisualStyleBackColor = false;
            this.bookModelRemoveButton.Click += new System.EventHandler(this.bookModelRemoveButton_Click);
            // 
            // bookModelEditButton
            // 
            this.bookModelEditButton.BackColor = System.Drawing.Color.White;
            this.bookModelEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookModelEditButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bookModelEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookModelEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookModelEditButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bookModelEditButton.Location = new System.Drawing.Point(486, 15);
            this.bookModelEditButton.Name = "bookModelEditButton";
            this.bookModelEditButton.Size = new System.Drawing.Size(96, 43);
            this.bookModelEditButton.TabIndex = 3;
            this.bookModelEditButton.Text = "Edit";
            this.bookModelEditButton.UseVisualStyleBackColor = false;
            this.bookModelEditButton.Click += new System.EventHandler(this.bookModelEditButton_Click);
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
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.landingFormLabel);
            this.Location = new System.Drawing.Point(3, 136);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookModelPriceInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label landingFormLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bookModelAddButton;
        private System.Windows.Forms.Button bookModelRemoveButton;
        private System.Windows.Forms.Button bookModelEditButton;
        private System.Windows.Forms.Button returnToDashboardButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView bookSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookModelNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookModelAuthorInput;
        private System.Windows.Forms.DateTimePicker bookModelPublishedDateInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker bookModelStockedDateInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bookModelPublisherInput;
        private System.Windows.Forms.NumericUpDown bookModelPriceInput;
    }
}