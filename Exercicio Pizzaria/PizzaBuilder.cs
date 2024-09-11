using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Pizzaria
{
    public class PizzaBuilder : IBuilder
    {
        private Pizza pizza;

        public PizzaBuilder()
        {
            this.reset();
        }

        public void reset()
        {
            this.pizza = new Pizza();
        }        

        public void setMolhoTomate(bool molho)
        {
            this.pizza.molhoTomate = molho;
        }

        public void setMussarela(bool mussarela)
        {
            this.pizza.mussarela = mussarela;
        }

        public void setTomate(bool tomate)
        {
            this.pizza.tomate = tomate;
        }

        public void setCalabresa(bool calabresa)
        {
            this.pizza.calabresa = calabresa;
        }

        public void setSalame(bool salame)
        {
            this.pizza.salame = salame;
        }

        public Pizza getResult()
        {
            return this.pizza;
        }
       
    }
}
