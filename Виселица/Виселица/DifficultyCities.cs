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
            GameLightCities glcities = new GameLightCities();
            glcities.Show(); //переход на форму с лёгким уровнем сложности для категории города
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameAverageCities gacities = new GameAverageCities();
            gacities.Show(); //переход на форму с уровнем сложности для категории города
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameDifficultCities gdcities = new GameDifficultCities();
            gdcities.Show(); //переход на форму с уровнем сложности для категории города
            this.Hide();
        }

        private void DifficultyCities_Load(object sender, EventArgs e)
        {

        }
    }

}
