using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeRiegoAutomatico
{
    public class ConfiguracionProgramado
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string hActivar;
        public string HActivar
        {
            get { return hActivar; }
            set { hActivar = value; }
        }

        private string hDesactivar;
        public string HDesactivar
        {
            get { return hDesactivar; }
            set { hDesactivar = value; }
        }

        public ConfiguracionProgramado()
        {
            this.Id = 0;
            this.HActivar = "";
            this.HDesactivar = "";
        }

        public ConfiguracionProgramado(int id, string horaActivar, string horaDesactivar)
        {
            this.Id = id;
            this.HActivar = horaActivar;
            this.HDesactivar = horaDesactivar;
        }

        public string cadena()
        {
            return HActivar + " - " + HDesactivar;
        }
    }
}
