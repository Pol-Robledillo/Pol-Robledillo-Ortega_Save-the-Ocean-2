using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.DAO
{
    public interface ICetaceanDAO
    {
        List<CetaceanDTO> GetCetaceans();
        CetaceanDTO GetCetaceanById(int id);
        void AddCetacean(CetaceanDTO cetacean);
        void UpdateCetacean(CetaceanDTO cetacean);
        void DeleteCetacean(CetaceanDTO cetacean);
    }
}
