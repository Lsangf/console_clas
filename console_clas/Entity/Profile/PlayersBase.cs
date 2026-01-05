using console_clas.Entity.Building.House;

namespace console_clas.Entity.Profile
{
    public abstract class PlayersBase : GameEntity
    {
        private string name;
        private long balance;
        private List<HouseBase> buyHouses;

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя не может быть пустым");
                this.name = value;
            }
        }

        public long Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Баланс не может быть отрицательным");
                this.balance = value;
            }
        }

        public List<HouseBase> BuyHouses
        {
            get { return this.buyHouses; }
            protected set { this.buyHouses = value; }
        }

        public PlayersBase(string name, long balance, List<HouseBase> buyHouses)
        {
            Name = name;
            Balance = balance;
            BuyHouses = buyHouses;
        }
    }
}
