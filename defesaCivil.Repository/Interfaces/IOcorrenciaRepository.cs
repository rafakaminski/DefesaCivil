using defesaCivil.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defesaCivil.Repository.Interfaces
{
    public interface IOcorrenciaRepository
    {
        List<Ocorrencia> PegarTodas();
        Ocorrencia SalvarOcorrencia(Ocorrencia ocorrencia);
        bool RemoverOcorrencia(long id);
    }   
}
