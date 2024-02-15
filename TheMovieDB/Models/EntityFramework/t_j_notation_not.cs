using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace TheMovieDB.Models.EntityFramework;


[Table("t_j_notation_not")]
public partial class t_j_notation_not
{
    [Key]
    [Column("utl_id")]
    public int UtilisateurId { get; set; }
    [Key]
    [Column("flm_id")]
    public int FilmId { get; set; }
    [Column("not_note")]
    public int Note { get; set; }

    [ForeignKey("t_e_film_flm")]
    [InverseProperty("FilmId")]
    public virtual t_e_film_flm FilmNote { get; set; } = null!;

    [ForeignKey("t_e_utilisateur_utl")]
    [InverseProperty("UtilisateurId")]
    public virtual t_e_utilisateur_utl UtilisateurNotant { get; set; } = null!;
}
