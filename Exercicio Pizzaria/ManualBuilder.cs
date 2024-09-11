using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Pizzaria
{
    public class ManualBuilder : IBuilder
    {
        private ManualPizza manual;

        public ManualBuilder()
        {
            this.reset();
        }

        public void reset()
        {
            this.manual = new ManualPizza();
        }      

        public void setMolhoTomate(bool molho)
        {
            if (molho)
            {
                this.manual.molhoTomate = "Essa pizza possui molho de tomate!";
            }
            else
            {
                this.manual.molhoTomate = "Essa pizza não possui molho de tomate!";
            }
        }

        public void setMussarela(bool mussarela)
        {
            if (mussarela)
            {
                this.manual.mussarela = "Essa pizza possui mussarela!";
            }
            else
            {
                this.manual.mussarela = "Essa pizza não possui mussarela!";
            }
        }

        public void setTomate(bool tomate)
        {
            if (tomate)
            {
                this.manual.tomate = "Essa pizza possui tomate!";
            }
            else
            {
                this.manual.tomate = "Essa pizza não possui tomate!";
            }
        }

        public void setCalabresa(bool calabresa)
        {
            if (calabresa)
            {
                this.manual.calabresa = "Essa pizza possui calabresa!";
            }
            else
            {
                this.manual.calabresa = "Essa pizza não possui calabresa!";
            }
        }

        public void setSalame(bool salame)
        {
            if (salame)
            {
                this.manual.salame = "Essa pizza possui salame!";
            }
            else
            {
                this.manual.salame = "Essa pizza não possui salame!";
            }
        }

        public ManualPizza getResult()
        {
            return this.manual;
        }
    }
}
