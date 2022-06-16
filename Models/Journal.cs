using csharp_api.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_api.Models
{
    [Table("journal_chantier")]
    public class Journal: BaseEntity
    {
        [Column("numero_chantier")]
        public int NumeroChantier { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("temperature_matin")]
        public int TemperatureMatin { get; set; }

        [Column("temperature_soir")]
        public int TemperatureSoir { get; set; }
        
        [Column("moe_generated")]
        public bool MoeGenerated { get; set; }

        [Column("materiel_generated")]
        public bool MaterielGenerated { get; set; }

        [Column("note")]
        public string Note { get; set; }


        public virtual Chantier Chantier { get; set; }
        public virtual IList<Depense> Depenses { get; set; }
    }
}
