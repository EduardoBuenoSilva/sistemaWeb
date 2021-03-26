using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T04.Models;

namespace T04.Services
{
    public class BancoMemoria : IBanco
    {
         private List<Aluno> db = new List<Aluno>();

        public BancoMemoria()
        {
            db.Add(new Aluno
            {
                Name = "Eduardo Bueno",
                RA = 139547,
                DtNascimente = new DateTime(1998, 3, 19)
            });

            db.Add(new Aluno
            {
                Name = "Mauricio Asenjo",
                RA = 999999,
                DtNascimente = new DateTime(1960, 5, 12)
            });

            db.Add(new Aluno
            {
                Name = "Claudio Nunes",
                RA = 696969,
                DtNascimente = new DateTime(1966, 2, 20)
            });

        }

        public List<Aluno> Alunos
        {

            get
            {
                return db;

            }

        }

       
    }
}
