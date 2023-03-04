namespace DesignPatterns.NullObject
{
    public class DB
    {
        private static List<Driver> _drivers = new List<Driver>
            {
                new Driver { Id = 101, Name = "Jose" },
                new Driver { Id = 200, Name = "Carlos" },
                new Driver { Id = 300, Name = "Jhon" },
                new Driver { Id = 405, Name = "Smith" },
                new Driver { Id = 503, Name = "Claudia" },
            };

        public static Employee GetEmployee(string s)
        {
            var driver = _drivers.FirstOrDefault(x => x.Name.Equals(s));
            return driver ?? Driver.NULL;
        }
    }
}
