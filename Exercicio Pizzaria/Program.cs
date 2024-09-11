using System;

namespace Ex1_Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Dono dono = new Dono();
            PizzaBuilder pbuilder = new PizzaBuilder();


            dono.montarPizzaMussarela(pbuilder);
            Pizza p1 = pbuilder.getResult();

            Console.WriteLine("-----------------");
            Console.WriteLine("Pizza Mussarela: ");
            Console.WriteLine("Possui Molho de Tomate? " + p1.molhoTomate);
            Console.WriteLine("Possui Mussarela? " + p1.mussarela);
            Console.WriteLine("Possui Tomate? " + p1.tomate);
            Console.WriteLine("Possui Calabresa? " + p1.calabresa);
            Console.WriteLine("Possui Salame? " + p1.salame);
            Console.WriteLine("-----------------");


            dono.montarPizzaCalabresa(pbuilder);
            Pizza p2 = pbuilder.getResult();

            Console.WriteLine("-----------------");
            Console.WriteLine("Pizza Calabresa: ");
            Console.WriteLine("Possui Molho de Tomate? " + p2.molhoTomate);
            Console.WriteLine("Possui Mussarela? " + p2.mussarela);
            Console.WriteLine("Possui Tomate? " + p2.tomate);
            Console.WriteLine("Possui Calabresa? " + p2.calabresa);
            Console.WriteLine("Possui Salame? " + p2.salame);
            Console.WriteLine("-----------------");

            ManualBuilder mbuilder = new ManualBuilder();
            dono.montarPizzaPeperoni(mbuilder);

            ManualPizza manual = mbuilder.getResult();
            Console.WriteLine("-----------------");
            Console.WriteLine("Manual Pizza Peperone: ");
            Console.WriteLine(manual.molhoTomate);
            Console.WriteLine(manual.mussarela);
            Console.WriteLine(manual.tomate);
            Console.WriteLine(manual.calabresa);
            Console.WriteLine(manual.salame);
            Console.WriteLine("-----------------");
        }
    }
}
