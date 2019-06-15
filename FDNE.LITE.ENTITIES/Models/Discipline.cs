using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FDNE.LITE.ENTITIES.Models
{
    public class Discipline
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
