﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Books.Models
{
    public partial class Livro
    {
        public Livro()
        {
            LivroClienteEmprestimo = new HashSet<LivroClienteEmprestimo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("livroNome")]
        [StringLength(50)]
        public string LivroNome { get; set; }
        [Required]
        [Column("livroAutor")]
        [StringLength(200)]
        public string LivroAutor { get; set; }
        [Required]
        [Column("livroEditora")]
        [StringLength(100)]
        public string LivroEditora { get; set; }
        [Column("livroAnoPulicacao", TypeName = "datetime")]
        public DateTime LivroAnoPulicacao { get; set; }
        [Required]
        [Column("livroEdicao")]
        [StringLength(50)]
        public string LivroEdicao { get; set; }

        [InverseProperty("LceldLivroNavigation")]
        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }
    }
}