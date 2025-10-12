using POO_app_Ejemplo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_app_Ejemplo.Models
{
    public class SuperHeroe : Heroe , ISuperHeroe
    {
        // Propiedades públicas del superhéroe
        private string _Nombre;
        public int Id { get; set; }
        public override string Nombre 
        { get
            { 
                return _Nombre; 
            
            }
          
          set
            { 
                _Nombre = value.Trim(); 
            }
        }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public List<Superpoder> SuperPoderes { get; set; }
        public bool PuedeVolar { get; set; }

        // Constructor vacío (permite crear el objeto sin parámetros)
        public SuperHeroe() { }

        // Constructor con parámetros para inicializar todas las propiedades
        public SuperHeroe(int id, string nombre, string identidadSecreta, string ciudad, bool puedeVolar, List<Superpoder> superPoderes)
        {
            Id = id;
            Nombre = nombre;
            IdentidadSecreta = identidadSecreta;
            Ciudad = ciudad;
            PuedeVolar = puedeVolar;
            SuperPoderes = superPoderes;
        }

        public override string SalvarLaTierra ()
        {
           return $"El superhéroe {IdentidadSecreta} ha salvado la Tierra!";
        }

        // Método público, que puede ser llamado desde cualquier parte
        public void UsarSuperpoder()
        {
            // Implementación de ejemplo
        }

        // Método privado, solo accesible dentro de esta clase
        private void MetodoPrivado()
        {
            // Implementación de ejemplo
        }

        // Método internal, accesible solo dentro del mismo proyecto/ensamblado
        internal void MetodoInterno()
        {
            // Implementación de ejemplo
        }

        // Método protected internal, accesible en clases derivadas o dentro del mismo ensamblado
        protected internal void MetodoProtegidoInterno()
        {
            // Implementación de ejemplo
        }

        public override string SalvarElMundo()
        {
            return $"El superhéroe {Nombre} está salvando el mundo!";
        }
    }

}
