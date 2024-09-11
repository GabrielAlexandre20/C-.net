using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploBuilder
{
    public class Diretor
    {

        private IBuilder builder;

        public void setBuilder(IBuilder b)
        {
            this.builder = b;
        }

        public void construirCarroPopular(IBuilder builder)
        {
            builder.reset();
            builder.setNumeroPortas(2);
            builder.setGPS(false);
            builder.setComputadorBordo(false);
            builder.setCor("Branco");
            builder.setTipoMotor("1.0");
        }

        public void construirCarroLuxo(IBuilder builder)
        {
            builder.reset();
            builder.setNumeroPortas(4);
            builder.setGPS(true);
            builder.setComputadorBordo(true);
            builder.setCor("Prata Perolado");
            builder.setTipoMotor("2.0");
        }

        public void construirCarroEsportivo(IBuilder builder)
        {
            builder.reset();
            builder.setNumeroPortas(7);
            builder.setGPS(true);
            builder.setComputadorBordo(true);
            builder.setCor("Rosa");
            builder.setTipoMotor("7.0");
        }
    }
}
