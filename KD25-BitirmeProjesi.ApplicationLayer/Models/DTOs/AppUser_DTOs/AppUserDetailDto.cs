﻿using KD25_BitirmeProjesi.CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD25_BitirmeProjesi.ApplicationLayer.Models.DTOs.AppUser_DTOs
{
    public class AppUserDetailDto
    {
        
            public int UserID { get; set; }
            public string FirstName { get; set; }
            public string? SecondName { get; set; }
            public string Surname { get; set; }
            public string? SecondSurname { get; set; }
            public string? Avatar { get; set; }
            public DateTime? BirthDate { get; set; }
            public string? BirthPlace { get; set; }
            public string NationalID { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string? Proficiency { get; set; }
            public string? Address { get; set; }
            public decimal? Salary { get; set; }
            public string? CurrencyType { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Role { get; set; }

            public string Company { get; set; }
            public string Department { get; set; }
        

    }
}
