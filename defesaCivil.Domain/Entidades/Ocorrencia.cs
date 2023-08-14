using defesaCivil.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace defesaCivil.Domain.Entidades
{
    public class Ocorrencia
    {
        public string Titulo { get; set; }
        public GravidadeEnum Gravidade { get; set; }
        public DateTime Data { get; set; }
        public int Cobrade { get; set; }

       
    }
}