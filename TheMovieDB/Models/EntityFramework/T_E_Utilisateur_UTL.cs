using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Intrinsics.X86;
using Microsoft.EntityFrameworkCore;


namespace TheMovieDB.Models.EntityFramework;

[PrimaryKey("Utl_id")]
[Table("t_e_utilisateur_utl")]
public partial class t_e_utilisateur_utl
{
    [Key]
    [Required]
    [Column("utl_id")]
    public int UtilisateurId { get; set; }

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
    [Required]
    public string? Mail { get; set; }

    [Column("utl_pwd")]
    [Required]
    public string? Pwd { get; set; }

    [Column("utl_rue")]
    public string? Rue { get; set; }

    [Column("utl_cp")]
    public string? CodePostal { get; set; }

    [Column("utl_ville")]
    public string? Ville { get; set; }

    [Column("utl_pays")]
    public string? Pays { get; set; }

    [Column("utl_latitude")]
    public decimal Latitude { get; set; }
    
    [Column("utl_longitude")]
    public decimal Longitude { get; set; }

    [Column("utl_datecreation")]
    public DateTime DateCreation { get; set; }

    [InverseProperty("Utl_Navigation")]
    public virtual ICollection<t_e_utilisateur_utl> NotesUtilisateur { get; set; } = new List<t_e_utilisateur_utl>();
}