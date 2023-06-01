namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of database would you like to use: List, SQL, or Mongo?");
            var databaseType = Console.ReadLine();

            IDataAccess database = DataAccessFactory.GetDataAccessType(databaseType);

            List<Product> products = database.LoadData();
            database.SaveData();
        }
    }
}
