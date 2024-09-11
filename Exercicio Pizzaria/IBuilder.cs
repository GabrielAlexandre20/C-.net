using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Pizzaria
{
    public interface IBuilder
    {
        public void reset();

        public void setMolhoTomate(bool molho);

        public void setMussarela(bool mussarela);

        public void setTomate(bool tomate);

        public void setCalabresa(bool calabresa);

        public void setSalame(bool salame);
    }
}
