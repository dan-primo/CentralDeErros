﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CentralDeErros.Infra.Entidades
{
    [Table ("USERS")]
    public class Users
    {
        [Column("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int UserId { get; set; }

        [Column("NAME")]
        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        [Column("EMAIL")]
        [StringLength(200)]
        [Required]
        public string Email { get; set; }

        [Column("PASSWORD")]
        [StringLength(50)]
        [Required]
        public string Password { get; set; }

        [Column("ROLE")]
        [StringLength(50)]
        [Required]
        public string Role { get; set; }
        public ICollection<Logs> ErrorOccurrences { get; set; }
    }
}