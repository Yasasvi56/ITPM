
namespace TimeTableT
{
    partial class WorkingDateAndTimeForm
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
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Upatebutton = new System.Windows.Forms.Button();
            this.saveNextbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(197, 130);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(338, 20);
            this.textBoxEmployeeID.TabIndex = 0;
            this.textBoxEmployeeID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(197, 185);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(338, 20);
            this.textBoxEmployeeName.TabIndex = 1;
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Location = new System.Drawing.Point(197, 241);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(338, 20);
            this.textBoxStartDate.TabIndex = 2;
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(197, 295);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(338, 20);
            this.textBoxEndDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(59, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(59, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(59, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(59, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "EndDate";
            // 
            // Upatebutton
            // 
            this.Upatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(142)))), ((int)(((byte)(53)))));
            this.Upatebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Upatebutton.Location = new System.Drawing.Point(592, 197);
            this.Upatebutton.Name = "Upatebutton";
            this.Upatebutton.Size = new System.Drawing.Size(132, 49);
            this.Upatebutton.TabIndex = 9;
            this.Upatebutton.Text = "clear";
            this.Upatebutton.UseVisualStyleBackColor = false;
            // 
            // saveNextbutton
            // 
            this.saveNextbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.saveNextbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveNextbutton.Location = new System.Drawing.Point(592, 130);
            this.saveNextbutton.Name = "saveNextbutton";
            this.saveNextbutton.Size = new System.Drawing.Size(132, 49);
            this.saveNextbutton.TabIndex = 10;
            this.saveNextbutton.Text = "save";
            this.saveNextbutton.UseVisualStyleBackColor = false;
            this.saveNextbutton.Click += new System.EventHandler(this.saveNextbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.BurlyWood;
            this.label5.Location = new System.Drawing.Point(59, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Working Time";
            // 
            // WorkingDateAndTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveNextbutton);
            this.Controls.Add(this.Upatebutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEndDate);
            this.Controls.Add(this.textBoxStartDate);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.textBoxEmployeeID);
            this.Name = "WorkingDateAndTimeForm";
            this.Text = "WorkingDateAndTimeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Upatebutton;
        private System.Windows.Forms.Button saveNextbutton;
        private System.Windows.Forms.Label label5;
    }
}