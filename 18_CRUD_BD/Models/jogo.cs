using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _18_CRUD_BD.Models
{
    [Table("Jogos")]
    public class Jogo
    {
        [Key]
        public int JogoId { get; set; }
        [Required(ErrorMessage="Nome é obrigatorio")]
        [Display(Name="Nome do jogo")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public bool Ativo{ get; set; }




    }
}