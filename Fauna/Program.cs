namespace Fauna;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.StopTheCar();
        Plane plane1 = new Plane();
        Toyota toyota = new Toyota();
        toyota.BuyToyota("Supra");
        Cat cat = new Cat();
        cat.Meow();
        Fish fish1 = new Fish("Nemo");
        fish1.AboutFish();
        Shark shark = new Shark("Bruce the Shark");
        Eagle eagle = new Eagle("Koko");
        Bee bee = new Bee();
        Spider spider = new Spider();
        Alien alien = new Alien();
        alien.Photo();
        Human human = new Human("Irakli");
    }
}