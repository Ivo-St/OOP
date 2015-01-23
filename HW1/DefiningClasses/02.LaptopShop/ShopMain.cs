namespace LaptopShop
{
    class ShopMain
    {
        static void Main()
        {
            Battery bat = new Battery("Li-ion", 4, 1250);
            Laptop test = new Laptop(model: "Test model",price: 669,manifacturer: "Intel", ram: 12, battery: bat);
            System.Console.WriteLine(test);
        }
    }
}
