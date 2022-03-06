using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classwork0403
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }
        Form1 form1;


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            
                if (radioButton1.Checked = true)
                {
                    form1.famText.Enabled = true;
                    form1.nameText.Enabled = true;
                    form1.desText.Enabled = true;
                }
                else
                {
                    form1.famText.Enabled = false;
                    form1.nameText.Enabled = false;
                    form1.desText.Enabled = false;


                }
            }
        }

    }

