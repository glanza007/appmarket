﻿using Appmarket.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appmarket.Data.Entities
{
    
        public class User : IdentityUser
        {
            [MaxLength(20,ErrorMessage = "* Solo se permiten números.")]
            [Required]
            [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
            public string Document { get; set; }

            [Display(Name = "First Name")]
            [MaxLength(50)]
            [Required]
            public string FirstName { get; set; }

            [Display(Name = "Last Name")]
            [MaxLength(50)]
            [Required]
            public string LastName { get; set; }

            [MaxLength(100)]
            public string Address { get; set; }

            [Display(Name = "Image")]
            public Guid ImageId { get; set; }

            //TODO: Pending to put the correct paths
            [Display(Name = "Image")]
            public string ImageFullPath => ImageId == Guid.Empty
                ? $"https://localhost:44367/images/noimage.png"
                : $"https://tecnologershn.blob.core.windows.net/usuarios/{ImageId}";

        [Display(Name = "User Type")]
            public UserType UserType { get; set; }

            public City City { get; set; }

            [Display(Name = "User")]
            public string FullName => $"{FirstName} {LastName}";

            [Display(Name = "User")]
            public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
        }

    
}
