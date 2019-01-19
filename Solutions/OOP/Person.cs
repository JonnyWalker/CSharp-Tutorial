namespace OOP
{
    class Person
    {
        private string name;
        private int alter;
        public string Name { get; protected set; }
        public int Alter { get; protected set; }

        public Person(string name, int alter)
        {
            Name = name;
            Alter = alter;
        }
        public void Altern()
        {
            Alter++;
        }
    }

}
