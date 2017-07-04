using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uno
{
    public partial class ModuleTest : Form
    {
        public ModuleTest()
        {
            InitializeComponent();
            test_sender();
        }

        private void test_sender()
        {
            //Esuchar lo que dice.
            string info = "naj1na";
            //Console.WriteLine("ID: " + ProcessIDText.Text);
            Console.WriteLine("Que llego: " + info);

            //Analizar el primer trozo de la trama.
            string substring = info.Substring(0, 2);
            //Si es "na", implica que esta pidiendo nombres.
            if (substring == "na")
            {
                //Como el juego es de 4 jugadores. la longitud maxima es de 12 caracteres.
                //Si la cadena tiene esa longitud, no hay mas nada que hacer
                //ya que todos los jugadores ya se asignaron su nombre.
                //
                //Si no tienen la longitud maxima quiere decir que no todos se han asignado el nombre.
                if (info.Length != 12)
                {
                    //Buscamos el numero del ultimo jugador.
                    int number = int.Parse(info[info.Length - 3].ToString());
                    Console.WriteLine("Numero: " + number);
                    //Aumentamos uno.
                    number++;
                    //Creamos el nombre.
                    string name = "j" + number.ToString();
                    Console.WriteLine("Nombre del jugador: " + name);
                    //Lo insertamos en la cadena.
                    info = info.Insert(info.Length - 2, name);
                    //Lo enviamos
                    Console.WriteLine("Que voy a enviar: " + info);
                    //com.send(info);

                    //PlayerName.Text = name;
                }
                else
                {
                    Console.WriteLine("Ya todos los jugadores tienen su nombre");
                }
            }
        }
    }
}
