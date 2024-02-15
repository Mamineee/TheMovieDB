using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace TheMovieDB.Models.EntityFramework;

[PrimaryKey("Flm_id")]
[Table("t_e_film_flm")]
public partial class t_e_film_flm
{
    [Key]
    [Required]
    [Column("flm_id")]
    public int FilmId { get; set; }

    [StringLength(100)]
    [Column("flm_titre")]
    public string? Titre { get; set; }


    [Column("flm_resume")]
    public string? Resume { get; set; }

    [Column("flm_datesortie")]
    public DateTime? DateSortie { get; set; }

    [Column("flm_duree")]
    public double Duree { get; set; }

    [Column("flm_genre")]
    [StringLength(30)]
    public string? Genre { get; set; }

    [InverseProperty("Flm_Navigation")]
    public virtual ICollection<t_e_film_flm> NotesFilm { get; set; } = new List<t_e_film_flm>();
}
