namespace RobotPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an original Service Robot
            ServiceRobot serviceRobot = new ServiceRobot(
                "CareBot-100",
                10,
                "1.0",
                "Assisting patients");

            Console.WriteLine("ORIGINAL ROBOT");
            serviceRobot.DisplayRobot();

            Console.WriteLine();

            // Clone the Service Robot
            ServiceRobot clonedServiceRobot =
                (ServiceRobot)serviceRobot.Clone();

            // Customize the cloned robot
            clonedServiceRobot.BatteryCapacity = 15;
            clonedServiceRobot.SoftwareVersion = "1.1";

            Console.WriteLine("CLONED AND CUSTOMIZED ROBOT");
            clonedServiceRobot.DisplayRobot();

            Console.WriteLine();
            Console.WriteLine("--------------------------------");

            // Create an Industrial Robot
            IndustrialRobot industrialRobot = new IndustrialRobot(
                "FactoryBot-200",
                20,
                "2.0",
                "Welding");

            Console.WriteLine();
            industrialRobot.DisplayRobot();

            Console.WriteLine();

            // Clone Industrial Robot
            IndustrialRobot clonedIndustrialRobot =
                (IndustrialRobot)industrialRobot.Clone();

            clonedIndustrialRobot.BatteryCapacity = 25;
            clonedIndustrialRobot.SoftwareVersion = "2.1";

            Console.WriteLine();
            Console.WriteLine("CLONED INDUSTRIAL ROBOT");
            clonedIndustrialRobot.DisplayRobot();

            Console.WriteLine();
            Console.WriteLine("--------------------------------");

            // Create Entertainment Robot
            EntertainmentRobot entertainmentRobot =
                new EntertainmentRobot(
                    "FunBot-300",
                    8,
                    "3.0",
                    "Dancing and interacting with visitors");

            Console.WriteLine();
            entertainmentRobot.DisplayRobot();

            Console.WriteLine();

            // Clone Entertainment Robot
            EntertainmentRobot clonedEntertainmentRobot =
                (EntertainmentRobot)entertainmentRobot.Clone();

            clonedEntertainmentRobot.BatteryCapacity = 12;
            clonedEntertainmentRobot.SoftwareVersion = "3.1";

            Console.WriteLine();
            Console.WriteLine("CLONED ENTERTAINMENT ROBOT");
            clonedEntertainmentRobot.DisplayRobot();

            Console.ReadLine();
        }
    }
}