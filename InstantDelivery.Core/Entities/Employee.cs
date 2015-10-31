﻿using InstantDelivery.Core.Enums;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InstantDelivery.Core.Entities
{
    [ImplementPropertyChanged]
    public class Employee : ValidationBase
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane")]
        [RegularExpression("[A-ZĄĆĘŁŃÓŚŹŻ]{1}[a-ząćęłńóśżź]+", ErrorMessage = "Proszę podać poprawne imię")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane")]
        [RegularExpression("[A-ZĄĆĘŁŃÓŚŹŻ]{1}[a-ząćęłńóśżź]+", ErrorMessage = "Proszę podać poprawne nazwisko")]
        public string LastName { get; set; }

        public Gender Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        [Phone(ErrorMessage = "Proszę podać poprawny numer telefonu")]
        public string PhoneNumber { get; set; }
        public Address PlaceOfResidence { get; set; }
        public string Email { get; set; }
        public string Pesel { get; set; }
        public string Comments { get; set; }
        public string MotherMaidenName { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }

        [Range(0.0, int.MaxValue)]
        public decimal Salary { get; set; }
        public DateTime? HireDate { get; set; }
        public string Citizenship { get; set; }
        public virtual ICollection<Package> Packages { get; set; }
    }
}