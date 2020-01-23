using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_BLL.Models
{
    public class RegisterModel
    {
        [DisplayName("Yetkili Adı")]
        public string Name { get; set; }

        [DisplayName("Yetkili Soyadı")]
        public string Surname { get; set; }
      
        [DisplayName("İşletme Adı")]
        public string CompanyName { get; set; }

        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }

        [DisplayName("Adres")]
        public string Adres { get; set; }

        [DisplayName("Eposta")]
        [EmailAddress(ErrorMessage ="Eposta adresiniz hatalı!!")]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        public string Password { get; set; }

        [DisplayName("Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreleriniz uyuşmuyor.")]
        public string RePassword { get; set; }

    }
}
