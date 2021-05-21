
namespace TimeTableT
{
    partial class AddSubject
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboOfferedyear = new System.Windows.Forms.ComboBox();
            this.txtSubjectcode = new System.Windows.Forms.TextBox();
            this.rdbSemester1 = new System.Windows.Forms.RadioButton();
            this.rdbSemester2 = new System.Windows.Forms.RadioButton();
            this.txtSubjectname = new System.Windows.Forms.TextBox();
            this.numericLhrs = new System.Windows.Forms.NumericUpDown();
            this.numericThrs = new System.Windows.Forms.NumericUpDown();
            this.numericEhrs = new System.Windows.Forms.NumericUpDown();
            this.numericLabhrs = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericLhrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEhrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLabhrs)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(53, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 45);
            this.label3.TabIndex = 38;
            this.label3.Text = "Add Subject";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnSave.Location = new System.Drawing.Point(559, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 47);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(142)))), ((int)(((byte)(53)))));
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnClear.Location = new System.Drawing.Point(416, 296);
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
            this.label9.Location = new System.Drawing.Point(416, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "Number of lecture hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label8.Location = new System.Drawing.Point(416, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Number of tutorial hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label7.Location = new System.Drawing.Point(58, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Subject name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(58, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Subject code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(416, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Number of lab hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(416, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Number of evaluation hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(58, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Offered semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(58, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Offered year";
            // 
            // comboOfferedyear
            // 
            this.comboOfferedyear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.comboOfferedyear.FormattingEnabled = true;
            this.comboOfferedyear.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022"});
            this.comboOfferedyear.Location = new System.Drawing.Point(193, 109);
            this.comboOfferedyear.Name = "comboOfferedyear";
            this.comboOfferedyear.Size = new System.Drawing.Size(149, 21);
            this.comboOfferedyear.TabIndex = 24;
            // 
            // txtSubjectcode
            // 
            this.txtSubjectcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtSubjectcode.Location = new System.Drawing.Point(193, 234);
            this.txtSubjectcode.Name = "txtSubjectcode";
            this.txtSubjectcode.Size = new System.Drawing.Size(149, 20);
            this.txtSubjectcode.TabIndex = 21;
            // 
            // rdbSemester1
            // 
            this.rdbSemester1.AutoSize = true;
            this.rdbSemester1.Checked = true;
            this.rdbSemester1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.rdbSemester1.Location = new System.Drawing.Point(194, 154);
            this.rdbSemester1.Name = "rdbSemester1";
            this.rdbSemester1.Size = new System.Drawing.Size(84, 17);
            this.rdbSemester1.TabIndex = 39;
            this.rdbSemester1.TabStop = true;
            this.rdbSemester1.Text = "1st semester";
            this.rdbSemester1.UseVisualStyleBackColor = true;
            // 
            // rdbSemester2
            // 
            this.rdbSemester2.AutoSize = true;
            this.rdbSemester2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.rdbSemester2.Location = new System.Drawing.Point(295, 154);
            this.rdbSemester2.Name = "rdbSemester2";
            this.rdbSemester2.Size = new System.Drawing.Size(88, 17);
            this.rdbSemester2.TabIndex = 40;
            this.rdbSemester2.TabStop = true;
            this.rdbSemester2.Text = "2nd semester";
            this.rdbSemester2.UseVisualStyleBackColor = true;
            // 
            // txtSubjectname
            // 
            this.txtSubjectname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtSubjectname.Location = new System.Drawing.Point(193, 192);
            this.txtSubjectname.Name = "txtSubjectname";
            this.txtSubjectname.Size = new System.Drawing.Size(149, 20);
            this.txtSubjectname.TabIndex = 41;
            // 
            // numericLhrs
            // 
            this.numericLhrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.numericLhrs.Location = new System.Drawing.Point(627, 111);
            this.numericLhrs.Name = "numericLhrs";
            this.numericLhrs.Size = new System.Drawing.Size(63, 20);
            this.numericLhrs.TabIndex = 42;
            // 
            // numericThrs
            // 
            this.numericThrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.numericThrs.Location = new System.Drawing.Point(627, 154);
            this.numericThrs.Name = "numericThrs";
            this.numericThrs.Size = new System.Drawing.Size(63, 20);
            this.numericThrs.TabIndex = 43;
            // 
            // numericEhrs
            // 
            this.numericEhrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.numericEhrs.Location = new System.Drawing.Point(627, 232);
            this.numericEhrs.Name = "numericEhrs";
            this.numericEhrs.Size = new System.Drawing.Size(63, 20);
            this.numericEhrs.TabIndex = 44;
            // 
            // numericLabhrs
            // 
            this.numericLabhrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.numericLabhrs.Location = new System.Drawing.Point(627, 192);
            this.numericLabhrs.Name = "numericLabhrs";
            this.numericLabhrs.Size = new System.Drawing.Size(63, 20);
            this.numericLabhrs.TabIndex = 45;
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(748, 394);
            this.Controls.Add(this.numericLabhrs);
            this.Controls.Add(this.numericEhrs);
            this.Controls.Add(this.numericThrs);
            this.Controls.Add(this.numericLhrs);
            this.Controls.Add(this.txtSubjectname);
            this.Controls.Add(this.rdbSemester2);
            this.Controls.Add(this.rdbSemester1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboOfferedyear);
            this.Controls.Add(this.txtSubjectcode);
            this.Name = "AddSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubject";
            ((System.ComponentModel.ISupportInitialize)(this.numericLhrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEhrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLabhrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboOfferedyear;
        private System.Windows.Forms.TextBox txtSubjectcode;
        private System.Windows.Forms.RadioButton rdbSemester1;
        private System.Windows.Forms.RadioButton rdbSemester2;
        private System.Windows.Forms.TextBox txtSubjectname;
        private System.Windows.Forms.NumericUpDown numericLhrs;
        private System.Windows.Forms.NumericUpDown numericThrs;
        private System.Windows.Forms.NumericUpDown numericEhrs;
        private System.Windows.Forms.NumericUpDown numericLabhrs;
    }
}