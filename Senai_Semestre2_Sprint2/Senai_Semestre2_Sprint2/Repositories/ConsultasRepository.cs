using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Senai_Semestre2_Sprint2.Domains;

namespace Senai_Semestre2_Sprint2.Repositories
{
    public class ConsultasRepository : IConsultasRepository
    {
        public void Atualizar(Consultas consulta)
        {
            using (SpMedGroup ctx = new SpMedGroup())
            {

                Consultas consultaUpdate = ctx.Consultas.Find(consulta.Id);
                consultaUpdate.IdStatus = consulta.IdStatus;
                ctx.SaveChanges();
            }
        }

        public void Cadastrar(Consultas consulta)
        {
            using (SpMedGroup ctx = new SpMedGroup())
            {

                ctx.Consultas.Add(consulta);
                ctx.SaveChanges();

            }
        }

        public List<Consultas> Listar()
        {
            using (SpMedGroup ctx = new SpMedGroup())
            {

                return ctx.Consultas.ToList();

            }
        }
    }
}
