/**
    @file Table.cs
    @brief Файл таблицы лидеров
    @copyright Viselitsa
    @author Соколова В.А.
    @date 10-05-2024
    @version 1.1.20
\par Использует класс:
    @ref Table
\par Содержит класс:
    @ref Table
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
    @brief Класс Table

    Основной и единственный класс, отвечающий за окно с таблицей лидеров
    */
    public partial class Table : Form
    {
        Dictionary<string, int> scores; ///< Количество побед

        /// Метод инициализации
        /** Инициализация всех компонентов окна Таблица лидеров
        */
        public Table()
        {
            InitializeComponent();
        }

        /** 
        @brief Кнопка button1
        
        Запускает открытие окна основного меню игры
        @param me Переменная для открытия основного меню игры
        */
        private void button1_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Show();//переход на форму
            this.Hide();//закрытие предыдущей формы
        }

        /// Метод-обработчик вывода
        /** Вывод таблицы лидеров
        @param scores Количество побед
        @param x Счётчик побед
        @param ColumnCount Число столбцов таблицы
        @param RowCount Число строк таблицы
        @param i Счётчик номеров игроков и побед
        @param Value Номера игроков
        */
        private void Table_Load(object sender, EventArgs e)
        {
            scores = ScoreBoard.get();
            scores = scores.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = scores.Count;
            int i = 0;
            foreach (KeyValuePair<string, int> score in scores)
            {
                dataGridView1[0, i].Value = score.Key;
                dataGridView1[1, i].Value = score.Value.ToString();
                i++;
            }

        }
    }

}
