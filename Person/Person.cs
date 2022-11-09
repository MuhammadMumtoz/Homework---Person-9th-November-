public class Person
{
    protected string? name;
    protected string? address;
    public Person(string name, string address)
    {
        this.name = name;
        this.address = address;
    }
    public string GetName()
    {
        return name;
    }
    public string GetAdress()
    {
        return address;
    }
    public void SetAdress(string address)
    {
        this.address = address;
    }
    public override string ToString()
    {
        return address;
    }
}
