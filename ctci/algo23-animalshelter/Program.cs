namespace algo23_animalshelter;
class Program
{
    static void Main(string[] args)
    {
        AnimalQueue shelter = new AnimalQueue();
        shelter.Enqueue(new Dog("Rex"));
        shelter.Enqueue(new Cat("Mia"));
        shelter.Enqueue(new Dog("Max"));
        shelter.Enqueue(new Cat("Lin"));

        Animal? availableAnimal = shelter.DequeueAny();
        Console.WriteLine($"{availableAnimal!.Name} - Date: {availableAnimal!.RegistrationDate}");

        availableAnimal = shelter.DequeueAny();
        Console.WriteLine($"{availableAnimal!.Name} - Date: {availableAnimal!.RegistrationDate}");

        availableAnimal = shelter.DequeueAny();
        Console.WriteLine($"{availableAnimal!.Name} - Date: {availableAnimal!.RegistrationDate}");
    }
}

public class Animal
{
    public string Name { get; set; }
    public DateTime RegistrationDate { get; set; }

    public Animal(string name)
    {
        this.Name = name;
        this.RegistrationDate = DateTime.Now;
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name) { }
}

public class Cat : Animal
{
    public Cat(string name) : base(name) { }
}

public class AnimalQueue
{
    Queue<Dog> dogs = new Queue<Dog>();
    Queue<Cat> cats = new Queue<Cat>();

    public void Enqueue(Animal animal)
    {
        if (animal is Dog)
            dogs.Enqueue((Dog)animal);
        else
            cats.Enqueue((Cat)animal);
    }

    public Animal? DequeueAny()
    {
        if (dogs.Count + cats.Count == 0)
            return null;

        if (dogs.Count == 0) return cats.Dequeue();
        if (cats.Count == 0) return dogs.Dequeue();

        Dog dog = dogs.Peek();
        Cat cat = cats.Peek();

        if (dog.RegistrationDate <= cat.RegistrationDate)
            return dogs.Dequeue();
        else
            return cats.Dequeue();
    }
}