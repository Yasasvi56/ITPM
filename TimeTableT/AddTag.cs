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
    public partial class AddTag : Form
    {
        public AddTag()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidated = validatefields();
                if (isvalidated)
                {
                    Tag tag = new Tag();
                    tag.tagName = txttagName.Text;
                    tag.tagCode = txttagCode.Text;
                    tag.relatedTag = comborelatedTag.SelectedItem.ToString();



                    string message = TagController.AddTag(tag);
                    MessageBox.Show(message);
                    clear();
                }
                else
                {
                    MessageBox.Show("please fill in all fields!");
                }
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("please fill in all fields!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private bool validatefields()
        {
            if (txttagName.Text != "" || txttagCode.Text != ""
                || comborelatedTag.SelectedIndex != -1)

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


    }
}
