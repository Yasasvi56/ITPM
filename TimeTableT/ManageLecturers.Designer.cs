
namespace TimeTableT
{
    partial class ManageLecturers
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combocenter = new System.Windows.Forms.ComboBox();
            this.combolevel = new System.Windows.Forms.ComboBox();
            this.combodepartment = new System.Windows.Forms.ComboBox();
            this.combofaculty = new System.Windows.Forms.ComboBox();
            this.combobuilding = new System.Windows.Forms.ComboBox();
            this.txtemployeeid = new System.Windows.Forms.TextBox();
            this.txtrank = new System.Windows.Forms.TextBox();
            this.txtlecturername = new System.Windows.Forms.TextBox();
            this.gridlecturers = new System.Windows.Forms.DataGridView();
            this.btnclear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtlecturerfilter = new System.Windows.Forms.TextBox();
            this.lbllecturerid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridlecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(66, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 45);
            this.label3.TabIndex = 38;
            this.label3.Text = "Manage Lecturers";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnupdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnupdate.Location = new System.Drawing.Point(495, 539);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(134, 47);
            this.btnupdate.TabIndex = 37;
            this.btnupdate.Text = "Save";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btndelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btndelete.Location = new System.Drawing.Point(355, 539);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(134, 47);
            this.btndelete.TabIndex = 36;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label9.Location = new System.Drawing.Point(382, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "Center";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label8.Location = new System.Drawing.Point(382, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Building";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label7.Location = new System.Drawing.Point(71, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Faculty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(71, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(382, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(382, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Rank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(71, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(71, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Lecturer Name";
            // 
            // combocenter
            // 
            this.combocenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.combocenter.FormattingEnabled = true;
            this.combocenter.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Kurunagala",
            "Jaffna"});
            this.combocenter.Location = new System.Drawing.Point(478, 357);
            this.combocenter.Name = "combocenter";
            this.combocenter.Size = new System.Drawing.Size(149, 21);
            this.combocenter.TabIndex = 27;
            // 
            // combolevel
            // 
            this.combolevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.combolevel.FormattingEnabled = true;
            this.combolevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.combolevel.Location = new System.Drawing.Point(478, 440);
            this.combolevel.Name = "combolevel";
            this.combolevel.Size = new System.Drawing.Size(149, 21);
            this.combolevel.TabIndex = 26;
            this.combolevel.SelectedIndexChanged += new System.EventHandler(this.combolevel_SelectedIndexChanged);
            // 
            // combodepartment
            // 
            this.combodepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.combodepartment.FormattingEnabled = true;
            this.combodepartment.Items.AddRange(new object[] {
            "Information Technology",
            "Network engineering",
            "Software Engineering",
            "Cyber Security",
            "Interactive Media",
            "Business Management",
            "Materials engineers"});
            this.combodepartment.Location = new System.Drawing.Point(194, 479);
            this.combodepartment.Name = "combodepartment";
            this.combodepartment.Size = new System.Drawing.Size(149, 21);
            this.combodepartment.TabIndex = 25;
            // 
            // combofaculty
            // 
            this.combofaculty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.combofaculty.FormattingEnabled = true;
            this.combofaculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Sciences"});
            this.combofaculty.Location = new System.Drawing.Point(194, 440);
            this.combofaculty.Name = "combofaculty";
            this.combofaculty.Size = new System.Drawing.Size(149, 21);
            this.combofaculty.TabIndex = 24;
            // 
            // combobuilding
            // 
            this.combobuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.combobuilding.FormattingEnabled = true;
            this.combobuilding.Items.AddRange(new object[] {
            "New building",
            "D-block",
            "Engineering building",
            "Computing building"});
            this.combobuilding.Location = new System.Drawing.Point(478, 399);
            this.combobuilding.Name = "combobuilding";
            this.combobuilding.Size = new System.Drawing.Size(149, 21);
            this.combobuilding.TabIndex = 23;
            // 
            // txtemployeeid
            // 
            this.txtemployeeid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtemployeeid.Location = new System.Drawing.Point(194, 399);
            this.txtemployeeid.Name = "txtemployeeid";
            this.txtemployeeid.Size = new System.Drawing.Size(149, 20);
            this.txtemployeeid.TabIndex = 22;
            this.txtemployeeid.TextChanged += new System.EventHandler(this.txtemployeeid_TextChanged);
            // 
            // txtrank
            // 
            this.txtrank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtrank.Enabled = false;
            this.txtrank.Location = new System.Drawing.Point(478, 480);
            this.txtrank.Name = "txtrank";
            this.txtrank.Size = new System.Drawing.Size(149, 20);
            this.txtrank.TabIndex = 21;
            // 
            // txtlecturername
            // 
            this.txtlecturername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtlecturername.Location = new System.Drawing.Point(194, 358);
            this.txtlecturername.Name = "txtlecturername";
            this.txtlecturername.Size = new System.Drawing.Size(149, 20);
            this.txtlecturername.TabIndex = 20;
            // 
            // gridlecturers
            // 
            this.gridlecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridlecturers.Location = new System.Drawing.Point(74, 172);
            this.gridlecturers.Name = "gridlecturers";
            this.gridlecturers.Size = new System.Drawing.Size(555, 150);
            this.gridlecturers.TabIndex = 39;
            this.gridlecturers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridlecturers_CellContentClick);
            this.gridlecturers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridlecturers_CellMouseClick);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(142)))), ((int)(((byte)(53)))));
            this.btnclear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnclear.Location = new System.Drawing.Point(215, 539);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(134, 47);
            this.btnclear.TabIndex = 40;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label10.Location = new System.Drawing.Point(69, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 76;
            this.label10.Text = " Lecturer";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.btnsearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnsearch.Location = new System.Drawing.Point(261, 127);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(74, 30);
            this.btnsearch.TabIndex = 75;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtlecturerfilter
            // 
            this.txtlecturerfilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtlecturerfilter.Location = new System.Drawing.Point(74, 132);
            this.txtlecturerfilter.Name = "txtlecturerfilter";
            this.txtlecturerfilter.Size = new System.Drawing.Size(167, 20);
            this.txtlecturerfilter.TabIndex = 74;
            this.txtlecturerfilter.TextChanged += new System.EventHandler(this.txtlecturerfilter_TextChanged);
            // 
            // lbllecturerid
            // 
            this.lbllecturerid.AutoSize = true;
            this.lbllecturerid.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllecturerid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lbllecturerid.Location = new System.Drawing.Point(71, 325);
            this.lbllecturerid.Name = "lbllecturerid";
            this.lbllecturerid.Size = new System.Drawing.Size(0, 18);
            this.lbllecturerid.TabIndex = 77;
            this.lbllecturerid.Visible = false;
            // 
            // ManageLecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(699, 635);
            this.Controls.Add(this.lbllecturerid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtlecturerfilter);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.gridlecturers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combocenter);
            this.Controls.Add(this.combolevel);
            this.Controls.Add(this.combodepartment);
            this.Controls.Add(this.combofaculty);
            this.Controls.Add(this.combobuilding);
            this.Controls.Add(this.txtemployeeid);
            this.Controls.Add(this.txtrank);
            this.Controls.Add(this.txtlecturername);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(715, 674);
            this.MinimumSize = new System.Drawing.Size(715, 674);
            this.Name = "ManageLecturers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageLecturers";
            this.Load += new System.EventHandler(this.ManageLecturers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridlecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combocenter;
        private System.Windows.Forms.ComboBox combolevel;
        private System.Windows.Forms.ComboBox combodepartment;
        private System.Windows.Forms.ComboBox combofaculty;
        private System.Windows.Forms.ComboBox combobuilding;
        private System.Windows.Forms.TextBox txtemployeeid;
        private System.Windows.Forms.TextBox txtrank;
        private System.Windows.Forms.TextBox txtlecturername;
        private System.Windows.Forms.DataGridView gridlecturers;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtlecturerfilter;
        private System.Windows.Forms.Label lbllecturerid;
    }
}