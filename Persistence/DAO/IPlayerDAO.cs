using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.DAO
{
    public interface IPlayerDAO
    {
        void SavePlayer(PlayerDTO player);
        void UpdatePlayer(PlayerDTO player);
        List<PlayerDTO> GetPlayers();
    }
}
