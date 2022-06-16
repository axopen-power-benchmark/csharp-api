using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_api.Models
{
    [Table("canopee_user")]
    public class User
    {
        [Key]
        [Column("matricule")]
        public int Matricule { get; set; }

        [Column("fullname")]
        public string Fullname { get; set; }

        [Column("societe")]
        public string Societe { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("job_title")]
        public string JobTitle { get; set; }

        [Column("resource_group_no")]
        public string ResourceGroupNo { get; set; }

        [Column("travel_code")]
        public string TravelCode { get; set; }

        [Column("numero_latest_chantier")]
        public int NumeroLatestChantier { get; set; }

        [Column("journal_pointage_erp")]
        public string JournalPointageErp { get; set; }


        public virtual Chantier Chantier { get; set; }
        public virtual IList<Chef> Chefs { get; set; }
        public virtual IList<Ouvrier> Ouvriers { get; set; }

    }
}
