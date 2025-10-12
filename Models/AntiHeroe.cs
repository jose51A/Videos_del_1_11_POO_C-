using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_app_Ejemplo.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionDeAntiheroe(string accion)
        {
            return $"El antiheroe {Nombre} ha realizado {accion}";
        }
    }
}
