using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.DAO
{
    public interface ISeaTurtleDAO
    {
        List<SeaTurtleDTO> GetSeaTurtles();
        SeaTurtleDTO GetSeaTurtleById(int id);
        void AddSeaTurtle(SeaTurtleDTO seaTurtle);
        void UpdateSeaTurtle(SeaTurtleDTO seaTurtle);
        void DeleteSeaTurtle(SeaTurtleDTO seaTurtle);
    }
}
