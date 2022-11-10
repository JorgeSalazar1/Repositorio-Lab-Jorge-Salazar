using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea10_JJSC_1202022
{
    internal class TrianguloRectangulo
    {
        public double catetoA;
        public double anguloOpuestoA;
        public double ObtenerCatetoB()
        {
            return catetoA / Math.Tan(anguloOpuestoA);
        }
        public double ObtenerHipotenusa()
        {
            return catetoA / Math.Sin(anguloOpuestoA);
        }
        public double ObtenerAnguloOpuestoB()
        {
            return 90 - anguloOpuestoA;
        }
        public double ObtenerArea()
        {
            return catetoA * ObtenerCatetoB() / 2;
        }
    }
}
