﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CinemaGo.DataModels.CustomModels
{
    public class ContactModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Comment is required")]

        public string Comment { get; set; }
    }
}
