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

        Button b1 = new Button();
        public Player()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Menu men = new Menu();
            men.Show();//переход на форму
            this.Hide();//закрытие предыдущей формы
        }

        private void button1_Click(object sender, EventArgs e)
        {
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


        }

        private void button2_Click(object sender, EventArgs e)
        {
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
