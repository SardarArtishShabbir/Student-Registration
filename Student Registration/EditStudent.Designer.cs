namespace Student_Registration
{
    partial class EditStudent
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
            this.components = new System.ComponentModel.Container();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Rno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.cmb_regID = new System.Windows.Forms.ComboBox();
            this.tblstudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registerStudentDataSet2 = new Student_Registration.RegisterStudentDataSet2();
            this.registerStudentDataSet1 = new Student_Registration.RegisterStudentDataSet1();
            this.tblstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_studentTableAdapter = new Student_Registration.RegisterStudentDataSet1TableAdapters.tbl_studentTableAdapter();
            this.tbl_studentTableAdapter1 = new Student_Registration.RegisterStudentDataSet2TableAdapters.tbl_studentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerStudentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerStudentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(185, 529);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(77, 28);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(185, 438);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(167, 59);
            this.txt_address.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 442);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Address :";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(185, 380);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(167, 22);
            this.txt_email.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 384);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Email :";
            // 
            // txt_Rno
            // 
            this.txt_Rno.Location = new System.Drawing.Point(185, 327);
            this.txt_Rno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Rno.Name = "txt_Rno";
            this.txt_Rno.Size = new System.Drawing.Size(167, 22);
            this.txt_Rno.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Roll No :";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(185, 286);
            this.txt_mobile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(167, 22);
            this.txt_mobile.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mobile :";
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(185, 234);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.ReadOnly = true;
            this.txt_fname.Size = new System.Drawing.Size(167, 22);
            this.txt_fname.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Father Name :";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(185, 177);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(167, 22);
            this.txt_name.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Registration ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 40);
            this.label1.TabIndex = 31;
            this.label1.Text = "Edit Student Details";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(287, 529);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(67, 28);
            this.btn_del.TabIndex = 32;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // cmb_regID
            // 
            this.cmb_regID.DataSource = this.tblstudentBindingSource1;
            this.cmb_regID.DisplayMember = "Registration ID";
            this.cmb_regID.FormattingEnabled = true;
            this.cmb_regID.Location = new System.Drawing.Point(185, 126);
            this.cmb_regID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_regID.Name = "cmb_regID";
            this.cmb_regID.Size = new System.Drawing.Size(167, 24);
            this.cmb_regID.TabIndex = 33;
            this.cmb_regID.ValueMember = "Registration ID";
            this.cmb_regID.SelectedIndexChanged += new System.EventHandler(this.cmb_regID_SelectedIndexChanged);
            // 
            // tblstudentBindingSource1
            // 
            this.tblstudentBindingSource1.DataMember = "tbl_student";
            this.tblstudentBindingSource1.DataSource = this.registerStudentDataSet2;
            // 
            // registerStudentDataSet2
            // 
            this.registerStudentDataSet2.DataSetName = "RegisterStudentDataSet2";
            this.registerStudentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerStudentDataSet1
            // 
            this.registerStudentDataSet1.DataSetName = "RegisterStudentDataSet1";
            this.registerStudentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblstudentBindingSource
            // 
            this.tblstudentBindingSource.DataMember = "tbl_student";
            this.tblstudentBindingSource.DataSource = this.registerStudentDataSet1;
            // 
            // tbl_studentTableAdapter
            // 
            this.tbl_studentTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_studentTableAdapter1
            // 
            this.tbl_studentTableAdapter1.ClearBeforeFill = true;
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 583);
            this.Controls.Add(this.cmb_regID);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Rno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.Load += new System.EventHandler(this.EditStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerStudentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerStudentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Rno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ComboBox cmb_regID;
        private RegisterStudentDataSet1 registerStudentDataSet1;
        private System.Windows.Forms.BindingSource tblstudentBindingSource;
        private RegisterStudentDataSet1TableAdapters.tbl_studentTableAdapter tbl_studentTableAdapter;
        private RegisterStudentDataSet2 registerStudentDataSet2;
        private System.Windows.Forms.BindingSource tblstudentBindingSource1;
        private RegisterStudentDataSet2TableAdapters.tbl_studentTableAdapter tbl_studentTableAdapter1;
    }
}