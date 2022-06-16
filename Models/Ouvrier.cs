using csharp_api.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_api.Models
{
    [Table("ouvrier_chantier")]
    public class Ouvrier : BaseEntity
    {
        [Column("numero_chantier")]
        public int NumeroChantier { get; set; }

        [Column("matricule_user")]
        public int MatriculeUser { get; set; }

        [Column("matricule")]
        public string Matricule { get; set; }

        [Column("unbind")]
        public bool Unbind { get; set; }


        public virtual Chantier Chantier { get; set; }
        public virtual User User { get; set; }
        public virtual IList<Depense> Depenses { get; set; }
    }
}
