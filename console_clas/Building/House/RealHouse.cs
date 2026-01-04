namespace console_clas.Building.House
{
    internal class RealHouse : HouseBase
    {
        public RealHouse(string idHouse, int square, int floors, int rooms, (int x, int y) coordinatesHouse) : base(idHouse, square, floors, rooms, coordinatesHouse)
        {
        }
    }
}
