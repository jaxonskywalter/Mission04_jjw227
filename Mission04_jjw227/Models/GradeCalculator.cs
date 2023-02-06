using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_jjw227.Models
{
    public class GradeCalculator
    {
        
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public decimal assignments { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal groupProject { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal quizzes { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal midtermExam { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal finalExam { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal intex { get; set; }

    }
}
