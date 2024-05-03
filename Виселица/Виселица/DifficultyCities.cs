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
    public partial class DifficultyCities : Form
    {
        public DifficultyCities()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            GameLightCities glcities = new GameLightCities();
            glcities.Show(); //переход на форму с лёгким уровнем сложности для категории города
            this.Hide();
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            GameAverageCities gacities = new GameAverageCities();
            gacities.Show(); //переход на форму с уровнем сложности для категории города
            this.Hide();
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            GameDifficultCities gdcities = new GameDifficultCities();
            gdcities.Show(); //переход на форму с уровнем сложности для категории города
            this.Hide();
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void DifficultyCities_Load(object sender, EventArgs e)
        {

        }
    }

}
