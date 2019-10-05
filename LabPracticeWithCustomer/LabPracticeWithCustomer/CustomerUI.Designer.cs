namespace LabPracticeWithCustomer
{
    partial class CustomerUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameValidLabel = new System.Windows.Forms.Label();
            this.codeValidLabel = new System.Windows.Forms.Label();
            this.contactValidLabel = new System.Windows.Forms.Label();
            this.addressValidLabel = new System.Windows.Forms.Label();
            this.districtValidLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeTextBox.Location = new System.Drawing.Point(124, 53);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(121, 20);
            this.codeTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(124, 96);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.Location = new System.Drawing.Point(124, 139);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(121, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contact";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactTextBox.Location = new System.Drawing.Point(124, 182);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "District";
            // 
            // districtComboBox
            // 
            this.districtComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Location = new System.Drawing.Point(124, 225);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(121, 21);
            this.districtComboBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Location = new System.Drawing.Point(46, 282);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Visible = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.Location = new System.Drawing.Point(170, 282);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameValidLabel
            // 
            this.nameValidLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameValidLabel.AutoSize = true;
            this.nameValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameValidLabel.ForeColor = System.Drawing.Color.Red;
            this.nameValidLabel.Location = new System.Drawing.Point(127, 121);
            this.nameValidLabel.Name = "nameValidLabel";
            this.nameValidLabel.Size = new System.Drawing.Size(0, 15);
            this.nameValidLabel.TabIndex = 5;
            // 
            // codeValidLabel
            // 
            this.codeValidLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeValidLabel.AutoSize = true;
            this.codeValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeValidLabel.ForeColor = System.Drawing.Color.Red;
            this.codeValidLabel.Location = new System.Drawing.Point(127, 78);
            this.codeValidLabel.Name = "codeValidLabel";
            this.codeValidLabel.Size = new System.Drawing.Size(0, 15);
            this.codeValidLabel.TabIndex = 5;
            // 
            // contactValidLabel
            // 
            this.contactValidLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactValidLabel.AutoSize = true;
            this.contactValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactValidLabel.ForeColor = System.Drawing.Color.Red;
            this.contactValidLabel.Location = new System.Drawing.Point(127, 207);
            this.contactValidLabel.Name = "contactValidLabel";
            this.contactValidLabel.Size = new System.Drawing.Size(0, 15);
            this.contactValidLabel.TabIndex = 5;
            // 
            // addressValidLabel
            // 
            this.addressValidLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressValidLabel.AutoSize = true;
            this.addressValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressValidLabel.ForeColor = System.Drawing.Color.Red;
            this.addressValidLabel.Location = new System.Drawing.Point(127, 164);
            this.addressValidLabel.Name = "addressValidLabel";
            this.addressValidLabel.Size = new System.Drawing.Size(0, 15);
            this.addressValidLabel.TabIndex = 5;
            // 
            // districtValidLabel
            // 
            this.districtValidLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.districtValidLabel.AutoSize = true;
            this.districtValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtValidLabel.ForeColor = System.Drawing.Color.Red;
            this.districtValidLabel.Location = new System.Drawing.Point(127, 250);
            this.districtValidLabel.Name = "districtValidLabel";
            this.districtValidLabel.Size = new System.Drawing.Size(0, 15);
            this.districtValidLabel.TabIndex = 5;
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(424, 13);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(16, 13);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "-1";
            this.idLabel.Visible = false;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(311, 53);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(571, 212);
            this.customerDataGridView.TabIndex = 7;
            this.customerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellClick);
            this.customerDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.customerDataGridView_CellFormatting);
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addressValidLabel);
            this.Controls.Add(this.codeValidLabel);
            this.Controls.Add(this.districtValidLabel);
            this.Controls.Add(this.contactValidLabel);
            this.Controls.Add(this.nameValidLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.districtComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CustomerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label nameValidLabel;
        private System.Windows.Forms.Label codeValidLabel;
        private System.Windows.Forms.Label contactValidLabel;
        private System.Windows.Forms.Label addressValidLabel;
        private System.Windows.Forms.Label districtValidLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DataGridView customerDataGridView;
    }
}

