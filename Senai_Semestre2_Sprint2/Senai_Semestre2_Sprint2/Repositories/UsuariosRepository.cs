using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Senai_Semestre2_Sprint2.Domains;
using Senai_Semestre2_Sprint2.DTOs.LoginDTO;

namespace Senai_Semestre2_Sprint2.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        public Usuarios BuscarPorEmail(LoginDTO login)
        {
            using (SpMedGroup ctx = new SpMedGroup())
            {

                Usuarios usuario = ctx.Usuarios.Include(n => n.Permicao).ToList().Find(x => x.Email == login.Email);

                return usuario;
                
            }



        }

        public void Cadastrar(Usuarios usuario)
        {
            using (SpMedGroup ctx = new SpMedGroup())
            {

                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();

            }
        }

        public List<Usuarios> Listar()
        {
            using (SpMedGroup ctx = new SpMedGroup())
            {
                return ctx.Usuarios.ToList();
            }
        }
    }
}
