using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SCG.ApplicationCore.Entity
{
    public class Contato:Notifiable
    {
        public Contato()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "int")]
        public int ContatoId{ get;  set; }

        public virtual Cliente Cliente { get; set; }
        [ForeignKey("Cliente")]
        [Column(Order = 2, TypeName = "int")]
        public int ClienteId { get;  set; }

        [Required]
        [Column("Nome", Order = 3, TypeName = "nvarchar(100)")]
        public string Nome { get; set; }

        [Required]
        [Column("Telefone", Order = 4, TypeName = "nvarchar(20)")]
        public string Telefone { get; set; }

        [Required]
        [Column("Email", Order = 5, TypeName = "nvarchar(100)")]
        public string Email { get; set; }

     
    }
}
