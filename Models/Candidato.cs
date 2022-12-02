using System;
using System.ComponentModel.DataAnnotations;

namespace CandidatoInfo.Models
{
    public class Candidato
    {
        public string Nome { get; set; }
        [Display(Name = "Cargo Pretendido")]
        public string CargoPretendido { get; set; }
        [Display(Name = "Pretensão Salarial")]
        public double PretensaoSalarial { get; set; }
        [Display(Name = "Data do Teste")]
        public DateTime DataTeste { get; set; }
    }
}
