﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RPPP_WebApp.Models;

/// <summary>
/// Tablica "Kartica" iz baze podataka.
/// </summary>
[Table("kartica")]
public partial class Kartica
{
    /// <summary>
    /// Stanje na kartici.
    /// </summary>
    [Column("stanje", TypeName = "decimal(18, 0)")]
    public decimal Stanje { get; set; }

    /// <summary>
    /// Broj kartice (jedinstven).
    /// </summary>
    [Key]
    [Column("brKartice")]
    public int BrKartice { get; set; }

    /// <summary>
    /// Projekt uz kojeg je vezana kartica.
    /// </summary>
    [InverseProperty("BrKarticeNavigation")]
    public virtual ICollection<Projekt> Projekt { get; set; } = new List<Projekt>();

    /// <summary>
    /// Popis transakcija vezanih uz karticu.
    /// </summary>
    [InverseProperty("BrKarticeNavigation")]
    public virtual ICollection<Transakcija> Transakcija { get; set; } = new List<Transakcija>();

}