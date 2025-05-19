namespace Assignment_Q1_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPatNum = new TextBox();
            txtFullName = new TextBox();
            txtPhnNum = new TextBox();
            txtNOI = new TextBox();
            txtDOB = new TextBox();
            cmbPatType = new ComboBox();
            cmbGender = new ComboBox();
            cmbProvince = new ComboBox();
            dtgrdPatients = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnSave = new Button();
            btnDisplayAll = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgrdPatients).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1067, 46);
            label1.TabIndex = 0;
            label1.Text = "eHealth Care Incorporated";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 77);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 1;
            label2.Text = "Patient Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 132);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 187);
            label4.Name = "label4";
            label4.Size = new Size(130, 23);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            // 
            // txtPatNum
            // 
            txtPatNum.Location = new Point(207, 77);
            txtPatNum.Name = "txtPatNum";
            txtPatNum.Size = new Size(167, 27);
            txtPatNum.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(207, 132);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(167, 27);
            txtFullName.TabIndex = 5;
            txtFullName.TextChanged += textBox2_TextChanged;
            // 
            // txtPhnNum
            // 
            txtPhnNum.Location = new Point(207, 183);
            txtPhnNum.Name = "txtPhnNum";
            txtPhnNum.Size = new Size(167, 27);
            txtPhnNum.TabIndex = 6;
            // 
            // txtNOI
            // 
            txtNOI.Location = new Point(207, 246);
            txtNOI.Name = "txtNOI";
            txtNOI.Size = new Size(167, 27);
            txtNOI.TabIndex = 7;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(797, 262);
            txtDOB.Name = "txtDOB";
            txtDOB.PlaceholderText = "DD/MM/YY";
            txtDOB.Size = new Size(151, 27);
            txtDOB.TabIndex = 8;
            // 
            // cmbPatType
            // 
            cmbPatType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatType.FormattingEnabled = true;
            cmbPatType.Items.AddRange(new object[] { "IN_Patient", "OUT_Patient", "Emergency" });
            cmbPatType.Location = new Point(797, 81);
            cmbPatType.Name = "cmbPatType";
            cmbPatType.Size = new Size(151, 28);
            cmbPatType.TabIndex = 9;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male ", "Female" });
            cmbGender.Location = new Point(797, 133);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(151, 28);
            cmbGender.TabIndex = 10;
            // 
            // cmbProvince
            // 
            cmbProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvince.FormattingEnabled = true;
            cmbProvince.Items.AddRange(new object[] { "Eastern Cape", "Free State", "Gauteng", "KwaZulu-Natal", "Limpopo", "Mpumalanga", "Northern Cape", "North West ", "Western Cape" });
            cmbProvince.Location = new Point(797, 200);
            cmbProvince.Name = "cmbProvince";
            cmbProvince.Size = new Size(151, 28);
            cmbProvince.TabIndex = 11;
            // 
            // dtgrdPatients
            // 
            dtgrdPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrdPatients.Dock = DockStyle.Bottom;
            dtgrdPatients.Location = new Point(0, 387);
            dtgrdPatients.MultiSelect = false;
            dtgrdPatients.Name = "dtgrdPatients";
            dtgrdPatients.RowHeadersWidth = 51;
            dtgrdPatients.RowTemplate.Height = 29;
            dtgrdPatients.Size = new Size(1067, 204);
            dtgrdPatients.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 246);
            label5.Name = "label5";
            label5.Size = new Size(143, 23);
            label5.TabIndex = 13;
            label5.Text = "Nature Of Illness";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(594, 81);
            label6.Name = "label6";
            label6.Size = new Size(110, 23);
            label6.TabIndex = 14;
            label6.Text = "Patient Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(594, 134);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 15;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(594, 205);
            label8.Name = "label8";
            label8.Size = new Size(78, 23);
            label8.TabIndex = 16;
            label8.Text = "Province";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(594, 266);
            label9.Name = "label9";
            label9.Size = new Size(118, 23);
            label9.TabIndex = 17;
            label9.Text = "Date Of Birth";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(0, 342);
            label10.Name = "label10";
            label10.Size = new Size(178, 23);
            label10.TabIndex = 18;
            label10.Text = "Search By Patient No";
            label10.Click += label10_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(501, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 38);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button1_Click;
            // 
            // btnDisplayAll
            // 
            btnDisplayAll.Location = new Point(659, 333);
            btnDisplayAll.Name = "btnDisplayAll";
            btnDisplayAll.Size = new Size(108, 37);
            btnDisplayAll.TabIndex = 20;
            btnDisplayAll.Text = "Display All";
            btnDisplayAll.UseVisualStyleBackColor = true;
            btnDisplayAll.Click += btnDisplayAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(815, 333);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 37);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button3_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(955, 333);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 38);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(207, 341);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(167, 27);
            txtSearch.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 591);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnDisplayAll);
            Controls.Add(btnSave);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtgrdPatients);
            Controls.Add(cmbProvince);
            Controls.Add(cmbGender);
            Controls.Add(cmbPatType);
            Controls.Add(txtDOB);
            Controls.Add(txtNOI);
            Controls.Add(txtPhnNum);
            Controls.Add(txtFullName);
            Controls.Add(txtPatNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "eHealth Care Hospital Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgrdPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPatNum;
        private TextBox txtFullName;
        private TextBox txtPhnNum;
        private TextBox txtNOI;
        private TextBox txtDOB;
        private ComboBox cmbPatType;
        private ComboBox cmbGender;
        private ComboBox cmbProvince;
        private DataGridView dtgrdPatients;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnSave;
        private Button btnDisplayAll;
        private Button btnSearch;
        private Button btnDelete;
        private TextBox txtSearch;
    }
}