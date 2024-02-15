
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace TheMovieDB.Models.EntityFramework;

[PrimaryKey("Utl_id", "Flm_id")]
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

    [ForeignKey("Utl_id")]
    [InverseProperty("t_j_notation_not")]
    public virtual t_e_utilisateur_utl UtilisateurNotant { get; set; } = null!;

    [ForeignKey("Flm_id")]
    [InverseProperty("t_j_notation_not")]
    public virtual t_e_film_flm FilmNote { get; set; } = null!;
}