usingSystem;
classStudent
{
 
public int RollNo { get;set; }
public string Name{ get; set; }
 
public Student(intr, string n)
{
RollNo = r;
Name = n;
}
 
public void Display()
{
Console.WriteLine("Roll No: " +RollNo + ", Name: " +Name);
}
}
classProgram
{
static void Main()
{
Student s1 =new Student(101, "Rahul");
Student s2 =new Student(102, "Sneha");
s1.Display();
s2.Display();
}
}
