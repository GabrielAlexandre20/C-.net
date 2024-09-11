using System;

namespace ExemploBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Diretor diretor = new Diretor();
            CarroBuilder cbuilder = new CarroBuilder();

            diretor.construirCarroPopular(cbuilder);
            Carro carroHyan = cbuilder.getResult();

            Console.WriteLine("Carro Popular");
            Console.WriteLine("Portas: " + carroHyan.numeroPortas);
            Console.WriteLine("GPS: " + carroHyan.GPS);
            Console.WriteLine("Computador Bordo: " + carroHyan.computadorBordo);
            Console.WriteLine("Cor: " + carroHyan.cor);
            Console.WriteLine("Motor: " + carroHyan.tipoMotor);

            diretor.construirCarroLuxo(cbuilder);
            Carro carroCorba = cbuilder.getResult();

            Console.WriteLine("Carro Luxo");
            Console.WriteLine("Portas: " + carroCorba.numeroPortas);
            Console.WriteLine("GPS: " + carroCorba.GPS);
            Console.WriteLine("Computador Bordo: " + carroCorba.computadorBordo);
            Console.WriteLine("Cor: " + carroCorba.cor);
            Console.WriteLine("Motor: " + carroCorba.tipoMotor);

            ManualBuilder mbuilder = new ManualBuilder();
            diretor.construirCarroLuxo(mbuilder);

            ManualCarro manualCorba = mbuilder.getResult();
            Console.WriteLine("Carro Luxo");
            Console.WriteLine(manualCorba.numeroPortas);
            Console.WriteLine(manualCorba.GPS);
            Console.WriteLine(manualCorba.computadorBordo);
            Console.WriteLine(manualCorba.cor);
            Console.WriteLine(manualCorba.tipoMotor);

            diretor.construirCarroEsportivo(cbuilder);
            Carro carroIvan = cbuilder.getResult();
            Console.WriteLine("Carro Esportivo");
            Console.WriteLine("Portas: " + carroIvan.numeroPortas);
            Console.WriteLine("GPS: " + carroIvan.GPS);
            Console.WriteLine("Computador Bordo: " + carroIvan.computadorBordo);
            Console.WriteLine("Cor: " + carroIvan.cor);
            Console.WriteLine("Motor: " + carroIvan.tipoMotor);

        }
    }
}
