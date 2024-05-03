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
<<<<<<< HEAD

=======
            GameLightCountries glcount = new GameLightCountries();
            glcount.Show();
            this.Hide();
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            GameAverageCountries gacount = new GameAverageCountries();
            gacount.Show();
            this.Hide();
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            GameDifficultCountries gdcount = new GameDifficultCountries();
            gdcount.Show();
            this.Hide();
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void DifficultyCountries_Load(object sender, EventArgs e)
        {

        }
    }

}
