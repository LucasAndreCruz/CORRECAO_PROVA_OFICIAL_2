using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CORRECAO_PROVA_OFICIAL_2.Models
{
    [MetadataType(typeof(ProfissionalMD))]
    public partial class Profissional { }
    public class ProfissionalMD
    {
        [DisplayName("Código(PK)")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int ProfissionalId { get; set; }

        [DisplayName("Profissional")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(20, ErrorMessage = "No máximo 20 caracteres")]
        public string NomeProfissional { get; set; }

        [DisplayName("Código(FK)")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int ProfissaoId { get; set; }

    }
}