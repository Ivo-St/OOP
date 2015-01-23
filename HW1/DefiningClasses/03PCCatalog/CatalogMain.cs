namespace PCCatalog
{
    class CatalogMain
    {
        static void Main()
        {
            Computer test = new Computer("test pc", 900,new Component("intel",600));
            System.Console.WriteLine(test.Price);
        }
    }
}
