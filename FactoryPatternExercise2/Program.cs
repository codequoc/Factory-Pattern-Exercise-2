namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you want to use?");
            Console.WriteLine("Type either: sql, mango, or list");

            var userInput = Console.ReadLine();
            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: { product.Name} Price: ${product.Price}");
            }
        }
    }
}
