/**
    @file ScoreBoard.cs
    @brief Файл таблицы рекордов
    @copyright Viselitsa
    @author Соколова В.А.
    @date 10-05-2024
    @version 1.1.20
\par Использует класс:
    @ref ScoreBoard
\par Содержит класс:
    @ref ScoreBoard
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Виселица
{
    /**
    @brief Класс ScoreBoard

    Основной и единственный класс, отвечающий за таблицу рекордов
    */
    class ScoreBoard
    {
        /// Метод определения таблицы рекордов
        /** Определение таблицы рекордов
        @param me Таблица рекордов
        */
        public static string me { get; set; }

        /// Метод сохранения информации в текстовый файл
        /** Сохранение информации в файл
        @param l Количество побед
        @param name Имя игрока
        */
        public static Dictionary<string, int> get()
        {
            return File.ReadAllLines("Рекорды.txt").Where(l => !string.IsNullOrWhiteSpace(l)).ToDictionary(name => name.Substring(0, name.IndexOf("|")), name => int.Parse(name.Substring(name.IndexOf("|")+1)));
        }

        /// Метод счётчика побед
        /** Счётчик побед
        @param score Количество побед
        @param me Определение таблицы
        @param arr Массив строк
        @param z Счётчик строк
        */
        public static void win()
        {
            Dictionary<string, int> score = get();
            if (score.ContainsKey(me)) score[me] += 1;
            else score.Add(me, 1);

            string[] arr = score.Select(z => (z.Key + "|" + z.Value)).ToArray();
            File.WriteAllLines("Рекорды.txt", arr);
        }
       
    }
}
