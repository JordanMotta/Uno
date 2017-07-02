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
    public partial class Player : Form
    {
        public Comunication com;

        public Player()
        {
            com = new USocket();
            InitializeComponent();
            ProcessIDText.Text = System.Diagnostics.Process.GetCurrentProcess().Id.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            com.connect();
            ConnectButton.Text = "Empezar";
            ConnectButton.Click -= ConnectButton_Click;
            ConnectButton.Click += initializeGame;
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(permanentListener));
            t.Start();
        }

        private void initializeGame(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            
            com.send("naj1na");
            PlayerName.Text = "j1";
        }

        private void permanentListener()
        {
            while (com.isOpen())
            {
                //Esuchar lo que dice.
                string info = com.listen();
                Console.WriteLine("ID: " + ProcessIDText.Text);
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
                        //Aumentamos uno.
                        number++;
                        //Creamos el nombre.
                        string name = "j" + number.ToString();
                        //Lo insertamos en la cadena.
                        info.Insert(info.Length - 3, name);
                        //Lo enviamos
                        com.send(info);

                        PlayerName.Text = name;
                    }
                    else {
                        Console.WriteLine("Ya todos los jugadores tienen su nombre");
                    }
                }
            }
        }

        private void endGame()
        {
            com.close();
        }
    }
}
