
namespace TimeTableT
{
    partial class AddSession
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
            this.tabSession = new System.Windows.Forms.TabControl();
            this.selectGroupTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTag = new System.Windows.Forms.ComboBox();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.txtNoOfStudent = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.selectLecturersTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.listSelectedLecturers = new System.Windows.Forms.ListBox();
            this.listAllLecturers = new System.Windows.Forms.ListBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itpmDataSet = new TimeTableT.itpmDataSet();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.subjectTableAdapter = new TimeTableT.itpmDataSetTableAdapters.subjectTableAdapter();
            this.lecturerTableAdapter = new TimeTableT.itpmDataSetTableAdapters.lecturerTableAdapter();
            this.tabSession.SuspendLayout();
            this.selectGroupTab.SuspendLayout();
            this.selectLecturersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSession
            // 
            this.tabSession.Controls.Add(this.selectGroupTab);
            this.tabSession.Controls.Add(this.selectLecturersTab);
            this.tabSession.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSession.Location = new System.Drawing.Point(12, 74);
            this.tabSession.Name = "tabSession";
            this.tabSession.SelectedIndex = 0;
            this.tabSession.Size = new System.Drawing.Size(611, 293);
            this.tabSession.TabIndex = 0;
            // 
            // selectGroupTab
            // 
            this.selectGroupTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.selectGroupTab.Controls.Add(this.label3);
            this.selectGroupTab.Controls.Add(this.btnNext);
            this.selectGroupTab.Controls.Add(this.btnClear);
            this.selectGroupTab.Controls.Add(this.label9);
            this.selectGroupTab.Controls.Add(this.label8);
            this.selectGroupTab.Controls.Add(this.label7);
            this.selectGroupTab.Controls.Add(this.label2);
            this.selectGroupTab.Controls.Add(this.label1);
            this.selectGroupTab.Controls.Add(this.comboTag);
            this.selectGroupTab.Controls.Add(this.comboSubject);
            this.selectGroupTab.Controls.Add(this.comboGroup);
            this.selectGroupTab.Controls.Add(this.txtNoOfStudent);
            this.selectGroupTab.Controls.Add(this.txtDuration);
            this.selectGroupTab.Location = new System.Drawing.Point(4, 27);
            this.selectGroupTab.Name = "selectGroupTab";
            this.selectGroupTab.Padding = new System.Windows.Forms.Padding(3);
            this.selectGroupTab.Size = new System.Drawing.Size(603, 262);
            this.selectGroupTab.TabIndex = 0;
            this.selectGroupTab.Text = "Select Group , Subject & Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(531, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Hrs";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.btnNext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnNext.Location = new System.Drawing.Point(425, 185);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(134, 47);
            this.btnNext.TabIndex = 37;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(142)))), ((int)(((byte)(53)))));
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnClear.Location = new System.Drawing.Point(285, 185);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 47);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label9.Location = new System.Drawing.Point(346, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "No of Students";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label8.Location = new System.Drawing.Point(346, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label7.Location = new System.Drawing.Point(35, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Select Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Select Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select Tag";
            // 
            // comboTag
            // 
            this.comboTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.comboTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTag.FormattingEnabled = true;
            this.comboTag.Items.AddRange(new object[] {
            "Lectures",
            "Tute",
            "Labs"});
            this.comboTag.Location = new System.Drawing.Point(151, 48);
            this.comboTag.Name = "comboTag";
            this.comboTag.Size = new System.Drawing.Size(149, 26);
            this.comboTag.TabIndex = 27;
            // 
            // comboSubject
            // 
            this.comboSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.comboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSubject.FormattingEnabled = true;
            this.comboSubject.Location = new System.Drawing.Point(151, 130);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(149, 26);
            this.comboSubject.TabIndex = 24;
            // 
            // comboGroup
            // 
            this.comboGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.comboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Items.AddRange(new object[] {
            "Group01",
            "Group02",
            "Group03"});
            this.comboGroup.Location = new System.Drawing.Point(151, 89);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(149, 26);
            this.comboGroup.TabIndex = 23;
            // 
            // txtNoOfStudent
            // 
            this.txtNoOfStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtNoOfStudent.Location = new System.Drawing.Point(459, 50);
            this.txtNoOfStudent.Name = "txtNoOfStudent";
            this.txtNoOfStudent.Size = new System.Drawing.Size(68, 26);
            this.txtNoOfStudent.TabIndex = 22;
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtDuration.Location = new System.Drawing.Point(459, 89);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(68, 26);
            this.txtDuration.TabIndex = 21;
            // 
            // selectLecturersTab
            // 
            this.selectLecturersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.selectLecturersTab.Controls.Add(this.label6);
            this.selectLecturersTab.Controls.Add(this.label5);
            this.selectLecturersTab.Controls.Add(this.btnSelect);
            this.selectLecturersTab.Controls.Add(this.btnUnselect);
            this.selectLecturersTab.Controls.Add(this.btnSave);
            this.selectLecturersTab.Controls.Add(this.btnBack);
            this.selectLecturersTab.Controls.Add(this.listSelectedLecturers);
            this.selectLecturersTab.Controls.Add(this.listAllLecturers);
            this.selectLecturersTab.Location = new System.Drawing.Point(4, 27);
            this.selectLecturersTab.Name = "selectLecturersTab";
            this.selectLecturersTab.Padding = new System.Windows.Forms.Padding(3);
            this.selectLecturersTab.Size = new System.Drawing.Size(603, 262);
            this.selectLecturersTab.TabIndex = 1;
            this.selectLecturersTab.Text = "Select Lecturers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(359, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Selected Lecturers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(97, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "All Lecturers";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.btnSelect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnSelect.Location = new System.Drawing.Point(263, 66);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(74, 30);
            this.btnSelect.TabIndex = 42;
            this.btnSelect.Text = ">>";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUnselect
            // 
            this.btnUnselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.btnUnselect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnselect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnUnselect.Location = new System.Drawing.Point(263, 111);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(74, 30);
            this.btnUnselect.TabIndex = 41;
            this.btnUnselect.Text = "<<";
            this.btnUnselect.UseVisualStyleBackColor = false;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnSave.Location = new System.Drawing.Point(425, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 47);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnBack.Location = new System.Drawing.Point(285, 185);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 47);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listSelectedLecturers
            // 
            this.listSelectedLecturers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.listSelectedLecturers.FormattingEnabled = true;
            this.listSelectedLecturers.ItemHeight = 18;
            this.listSelectedLecturers.Location = new System.Drawing.Point(361, 37);
            this.listSelectedLecturers.Name = "listSelectedLecturers";
            this.listSelectedLecturers.Size = new System.Drawing.Size(139, 130);
            this.listSelectedLecturers.TabIndex = 1;
            // 
            // listAllLecturers
            // 
            this.listAllLecturers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.listAllLecturers.FormattingEnabled = true;
            this.listAllLecturers.ItemHeight = 18;
            this.listAllLecturers.Location = new System.Drawing.Point(99, 37);
            this.listAllLecturers.Name = "listAllLecturers";
            this.listAllLecturers.Size = new System.Drawing.Size(139, 130);
            this.listAllLecturers.TabIndex = 0;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "subject";
            this.subjectBindingSource.DataSource = this.itpmDataSet;
            // 
            // itpmDataSet
            // 
            this.itpmDataSet.DataSetName = "itpmDataSet";
            this.itpmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "lecturer";
            this.lecturerBindingSource.DataSource = this.itpmDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 45);
            this.label4.TabIndex = 39;
            this.label4.Text = "Add Session";
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // AddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(636, 381);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabSession);
            this.MaximizeBox = false;
            this.Name = "AddSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSession";
            this.Load += new System.EventHandler(this.AddSession_Load);
            this.tabSession.ResumeLayout(false);
            this.selectGroupTab.ResumeLayout(false);
            this.selectGroupTab.PerformLayout();
            this.selectLecturersTab.ResumeLayout(false);
            this.selectLecturersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabSession;
        private System.Windows.Forms.TabPage selectGroupTab;
        private System.Windows.Forms.TabPage selectLecturersTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTag;
        private System.Windows.Forms.ComboBox comboSubject;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.TextBox txtNoOfStudent;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.ListBox listSelectedLecturers;
        private System.Windows.Forms.ListBox listAllLecturers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private itpmDataSet itpmDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private itpmDataSetTableAdapters.subjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private itpmDataSetTableAdapters.lecturerTableAdapter lecturerTableAdapter;
    }
}