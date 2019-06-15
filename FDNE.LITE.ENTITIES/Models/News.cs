using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FDNE.LITE.ENTITIES.Models
{
    public class News
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Body { get; set; }

        public string UrlPicture { get; set; }

        public DateTime PublicationTime { get; set; }
    }
}
