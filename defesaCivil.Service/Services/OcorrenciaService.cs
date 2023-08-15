using defesaCivil.Domain.Entidades;
using defesaCivil.Repository.Interfaces;
using defesaCivil.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defesaCivil.Service.Services
{
    public class OcorrenciaService : IOcorrenciaService
    {

        private readonly IOcorrenciaRepository _ocorrenciaRepository;

        public OcorrenciaService(IOcorrenciaRepository ocorrenciaRepository)
        {
            _ocorrenciaRepository = ocorrenciaRepository;
        }

        public List<Ocorrencia> BuscarTodas()
        {
            return _ocorrenciaRepository.PegarTodas();
        }

        public Ocorrencia Salvar(Ocorrencia ocorrencia)
        {
            return _ocorrenciaRepository.SalvarOcorrencia(ocorrencia);
        }

        public bool Remover(long id)
        {
            return _ocorrenciaRepository.RemoverOcorrencia(id);
        }



    }
}
