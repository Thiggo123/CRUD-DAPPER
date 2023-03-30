using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_DAPPER.Entities
{
    public class Produto
    {
        [Key]
        [Display(Name = "ProdutoId")]
        public int ProdutoId { get; set; }

        [Required]
        [Display(Name = "Nome do Produto")]
        [StringLength(25,ErrorMessage ="O Nome deve ter entre 1 e 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Estoque")]
        public int Estoque { get; set; }
        [Required]
        [Display(Name = "Preço")]
        public double Preco { get; set; }
    }
}
