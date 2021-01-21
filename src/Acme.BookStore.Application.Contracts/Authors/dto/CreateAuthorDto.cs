using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Acme.BookStore.Authors;

namespace Acme.BookStore.Authors.dto
{
    public class CreateAuthorDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string ShortBio { get; set; }
    }
}
