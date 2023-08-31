using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year_Month_Day
{
    public partial class ListBoxUsing : Form
    {
        public ListBoxUsing()
        {
            InitializeComponent();
            
        }
        public void Form3_Load(object sender, EventArgs e)
        {
            System.Resources.ResourceSet resourceset = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture,true,true);
            foreach(DictionaryEntry src in resourceset)
            {
                listBox1.Items.Add(src.Key);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj = Properties.Resources.ResourceManager.GetObject($"{listBox1.SelectedItem}");
            pictureBox1.Image = (Image)obj; 
        }
    }
    internal class Costum
    {

    }
}
