using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableT.Controllers;
using TimeTableT.Models;

namespace TimeTableT
{
    public partial class ManageTag : Form
    {
        public ManageTag()
        {
            InitializeComponent();
        }

      
        private void loadgrid()
        {
            try
            {
                dataGridView1.DataSource = TagController.FilterTag();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int tagId = Convert.ToInt32(row.Cells[0].Value.ToString());
                    Tag tag = TagController.SelectedTag(tagId);
                    if (tag != null)
                    {
                        label5.Text = tagId.ToString();
                        txttagName.Text = tag.tagName;
                        txttagCode.Text = tag.tagCode;
                        comborelatedTag.SelectedItem = tag.relatedTag;

                    }
                    else
                    {
                        label5.Text = string.Empty;
                        txttagName.Text = string.Empty;
                        txttagCode.Text = string.Empty;
                        comborelatedTag.SelectedIndex = -1;

                    }
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("no data selected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    int tagId = Convert.ToInt32(dataGridView1.Text);
                    Tag tag = new Tag();
                    tag.tagId = tagId;
                    tag.tagName = txttagName.Text;
                    tag.tagCode = txttagCode.Text;
                    tag.relatedTag = comborelatedTag.SelectedItem.ToString();

                    string message = TagController.UpdateTag(tag);
                    MessageBox.Show(message);
                    loadgrid();
                    clear();
                }
                else
                {
                    MessageBox.Show("please fill in all fields!");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool validatefields()
        {
            if (txttagName.Text != ""
                && txttagCode.Text != ""
                && comborelatedTag.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }
        private void clear()
        {
            txttagName.Text = string.Empty;
            txttagCode.Text = string.Empty;
            comborelatedTag.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int tagId = Convert.ToInt32(dataGridView1.Text);
                string message = TagController.DeleteTag(tagId);
                MessageBox.Show(message);
                loadgrid();
                clear();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("please select a specific tag");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void ManageTag_Load_1(object sender, EventArgs e)
        {
            loadgrid();
        }
    }
}
