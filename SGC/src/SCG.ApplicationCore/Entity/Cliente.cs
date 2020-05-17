using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SCG.ApplicationCore.Entity
{
    public class Cliente: Notifiable
    {

        public Cliente()
        {

        }
        public Cliente(string Nome, string CPF)
        {
            this.Nome = Nome;
            this.CPF = CPF;

          // this.Contato = new List<Contato>();

            new AddNotifications<Cliente>(this).IfNullOrInvalidLength(x => x.Nome, 1,2, "O campo nome deve conter entre 4 ou 6 caracter");

           
        }
        [Key]
        public int ClienteId { get; private set; }
        [Required]
        [Column("Nome", Order = 2, TypeName = "nvarchar(100)")]
        public string Nome { get; private set; }
        [Required]
        [Column("CPF", Order = 3, TypeName = "nvarchar(11)")]
        public string CPF { get; private set; }

     //  public ICollection<Contato> Contato { get; set; }
    }
}
