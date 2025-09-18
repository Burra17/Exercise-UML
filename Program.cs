namespace Exercise_UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Buddy";
            dog.Age = 3;
            dog.Color = "Brown";
            dog.Breed = "Golden Retriever";
            Cat cat = new Cat();
            cat.Name = "Whiskers";
            cat.Age = 2;
            cat.Color = "Black";
            cat.Temperament = "Playful";
            Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Color: {dog.Color}, Breed: {dog.Breed}");
            dog.MakeSound();
            Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, Color: {cat.Color}, Temperament: {cat.Temperament}");
            cat.MakeSound();
        }
    }
}
