using console_clas.Building.House;
using console_clas.Interface;

namespace console_clas.Entity.Profile
{
    public abstract class PlayersBase : IPrintInfo
    {
        private string id;
        private string name;
        private long balance;
        private List<HouseBase> buyHouses;

        public string Id
        {
            get { return this.id; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ID не может быть пустым");
                this.id = value;
            }
        }

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
            protected set
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

        public PlayersBase(string id, string name, long balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public void PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
