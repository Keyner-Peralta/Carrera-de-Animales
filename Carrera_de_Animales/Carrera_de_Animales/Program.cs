using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_de_Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo caballo = new Caballo();
            Perro perro = new Perro();
            Gato gato = new Gato();

            for (int i = 0; i < 10; i++)
            {
                caballo.Mover();
                perro.Mover();
                gato.Mover();
            }
            if(caballo.score > perro.score && caballo.score > gato.score) Console.WriteLine("El ganador es el Caballo con puntaje de " + caballo.score);

            else if (perro.score > gato.score) Console.WriteLine("El ganador es el Perro con puntaje de " + perro.score);

            else Console.WriteLine("El ganador es el Gato con puntaje de " + gato.score);


        }
    }

    class Caballo 
    {
        public int movimiento;
        public int score;
        public void Mover()
        {
            Random random = new Random();
            
            movimiento = random.Next(1,5);
            score += movimiento;
        }

    }

    class Perro
    {
        public int movimiento;
        public int score;
        public void Mover()
        {
            Random random = new Random();

            movimiento = random.Next(1, 3);
            score += movimiento;
        }

    }

    class Gato
    {
        public int movimiento;
        public int score;
        public void Mover()
        {
            Random random = new Random();

            movimiento = random.Next(1,2);
            score += movimiento;
        }
    }
}
