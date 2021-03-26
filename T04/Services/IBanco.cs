using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T04.Models;

namespace T04.Services
{

    public interface IBanco
    {
        public List<Aluno> Alunos { get; }

    }
}
