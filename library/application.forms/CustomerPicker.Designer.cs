namespace library.application.forms {
    partial class CustomerPicker {
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerQueryInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerSet = new System.Windows.Forms.DataGridView();
            this.submitCustomerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(456, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick a Customer";
            // 
            // customerQueryInput
            // 
            this.customerQueryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerQueryInput.Location = new System.Drawing.Point(18, 61);
            this.customerQueryInput.Name = "customerQueryInput";
            this.customerQueryInput.Size = new System.Drawing.Size(651, 29);
            this.customerQueryInput.TabIndex = 1;
            this.customerQueryInput.TextChanged += new System.EventHandler(this.customerQueryInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // customerSet
            // 
            this.customerSet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerSet.Location = new System.Drawing.Point(18, 96);
            this.customerSet.MultiSelect = false;
            this.customerSet.Name = "customerSet";
            this.customerSet.ReadOnly = true;
            this.customerSet.RowHeadersWidth = 30;
            this.customerSet.Size = new System.Drawing.Size(651, 369);
            this.customerSet.TabIndex = 3;
            this.customerSet.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerSet_RowHeaderMouseClick);
            // 
            // submitCustomerButton
            // 
            this.submitCustomerButton.BackColor = System.Drawing.Color.White;
            this.submitCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitCustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submitCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitCustomerButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.submitCustomerButton.Location = new System.Drawing.Point(573, 471);
            this.submitCustomerButton.Name = "submitCustomerButton";
            this.submitCustomerButton.Size = new System.Drawing.Size(96, 43);
            this.submitCustomerButton.TabIndex = 8;
            this.submitCustomerButton.Text = "Select";
            this.submitCustomerButton.UseVisualStyleBackColor = false;
            this.submitCustomerButton.Click += new System.EventHandler(this.submitCustomerButton_Click);
            // 
            // CustomerPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 526);
            this.Controls.Add(this.submitCustomerButton);
            this.Controls.Add(this.customerSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerQueryInput);
            this.Controls.Add(this.label1);
            this.Name = "CustomerPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerPicker";
            this.Load += new System.EventHandler(this.CustomerPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerQueryInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView customerSet;
        private System.Windows.Forms.Button submitCustomerButton;
    }
}