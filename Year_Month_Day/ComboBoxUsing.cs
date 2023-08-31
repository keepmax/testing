using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year_Month_Day
{
    public partial class ComboBoxUsing : Form
    {
        public ComboBoxUsing()
        {
            
            InitializeComponent();
            //给年份的ComboBox添加数据
            int year = DateTime.Now.Year;
            for (; year >= 1949; year--)
            {
                comboBoxYear.Items.Add(year);
            }
            comboBoxYear.SelectedIndex = 0;

            //给月份的ComboBox添加数据
            for (int i = 1; i <= 12; i++)
            {
                comboBoxMonth.Items.Add(i);
            }
            comboBoxMonth.SelectedIndex = 0;
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMonth.Items.Count != 0) {
                int year = (int)comboBoxYear.SelectedItem;
                int month = (int)comboBoxMonth.SelectedItem;
                comboBoxDay.Items.Clear();

                int day = getDays(year, month);
                for(int i = 1; i <= day; i++)
                {
                    comboBoxDay.Items.Add(i);
                }
                comboBoxDay.SelectedIndex = 0;
            }
        }

        private int getDays(int year, int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                        return 28;
                    else return 29;
                default:
                    return 0;
            }

        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
