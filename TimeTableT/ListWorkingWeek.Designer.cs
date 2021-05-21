
namespace TimeTableT
{
    partial class ListWorkingWeek
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownUpadeNoOfWDaytes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUpdateHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUpdateMinutes = new System.Windows.Forms.NumericUpDown();
            this.hideLable = new System.Windows.Forms.Label();
            this.checkBoxSunday = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxTursday = new System.Windows.Forms.CheckBox();
            this.checkBoxWensday = new System.Windows.Forms.CheckBox();
            this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxMonday = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtlecturerfilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpadeNoOfWDaytes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(37, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Manage Working Dates And Times Per Week";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(639, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 48);
            this.button1.TabIndex = 23;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(639, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 48);
            this.button2.TabIndex = 24;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(142)))), ((int)(((byte)(53)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(639, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 48);
            this.button3.TabIndex = 25;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(579, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(41, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Number Of Working Dates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(41, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Working Times Per Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(358, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Hours";
            // 
            // numericUpDownUpadeNoOfWDaytes
            // 
            this.numericUpDownUpadeNoOfWDaytes.Location = new System.Drawing.Point(221, 265);
            this.numericUpDownUpadeNoOfWDaytes.Name = "numericUpDownUpadeNoOfWDaytes";
            this.numericUpDownUpadeNoOfWDaytes.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownUpadeNoOfWDaytes.TabIndex = 31;
            // 
            // numericUpDownUpdateHours
            // 
            this.numericUpDownUpdateHours.Location = new System.Drawing.Point(221, 374);
            this.numericUpDownUpdateHours.Name = "numericUpDownUpdateHours";
            this.numericUpDownUpdateHours.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownUpdateHours.TabIndex = 32;
            // 
            // numericUpDownUpdateMinutes
            // 
            this.numericUpDownUpdateMinutes.Location = new System.Drawing.Point(444, 374);
            this.numericUpDownUpdateMinutes.Name = "numericUpDownUpdateMinutes";
            this.numericUpDownUpdateMinutes.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownUpdateMinutes.TabIndex = 33;
            // 
            // hideLable
            // 
            this.hideLable.AutoSize = true;
            this.hideLable.Location = new System.Drawing.Point(420, 27);
            this.hideLable.Name = "hideLable";
            this.hideLable.Size = new System.Drawing.Size(0, 13);
            this.hideLable.TabIndex = 34;
            this.hideLable.Visible = false;
            // 
            // checkBoxSunday
            // 
            this.checkBoxSunday.AutoSize = true;
            this.checkBoxSunday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxSunday.Location = new System.Drawing.Point(286, 341);
            this.checkBoxSunday.Name = "checkBoxSunday";
            this.checkBoxSunday.Size = new System.Drawing.Size(62, 17);
            this.checkBoxSunday.TabIndex = 42;
            this.checkBoxSunday.Text = "Sunday";
            this.checkBoxSunday.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaturday
            // 
            this.checkBoxSaturday.AutoSize = true;
            this.checkBoxSaturday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxSaturday.Location = new System.Drawing.Point(216, 341);
            this.checkBoxSaturday.Name = "checkBoxSaturday";
            this.checkBoxSaturday.Size = new System.Drawing.Size(68, 17);
            this.checkBoxSaturday.TabIndex = 41;
            this.checkBoxSaturday.Text = "Saturday";
            this.checkBoxSaturday.UseVisualStyleBackColor = true;
            // 
            // checkBoxFriday
            // 
            this.checkBoxFriday.AutoSize = true;
            this.checkBoxFriday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxFriday.Location = new System.Drawing.Point(496, 308);
            this.checkBoxFriday.Name = "checkBoxFriday";
            this.checkBoxFriday.Size = new System.Drawing.Size(54, 17);
            this.checkBoxFriday.TabIndex = 40;
            this.checkBoxFriday.Text = "Friday";
            this.checkBoxFriday.UseVisualStyleBackColor = true;
            // 
            // checkBoxTursday
            // 
            this.checkBoxTursday.AutoSize = true;
            this.checkBoxTursday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxTursday.Location = new System.Drawing.Point(426, 308);
            this.checkBoxTursday.Name = "checkBoxTursday";
            this.checkBoxTursday.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTursday.TabIndex = 39;
            this.checkBoxTursday.Text = "Tursday";
            this.checkBoxTursday.UseVisualStyleBackColor = true;
            // 
            // checkBoxWensday
            // 
            this.checkBoxWensday.AutoSize = true;
            this.checkBoxWensday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxWensday.Location = new System.Drawing.Point(356, 308);
            this.checkBoxWensday.Name = "checkBoxWensday";
            this.checkBoxWensday.Size = new System.Drawing.Size(71, 17);
            this.checkBoxWensday.TabIndex = 38;
            this.checkBoxWensday.Text = "Wensday";
            this.checkBoxWensday.UseVisualStyleBackColor = true;
            // 
            // checkBoxTuesday
            // 
            this.checkBoxTuesday.AutoSize = true;
            this.checkBoxTuesday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxTuesday.Location = new System.Drawing.Point(286, 308);
            this.checkBoxTuesday.Name = "checkBoxTuesday";
            this.checkBoxTuesday.Size = new System.Drawing.Size(67, 17);
            this.checkBoxTuesday.TabIndex = 37;
            this.checkBoxTuesday.Text = "Tuesday";
            this.checkBoxTuesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonday
            // 
            this.checkBoxMonday.AutoSize = true;
            this.checkBoxMonday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxMonday.Location = new System.Drawing.Point(216, 307);
            this.checkBoxMonday.Name = "checkBoxMonday";
            this.checkBoxMonday.Size = new System.Drawing.Size(64, 17);
            this.checkBoxMonday.TabIndex = 36;
            this.checkBoxMonday.Text = "Monday";
            this.checkBoxMonday.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Working Dates";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.btnsearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnsearch.Location = new System.Drawing.Point(639, 22);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(74, 30);
            this.btnsearch.TabIndex = 77;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // txtlecturerfilter
            // 
            this.txtlecturerfilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtlecturerfilter.Location = new System.Drawing.Point(452, 27);
            this.txtlecturerfilter.Name = "txtlecturerfilter";
            this.txtlecturerfilter.Size = new System.Drawing.Size(167, 20);
            this.txtlecturerfilter.TabIndex = 76;
            this.txtlecturerfilter.TextChanged += new System.EventHandler(this.txtlecturerfilter_TextChanged);
            // 
            // ListWorkingWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtlecturerfilter);
            this.Controls.Add(this.checkBoxSunday);
            this.Controls.Add(this.checkBoxSaturday);
            this.Controls.Add(this.checkBoxFriday);
            this.Controls.Add(this.checkBoxTursday);
            this.Controls.Add(this.checkBoxWensday);
            this.Controls.Add(this.checkBoxTuesday);
            this.Controls.Add(this.checkBoxMonday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hideLable);
            this.Controls.Add(this.numericUpDownUpdateMinutes);
            this.Controls.Add(this.numericUpDownUpdateHours);
            this.Controls.Add(this.numericUpDownUpadeNoOfWDaytes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListWorkingWeek";
            this.Text = "ListWorkingWeek";
            this.Load += new System.EventHandler(this.ListWorkingWeek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpadeNoOfWDaytes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownUpadeNoOfWDaytes;
        private System.Windows.Forms.NumericUpDown numericUpDownUpdateHours;
        private System.Windows.Forms.NumericUpDown numericUpDownUpdateMinutes;
        private System.Windows.Forms.Label hideLable;
        private System.Windows.Forms.CheckBox checkBoxSunday;
        private System.Windows.Forms.CheckBox checkBoxSaturday;
        private System.Windows.Forms.CheckBox checkBoxFriday;
        private System.Windows.Forms.CheckBox checkBoxTursday;
        private System.Windows.Forms.CheckBox checkBoxWensday;
        private System.Windows.Forms.CheckBox checkBoxTuesday;
        private System.Windows.Forms.CheckBox checkBoxMonday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtlecturerfilter;
    }
}