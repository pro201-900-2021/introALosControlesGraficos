using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introALosControlesGraficos.model
{
    class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;

        public Persona(string nombre, string apellido, int edad)
        {
            _nombre = nombre;
            _apellido = apellido;
            _edad = edad;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Edad { get => _edad; set => _edad = value; }
    }
}
