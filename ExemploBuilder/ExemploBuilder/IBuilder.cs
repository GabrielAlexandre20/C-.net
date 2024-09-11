using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploBuilder
{
    public interface IBuilder
    {
        public void setNumeroPortas(int num);
        public void setGPS(bool gps);
        public void setComputadorBordo(bool compBordo);
        public void setCor(string cor);
        public void setTipoMotor(string motor);

        public void reset();



    }
}
