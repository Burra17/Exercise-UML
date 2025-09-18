
namespace Exercise_UML
{
    public class Dog : Animal
    {
        private string _breed { get; set; } // Private property specific to Dog class
        public string Breed // Public property to access the private _breed field
        {
            get { return _breed; }
            set { _breed = value; }
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!"); // Implementation of the abstract method
        }
    }
    
    
}
