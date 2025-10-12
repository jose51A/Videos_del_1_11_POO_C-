using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_app_Ejemplo.Models
{
    public class Superpoder
    {
        // Propiedades públicas del superpoder
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public NivelPoder Nivel { get; set; }

        // Constructor vacío
        public Superpoder() { }

        // Constructor con parámetros para inicializar todas las propiedades
        public Superpoder(string nombre, string descripcion, NivelPoder nivel)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Nivel = nivel;
        }
        // Enumerado que define los niveles de poder
        public enum NivelPoder
        {
            Nivel1,
            Nivel2,
            Nivel3
        }
    }
}
