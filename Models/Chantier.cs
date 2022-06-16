using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_api.Models
{
    [Table("chantier")]
    public class Chantier
    {
        [Key]
        [Column("numero")]
        public int Numero { get; set; }

        [Column("description")]
        public string Description{ get; set; }

        [Column("city")]
        public string City { get; set; }
        
        [Column("city_cp")]
        public int CityCP { get; set; }

        [Column("date_debut")]
        public DateTime DateDebut { get; set; }

        [Column("date_fin")]
        public DateTime DateFin { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("lien_sharepoint")]
        public string LienSharepoint { get; set; }

        [Column("lien_files")]
        public string LienFiles { get; set; }

        [Column("lien_gearth")]
        public string LienGearth { get; set; }

        [Column("prix_moyen_moe_jour")]
        public int PrixMoyenMoeJour { get; set; }

        [Column("prix_moyen_moe_nuit")]
        public int PrixMoyenMoeNuit { get; set; }

        [Column("prix_moyen_materiel")]
        public int PrixMoyenMateriel { get; set; }

        [Column("journal_pointage_erp")]
        public string JournalPointageErp { get; set; }

        public virtual IList<Ouvrier> Ouvriers { get; set; }
        public virtual IList<Chef> Chefs { get; set; }
        public virtual IList<Journal> Journaux { get; set; }
        public virtual IList<User> Users { get; set; }
    }
}
