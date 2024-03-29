﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DershaneOrnekSB.Entities
{
    public class User
    {
        
        public int Id { get; set; }

        [Display(Name = "Ad"), StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Soyad"), StringLength(50)]
        public string? Surname { get; set; }

        public string? Email { get; set; }

        [Display(Name = "Telefon"), StringLength(15)]
        public string? Phone { get; set; }

        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Display(Name = "Eklenme Tarihi"),ScaffoldColumn(false)]
        public DateTime? CreateDate { get; set; }
         = DateTime.Now;

        [Display(Name = "Durum")]
        public bool IsActive { get; set; }

        [Display(Name = "Admin")]
        public bool IsAdmin { get; set; }

        public Guid? UserGuid { get; set; } // Bu guid i session veya cookie de saklayarak kullanıcıyı tanımak için kullanırız
    }
}
