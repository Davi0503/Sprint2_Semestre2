using System;
using System.Collections.Generic;

namespace Senai_Semestre2_Sprint2.Domains
{
    public partial class StatusConsulta
    {
        public StatusConsulta()
        {
            Consultas = new HashSet<Consultas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Consultas> Consultas { get; set; }
    }
}
