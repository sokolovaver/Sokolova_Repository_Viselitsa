/**
    @file GameAverageCountries.cs
    @brief Файл окна игрового поля для среднего уровня категории стран
    @copyright Viselitsa
    @author Соколова В.А.
    @date 10-05-2024
    @version 1.1.20
\par Использует класс:
    @ref GameAverageCountries
\par Содержит класс:
    @ref GameAverageCountries
*/
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
    /**
    @brief Класс GameAverageCountries

    Основной и единственный класс, отвечающий за окно игрового поля для среднего уровня категории стран
    */
    public partial class GameAverageCountries : Form
    {
        string word; ///< Необходимое слово
        int numGuessesInt; ///< Число догадок
        List<char> guessedLetters; ///< Угаданные буквы

        /// Метод инициализации
        /** Инициализация всех компонентов окна Игровое поле среднего уровня категории стран
        */
        public GameAverageCountries()
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
            me.Show();
            this.Hide();
        }

        /// Метод-обработчик вывода
        /** Вывод кнопок с буквами для выбора букв угадываемого слова
        @param str Все буквы алфавита
        @param posX Позиция X для рисования кнопок
        @param posY Позиция Y для рисования кнопок
        @param i Счётчик кнопок
        @param button Переменная для создания кнопки
        */
        private void GameAverageCountries_Load(object sender, EventArgs e)
        {
            string str = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            int posX = 150, posY = 150;
            for (int i = 0; i < str.Count(); i++)/// Создание цикла
            {

                Button button = new Button();
                button.BackColor = Color.PaleTurquoise;/// Цвет кнопки
                button.Text = str[i] + "";/// Присваивает значение след.буквы
                button.Click += new EventHandler(this.button_Click);
                button.Location = new System.Drawing.Point(posX, posY);/// Рисование кнопки
                button.Size = new System.Drawing.Size(35, 30);/// Задание размера кнопки
                this.Controls.Add(button);/// Добавление кнопки
                posX += button.Width;/// Ширина кнопки
                if ((i + 1) % 8 == 0)
                {
                    posX = 150;
                    posY += button.Height;
                }
            }
            start_new_game();
        }

        /// Метод начальной позиции игры
        /** Отображение начальной позиции игрового поля
        @param numGuessesInt Количество попыток
        @param guessedLetters Отгаданные буквы
        @param word Слово для отгадывания
        */
        private void start_new_game()
        {

            numGuessesInt = 6;
            guessedLetters = new List<char>();
            word = pickWord();
            MessageBox.Show("Угадай страну");
            label2.Text = displayWord();
            label3.Text = "";
            pictureBox1.Load(@"Виселица 1.jpg");
        }
        
        /// Метод выбора слова рандомно
        /** Выбор слова рандомно
        @param wordList Список слов
        @param randomGen Выбранное слово
        */
        static string pickWord()
        {
            string[] wordList = File.ReadAllLines("Страны ср. ур.txt");
            Random randomGen = new Random();
            return wordList[randomGen.Next(wordList.Count())];
        }

        /// Метод ввода угадываемого слова
        /** Ввод угадываемого слова
        @param returnedWord Возвращаемое слово
        @param guessedLetters Угаданные буквы
        @param letter Буквы
        @param word Слово
        @param letterMatch Совпадающие буквы
        @param character Переменная для поочерёдного угадывания букв в слове
        */
        private string displayWord()
        {
            string returnedWord = "";
            if (guessedLetters.Count == 0)
            {
                foreach (char letter in word) returnedWord += "_ ";
                return returnedWord;
            }
            foreach (char letter in word)
            {
                bool letterMatch = false;
                foreach (char character in guessedLetters)

                    if (char.ToLower(character) == char.ToLower(letter))
                    {
                        returnedWord += character + " ";
                        letterMatch = true;
                        break;
                    }
                    else letterMatch = false;

                if (letterMatch == false) returnedWord += "_ ";
            }
            return returnedWord;
        }

        /// Метод вывода изображений виселицы различной степени заполнения
        /** Вывод изображений виселицы различной степени заполнения
        @param letter_btn Кнопка для буквы
        @param sender Вид изображения
        @param guessedLetter Угаданная буква
        @param letters Слова
        @param repeat Повторение букв
        @param i Счётчик угаданных букв
        @param guessedLetters Угаданные буквы
        @param word Угадываемое слово
        @param numGuessesInt Количество догадок
        @param letter Буква
        @param wordToDisplay Слово для отображения
        */
        void button_Click(object sender, System.EventArgs e)
        {
            Button letter_btn = sender as Button;
            string guessedLetter = letter_btn.Text;
            string letters = "";

            bool repeat = false;
            for (int i = 0; i < guessedLetters.Count; i++)
                if (char.ToLower(guessedLetters[i]) == char.ToLower(guessedLetter.ToCharArray()[0])) repeat = true;

            if (repeat == false)
            {
                guessedLetters.Add(guessedLetter.ToCharArray()[0]);
                if (!word.ToLower().Contains(char.ToLower(guessedLetter.ToCharArray()[0])))
                    numGuessesInt -= 1;
                pictureBox1.Load(@"Виселица " + (7 - numGuessesInt) + ".jpg");/// Изменение картинки, если не угадал букву

                foreach (char letter in guessedLetters) letters += " " + letter;
                label2.Text = letters;

                string wordToDisplay = displayWord();
                label3.Text = displayWord();

                if (!wordToDisplay.Contains("_"))
                {
                    MessageBox.Show("Вы выиграли! Правильное слово: " + word);
                    ScoreBoard.win();
                    start_new_game();
                }
                else if (numGuessesInt <= 0)
                {

                    MessageBox.Show("Вы проиграли! Правильное слово: " + word);
                    start_new_game();
                }
            }
        }

        /// Метод-обработчик нажатия
        /** Вывод поля для угадываемого слова
        */
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        /// Метод-обработчик нажатия
        /** Вывод поля для угадывания букв
        */
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

