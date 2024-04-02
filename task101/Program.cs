namespace task101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qaleriada avtomibillerin max sayini yaz:");
            int maxSize = int.Parse(Console.ReadLine());

            Gallery gallery = new Gallery(maxSize);

            while (true)
            {
                Console.WriteLine("\n1. Avtomobil Əlavə Et \n2. Show All Cars\n3. Find Car by ID\n4. Find Car by Car Code\n5. Find Cars by Speed Interval\n6. Exit");
                Console.WriteLine("seciminizi yazin:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(" Avtomobilin ID yaz:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Avtomobilin adini yaz:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Avtomobilin suretini yaz:");
                        int speed = int.Parse(Console.ReadLine());
                        Console.WriteLine("Avtomobilin kodunu yaz:");
                        string carCode = Console.ReadLine();
                        gallery.AddCar(new Car(id, name, speed, carCode));
                        break;
                    case 2:
                        gallery.ShowAllCars();
                        break;
                    case 3:
                        Console.WriteLine("Tapmaq istədiyin avtomobilin ID-sini daxil et:");
                        int idToFind = int.Parse(Console.ReadLine());
                        Car foundCarById = gallery.FindCarById(idToFind);
                        if (foundCarById != null)
                        {
                            Console.WriteLine($"Tapılan avtomobil: ID: {foundCarById.Id}, Ad: {foundCarById.Name}, Sürət: {foundCarById.Speed}, Avtomobil Kodu: {foundCarById.CarCode}");
                        }
                        else
                        {
                            Console.WriteLine("Avtomobil tapılmadı.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Tapmaq istədiyin avtomobilin kodunu daxil et:");
                        string codeToFind = Console.ReadLine();
                        Car foundCarByCode = gallery.FindCarByCarCode(codeToFind);
                        if (foundCarByCode != null)
                        {
                            Console.WriteLine($"Tapılan avtomobil: ID: {foundCarByCode.Id}, Ad: {foundCarByCode.Name}, Sürət: {foundCarByCode.Speed}, Avtomobil Kodu: {foundCarByCode.CarCode}");
                        }
                        else
                        {
                            Console.WriteLine("Car not found.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Minimum sürəti daxil edin:");
                        int minSpeed = int.Parse(Console.ReadLine());
                        Console.WriteLine("Maksimum sürəti daxil edin:");
                        int maxSpeed = int.Parse(Console.ReadLine());
                        Car[] carsInInterval = gallery.FindCarsBySpeedInterval(minSpeed, maxSpeed);
                        Console.WriteLine($"Sürət aralığında tapılan avtomobillər {minSpeed}-{maxSpeed}:");
                        foreach (Car car in carsInInterval)
                        {
                            Console.WriteLine($"ID: {car.Id}, Ad: {car.Name}, Sürət: {car.Speed}, Avtomobil Kodu: {car.CarCode}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("cixilir..");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim 1 ilə 6 arasında bir rəqəm daxil et.");
                        break;
                }
            }
        }


    }
}
