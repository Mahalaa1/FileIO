namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = FileRoot.fileRoot;
            char dirSeperator = Path.DirectorySeparatorChar;
            var file = root + dirSeperator + "IO" + dirSeperator + "data.csv";
            var newFile = root + dirSeperator + "IO" + dirSeperator + "data.psv";

            var people = new List<Person>();
            Address address = new Address();
            Phone phone = new Phone();

            using (var reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var information = line.Split(",");

                    var FirstName = information[0];
                    var LastName = information[1];
                    var Address = new Address(information[3], information[4], information[5], information[6], information[7]);
                    var Phone = information[8];

                    people.Add(new Person(FirstName, LastName, Address, Phone));
                }
            }

            people.Sort();

            Console.WriteLine("Sorting. . .");

            Console.WriteLine("Creating PSV File.");

            using (var writer = new StreamWriter(newFile, append: false))
            {
                foreach (Person p in people)
                {
                    string line = $"{p.FirstName}|{p.LastName}|{p.Address}|{p.Phone}|";
                    writer.WriteLine(line);
                }
            }
        }
    }
}