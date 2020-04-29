﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phd.Models
{
    public class BRStudentGrade
    {
        public int Id { get; set; }

        [Display(Name = "Оценка (%)")]
        public int Value { get; set; }
        public string Opinion { get; set; }  // добавил в соотвествии с презентацией
        public string Question { get; set; } // добавил в соотвествии с презентацией

        // связи
        public int BRStudentId { get; set; }
        public BRStudent BRStudent { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        // ***





        


    }
}
