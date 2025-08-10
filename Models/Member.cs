
public class Member : AbstractPerson
{
    public Member(int id, string name) : base(id, name) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Member ID: {Id}, Name: {Name}");
    }
}
