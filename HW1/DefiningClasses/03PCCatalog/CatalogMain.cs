namespace PCCatalog
{
    class CatalogMain
    {
        static void Main()
        {
            Computer test = new Computer("test pc",new Component("intel",600));
            Computer test2 = new Computer("test2 pc", new Component("AMD", 400));
            System.Console.WriteLine(test.PrintPC());
            Computer[] list = { test, test2 };
            Computer.SortList(list);
            for (int i = 0; i < list.Length; i++)
            {
                System.Console.WriteLine(list[i].PrintPC());
            }
        }
    }
}
