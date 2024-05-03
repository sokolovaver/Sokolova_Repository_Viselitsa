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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            Player pl = new Player();
            pl.Show();//переход на форму
            this.Hide();//закрытие предыдущей формы
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            Spravka sp = new Spravka();
            sp.Show();//переход на форму
            this.Hide();//закрытие предыдущей формы
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            Application.Exit(); //кнопка выхода
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            Table tab = new Table();
            tab.Show();//переход на форму
            this.Hide();//закрытие предыдущей формы
>>>>>>> c0c4bf92cdb21feb31f290bbc32c964e37a72e7c
        }
    }

}
