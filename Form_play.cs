using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form_play : MetroFramework.Forms.MetroForm
    {
        Form1 helpform;
        int[][] array = new int[][] { new int[] {2,0,0,0 },
                                      new int[] {0,4,0,0 },
                                      new int[] {0,0,8,0 },
                                      new int[] {0,0,0,16 }};
        Random m;

        public Form_play()
        {
            InitializeComponent();
        }
        public Form_play(Form1 x)
        {
            
            InitializeComponent();
            helpform = x;

            vivod_matrix();
        }

        //вывод матрицы -------------------------------потом будет изменен
        public void vivod_matrix()
        {
            string way;
            way = array[0][0].ToString() + ".png";
            pictureBox1.Image = Image.FromFile(way);
            way = array[0][1].ToString() + ".png";
            pictureBox2.Image = Image.FromFile(way);
            way = array[0][2].ToString() + ".png";
            pictureBox3.Image = Image.FromFile(way);
            way = array[0][3].ToString() + ".png";
            pictureBox4.Image = Image.FromFile(way);

            way = array[1][0].ToString() + ".png";
            pictureBox5.Image = Image.FromFile(way);
            way = array[1][1].ToString() + ".png";
            pictureBox6.Image = Image.FromFile(way);
            way = array[1][2].ToString() + ".png";
            pictureBox7.Image = Image.FromFile(way);
            way = array[1][3].ToString() + ".png";
            pictureBox8.Image = Image.FromFile(way);
            way = array[2][0].ToString() + ".png";
            pictureBox9.Image = Image.FromFile(way);
            way = array[2][1].ToString() + ".png";
            pictureBox10.Image = Image.FromFile(way);
            way = array[2][2].ToString() + ".png";
            pictureBox11.Image = Image.FromFile(way);
            way = array[2][3].ToString() + ".png";
            pictureBox12.Image = Image.FromFile(way);
            way = array[3][0].ToString() + ".png";
            pictureBox13.Image = Image.FromFile(way);
            way = array[3][1].ToString() + ".png";
            pictureBox14.Image = Image.FromFile(way);
            way = array[3][2].ToString() + ".png";
            pictureBox15.Image = Image.FromFile(way);
            way = array[3][3].ToString() + ".png";
            pictureBox16.Image = Image.FromFile(way);

        }

        //нажатие кнопки
        private void Form_play_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)//если влево
            {
                //поворот матрицы +90


            }
            if (e.KeyCode == Keys.Right)//если вправо
            {
                //поворот матрицы -90


            }
            if (e.KeyCode == Keys.Up)//если вверх
            {
                


            }
            if (e.KeyCode == Keys.Down)//если вниз
            {
                //поворот матрицы +180


            }
            //вывод
            //проверка движения(поиск нулей и смеж чисел)


        }
    }
}
