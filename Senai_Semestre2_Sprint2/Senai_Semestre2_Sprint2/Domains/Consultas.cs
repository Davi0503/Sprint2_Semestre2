using System;
using System.Collections.Generic;

namespace Senai_Semestre2_Sprint2.Domains
{
    public partial class Consultas
    {
        public int Id { get; set; }
        public DateTime DataAgendamento { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Descricao { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedicos { get; set; }
        public int IdStatus { get; set; }

        public Medicos IdMedicosNavigation { get; set; }
        public Pacientes IdPacienteNavigation { get; set; }
        public StatusConsulta IdStatusNavigation { get; set; }
    }
}
