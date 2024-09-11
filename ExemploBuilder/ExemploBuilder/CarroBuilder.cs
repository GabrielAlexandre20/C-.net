using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploBuilder
{
    public class CarroBuilder : IBuilder
    {
        private Carro carro;

        public CarroBuilder()
        {
            this.reset();
        }

        public void reset()
        {
            carro = new Carro();
        }

        public void setNumeroPortas(int num)
        {
            this.carro.numeroPortas = num;
        }

        public void setGPS(bool gps)
        {
            this.carro.GPS = gps;
        }

        public void setComputadorBordo(bool compBordo)
        {
            this.carro.computadorBordo = compBordo;
        }

        public void setCor(string cor)
        {
            this.carro.cor = cor;
        }

        public void setTipoMotor(string motor)
        {
            this.carro.tipoMotor = motor;
        }

        public Carro getResult()
        {
            return this.carro;
        }

    }
}
