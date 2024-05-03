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
    public partial class DifficultyCountries : Form
    {
        public DifficultyCountries()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameLightCountries glcount = new GameLightCountries();
            glcount.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameAverageCountries gacount = new GameAverageCountries();
            gacount.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameDifficultCountries gdcount = new GameDifficultCountries();
            gdcount.Show();
            this.Hide();
        }

        private void DifficultyCountries_Load(object sender, EventArgs e)
        {

        }
    }

}
