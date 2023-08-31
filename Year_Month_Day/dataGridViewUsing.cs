using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Year_Month_Day.Properties;
using static System.Net.Mime.MediaTypeNames;

namespace Year_Month_Day
{
    public partial class dataGridViewUsing : Form
    {
        public dataGridViewUsing()
        {
            InitializeComponent();
        }
        private BindingList<Student> students = null;
        private void dataGridViewUsing_Load(object sender, EventArgs e)
        {
            //添加数据方式1：创建单元格行和列，把列添加到行中，把行添加到dataGridView1中
            DataGridViewRow row1 = new DataGridViewRow();
            DataGridViewTextBoxCell col1 = new DataGridViewTextBoxCell() { Value = "2" };
            DataGridViewTextBoxCell col2 = new DataGridViewTextBoxCell() { Value = "李四" };
            DataGridViewComboBoxCell col3 = new DataGridViewComboBoxCell();
            col3.Items.Add("公务员");
            col3.Items.Add("程序猿");
            DataGridViewLinkCell col4 = new DataGridViewLinkCell() { Value = "http://www.baidu.com" };
            DataGridViewButtonCell col5 = new DataGridViewButtonCell() { Value = "删除" };

            //指定图片的缩放模式
            System.Drawing.Image img1 = Properties.Resources._4;
            Bitmap bmp1 = new Bitmap(img1.Width / 8, img1.Height / 8);
            //画布
            Graphics g = Graphics.FromImage(bmp1);
            //HighQualityBicubic 实现高质量的图像缩放效果
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //将图片画到画布中
            g.DrawImage(img1, new Rectangle(0, 0, img1.Width / 8, img1.Height / 8));
            DataGridViewImageCell col6 = new DataGridViewImageCell() { Value = bmp1 };

            row1.Cells.Add(col1);
            row1.Cells.Add(col2);
            row1.Cells.Add(col3);
            row1.Cells.Add(col4);
            row1.Cells.Add(col5);
            row1.Cells.Add(col6);

            dataGridView1.Rows.Add(row1);


            //添加数据方式2：使用Cells的控件名称或者索引来添加
            //返回新行索引 第一行的索引是0
            int rowIndex1 = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowIndex1].Cells["ColumnJing"] = new DataGridViewTextBoxCell() { Value = "1" };
            dataGridView1.Rows[rowIndex1].Cells["ColumnName"] = new DataGridViewTextBoxCell() { Value = "张三" };
            dataGridView1.Rows[rowIndex1].Cells["ColumnBlog"] = new DataGridViewTextBoxCell() { Value = "http://www.baidu.com" };
            dataGridView1.Rows[rowIndex1].Cells["ColumnOpt"] = new DataGridViewButtonCell() { Value = "删除" };

            //指定图片的缩放模式
            System.Drawing.Image image = Properties.Resources._5;
            Bitmap bitmap = new Bitmap(image.Width / 8, image.Height / 8);
            //画布
            Graphics g2 = Graphics.FromImage(bitmap);
            //HighQualityBicubic 实现高质量的图像缩放效果
            g2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //将图片画到画布中
            g2.DrawImage(image, new Rectangle(0, 0, image.Width / 8, image.Height / 8));
            dataGridView1.Rows[rowIndex1].Cells["ColumnImage"] = new DataGridViewImageCell() { Value = bitmap };



            //禁用自动添加列
            dataGridView1.AutoGenerateColumns = false;

            /*
            Student stu1 = new Student()
            {
                Id = 1,
                Name = "张三",
                Age = 10,
                Phone = "1828282882",
                Job = "校长"
            };
            Student stu2 = new Student()
            {
                Id = 2,
                Name = "李四",
                Age = 10,
                Phone = "1828282882",
                Job = "老师"
            };
            Student stu3 = new Student()
            {
                Id = 3,
                Name = "王五",
                Age = 10,
                Phone = "1828282882",
                Job = "学生"
            };

            students = new BindingList<Student>() { stu1, stu2, stu3 };

            //当给dataGridView1通过DataSource指定数据源的时候，最好是BindingList或者BindSource
            //在通过DataSource指定数据源的时候，不建议使用dataGridView1.Rows.Add  .Remove去添加行和删除行了
            dataGridView1.DataSource = students;

            //给每一行的最后一列添加一个按钮，并且设置每一行的Combobox的数据
            foreach (DataGridViewRow tmpRow in dataGridView1.Rows)
            {
                //给ComboBox指定数据
                DataGridViewComboBoxCell comBoxCell = tmpRow.Cells["ColumnCareer"] as DataGridViewComboBoxCell;
                comBoxCell.Items.Add("校长");
                comBoxCell.Items.Add("老师");
                comBoxCell.Items.Add("学生");

                if (tmpRow.Index != students.Count)
                {
                    //指定comBoxCell的选中项
                    Student current = students[tmpRow.Index];
                    comBoxCell.Value = current.Job;

                    //给最后一列添加一个按钮
                    DataGridViewButtonCell buttonCell = tmpRow.Cells["ColumnOpt"] as DataGridViewButtonCell;
                    buttonCell.Value = "删除";
                }
            }
            */
        }



        //双击单元格事件
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.ColumnIndex点击的列  e.RowIndex点击的行
            //判断是否是删除按钮
            if (e.ColumnIndex == 4)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
            //判断是否是博客链接
            else if (e.ColumnIndex == 3)
            {
                string url = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                System.Diagnostics.Process.Start(url);
            }
        }
    }

        /*
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Console.WriteLine("点击了删除按钮");
                students.RemoveAt(e.RowIndex);
            }

        }
        */
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Job { get; set; }
    }
}
