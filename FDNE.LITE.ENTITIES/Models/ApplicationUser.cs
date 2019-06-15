using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FDNE.LITE.ENTITIES.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string PaternalSurname { get; set; }

        [Required]
        public string MaternalSurname { get; set; }

        [NotMapped]
        public string FullName => $"{Name}, {PaternalSurname} {MaternalSurname}";

        [Required]
        public string Dni { get; set; }

        public DateTime? BirthDate { get; set; }

        public string UrlPicture { get; set; }

        public ICollection<Binomial> Binomials { get; set; }
    }
}
