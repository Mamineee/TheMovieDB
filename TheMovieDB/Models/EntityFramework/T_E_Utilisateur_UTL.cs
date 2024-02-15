using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheMovieDB.Models.EntityFramework;


[Table("t_e_utilisateur_utl")]
public partial class t_e_utilisateur_utl
{
    [Key]
    [Column("utl_id")]
    public string? UtilisateurId { get; set; }
    [Column("utl_nom")]
    [StringLength(50)]
    public string? Nom { get; set; }
    [Column("utl_prenom")]
    [StringLength(50)]
    public string? Prenom { get; set; }
    [Column("utl_mobile", TypeName = "char(10)")]
    public string? Mobile { get; set; }
    [Column("utl_mail")]
    [StringLength(100)]
    public string? Mail { get; set; }
    [Column("utl_pwd")]
    [StringLength(64)]
    public string? Pwd { get; set; }
    [Column("utl_rue")]
    [StringLength(200)]
    public string? Rue { get; set; }
    [Column("utl_cp", TypeName = "char(10)")]
    public string? CodePostal { get; set; }
    [Column("utl_ville")]
    [StringLength(50)]
    public string? Ville { get; set; }
    [Column("utl_pays")]
    [StringLength(50)]
    public string? Pays { get; set; }
    [Column("utl_latitude")]
    public float? Latitude { get; set; }
    [Column("utl_longitude")]
    public float? Longitude { get; set; }
    [Column("utl_datecreation")]
    public DateTime DateCreation { get; set; }

    [InverseProperty("UtilisateurNotant")]
    public virtual ICollection<t_j_notation_not> NotesUtilisateur { get; set; } = new List<t_j_notation_not>();

}
