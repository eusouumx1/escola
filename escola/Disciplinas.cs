using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    internal class Disciplina
    {
        public string Titulo { get; set; }
        public double CargaHoraria { get; set; }
        public string Ementa { get; set; }

        public Disciplina(string titulo, double cargaHoraria, string ementa) 
        {
            this.Titulo = titulo;
            this.CargaHoraria = cargaHoraria;
            this.Ementa = ementa;
        }
    }
}
