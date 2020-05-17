namespace library.application.forms {
    partial class LandingForm {
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.returningFormOpenButton = new System.Windows.Forms.Button();
            this.lendingFormOpenButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookFormOpenButton = new System.Windows.Forms.Button();
            this.employeeFormOpenButton = new System.Windows.Forms.Button();
            this.customerFormOpenButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(120, 38);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "eLibrarian";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(138, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dashboard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 459);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.returningFormOpenButton);
            this.groupBox2.Controls.Add(this.lendingFormOpenButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 132);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lending and Returning";
            // 
            // returningFormOpenButton
            // 
            this.returningFormOpenButton.BackColor = System.Drawing.Color.White;
            this.returningFormOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returningFormOpenButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returningFormOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returningFormOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returningFormOpenButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.returningFormOpenButton.Location = new System.Drawing.Point(151, 33);
            this.returningFormOpenButton.Name = "returningFormOpenButton";
            this.returningFormOpenButton.Size = new System.Drawing.Size(128, 70);
            this.returningFormOpenButton.TabIndex = 4;
            this.returningFormOpenButton.Text = "Returning";
            this.returningFormOpenButton.UseVisualStyleBackColor = false;
            this.returningFormOpenButton.Click += new System.EventHandler(this.returningFormOpenButton_Click);
            // 
            // lendingFormOpenButton
            // 
            this.lendingFormOpenButton.BackColor = System.Drawing.Color.White;
            this.lendingFormOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lendingFormOpenButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lendingFormOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lendingFormOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lendingFormOpenButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lendingFormOpenButton.Location = new System.Drawing.Point(17, 33);
            this.lendingFormOpenButton.Name = "lendingFormOpenButton";
            this.lendingFormOpenButton.Size = new System.Drawing.Size(128, 70);
            this.lendingFormOpenButton.TabIndex = 3;
            this.lendingFormOpenButton.Text = "Lending";
            this.lendingFormOpenButton.UseVisualStyleBackColor = false;
            this.lendingFormOpenButton.Click += new System.EventHandler(this.lendingFormOpenButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookFormOpenButton);
            this.groupBox1.Controls.Add(this.employeeFormOpenButton);
            this.groupBox1.Controls.Add(this.customerFormOpenButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Managements";
            // 
            // bookFormOpenButton
            // 
            this.bookFormOpenButton.BackColor = System.Drawing.Color.White;
            this.bookFormOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookFormOpenButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bookFormOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookFormOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookFormOpenButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bookFormOpenButton.Location = new System.Drawing.Point(285, 35);
            this.bookFormOpenButton.Name = "bookFormOpenButton";
            this.bookFormOpenButton.Size = new System.Drawing.Size(128, 70);
            this.bookFormOpenButton.TabIndex = 2;
            this.bookFormOpenButton.Text = "Book";
            this.bookFormOpenButton.UseVisualStyleBackColor = false;
            this.bookFormOpenButton.Click += new System.EventHandler(this.bookFormOpenButton_Click);
            // 
            // employeeFormOpenButton
            // 
            this.employeeFormOpenButton.BackColor = System.Drawing.Color.White;
            this.employeeFormOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeFormOpenButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.employeeFormOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeFormOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeFormOpenButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.employeeFormOpenButton.Location = new System.Drawing.Point(17, 35);
            this.employeeFormOpenButton.Name = "employeeFormOpenButton";
            this.employeeFormOpenButton.Size = new System.Drawing.Size(128, 70);
            this.employeeFormOpenButton.TabIndex = 0;
            this.employeeFormOpenButton.Text = "Employee";
            this.employeeFormOpenButton.UseVisualStyleBackColor = false;
            this.employeeFormOpenButton.Click += new System.EventHandler(this.employeeFormOpenButton_Click);
            // 
            // customerFormOpenButton
            // 
            this.customerFormOpenButton.BackColor = System.Drawing.Color.White;
            this.customerFormOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerFormOpenButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.customerFormOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerFormOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFormOpenButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.customerFormOpenButton.Location = new System.Drawing.Point(151, 35);
            this.customerFormOpenButton.Name = "customerFormOpenButton";
            this.customerFormOpenButton.Size = new System.Drawing.Size(128, 70);
            this.customerFormOpenButton.TabIndex = 1;
            this.customerFormOpenButton.Text = "Customer";
            this.customerFormOpenButton.UseVisualStyleBackColor = false;
            this.customerFormOpenButton.Click += new System.EventHandler(this.customerFormOpenButton_Click);
            // 
            // LandingForm
            // 
            this.ClientSize = new System.Drawing.Size(719, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel);
            this.Name = "LandingForm";
            this.Text = "eLibrarian";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button employeeFormOpenButton;
        private System.Windows.Forms.Button customerFormOpenButton;
        private System.Windows.Forms.Button bookFormOpenButton;
        private System.Windows.Forms.Button lendingFormOpenButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button returningFormOpenButton;
    }
}