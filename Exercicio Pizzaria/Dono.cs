using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Pizzaria
{
    public class Dono
    {
        private IBuilder builder;

        public void setBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        public void montarPizzaMussarela(IBuilder builder)
        {
            builder.reset();
            builder.setMolhoTomate(true);
            builder.setMussarela(true);
            builder.setTomate(true);
            builder.setCalabresa(false);
            builder.setSalame(false);
        }
        public void montarPizzaCalabresa (IBuilder builder)
        {
            builder.reset();
            builder.setMolhoTomate(true);
            builder.setMussarela(true);
            builder.setTomate(false);
            builder.setCalabresa(true);
            builder.setSalame(false);
        }
        public void montarPizzaPeperoni(IBuilder builder)
        {
            builder.reset();
            builder.setMolhoTomate(true);
            builder.setMussarela(true);
            builder.setTomate(true);
            builder.setCalabresa(false);
            builder.setSalame(true);
        }
    }
}
