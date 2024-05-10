/**
    @file DifficultyAnimals.cs
    @brief Файл окна выбора уровней сложности для категории животных
    @copyright Viselitsa
    @author Соколова В.А.
    @date 10-05-2024
    @version 1.1.20
\par Использует класс:
    @ref DifficultyAnimals
\par Содержит класс:
    @ref DifficultyAnimals
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
    @brief Класс DifficultyAnimals

    Основной и единственный класс, отвечающий за окно выбора уровней сложности для категории животных
    */
    public partial class DifficultyAnimals : Form
    {
        /// Метод инициализации
        /** Инициализация всех компонентов окна Сложность животные
        */
        public DifficultyAnimals()
        {
            InitializeComponent();
        }

        /// Метод-обработчик вывода
        /** Вывод информации об уровнях сложности категории животных
        */
        private void DifficultyAnimals_Load(object sender, EventArgs e)
        {

        }
        /** 
        @brief Кнопка button1
       
        Запускает открытие окна игры для легкого уровня сложности категории животных
        @param gla Переменная для открытия окна игры для легкого уровня сложности категории животных
        */
        private void button1_Click(object sender, EventArgs e)
        {
            GameLightAnimals gla = new GameLightAnimals();
            gla.Show();
            this.Hide();
        }

        /** 
        @brief Кнопка button2
       
        Запускает открытие окна игры для среднего уровня сложности категории животных
        @param gaa Переменная для открытия окна игры для среднего уровня сложности категории животных
        */
        private void button2_Click(object sender, EventArgs e)
        {
            GameAverageAnimals gaa = new GameAverageAnimals();
            gaa.Show();
            this.Hide();
        }

        /** 
        @brief Кнопка button3
       
        Запускает открытие окна игры для сложного уровня сложности категории животных
        @param gda Переменная для открытия окна игры для сложного уровня сложности категории животных
        */
        private void button3_Click(object sender, EventArgs e)
        {
            GameDifficultAnimals gda = new GameDifficultAnimals();
            gda.Show();
            this.Hide();
        }
    }

}
