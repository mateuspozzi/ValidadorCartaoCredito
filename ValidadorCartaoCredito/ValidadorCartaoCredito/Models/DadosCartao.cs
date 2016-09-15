using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ValidadorCartaoCredito.Models
{
    public class DadosCartao
    {
        [MaxLength(19, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(19, ErrorMessage = "Mínimo de 19 caracteres")]
        [DisplayName("Número do Cartão")]
        [Required(ErrorMessage = "Preencher campo Numero do Cartão")]
        public String NumeroCartao { get; set; }
    }
}