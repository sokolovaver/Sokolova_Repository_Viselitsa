/**
    @file Player.cs
    @brief Файл авторизации пользователей
    @copyright Viselitsa
    @author Соколова В.А.
    @date 10-05-2024
    @version 1.1.20
\par Использует класс:
    @ref Player
\par Содержит класс:
    @ref Player
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
    @brief Класс Player

    Основной и единственный класс, отвечающий за окно авторизации пользователей
    */
    public partial class Player : Form
    {

        Button b1 = new Button(); ///< Вывод новой кнопки

        /// Метод инициализации
        /** Инициализация всех компонентов окна Игрок
        */
        public Player()
        {
            InitializeComponent();
        }

        /** 
        @brief Кнопка button4
        
        Запускает открытие окна основного меню игры
        @param men Переменная для открытия основного меню игры
        */
        private void button4_Click(object sender, EventArgs e)
        {

            Menu men = new Menu();
            men.Show();/// Переход на форму
            this.Hide();/// Закрытие предыдущей формы
        }

        /** 
        @brief Кнопка button1
        
        Запускает открытие окна выбора сложности для категории стран
        @param dcount Переменная для открытия окна выбора сложности для категории стран
        @param me Переменная для вывода текстового поля
        */
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ScoreBoard.me = textBox1.Text;
                DifficultyCountries dcount = new DifficultyCountries();
                dcount.Show();/// Переход на форму
                this.Hide();/// Закрытие предыдущей формы
            }
            else
            {
                MessageBox.Show("Введите имя");
            }


        }

        /** 
        @brief Кнопка button2
        
        Запускает открытие окна выбора сложности для категории животных
        @param da Переменная для открытия окна выбора сложности для категории животных
        @param me Переменная для вывода текстового поля
        */
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ScoreBoard.me = textBox1.Text;
                DifficultyAnimals da = new DifficultyAnimals();
                da.Show();/// Переход на форму
                this.Hide();/// Закрытие предыдущей формы
            }
            else
            {
                MessageBox.Show("Введите имя");
            }
        }

        /** 
        @brief Кнопка button3
        
        Запускает открытие окна выбора сложности для категории городов
        @param dcities Переменная для открытия окна выбора сложности для категории городов
        @param me Переменная для вывода текстового поля
        */
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ScoreBoard.me = textBox1.Text;
                DifficultyCities dcities = new DifficultyCities();
                dcities.Show();/// Переход на форму
                this.Hide();/// Закрытие предыдущей формы
            }
            else
            {
                MessageBox.Show("Введите имя");
            }
        }

        /** 
        @brief Метод сохранения имени
        
        Сохраняет имена игроков
        */
        private void saveName()
        {


        }

        /// Метод-обработчик изменения
        /** Срабатывает, когда происходит изменение имени игрока
        */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// Метод-обработчик вывода
        /** Вывод поля авторизации пользователя
        */
        private void Player_Load(object sender, EventArgs e)
        {

        }

        /// Метод-обработчик изменения
        /** Срабатывает, когда происходит изменение игрока
        */
        private void textBox1_ChangedPlayer(object sender, EventArgs e)
        {

        }
    }

}
