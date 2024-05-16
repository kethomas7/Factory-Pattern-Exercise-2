namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of database would you like to use? SQL, Mongo, List");

            var choice = Console.ReadLine();

            IDataAccess Dataset = DataAccessFactory.GetDataAccessType(choice);

            Dataset.LoadData();
            Dataset.SaveData();
        }
    }
}
