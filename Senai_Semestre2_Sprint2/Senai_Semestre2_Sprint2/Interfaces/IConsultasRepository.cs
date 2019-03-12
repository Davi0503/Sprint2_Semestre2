using Senai_Semestre2_Sprint2.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Semestre2_Sprint2.Repositories
{
    public interface IConsultasRepository
    {
        List<Consultas> Listar();
        void Cadastrar(Consultas consulta);
        void Atualizar(Consultas consulta);
    }
}
