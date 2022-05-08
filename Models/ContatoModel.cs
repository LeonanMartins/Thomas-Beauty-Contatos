using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TBContatos.Models
{
    [Table("TBContatos")]
    public class Contato
    {
        [Column("id")]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Column("formacao")]
        [Display(Name = "Formação")]
        public string formacao { get; set; }

        [Column("telefone")]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Column("email")]
        [Display(Name = "E-Mail")]
        public string email { get; set; }

        [Column("datacontacto")]
        [Display(Name = "Data de Contato do Cliente")]
        public string datacontato { get; set; }

        [Column("melhorhorario")]
        [Display(Name = "Melhor Horário Para Contato")]
        public string melhorhorario { get; set; }

        [Column("primeirocontato")]
        [Display(Name = "Houve o Primeiro Contato?")]
        public bool primeirocontato { get; set; }

        [Column("numerocontatos")]
        [Display(Name = "Numero de Contatos Feitos")]
        public int numerocontatos { get; set; }

        [Column("dataprimeiro")]
        [Display(Name = "Data do Primeiro Contato")]
        public string dataprimeirocontato { get; set; }

        [Column("dataultimocontato")]
        [Display(Name = "Data do Último Contato")]
        public string dataultimocontato { get; set; }

        [Column("dataproximocontato")]
        [Display(Name = "Data do Proxímo Cotato")]
        public string dataproximocontato { get; set; }

        [Column("obs")]
        [Display(Name = "Observações")]
        public string obs { get; set; }
    }
}
