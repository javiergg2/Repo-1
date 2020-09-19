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

        int[] vector3 = new int[50];

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
            lista_ejercicio11.Items.Clear();
            
            Array.Sort(vector3);


            for (int i = vector.Length - 1; i >= 0; i--)
            {

                lista_ejercicio11.Items.Add(vector3[i]);



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
            for (int i = 0; i < vector.Length; i++)
            {

                lista_ejercicio5.Items.Add(vector[i]);



            }
           
           
           
        }

        private void boton_ejercicio7_Click(object sender, EventArgs e)
        {
            lista_ejercicio7.Items.Clear();
            Array.Reverse(vector);


            for (int i = 0; i < vector.Length; i++)
            {

                lista_ejercicio7.Items.Add(vector[i]);



            }

        }

        private void boton_ejercicio8_Click(object sender, EventArgs e)
        {

            lista_ejercicio8.Items.Clear();
            int[] vector2 = new int[50];


            Array.Copy(vector,  vector2,  50 );

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



            for (int i = 0; i < vector3.Length; i++)
            {
                int numero = 0;
                Boolean continuar = true;
               while(continuar)
                {
                     numero = aleatrio.Next(100);
                    Boolean esta = false;
                    for(int j=0;j<i;j++)
                    {
                        if (numero == vector3[j])
                            esta = true;

                    }
                    if (esta == false) break;
                }
                vector3[i] = numero;

                lista_ejercicio9.Items.Add(vector3[i]);
            }

        }

        private void boton_ejercicio10_Click(object sender, EventArgs e)
        {
            lista_ejercicio10.Items.Clear();
            int mayor25 = 0;
            int menor25 = 0;
            for (int i = 0; i < vector3.Length; i++)
            {
                if ( vector3[i] > 25)
                {
                    mayor25 += 1;

                }
                if (vector3[i] < 25)
                {
                    menor25 += 1;

                }

            }

            lista_ejercicio10.Items.Add("Mayor "+ mayor25);
            lista_ejercicio10.Items.Add("Menor " + menor25);
        }

        private void boton_ejercicio12_Click(object sender, EventArgs e)
        {

            lista_ejercicio12.Items.Clear();


            int numero = Convert.ToInt32(texto_ejercicio12.Text);

            for (int i = 0; i < vector3.Length; i++)


            {
                if (vector3[i] == numero)
                {
                    int numeroAle = 0;
                    for (int i3 = 0; i3 < vector3.Length; i3++)
                    {
                       
                        Boolean continuar = true;
                        while (continuar)
                        {
                            numeroAle = aleatrio.Next(100);
                            Boolean esta = false;
                            for (int j = 0; j < i; j++)
                            {
                                if (numeroAle == vector3[j])
                                    esta = true;

                            }
                            if (esta == false) break;
                        }
                       
                    }
                    vector3[i] = numeroAle;
                }

                lista_ejercicio12.Items.Add(vector3[i]);
            }
           
        }

        private void lista_ejercicio12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boton_ejercicio13_Click(object sender, EventArgs e)
        {

            int numero = Convert.ToInt32(texto_ejercicio13.Text);

            int numerosMayores = 0;
            int numerosMenores = 0;

            for (int i = 0; i < vector.Length; i++)


            {
                if (vector[i] > numero)
                {
                    numerosMayores++;
                }

                if (vector[i] < numero)
                {
                    numerosMenores++;
                }

                

            }
            lista_ejercicio13.Items.Add("Hay " + numerosMayores + " que son mayores.");
            lista_ejercicio13.Items.Add("Hay " + numerosMenores+ " que son menores");
        }

        private void lista_ejercicio5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lista_ejercicio11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
