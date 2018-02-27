using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AppDamnModels;
using AppDamnDAL;
namespace AppDamnBLL
{
    public class UserAccount
    {
        CCOR_AppsDBEntities _objDAL = new CCOR_AppsDBEntities();
       
        public UserAccount()
        {
            
        }
        public List<ProfessionInfoModel> GetProfessionInfo()
        {              
            List<ProfessionInfo> _objUserModel = _objDAL.GetAllProfessionInfo().ToList<ProfessionInfo>();                            
            List<ProfessionInfoModel> profLst =
                    _objUserModel.Select(x => new ProfessionInfoModel
                            {
                                ProfessionCode = x.ProfessionCode,
                                Profession = x.Profession
                            }).ToList();         
            return profLst;
        }
        public int CreateUserAccount(UserAccViewModel model)
        {
            int result = 0;
                  
            return result;
        }

    }
}
