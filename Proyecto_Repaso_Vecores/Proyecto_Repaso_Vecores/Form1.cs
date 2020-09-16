using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Repaso_Vecores
{
    public partial class Form1 : Form
    {
        Random aleatrio = new Random();
        int[] vector = new int[50];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnEjercicio1_Click(object sender, EventArgs e)
        {
            lista_aleatoria.Items.Clear();

            for (int i=0;i < vector.Length; i++)
            {
                vector[i] = aleatrio.Next(100);
                lista_aleatoria.Items.Add(vector[i]);



             }
           
        }

        private void BtnEjercicio2_Click(object sender, EventArgs e)
        {
            lista_ejercicio2.Items.Clear();
            int numeroMayor = 0;
            int numeroMenor = 101;

            for (int i = 0; i < vector.Length; i++)
            {

                if (vector[i] > numeroMayor)
                {
                    numeroMayor = vector[i];
                    
                }


                if (vector[i] < numeroMenor)
                {
                    numeroMenor = vector[i];
                    
                }

            }
            lista_ejercicio2.Items.Add("El numero mayor es "+  numeroMayor);
            lista_ejercicio2.Items.Add("El numero menor es " + numeroMenor);
        }

        private void Boton_Ejercicio3_Click(object sender, EventArgs e)
        {
           int posicion20 = 0;
            int posicion30 = 0;

            for (int i = 0; i < vector.Length; i++)
            {

                posicion20 = vector[20];
                posicion30 = vector[30];


            }
            lista_ejercicio3.Items.Add("La posición 20 es  " + posicion20);
            lista_ejercicio3.Items.Add("La posición 30 es  " + posicion30);
        }

        private void Boton_Ejercicio4_Click(object sender, EventArgs e)
        {
            int todosNumeros = 0;
            int cuantosNumeros = 0;

            for (int i = 0; i < vector.Length; i++)
            {

                todosNumeros += vector[i];

                cuantosNumeros = vector[i];
            }

            int media = 0;

            media = todosNumeros / cuantosNumeros;

            lista_ejercicio4.Items.Add("El media es " + media);
          

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Array.Sort(vector);
            lista_ejercicio11.Items.Clear();

            for (int i = 0; i < vector.Length; i++)
            {
                
                lista_ejercicio11.Items.Add(vector[i]);



            }
         

        }

        private void boton_ejercicio5_Click(object sender, EventArgs e)
        {
            lista_ejercicio6.Items.Clear();
           
           
            int sumaNumero = 0;

            
            int numero = Convert.ToInt32(caja_ejercicio6.Text);

            for (int i = 0; i < vector.Length; i++)

               
            {
            if (vector[i] == numero)
                {
                    sumaNumero += 1;
                }

               


            }

            lista_ejercicio6.Items.Add("Su numero " + numero);
            lista_ejercicio6.Items.Add("Aparece " + sumaNumero);
        }

        private void boton_ejercicio5_Click_1(object sender, EventArgs e)
        {
            lista_ejercicio5.Items.Clear();
            Array.Sort(vector);
            

            for (int i = vector.Length - 1; i >= 0; i--)
            {

                lista_ejercicio5.Items.Add(vector[i]);



            }
        }

        private void boton_ejercicio7_Click(object sender, EventArgs e)
        {
            lista_ejercicio7.Items.Clear();


            for (int i = vector.Length - 1; i >= 0; i--)
            {

                lista_ejercicio7.Items.Add(vector[i]);



            }
        }

        private void boton_ejercicio8_Click(object sender, EventArgs e)
        {
            lista_ejercicio8.Items.Clear();
            int[] vector2 = new int[50];

            vector2 = vector;
            Array.Sort(vector2);

            int aux = vector2[0];
            for (int i = 0; i < vector2.Length; i++)
            {
                if (aux == vector2[i])
                {

                    aux = vector2[i];
                    vector2[i] = -1;
                }
                else
                {
                   
                   
                    aux = vector2[i];

                   
                }
            }

            for (int i = 0; i < vector2.Length; i++)
            {
                lista_ejercicio8.Items.Add(vector2[i]);
            }

        }
        

        private void boton_ejercicio9_Click(object sender, EventArgs e)
        {
            lista_ejercicio9.Items.Clear();
            Random aleatrio2 = new Random();

          

            int[] vector3 = new int[50];

            for (int i = 0; i < vector3.Length; i++)
            {

                vector3[i] = aleatrio2.Next(100);


                lista_ejercicio9.Items.Add(vector3[i]);



            }

        }

        private void boton_ejercicio10_Click(object sender, EventArgs e)
        {

        }
    }
}
