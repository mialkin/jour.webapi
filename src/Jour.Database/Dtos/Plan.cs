using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jour.Database.Dtos
{
    public class ToDo
    {
        [Key]
        public int ToDoId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime? DateCompleted { get; set; }
    }
}