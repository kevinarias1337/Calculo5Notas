using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5notas
{
    public class Promedio
    {
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        private double nota5;

        public void setNota1(double total)
        {
            this.nota1 = total;
        }
        public double getNota1()
        {
            return this.nota1;
        }
        public void setNota2(double total)
        {
            this.nota2 = total;
        }
        public double getNota2()
        {
            return this.nota2;
        }
        public void setNota3(double total)
        {
            this.nota3 = total;
        }
        public double getNota3()
        {
            return this.nota3;
        }
        public void setNota4(double total)
        {
            this.nota4 = total;
        }
        public double getNota4()
        {
            return this.nota4;
        }
        public void setNota5(double total)
        {
            this.nota5 = total;
        }
        public double getNota5()
        {
            return this.nota5;
        }

        public double calcularPromedio()
        {
            return (this.getNota1() + this.getNota2() + this.getNota3() + this.getNota4() + this.getNota5()) / 5;
        }
    
    }
}
