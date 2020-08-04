using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Serialization;

namespace SalesWebMvc1.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome obrigatório")]
        [StringLength(40)]
        public string Name { get; set; } 
        [EmailAddress(ErrorMessage ="Campo obrigatório")]
        public string Email { get; set; }
        [Display(Name ="Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SallesRecord> Salles { get; set; } = new List<SallesRecord>();
        public int DepartmentId { get; set; }

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddSalles( SallesRecord sr)
        {
            Salles.Add(sr);

        }
        public void RemoveSalles(SallesRecord sr)
        {
            Salles.Remove(sr);
        }
        public double TotalSalles(DateTime inicial, DateTime final)
        {
            return Salles.Where(sr => sr.Date >= inicial && sr.Date <= final).Sum(sr => sr.Amount);

        }
    }
}
