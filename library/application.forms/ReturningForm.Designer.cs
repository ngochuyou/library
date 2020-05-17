namespace library.application.forms {
    partial class ReturningForm {
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
            this.landingFormButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.landingFormLabel = new System.Windows.Forms.Label();
            this.paymentSet = new System.Windows.Forms.DataGridView();
            this.itemSet = new System.Windows.Forms.DataGridView();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSet)).BeginInit();
            this.SuspendLayout();
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
            this.landingFormButton.TabIndex = 11;
            this.landingFormButton.Text = "Back";
            this.landingFormButton.UseVisualStyleBackColor = false;
            this.landingFormButton.Click += new System.EventHandler(this.landingFormButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(138, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Returning";
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
            this.landingFormLabel.TabIndex = 12;
            this.landingFormLabel.Text = "eLibrarian";
            this.landingFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.landingFormLabel.Click += new System.EventHandler(this.landingFormLabel_Click);
            // 
            // paymentSet
            // 
            this.paymentSet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.paymentSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentSet.Location = new System.Drawing.Point(12, 59);
            this.paymentSet.MultiSelect = false;
            this.paymentSet.Name = "paymentSet";
            this.paymentSet.ReadOnly = true;
            this.paymentSet.RowHeadersWidth = 30;
            this.paymentSet.Size = new System.Drawing.Size(353, 447);
            this.paymentSet.TabIndex = 18;
            this.paymentSet.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.paymentSet_RowHeaderMouseClick);
            // 
            // itemSet
            // 
            this.itemSet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemSet.Location = new System.Drawing.Point(371, 59);
            this.itemSet.MultiSelect = false;
            this.itemSet.Name = "itemSet";
            this.itemSet.ReadOnly = true;
            this.itemSet.RowHeadersWidth = 30;
            this.itemSet.Size = new System.Drawing.Size(336, 496);
            this.itemSet.TabIndex = 19;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Coral;
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.returnButton.Location = new System.Drawing.Point(12, 512);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(88, 43);
            this.returnButton.TabIndex = 21;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // ReturningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 567);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.itemSet);
            this.Controls.Add(this.paymentSet);
            this.Controls.Add(this.landingFormButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.landingFormLabel);
            this.Name = "ReturningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturningForm";
            this.Load += new System.EventHandler(this.ReturningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button landingFormButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label landingFormLabel;
        private System.Windows.Forms.DataGridView paymentSet;
        private System.Windows.Forms.DataGridView itemSet;
        private System.Windows.Forms.Button returnButton;
    }
}