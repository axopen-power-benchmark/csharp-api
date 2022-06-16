using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_api.Models
{
    [Table("chef_chantier_user")]
    public class Chef
    {
        [Column("numero_chantier")]
        public int NumeroChantier{ get; set; }

        [Column("matricule_user")]
        public int MatriculeUser { get; set; }

        public virtual Chantier Chantier { get; set; }
        public virtual User User { get; set; }

    }
}
