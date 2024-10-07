﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RPPP_WebApp.Models;

[Table("zahtjev")]
public partial class Zahtjev
{
    [Key]
    [Column("idZahtjeva")]
    public int IdZahtjeva { get; set; }

    [Required]
    [Column("naslov", TypeName = "text")]
    public string Naslov { get; set; }

    [Column("opis", TypeName = "text")]
    public string Opis { get; set; }

    [Column("idProjekta")]
    public int? IdProjekta { get; set; }

    [ForeignKey("IdProjekta")]
    [InverseProperty("Zahtjev")]
    public virtual Projekt IdProjektaNavigation { get; set; }

    [Column("idVrste")]
    public int? IdVrste { get; set; }  

    [ForeignKey("IdVrste")]
    [InverseProperty("Zahtjev")]
    public virtual VrstaZah IdVrsteNavigation { get; set; }

    [InverseProperty("IdZahtjevaNavigation")]
    public virtual ICollection<Zadatak> Zadatak { get; set; } = new List<Zadatak>();
}