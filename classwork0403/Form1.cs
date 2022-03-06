using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace classwork0403
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void linkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkGit.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=wNhrsZrOWoQ&t=783s");
        }

        private void firstvkladka_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string title = "TabPage " + (firstvkladka.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            firstvkladka.TabPages.Add(myTabPage);
        }

        private void settingsButton_MouseClick(object sender, MouseEventArgs e)
        {

            settings sttg = new settings();
            sttg.Show();
            this.Hide();

        }

        private void tabInfo_Load(object sender, DataGridViewCellEventArgs e)
        {
            string path = "C:\\Users\\talda\\source\\repos\\classwork040322\\classwork0403\\bin\\Debug\\tabInfo.txt";
            string[] str;
            tabInfo.ColumnCount = 3;
            tabInfo.RowCount = 3;
            using (System.IO.StreamReader read = new System.IO.StreamReader(path, System.Text.Encoding.Default))
            {
                str = read.ReadToEnd().Split(new Char[] { ' ', '\n', '\r' }); // и n

                int pos = 0;

                for (int i = 0; i < tabInfo.RowCount; i++)
                {
                    for (int j = 0; j < tabInfo.ColumnCount; j++)
                    {
                        while (str[pos] == "")
                        {
                            pos++;
                        }

                        tabInfo[j, i].Value = str[pos];

                        pos++;
                    }

                }
            }
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            savebutton.DialogResult = DialogResult.OK;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Текстовый файл |*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamwriter = new StreamWriter(save.FileName);
                streamwriter.WriteLine(famText.Text);
                streamwriter.WriteLine(nameText.Text);
                streamwriter.WriteLine(desText.Text);
                streamwriter.Close();
            }

        }
    }
}
