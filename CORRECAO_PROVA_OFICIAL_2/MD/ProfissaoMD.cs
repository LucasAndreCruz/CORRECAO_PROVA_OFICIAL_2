using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CORRECAO_PROVA_OFICIAL_2.Models
{
    [MetadataType(typeof(ProfissaoMD))]
    public partial class Profissao { }
    public class ProfissaoMD
    {
        [DisplayName("Código(PK)")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int ProfissaoId { get; set; }

        [DisplayName("Profissão")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(20, ErrorMessage = "No máximo 20 caracteres")]
        public string NomeProfissao { get; set; }
    }
}