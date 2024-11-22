using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class CuentasDeAdministracion
    {
        public string Propietario { get; set; }
        public int ID { get; set; }
        public bool NivelAdmin { get; set; }
        public bool NivelGerente { get; set; }
        public bool NivelCajero { get; set; }
        public string Contraseña { get; set; }

        public void Admin_Alta() { }


    }
}
