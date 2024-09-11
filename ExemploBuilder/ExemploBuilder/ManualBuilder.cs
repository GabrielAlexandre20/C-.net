using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploBuilder
{
    public class ManualBuilder : IBuilder
    {
        private ManualCarro manual;

        public ManualBuilder()
        {
            this.reset();
        }

        public void reset()
        {
            this.manual = new ManualCarro();
        }

        public void setNumeroPortas(int num)
        {
            this.manual.numeroPortas = "Esse carro possui " + num + " portas";
        }

        public void setGPS(bool gps)
        {
            if (gps)
                this.manual.GPS = "Esse carro possui o GPS do modelo XXXX";
            else
                this.manual.GPS = "Esse carro não possui GPS ... dá seus pulo!";
        }

        public void setComputadorBordo(bool compBordo)
        {
            if (compBordo)
                this.manual.computadorBordo = "Esse carro possui computador de bordo do modelo YYYYYY";
            else
                this.manual.computadorBordo = "Esse carro nao possui computador de bordo... dirige ai, tirou a carta por correio?";
        }

        public void setCor(string cor)
        {
            this.manual.cor = "Esse carro é da cor " + cor;
        }

        public void setTipoMotor(string motor)
        {
            this.manual.tipoMotor = "O motor é " + motor;
        }

        public ManualCarro getResult()
        {
            return this.manual;
        }
    }
}
