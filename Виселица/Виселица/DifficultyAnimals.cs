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
    public partial class DifficultyAnimals : Form
    {
        public DifficultyAnimals()
        {
            InitializeComponent();
        }

        private void DifficultyAnimals_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            GameLightAnimals gla = new GameLightAnimals();
            gla.Show();
            this.Hide();
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            GameAverageAnimals gaa = new GameAverageAnimals();
            gaa.Show();
            this.Hide();
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            GameDifficultAnimals gda = new GameDifficultAnimals();
            gda.Show();
            this.Hide();
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }
    }

}
