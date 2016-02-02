﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Models
{
    public class QuestionViewModel
    {
        public Guid QuestionID { get; set; }
        public Guid StudentID { get; set; }
        public Guid? TutorID { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "The {0} must be at least {2} characters long and maximum 256 characters long.", MinimumLength = 10)]
        public string Title { get; set; }

        [Required]
        [AllowHtml]
        [StringLength(1000, ErrorMessage = "The {0} must be at least {2} characters long and maximum 1000 characters long.", MinimumLength = 10)]
        public string Details { get; set; }

        public string Status { get; set; }
        [Required]
        public float Amount { get; set; }

        public Guid? CategoryID { get; set; }

       
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DueDate { get; set; }
        public DateTime PostedTime { get; set; }
    }
}