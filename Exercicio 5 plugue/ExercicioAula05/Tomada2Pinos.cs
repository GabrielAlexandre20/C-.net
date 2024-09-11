using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAula05
{
    public class Tomada2Pinos
    {
        private Plugue2Pinos plugue;
        private int quantidadePinos;

        public Tomada2Pinos(Plugue2Pinos plugue)
        {
            this.plugue = plugue;
            this.quantidadePinos = 2;
        }

        public void setPlugue(Plugue2Pinos plugue)
        {
            this.plugue = plugue;
        }

        public Boolean encaixa()
        {
            return this.plugue.getQuantidadePinos() == this.quantidadePinos;
        }


    }
}
