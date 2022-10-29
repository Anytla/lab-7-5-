namespace OOP.Interfaces.BorderControl
{
    public interface IPerson
    {
        public string Name { get; }

        public int Age { get; }

        public string Id { get; }

        public string Birthdate { get; }
    }

    public interface IRobot
    {
        public string Model { get; }

        public string Id { get; }
    }

    public interface IAnimal
    {
        public string Name { get; }

        public string Birthdate { get; }
    }

    public interface IBuyer
    {
        public int Food { get; }

        public void BuyFood();
    }


}