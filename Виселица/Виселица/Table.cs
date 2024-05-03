using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Виселица
{
    public partial class Table : Form
    {
        Dictionary<string, int> scores;

        public Table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Show();//переход на форму
            this.Hide();//закрытие предыдущей формы
        }

        private void Table_Load(object sender, EventArgs e)
        {
            scores = ScoreBoard.get();
            scores = scores.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = scores.Count;
            int i = 0;
            foreach (KeyValuePair<string, int> score in scores)
            {
                dataGridView1[0, i].Value = score.Key;
                dataGridView1[1, i].Value = score.Value.ToString();
                i++;
            }

        }
    }

}
