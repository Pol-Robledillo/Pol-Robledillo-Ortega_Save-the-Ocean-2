using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs
{
    public class Player
    {
        public string? Name { get; set; }
        public string? Occupation { get; set; }
        public int Exp { get; set; }
        public Player(string name, string occupation, int exp)
        {
            Name = name;
            Occupation = occupation;
            Exp = exp;
        }
    }
}
