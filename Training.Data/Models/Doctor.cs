using System;
using System.ComponentModel.DataAnnotations;

namespace Training.Data.Models
{
   public class Doctor
   {
      [Key]
      public string Id { get; set; }
      public string Name { get; set; }
      public string ProfessionalActivity { get; set; }
   }
}