namespace VirtualZooManagementSystem
{
    public class Animal
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Eat(string food)
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} named {Name} is eating {food}.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} named {Name} is sleeping.");
        }

        public virtual void Speak()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} named {Name} makes a sound.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} named {Name} moves.");
        }

        public virtual void FeedGrass()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} named {Name} is eating grass.");
        }

        public virtual void FeedFish()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} named {Name} is eating fish.");
        }

        public virtual void FeedMeat()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} named {Name} is eating meat.");
        }
    }

    // Interface to move animals
    public interface IMovable
    {
        void Move();
    }

    // Interface to feed animals
    public interface IFeedable
    {
        void Feed(string food);
        void FeedGrass();
        void FeedFish();
        void FeedMeat();
    }

    public class Lion : Animal, IMovable, IFeedable
    {
        public void Move()
        {
            Console.WriteLine($"{Name} the lion performs for the audience.");
        }

        public void Feed(string food)
        {
            if (food.ToLower() == "meat")
            {
                FeedMeat();
            }
            else
            {
                Console.WriteLine($"The lion named {Name} cannot eat {food}.");
            }
        }

        public override void FeedMeat()
        {
            Console.WriteLine($"The lion named {Name} is eating meat.");
        }
    }

    public class Zebra : Animal, IMovable, IFeedable
    {
        public void Move()
        {
            Console.WriteLine($"{Name} the zebra crazily runs around.");
        }

        public void Feed(string food)
        {
            if (food.ToLower() == "grass")
            {
                FeedGrass();
            }
            else
            {
                Console.WriteLine($"The zebra named {Name} cannot eat {food}.");
            }
        }

        public override void FeedGrass()
        {
            Console.WriteLine($"{Name} the zebra is eating grass.");
        }
    }

    public class Giraffe : Animal, IMovable, IFeedable
    {
        public void Move()
        {
            Console.WriteLine($"{Name} the giraffe hides anxiously.");
        }

        public void Feed(string food)
        {
            if (food.ToLower() == "leaves")
            {
                FeedGrass();
            }
            else
            {
                Console.WriteLine($"The giraffe named {Name} cannot eat {food}.");
            }
        }

        public override void FeedGrass()
        {
            Console.WriteLine($"The giraffe named {Name} is eating leaves.");
        }
    }

    public class Hippo : Animal, IMovable, IFeedable
    {
        public void Move()
        {
            Console.WriteLine($"{Name} the hippo plays in the water.");
        }

        public void Feed(string food)
        {
            if (food.ToLower() == "plants")
            {
                FeedGrass();
            }
            else
            {
                Console.WriteLine($"The hippo named {Name} cannot eat {food}.");
            }
        }

        public override void FeedGrass()
        {
            Console.WriteLine($"The hippo named {Name} is eating plants.");
        }
    }

    public class Lemur : Animal, IMovable, IFeedable
    {
        public void Move()
        {
            Console.WriteLine($"{Name} lemur named  dances to 'I Like To Move It'.");
        }

        public void Feed(string food)
        {
            if (food.ToLower() == "fruits")
            {
                FeedGrass();
            }
            else
            {
                Console.WriteLine($"The lemur named {Name} cannot eat {food}.");
            }
        }

        public override void FeedGrass()
        {
            Console.WriteLine($"The lemur named {Name} is eating fruits.");
        }
    }

    public class Penguin : Animal, IMovable, IFeedable
    {
        public void Move()
        {
            Console.WriteLine($"{Name} the penguin smiles and waves at the crowd.");
        }

        public void Feed(string food)
        {
            if (food.ToLower() == "fish")
            {
                FeedFish();
            }
            else
            {
                Console.WriteLine($"The penguin named {Name} cannot eat {food}.");
            }
        }

        public override void FeedFish()
        {
            Console.WriteLine($"The penguin named {Name} is eating fish.");
        }
    }
}
