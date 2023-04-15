using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Web.Models
{
    public class LoginViewModel
    {
        [Required]
         [Display(Name = "Usuario: ")]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        public string Senha { get; set; }


        [Display(Name = "Lembrar Me")]
        public bool LembrarMe { get; set; }
      
    }
}