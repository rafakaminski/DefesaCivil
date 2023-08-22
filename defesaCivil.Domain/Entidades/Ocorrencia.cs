using defesaCivil.Domain.Enums;

namespace defesaCivil.Domain.Entidades
{
    public class Ocorrencia : BaseEntity
    {
        public string Titulo { get; set; }
        public GravidadeEnum Gravidade { get; set; }
        public DateTime Data { get; set; }
        public int Cobrade { get; set; }

       
    }
}