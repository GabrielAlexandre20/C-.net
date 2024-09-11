using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAula05
{
    public class Plugue2Pinos
    {
        private int quantidade_pinos;

        public void setQuantidadePinos(int qtd)
        {
            this.quantidade_pinos = qtd;
        }

        public virtual int getQuantidadePinos()
        {
            return this.quantidade_pinos;
        }


    }
}
