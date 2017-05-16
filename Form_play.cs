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
        /*int[][] array = new int[][] { new int[] {0,0,0,0 },
                                      new int[] {0,0,0,0 },
                                      new int[] {0,0,0,0 },
                                      new int[] {0,0,0,0 }};
                                      */
        int[][] array = new int[][] { new int[] {0,0,0,0 },
                                      new int[] {0,0,0,0 },
                                      new int[] {0,0,0,0 },
                                      new int[] {0,0,0,0 }};
        Random m;
        int Score = 2;

        public Form_play()
        {
            InitializeComponent();
        }
        public Form_play(Form1 x)
        {
            
            InitializeComponent();
            helpform = x;


            m = new Random();


            addnumber();
            addnumber();
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

            metroLabel_scr.Text = Score.ToString(); 

        }

        //нажатие кнопки
        /* private void Form_play_KeyDown(object sender, KeyEventArgs e)
         {
             int[][] help_matrix = new int[3][];

             //1
             if(e.KeyCode==Keys.Left)//если влево
             {
                 //поворот матрицы +90
                 help_matrix[0] = new int[] { array[3][0], array[2][0], array[1][0], array[0][0] };
                 help_matrix[1] = new int[] { array[3][1], array[2][1], array[1][1], array[0][1] };
                 help_matrix[2] = new int[] { array[3][2], array[2][2], array[1][2], array[0][2] };
                 help_matrix[3] = new int[] { array[3][3], array[2][3], array[1][3], array[0][3] };

                 run(help_matrix);

                 //поворот матрицы -90
                /* array[0] =new int[]{help_matrix[0][3],help_matrix[1][3],help_matrix[2][3],help_matrix[3][3] };
                 array[0] = new int[] { help_matrix[0][2], help_matrix[1][2], help_matrix[2][2], help_matrix[3][2] };
                 array[0] = new int[] { help_matrix[0][1], help_matrix[1][1], help_matrix[2][1], help_matrix[3][1] };
                 array[0] = new int[] { help_matrix[0][0], help_matrix[1][0], help_matrix[2][0], help_matrix[3][0] };

             





                 vivod_matrix();
             }
             if (e.KeyCode == Keys.Right)//если вправо
             {
                 //поворот матрицы -90

                 MessageBox.Show("ok");
             }
             if (e.KeyCode == Keys.Up)//если вверх
             {

                 MessageBox.Show("ok");

             }
             if (e.KeyCode == Keys.Down)//если вниз
             {
                 MessageBox.Show("ok");
                 //поворот матрицы +180


             }
             //2-циклич джижение
             //3-обратный поворот
             //проверка движения(поиск нулей и смеж чисел)
             //4-добавление числа
             //вывод
             


         }*/

        //ВЕРХ
        private void button_UP_Click(object sender, EventArgs e)
        {
            bool hod = false;
           
            run(array, ref hod);

            chek();
            if (hod) addnumber();

            vivod_matrix();
        }

        //ВЛЕВО
        private void button_LEFT_Click(object sender, EventArgs e)
        {
            bool hod = false;
            int[][] help_matrix = new int[4][];
            //поворот матрицы +90
            help_matrix[0] = new int[] { array[3][0], array[2][0], array[1][0], array[0][0] };
            help_matrix[1] = new int[] { array[3][1], array[2][1], array[1][1], array[0][1] };
            help_matrix[2] = new int[] { array[3][2], array[2][2], array[1][2], array[0][2] };
            help_matrix[3] = new int[] { array[3][3], array[2][3], array[1][3], array[0][3] };


            run(help_matrix,ref hod);

            //поворот матрицы -90
            /*  array[0] = new int[] { help_matrix[0][3], help_matrix[1][3], help_matrix[2][3], help_matrix[3][3] };
              array[0] = new int[] { help_matrix[0][2], help_matrix[1][2], help_matrix[2][2], help_matrix[3][2] };
              array[0] = new int[] { help_matrix[0][1], help_matrix[1][1], help_matrix[2][1], help_matrix[3][1] };
              array[0] = new int[] { help_matrix[0][0], help_matrix[1][0], help_matrix[2][0], help_matrix[3][0] };*/

            array[0][0] = help_matrix[0][3];
            array[0][1] = help_matrix[1][3];
            array[0][2] = help_matrix[2][3];
            array[0][3] = help_matrix[3][3];
            array[1][0] = help_matrix[0][2];
            array[1][1] = help_matrix[1][2];
            array[1][2] = help_matrix[2][2];
            array[1][3] = help_matrix[3][2];
            array[2][0] = help_matrix[0][1];
            array[2][1] = help_matrix[1][1];
            array[2][2] = help_matrix[2][1];
            array[2][3] = help_matrix[3][1];
            array[3][0] = help_matrix[0][0];
            array[3][1] = help_matrix[1][0];
            array[3][2] = help_matrix[2][0];
            array[3][3] = help_matrix[3][0];


            chek();
            if (hod) addnumber();

            vivod_matrix();

        }

        //ПРАВО
        private void button_RIGTH_Click(object sender, EventArgs e)
        {
            bool hod = false;
            int[][] help_matrix = new int[4][];
            //поворот матрицы -90
            help_matrix[0] = new int[] { array[0][3], array[1][3], array[2][3], array[3][3] };
            help_matrix[1] = new int[] { array[0][2], array[1][2], array[2][2], array[3][2] };
            help_matrix[2] = new int[] { array[0][1], array[1][1], array[2][1], array[3][1] };
            help_matrix[3] = new int[] { array[0][0], array[1][0], array[2][0], array[3][0] };


            run(help_matrix, ref hod);

            //поворот матрицы +90
            
            


            array[0][0] = help_matrix[3][0];
            array[0][1] = help_matrix[2][0];
            array[0][2] = help_matrix[1][0];
            array[0][3] = help_matrix[0][0];
            array[1][0] = help_matrix[3][1];
            array[1][1] = help_matrix[2][1];
            array[1][2] = help_matrix[1][1];
            array[1][3] = help_matrix[0][1];
            array[2][0] = help_matrix[3][2];
            array[2][1] = help_matrix[2][2];
            array[2][2] = help_matrix[1][2];
            array[2][3] = help_matrix[0][2];
            array[3][0] = help_matrix[3][3];
            array[3][1] = help_matrix[2][3];
            array[3][2] = help_matrix[1][3];
            array[3][3] = help_matrix[0][3];


            chek();
            if (hod) addnumber();

            vivod_matrix();

        }

        //НИЗ
        private void button_DOWN_Click(object sender, EventArgs e)
        {

            bool hod = false;
            int[][] help_matrix = new int[4][];
            //поворот матрицы -90
            help_matrix[0] = new int[] { array[3][3], array[3][2], array[3][1], array[3][0] };
            help_matrix[1] = new int[] { array[2][3], array[2][2], array[2][1], array[2][0] };
            help_matrix[2] = new int[] { array[1][3], array[1][2], array[1][1], array[1][0] };
            help_matrix[3] = new int[] { array[0][3], array[0][2], array[0][1], array[0][0] };


            run(help_matrix, ref hod);

            //поворот матрицы +90




            array[0][0] = help_matrix[3][3];
            array[0][1] = help_matrix[3][2];
            array[0][2] = help_matrix[3][1];
            array[0][3] = help_matrix[3][0];
            array[1][0] = help_matrix[2][3];
            array[1][1] = help_matrix[2][2];
            array[1][2] = help_matrix[2][1];
            array[1][3] = help_matrix[2][0];
            array[2][0] = help_matrix[1][3];
            array[2][1] = help_matrix[1][2];
            array[2][2] = help_matrix[1][1];
            array[2][3] = help_matrix[1][0];
            array[3][0] = help_matrix[0][3];
            array[3][1] = help_matrix[0][2];
            array[3][2] = help_matrix[0][1];
            array[3][3] = help_matrix[0][0];


            chek();
            if (hod) addnumber();

            vivod_matrix();











        }
        //
        void chek()
        {
            bool ch = false;
            foreach (int[] elem in array)
                foreach (int el in elem)
                    if (el == 0) ch = true;
            if (!ch) { MessageBox.Show("Вы прое*ли("); Close(); }
        }
        //4
        void addnumber()//4 часть-добавление числа
        {
            int x, y;
            while(true)
            {
                x = m.Next(0, 4);
                y = m.Next(0, 4);

                if(array[x][y]==0)
                {
                    array[x][y] = 2;
                    break;
                }

            }

        }
        //3
         void run(int[][] MATR,ref bool bilhod)
        {
            bool[] radi = new bool[] { true, true, true, true };

            int[] kolvo_oper = new int[] { 0, 0, 0, 0 };
            int[] znach_oper = new int[] { 0, 0, 0, 0 };

            bilhod = false;
            while (true)
            {
                bool QQ = false;

                
                
                //суммируем числа
                for (int i = 0; i < 3; i++)
                {
                    for (int ii = 0; ii < 4; ii++)
                    {
                        if (((MATR[i][ii] == MATR[i + 1][ii]) && MATR[i][ii] != 0&&kolvo_oper[ii]<2))//если найдено сопутсвующ число
                        {
                            if (!(kolvo_oper[ii] > 0 && znach_oper[ii] != 0))
                            {
                                znach_oper[ii] = MATR[i][ii];
                                radi[ii] = false;
                                kolvo_oper[ii]++;
                                bilhod = true;
                                QQ = true;
                                MATR[i][ii] *= 2;

                                Score += MATR[i][ii];
                                for (int x = i + 1; x < 3; x++)
                                { MATR[x][ii] = MATR[x + 1][ii]; }
                                MATR[3][ii] = 0;

                                //проходим заново
                                i = 0; ii = 0;
                            }
                        }



                    }

                }
                bool hlp = false;
                //избавляемся от верхних нулей
                while (true)
                {
                    hlp = false;
                    for (int i = 0; i < 3; i++)
                    {

                        for (int ii = 0; ii < 4; ii++)
                        {
                            if ((MATR[i][ii] != MATR[i + 1][ii]) && MATR[i][ii] == 0)
                            {
                                bilhod = true;
                                QQ = true;
                                // MessageBox.Show("brr");
                                for (int x = i; x < 3; x++)
                                { MATR[x][ii] = MATR[x + 1][ii]; }
                                MATR[3][ii] = 0;

                                hlp = true;
                                //проходим заново
                                // i = 0; ii = 0;
                            }
                        }

                    }
                    if (!hlp) break;
                }

                if (!QQ) break;
            }

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
