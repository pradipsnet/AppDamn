using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AppDamnDAL;
namespace AppDamnModels
{
    public class UserAccViewModel
    {
     
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please select your profession")]
        [Display(Name = "Your Profession")]
        public List<ProfessionInfoModel> ProfList { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your name")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "E-Mail")]
        public string EMail { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string PWD { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        public string ConfirmPWD { get; set; }
       
    }
    public class ProfessionInfoModel
    {
        public int ProfessionID { get; set; }
        public string ProfessionCode { get; set; }
        public string Profession { get; set; }
        public string ProfDescription { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }

}
