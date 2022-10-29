namespace OOP.Interfaces.BorderControl
{
    public class Robot : IRobot
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model
        {
            get => this.model;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Model));
                this.model = value;
            }
        }

        public string Id
        {
            get => this.id;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Id));
                Validator.ValidateOnlyDigits(value, nameof(this.id));
                this.id = value;
            }
        }
    }

    public class Rebel : IPerson, IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Id = "0000";
            this.Birthdate = "01/01/1970";
            this.Group = group;
            this.Food = 0;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Name));
                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Age)} cannot be negative");
                }

                this.age = value;
            }
        }

        public string Id { get; }

        public string Birthdate { get; }

        public string Group
        {
            get => this.group;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Group));
                this.group = value;
            }
        }

        public int Food
        {
            get => this.food;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid food amount");
                }

                this.food = value;
            }
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }

    public class Pet : IAnimal
    {
        private string name;
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Name));
                this.name = value;
            }
        }

        public string Birthdate
        {
            get => this.birthdate;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Birthdate));
                Validator.ValidateBirthdate(value);
                this.birthdate = value;
            }
        }
    }
}