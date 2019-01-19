namespace OOP
{
    class Mitarbeiter : Person
    {
        public int personalNummer;

        public Mitarbeiter(string name, int alter, int personalNummer)
        {
            Name = name;
            Alter = alter;
            this.personalNummer = personalNummer;
        }
    }
}
