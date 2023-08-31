using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year_Month_Day
{
    public partial class listViewUsing : Form
    {
        public listViewUsing()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                if (item == null)
                {
                    return;
                }
                string str = "";
                str += "名字：" + item.Text + "\n";
                str += "属性：" + item.SubItems[1].Text + "\n";
                str += "伤害：" + item.SubItems[2].Text + "\n";
                str += "可操作性：" + item.SubItems[3].Text + "\n";
                MessageBox.Show(str);
            }
            
        }

        private void listViewUsing_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("奎桑提");
            item.ImageIndex = 1;
            item.SubItems.Add("物理疯");
            item.SubItems.Add("可观");
            item.SubItems.Add("w(ﾟДﾟ)w");
            listView1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in listView2.SelectedItems)
                {
                    int index = item.Index;
                    Console.WriteLine(index);
                }
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
