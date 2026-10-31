usingSystem;
 
classAnimal
{
public virtual void Speak()
{
Console.WriteLine("Animal makesa sound");
}
}
 
classDog : Animal
{
 
public override voidSpeak()
{
Console.WriteLine("Dog barks");
}
}
classProgram
{
static void Main()
{
Animal a1 = new Animal();
Animal a2 = new Dog();
a1.Speak();
a2.Speak();
}
}
