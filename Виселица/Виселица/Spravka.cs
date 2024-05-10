/**
    @file Spravka.cs
    @brief Файл справки игры
    @copyright Viselitsa
    @author Соколова В.А.
    @date 10-05-2024
    @version 1.1.20
\par Использует класс:
    @ref Spravka
\par Содержит класс:
    @ref Spravka
*/
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
    /**
    @brief Класс Spravka

    Основной и единственный класс, отвечающий за окно со справкой игры
    */
    public partial class Spravka : Form
    {
        /// Метод инициализации
        /** Инициализация всех компонентов окна Справка
        */
        public Spravka()
        {
            InitializeComponent();
        }

        /** 
       @brief Кнопка button1
       
       Запускает вывод сообщения с информацией о правилах игры
       */
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра заключается в том, что загадывается слово, а игрок угадывает буквы и все слово целиком. \nЗагаданное слово является именем существительным единственного числа. \nВсего попыток 6. Если игрок выбирает неверную букву, то количество попыток уменьшается. Если человек в виселице нарисован полностью, то игрок проигрывает. Если игроку удаётся угадать слово, он выигрывает.");
        }

       /** 
       @brief Кнопка button2
       
       Запускает открытие окна основного меню игры
       @param me Переменная для открытия основного меню игры
       */
        private void button2_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Show();
            this.Hide();
        }

        /// Метод-обработчик вывода
        /** Вывод информации о разработчике
        */
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        /// Метод-обработчик нажатия
        /** Вывод информации о разработчике
        */
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
