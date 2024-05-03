using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;

namespace Виселица
{
    public partial class GameDifficultAnimals : Form
    {

        public GameDifficultAnimals()
        {
            InitializeComponent();
        }

        private void GameDifficultAnimals_Load(object sender, EventArgs e)
<<<<<<< HEAD
        {
            string str = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            int posX = 150, posY = 150;
            for (int i = 0; i < str.Count(); i++)//созданиецикла
            {

                Button button = new Button();
                button.BackColor = Color.PaleTurquoise;//цветкнопки
                button.Text = str[i] + "";//присваивает значение след.буквы
                button.Click += new EventHandler(this.button_Click);
                button.Location = new System.Drawing.Point(posX, posY);//рисованиекнопки
                button.Size = new System.Drawing.Size(35, 30);//заданиеразмеракнопки
                this.Controls.Add(button);//добавлениекнопки
                posX += button.Width;//ширинакнопки
                if ((i + 1) % 8 == 0)
                {
                    posX = 150;
                    posY += button.Height;
                }
            }
            start_new_game();
        }
        private void start_new_game()//начальная позиция
=======
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        {

        }
        void button_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Menu me = new Menu();
            me.Show();
            this.Hide();
=======

>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }
    }
}

