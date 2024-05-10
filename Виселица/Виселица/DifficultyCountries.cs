/**
    @file DifficultyCountries.cs
    @brief Файл окна выбора уровней сложности для категории стран
    @copyright Viselitsa
    @author Соколова В.А.
    @date 10-05-2024
    @version 1.1.20
\par Использует класс:
    @ref DifficultyCountries
\par Содержит класс:
    @ref DifficultyCountries
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
    @brief Класс DifficultyCountries

    Основной и единственный класс, отвечающий за окно выбора уровней сложности для категории стран
    */
    public partial class DifficultyCountries : Form
    {
        /// Метод инициализации
        /** Инициализация всех компонентов окна Сложность страны
        */
        public DifficultyCountries()
        {
            InitializeComponent();
        }

        /** 
        @brief Кнопка button1
       
        Запускает открытие окна игры для легкого уровня сложности категории стран
        @param glcount Переменная для открытия окна игры для легкого уровня сложности категории стран
        */
        private void button1_Click(object sender, EventArgs e)
        {
            GameLightCountries glcount = new GameLightCountries();
            glcount.Show();
            this.Hide();
        }

        /** 
        @brief Кнопка button2
       
        Запускает открытие окна игры для среднего уровня сложности категории стран
        @param gacount Переменная для открытия окна игры для среднего уровня сложности категории стран
        */
        private void button2_Click(object sender, EventArgs e)
        {
            GameAverageCountries gacount = new GameAverageCountries();
            gacount.Show();
            this.Hide();
        }

        /** 
        @brief Кнопка button3
       
        Запускает открытие окна игры для сложного уровня сложности категории стран
        @param gdcount Переменная для открытия окна игры для сложного уровня сложности категории стран
        */
        private void button3_Click(object sender, EventArgs e)
        {
            GameDifficultCountries gdcount = new GameDifficultCountries();
            gdcount.Show();
            this.Hide();
        }

        /// Метод-обработчик вывода
        /** Вывод информации об уровнях сложности категории стран
        */
        private void DifficultyCountries_Load(object sender, EventArgs e)
        {

        }
    }

}
