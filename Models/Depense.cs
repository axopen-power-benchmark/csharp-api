using csharp_api.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_api.Models
{
    [Table("depense_main_doeuvre")]
    public class Depense : BaseEntity
    {

        [Column("id_journal_chantier")]
        public int IdJournalChantier { get; set; }

        [Column("id_ouvrier_chantier")]
        public int IdOuvrierChantier { get; set; }

        [Column("quart_dheures_jour")]
        public int QuartHeuresJour { get; set; }

        [Column("quart_dheures_nuit")]
        public int QuartHeuresNuit { get; set; }

        [Column("voiture")]
        public bool Voiture { get; set; }

        [Column("sent")]
        public bool Sent { get; set; }
    
    
        public virtual Journal Journal { get; set; }
        public virtual Ouvrier Ouvrier { get; set; }
    }
}
