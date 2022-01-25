namespace ConsoleAppCSharp9
{
    public struct StructPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public StructPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}