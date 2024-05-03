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
    public partial class Player : Form
    {

<<<<<<< HEAD
=======
        Button b1 = new Button();
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        public Player()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD
=======
            Menu men = new Menu();
            men.Show();//переход на форму
            this.Hide();//закрытие предыдущей формы
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            if (textBox1.Text != "")
            {
                ScoreBoard.me = textBox1.Text;
                DifficultyCountries dcount = new DifficultyCountries();
                dcount.Show();//переход на форму
                this.Hide();//закрытие предыдущей формы
            }
            else
            {
                MessageBox.Show("Введите имя");
            }

>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c

        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            if (textBox1.Text != "")
            {
                ScoreBoard.me = textBox1.Text;
                DifficultyAnimals da = new DifficultyAnimals();
                da.Show();//переход на форму
                this.Hide();//закрытие предыдущей формы
            }
            else
            {
                MessageBox.Show("Введите имя");
            }
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            if (textBox1.Text != "")
            {
                ScoreBoard.me = textBox1.Text;
                DifficultyCities dcities = new DifficultyCities();
                dcities.Show();//переход на форму
                this.Hide();//закрытие предыдущей формы
            }
            else
            {
                MessageBox.Show("Введите имя");
            }
        }

        private void saveName()
        {
            // Create a simple setting


>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Player_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_ChangedPlayer(object sender, EventArgs e)
        {

        }
    }

}
