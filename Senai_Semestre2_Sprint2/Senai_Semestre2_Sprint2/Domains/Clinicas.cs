using System;
using System.Collections.Generic;

namespace Senai_Semestre2_Sprint2.Domains
{
    public partial class Clinicas
    {
        public Clinicas()
        {
            Medicos = new HashSet<Medicos>();
        }

        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RasaoSocial { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cnpj { get; set; }

        public ICollection<Medicos> Medicos { get; set; }
    }
}
