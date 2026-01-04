using console_clas.Building.House;

namespace console_clas.Entity.Profile
{
    internal class RealPlayer : PlayersBase
    {
        public RealPlayer(string id, string name, long balance, List<HouseBase> buyHouses) : base(id, name, balance, buyHouses)
        {
        }
    }
}
