using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Students
{
    public class CreateUpdateStudentDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public int CardId { get; set; } = 0;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Required]
        public StudentType Type { get; set; } = StudentType.Studied;

    }
}
