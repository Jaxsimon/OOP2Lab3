namespace InterfaceDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();

            Console.WriteLine("Enter a name for dog:");
            string dogName1 = Console.ReadLine();

            Dog dog1 = new Dog(dogName1);

            Console.WriteLine("Enter a name for dog:");
            string dogName = Console.ReadLine();
            Console.WriteLine("Enter a colour for dog:");
            string dogColour = Console.ReadLine();
            Console.WriteLine("Enter a height for dog: ");
            string dogHeight = Console.ReadLine();
            Console.WriteLine("Enter an age for dog:");
            string dogAge = Console.ReadLine();


            Dog dog = new Dog(dogName, dogColour, dogHeight, dogAge);

            Console.WriteLine(dog);
            dog.Eat();
            Console.WriteLine(dog.Cry());

            Console.WriteLine("Enter a name for cat:");
            string catName1 = Console.ReadLine();

            Cat cat1 = new Cat(catName1);

            Console.WriteLine("Enter a name for cat:");
            string catName = Console.ReadLine();
            Console.WriteLine("Enter a colour for cat:");
            string catColour = Console.ReadLine();
            Console.WriteLine("Enter a height for cat: ");
            string catHeight = Console.ReadLine();
            Console.WriteLine("Enter an age for cat:");
            string catAge = Console.ReadLine();

            Cat cat = new Cat(catName, catColour, catHeight, catAge);

            Console.WriteLine(cat);
            cat.Eat();
            Console.WriteLine(cat.Cry());

            
            animals.Add(dog);
            animals.Add(dog1);
            animals.Add(cat);
            animals.Add(cat1);

            Console.WriteLine("The name of all the animals are: ");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

        }
    }
}
