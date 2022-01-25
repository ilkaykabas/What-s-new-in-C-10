namespace ConsoleAppCSharp10;

public struct StructPerson
{
    public string FirstName { get; set; } = null;
    public string LastName { get; set; } = null;

    public StructPerson()
    {
    }
}

public struct StructPerson2
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public StructPerson2()
    {
        FirstName = null;
        LastName = null;
    }
}