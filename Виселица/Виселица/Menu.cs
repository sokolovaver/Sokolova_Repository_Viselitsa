/**
    @file Menu.cs
    @brief Файл основного меню игры
    @copyright Viselitsa
    @author Соколова В.А.
    @date 10-05-2024
    @version 1.1.20
\par Использует класс:
    @ref Menu
\par Содержит класс:
    @ref Menu
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
    @brief Класс Menu

    Основной и единственный класс, отвечающий за основное меню игры
    */
    public partial class Menu : Form
    {
        /// Метод инициализации
        /** Инициализация всех компонентов окна Меню
        */
        public Menu()
        {
            InitializeComponent();
        }

        /** 
        @brief Кнопка button1
        
        Запускает окно авторизации игрока
        */
        private void button1_Click(object sender, EventArgs e)
        {
            Player pl = new Player();
            pl.Show();/// Переход на форму
            this.Hide();/// Закрытие предыдущей формы
        }

        /** 
        @brief Кнопка button2
        
        Запускает окно справки игры
        */
        private void button2_Click(object sender, EventArgs e)
        {
            Spravka sp = new Spravka();
            sp.Show();/// Переход на форму
            this.Hide();/// Закрытие предыдущей формы
        }

        /** 
        @brief Кнопка button3
        
        Запускает выход из программы
        */
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); /// Кнопка выхода
        }

        /// Метод-обработчик события
        /** Открытие поля основного меню игры
        */
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        /** 
        @brief Кнопка button4
        
        Запускает окно таблицы лидеров
        */
        private void button4_Click(object sender, EventArgs e)
        {
            Table tab = new Table();
            tab.Show();/// Переход на форму
            this.Hide();/// Закрытие предыдущей формы
        }
    }

}
