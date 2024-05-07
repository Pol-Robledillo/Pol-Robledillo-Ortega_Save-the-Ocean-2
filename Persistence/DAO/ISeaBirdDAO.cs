using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.DAO
{
    public interface ISeaBirdDAO
    {
        List<SeaBirdDTO> GetSeaBirds();
        SeaBirdDTO GetSeaBirdById(int id);
        void AddSeaBird(SeaBirdDTO seaBird);
        void UpdateSeaBird(SeaBirdDTO seaBird);
        void DeleteSeaBird(SeaBirdDTO seaBird);
    }
}
