using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.DAO
{
    public interface IRescueDAO
    {
        void AddRescue(RescueDTO rescue);
        void UpdateRescue(RescueDTO rescue);
        void DeleteRescue(RescueDTO rescue);
        RescueDTO GetRescueById(int id);
        List<RescueDTO> GetRescues();
    }
}
