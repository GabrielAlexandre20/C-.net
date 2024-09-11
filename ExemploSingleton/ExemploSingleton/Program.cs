using System;

namespace ExemploSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ConexaoDB con = ConexaoDB.getInstance();

            ConexaoDB con2 = ConexaoDB.getInstance();

            ConexaoDB con3 = ConexaoDB.getInstance();
            
        }
    }
}
