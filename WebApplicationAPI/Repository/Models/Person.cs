using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationAPI.Repository.Models
{
    [Table("Person")]
    public partial class Person
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(100)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [Column("last_name")]
        [StringLength(100)]
        [Unicode(false)]
        public string LastName { get; set; } = null!;
        [Column("address")]
        [StringLength(1000)]
        [Unicode(false)]
        public string Address { get; set; } = null!;
        [Column("phone_number")]
        [StringLength(100)]
        [Unicode(false)]
        public string PhoneNumber { get; set; } = null!;
        [Column("date_of_birth", TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
    }
}
