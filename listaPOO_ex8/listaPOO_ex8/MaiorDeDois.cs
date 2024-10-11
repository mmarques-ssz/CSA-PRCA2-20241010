using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaPOO_ex8
{
    internal class MaiorDeDois
    {
        private int n1;
        private int n2;
        private int maior;
        private string maiorExtenso;

        public MaiorDeDois()
        {
            this.n1 = 0;
            this.n2 = 0;
        }

        public MaiorDeDois(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public void setN1(int n1)
        {
            this.n1 = n1;
        }
        public void setN2(int n2)
        {
            this.n2 = n2;
        }
        public int getN1()
        {
            return this.n1;
        }
        public int getN2()
        {
            return this.n2;
        }
        public int getMaior()
        {
            return this.maior;
        }
        public string getMaiorExtenso()
        {
            return this.maiorExtenso;
        }
        public void descobrirMaior()
        {
            if (this.n1 > this.n2)
            {
                this.maior = this.n1;
                this.maiorExtenso = "Primeiro";
            }
            else
            {
                this.maior = this.n2;
                this.maiorExtenso = "Segundo";
            }

        }
    }
}
