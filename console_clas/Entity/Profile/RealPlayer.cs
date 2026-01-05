using console_clas.Entity.Building.House;

namespace console_clas.Entity.Profile
{
    internal class RealPlayer : PlayersBase
    {
        public RealPlayer(string name, long balance, List<HouseBase> buyHouses) : base(name, balance, buyHouses)
        {
        }
    }
}
