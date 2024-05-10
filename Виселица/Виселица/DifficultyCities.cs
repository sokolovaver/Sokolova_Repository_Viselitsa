/**
    @file DifficultyCities.cs
    @brief Файл окна выбора уровней сложности для категории городов
    @copyright Viselitsa
    @author Соколова В.А.
    @date 10-05-2024
    @version 1.1.20
\par Использует класс:
    @ref DifficultyCities
\par Содержит класс:
    @ref DifficultyCities
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
    @brief Класс DifficultyCities

    Основной и единственный класс, отвечающий за окно выбора уровней сложности для категории городов
    */
    public partial class DifficultyCities : Form
    {
        
        /// Метод инициализации
        /** Инициализация всех компонентов окна Сложность города
        */
        public DifficultyCities()
        {
            InitializeComponent();
        }

        /** 
        @brief Кнопка button1
       
        Запускает открытие окна игры для легкого уровня сложности категории городов
        @param glcities Переменная для открытия окна игры для легкого уровня сложности категории городов
        */
        private void button1_Click(object sender, EventArgs e)
        {
            GameLightCities glcities = new GameLightCities();
            glcities.Show(); 
            this.Hide();
        }

        /** 
        @brief Кнопка button2
       
        Запускает открытие окна игры для среднего уровня сложности категории городов
        @param gacities Переменная для открытия окна игры для среднего уровня сложности категории городов
        */
        private void button2_Click(object sender, EventArgs e)
        {
            GameAverageCities gacities = new GameAverageCities();
            gacities.Show(); 
            this.Hide();
        }

        /** 
        @brief Кнопка button3
       
        Запускает открытие окна игры для сложного уровня сложности категории городов
        @param gdcities Переменная для открытия окна игры для сложного уровня сложности категории городов
        */
        private void button3_Click(object sender, EventArgs e)
        {
            GameDifficultCities gdcities = new GameDifficultCities();
            gdcities.Show(); 
            this.Hide();
        }

        /// Метод-обработчик вывода
        /** Вывод информации об уровнях сложности категории городов
        */
        private void DifficultyCities_Load(object sender, EventArgs e)
        {

        }
    }

}
