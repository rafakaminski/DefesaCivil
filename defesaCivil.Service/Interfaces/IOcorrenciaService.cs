using defesaCivil.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defesaCivil.Service.Interfaces
{
    public interface IOcorrenciaService
    {
        Ocorrencia Salvar(Ocorrencia ocorrencia);

        List<Ocorrencia> BuscarTodas();

        bool Remover(long id);


    }
}
