using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace AppDamn.Models
{
    public class UserAccountViewModels
    {
        [Required]
        [Display(Name = "Your Profession")]
        public List<string> YourProfession { get; set; }        

        [Required]
        [Display(Name="User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name ="E-Mail")]
        public string EMail { get; set; }

        [Required]
        [Display(Name ="Password")]
        public string PWD { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        public string ConfirmPWD { get; set; }

        public List<string> AddProfession()
        {
            List<string> profession = new List<string>();
            YourProfession.Add("Devl");

            return profession;

        }
    }

}