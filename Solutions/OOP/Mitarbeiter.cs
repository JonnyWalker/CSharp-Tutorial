namespace OOP
{
    class Mitarbeiter : Person
    {
        public int personalNummer;

        public Mitarbeiter(string name, int alter, int personalNummer) : base(name, alter)
        {
            this.personalNummer = personalNummer;
        }
    }
}
