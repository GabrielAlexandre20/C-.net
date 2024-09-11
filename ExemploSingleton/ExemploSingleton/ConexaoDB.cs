using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploSingleton
{
    public sealed class ConexaoDB
    {
        private static ConexaoDB instance = null;

        private ConexaoDB()
        {

        }

        public static ConexaoDB getInstance()
        {

            if (instance == null)
            {
                instance = new ConexaoDB();
                Console.WriteLine("Criando um novo objeto de Conexao DB");
            }
            else
            {
                Console.WriteLine("Usando o objeto Conexao DB ja existente!");
            }
                

            return instance;
        }
    }
}
