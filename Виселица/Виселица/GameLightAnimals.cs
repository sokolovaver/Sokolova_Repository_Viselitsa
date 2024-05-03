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
    public partial class GameLightAnimals : Form
    {
        string word;
        int numGuessesInt;
        List<char> guessedLetters;

        public GameLightAnimals()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Menu me = new Menu();
            me.Show();
            this.Hide();
        }

        private void GameLightAnimals_Load(object sender, EventArgs e)
=======

        }

        private void GameLightAnimals_Load(object sender, EventArgs e)
        {

        }
        void button_Click(object sender, System.EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
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
        {

            numGuessesInt = 6;//количество попыток
            guessedLetters = new List<char>();//отгаданные буквы
            word = pickWord();
            MessageBox.Show("Угадай животное");
            label2.Text = displayWord();
            label3.Text = "";
            pictureBox1.Load(@"Виселица 1.jpg");
        }
        static string pickWord()//выбор слова рандомно
        {
            string[] wordList = File.ReadAllLines("Животные.txt");
            Random randomGen = new Random();
            return wordList[randomGen.Next(wordList.Count())];
        }
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
<<<<<<< HEAD
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
                pictureBox1.Load(@"Виселица " + (7 - numGuessesInt) + ".jpg");//изменение картинки если не угадал букву


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
        private void label2_Click(object sender, EventArgs e)
        {

        }

=======

>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
    }

}

