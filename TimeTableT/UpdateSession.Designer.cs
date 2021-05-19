
namespace TimeTableT
{
    partial class UpdateSession
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
            this.label4 = new System.Windows.Forms.Label();
            this.tabSession = new System.Windows.Forms.TabControl();
            this.selectGroupTab = new System.Windows.Forms.TabPage();
            this.lblsessionid = new System.Windows.Forms.Label();
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listSelectedLecturers = new System.Windows.Forms.ListBox();
            this.listAllLecturers = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabSession.SuspendLayout();
            this.selectGroupTab.SuspendLayout();
            this.selectLecturersTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(17, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 45);
            this.label4.TabIndex = 41;
            this.label4.Text = "Update Session";
            // 
            // tabSession
            // 
            this.tabSession.Controls.Add(this.selectGroupTab);
            this.tabSession.Controls.Add(this.selectLecturersTab);
            this.tabSession.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSession.Location = new System.Drawing.Point(15, 76);
            this.tabSession.Name = "tabSession";
            this.tabSession.SelectedIndex = 0;
            this.tabSession.Size = new System.Drawing.Size(611, 293);
            this.tabSession.TabIndex = 40;
            // 
            // selectGroupTab
            // 
            this.selectGroupTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.selectGroupTab.Controls.Add(this.lblsessionid);
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
            // lblsessionid
            // 
            this.lblsessionid.AutoSize = true;
            this.lblsessionid.Location = new System.Drawing.Point(339, 16);
            this.lblsessionid.Name = "lblsessionid";
            this.lblsessionid.Size = new System.Drawing.Size(0, 18);
            this.lblsessionid.TabIndex = 39;
            this.lblsessionid.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(536, 99);
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
            this.btnNext.Location = new System.Drawing.Point(430, 194);
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
            this.btnClear.Location = new System.Drawing.Point(290, 194);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 47);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label9.Location = new System.Drawing.Point(351, 59);
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
            this.label8.Location = new System.Drawing.Point(351, 98);
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
            this.label7.Location = new System.Drawing.Point(40, 139);
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
            this.label2.Location = new System.Drawing.Point(40, 100);
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
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select Tag";
            // 
            // comboTag
            // 
            this.comboTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.comboTag.FormattingEnabled = true;
            this.comboTag.Items.AddRange(new object[] {
            "Lectures",
            "Tute",
            "Labs"});
            this.comboTag.Location = new System.Drawing.Point(156, 57);
            this.comboTag.Name = "comboTag";
            this.comboTag.Size = new System.Drawing.Size(149, 26);
            this.comboTag.TabIndex = 27;
            // 
            // comboSubject
            // 
            this.comboSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.comboSubject.FormattingEnabled = true;
            this.comboSubject.Location = new System.Drawing.Point(156, 139);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(149, 26);
            this.comboSubject.TabIndex = 24;
            // 
            // comboGroup
            // 
            this.comboGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Items.AddRange(new object[] {
            "Group01",
            "Group02",
            "Group03"});
            this.comboGroup.Location = new System.Drawing.Point(156, 98);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(149, 26);
            this.comboGroup.TabIndex = 23;
            // 
            // txtNoOfStudent
            // 
            this.txtNoOfStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtNoOfStudent.Location = new System.Drawing.Point(464, 59);
            this.txtNoOfStudent.Name = "txtNoOfStudent";
            this.txtNoOfStudent.Size = new System.Drawing.Size(68, 26);
            this.txtNoOfStudent.TabIndex = 22;
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtDuration.Location = new System.Drawing.Point(464, 98);
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
            this.selectLecturersTab.Controls.Add(this.btnBack);
            this.selectLecturersTab.Controls.Add(this.btnUpdate);
            this.selectLecturersTab.Controls.Add(this.listSelectedLecturers);
            this.selectLecturersTab.Controls.Add(this.listAllLecturers);
            this.selectLecturersTab.Controls.Add(this.button3);
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
            this.label6.Location = new System.Drawing.Point(364, 23);
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
            this.label5.Location = new System.Drawing.Point(102, 23);
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
            this.btnSelect.Location = new System.Drawing.Point(268, 75);
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
            this.btnUnselect.Location = new System.Drawing.Point(268, 120);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(74, 30);
            this.btnUnselect.TabIndex = 41;
            this.btnUnselect.Text = "<<";
            this.btnUnselect.UseVisualStyleBackColor = false;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnBack.Location = new System.Drawing.Point(290, 194);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 47);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnUpdate.Location = new System.Drawing.Point(430, 194);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 47);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listSelectedLecturers
            // 
            this.listSelectedLecturers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.listSelectedLecturers.FormattingEnabled = true;
            this.listSelectedLecturers.ItemHeight = 18;
            this.listSelectedLecturers.Location = new System.Drawing.Point(366, 46);
            this.listSelectedLecturers.Name = "listSelectedLecturers";
            this.listSelectedLecturers.Size = new System.Drawing.Size(139, 130);
            this.listSelectedLecturers.TabIndex = 1;
            // 
            // listAllLecturers
            // 
            this.listAllLecturers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.listAllLecturers.FormattingEnabled = true;
            this.listAllLecturers.ItemHeight = 18;
            this.listAllLecturers.Location = new System.Drawing.Point(104, 46);
            this.listAllLecturers.Name = "listAllLecturers";
            this.listAllLecturers.Size = new System.Drawing.Size(139, 130);
            this.listAllLecturers.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(142)))), ((int)(((byte)(53)))));
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.button3.Location = new System.Drawing.Point(430, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 47);
            this.button3.TabIndex = 39;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // UpdateSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(639, 382);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabSession);
            this.Name = "UpdateSession";
            this.Text = "UpdateSession";
            this.tabSession.ResumeLayout(false);
            this.selectGroupTab.ResumeLayout(false);
            this.selectGroupTab.PerformLayout();
            this.selectLecturersTab.ResumeLayout(false);
            this.selectLecturersTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabSession;
        private System.Windows.Forms.TabPage selectGroupTab;
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
        private System.Windows.Forms.TabPage selectLecturersTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox listSelectedLecturers;
        private System.Windows.Forms.ListBox listAllLecturers;
        private System.Windows.Forms.Label lblsessionid;
        private System.Windows.Forms.Button button3;
    }
}