using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CadProdutos.Models
{
    [Table("categorias", Schema = "public")]

    public class Categoria
    {
        [Key]
        [Column("id")]

        public int Id { get; set; }
        [Column("nome")]

        public string Nome { get; set; } = "";

        public List<Produto> Produto
        { get; set; } = new List<Produto>();
    }
}