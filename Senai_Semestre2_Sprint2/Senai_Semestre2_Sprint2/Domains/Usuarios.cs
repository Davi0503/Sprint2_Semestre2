using System;
using System.Collections.Generic;

namespace Senai_Semestre2_Sprint2.Domains
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Medicos = new HashSet<Medicos>();
            Pacientes = new HashSet<Pacientes>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Permicao { get; set; }

        public ICollection<Medicos> Medicos { get; set; }
        public ICollection<Pacientes> Pacientes { get; set; }
    }
}
