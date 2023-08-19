using Microsoft.EntityFrameworkCore;
using defesaCivil.Domain.Entidades;
using defesaCivil.Repository.Context;
using defesaCivil.Repository.Interfaces;
using defesaCivil.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defesaCivil.Repository.Repositories
{
    public class OcorrenciaRepository : GenericRepository<Ocorrencia>, IOcorrenciaRepository
    {

        public OcorrenciaRepository(defesaCivilContext context) : base(context) { }

        public List<Ocorrencia> PegarTodas()
        {
            return GetAll().ToList();
        }

        public bool RemoverOcorrencia(long Id)
        {
            try
            {
                Remover(Id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Ocorrencia SalvarOcorrencia(Ocorrencia ocorrencia)
        {
            throw new NotImplementedException();
        }
    }
}
