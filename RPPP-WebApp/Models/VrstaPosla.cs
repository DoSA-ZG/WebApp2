﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RPPP_WebApp.Models;
/// <summary>
/// Entitet koji predstavlja vrstu posla.
/// </summary>
[Table("vrstaPosla")]
public partial class VrstaPosla
{
    /// <summary>
    /// Jedinstveni identifikator vrste posla.
    /// </summary>
    [Key]
    [Column("idVrste")]
    public int IdVrste { get; set; }

    /// <summary>
    /// Ime vrste posla
    /// </summary>
    [Required]
    [Column("imeVrste", TypeName = "text")]
    public string ImeVrste { get; set; }

    /// <summary>
    /// Kolekcija poslova kojima je vrsta posla navedeni entitet
    /// </summary>

    [InverseProperty("IdVrsteNavigation")]
    public virtual ICollection<Posao> Posao { get; set; } = new List<Posao>();
}