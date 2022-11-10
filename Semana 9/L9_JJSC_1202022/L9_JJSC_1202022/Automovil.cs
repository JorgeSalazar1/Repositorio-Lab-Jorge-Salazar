using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_JJSC_1202022
{
    class Automovil
    {
        public int modelo;
        public double precio;
        public string marca;
        public bool disponibilidad;
        public double tipoDeCambioDolar;
        public double descuentoAplicado;

        public Automovil(int modelo, double precio, string marca, bool disponibilidad, double tipoDeCambioDolar)
        {
            this.modelo = modelo;
            this.precio = precio;
            this.marca = marca;
            this.disponibilidad = disponibilidad;
            this.tipoDeCambioDolar = tipoDeCambioDolar;
            this.descuentoAplicado = 0.0;
        }
    }
}
