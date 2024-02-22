using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.data.dto
{
    public class UserLoginDto
    {
        private string password;
        private string login;

        public UserLoginDto(string password, string login)
        {
            this.password = password;
            this.login = login;
        }

        [System.ComponentModel.DisplayName("Password")]
        [Required(ErrorMessage = "Le Password obliatoire")]
        [StringLength(10,MinimumLength =2,ErrorMessage ="Le Password doit contenir entre 2 et 10 caracteres ")]
        public string Password { get => password; set => password = value; }

        [System.ComponentModel.DisplayName("Login")]
        [Required(ErrorMessage ="Le login obligatoire")]
        public string Login { get => login; set => login = value; }
    }
}
