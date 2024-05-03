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
    public partial class Spravka : Form
    {
        public Spravka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра заключается в том, что загадывается слово, а игрок угадывает буквы и все слово целиком. \nЗагаданное слово является именем существительным единственного числа. \nВсего попыток 6. Если игрок выбирает неверную букву, то количество попыток уменьшается. Если человек в виселице нарисован полностью, то игрок проигрывает. Если игроку удаётся угадать слово, он выигрывает.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
