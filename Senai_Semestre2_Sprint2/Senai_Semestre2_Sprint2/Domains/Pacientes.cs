using System;
using System.Collections.Generic;

namespace Senai_Semestre2_Sprint2.Domains
{
    public partial class Pacientes
    {
        public Pacientes()
        {
            Consultas = new HashSet<Consultas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rg { get; set; }

        public Usuarios IdUsuarioNavigation { get; set; }
        public ICollection<Consultas> Consultas { get; set; }
    }
}
