using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAula05
{
    public class AdaptadoPlugue3Pinos : Plugue2Pinos
    {

        private Plugue3Pinos plugue3Pinos;

        public AdaptadoPlugue3Pinos(Plugue3Pinos plugue)
        {
            this.plugue3Pinos = plugue;
        }

        public override int getQuantidadePinos()
        {
            return this.plugue3Pinos.quantidade_pinos - 1;
        }

    }
}
