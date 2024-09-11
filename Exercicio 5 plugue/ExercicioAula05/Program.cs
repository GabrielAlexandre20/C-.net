using System;

namespace ExercicioAula05
{
    class Program
    {
        static void Main(string[] args)
        {

            Plugue2Pinos plugue2pinos = new Plugue2Pinos();
            plugue2pinos.setQuantidadePinos(2);

            Tomada2Pinos tomada2Pinos = new Tomada2Pinos(plugue2pinos);
            Console.WriteLine(tomada2Pinos.encaixa());

            Plugue3Pinos plugue3Pinos = new Plugue3Pinos();

            AdaptadoPlugue3Pinos adaptador = new AdaptadoPlugue3Pinos(plugue3Pinos);

            tomada2Pinos.setPlugue(adaptador);
            Console.WriteLine(tomada2Pinos.encaixa());


        }
    }
}
