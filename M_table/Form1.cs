using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            dataGridView1.Columns.Clear();

            // ساخت ستون‌ها (۱ تا ۱۰)
            for (int c = 1; c <= 10; c++)
            {
                var col = new DataGridViewTextBoxColumn();
                col.HeaderText = c.ToString();
                col.Width = 50;
                dataGridView1.Columns.Add(col);
            }

            // ساخت ردیف‌ها
            for (int r = 1; r <= 10; r++)
            {
                object[] cells = new object[10];
                for (int c = 1; c <= 10; c++)
                {
                    cells[c - 1] = r * c;
                }

                int index = dataGridView1.Rows.Add(cells);
                dataGridView1.Rows[index].HeaderCell.Value = r.ToString();
            }

            // فقط برای زیبایی (اختیاری)
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }
    }
}
