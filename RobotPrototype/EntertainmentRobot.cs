namespace RobotPrototype
{
    public class EntertainmentRobot : IRobot
    {
        public string ModelName { get; set; }
        public double BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }

        public string EntertainmentFeature { get; set; }

        public EntertainmentRobot(
            string modelName,
            double batteryCapacity,
            string softwareVersion,
            string entertainmentFeature)
        {
            ModelName = modelName;
            BatteryCapacity = batteryCapacity;
            SoftwareVersion = softwareVersion;
            EntertainmentFeature = entertainmentFeature;
        }

        public IRobot Clone()
        {
            return new EntertainmentRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                EntertainmentFeature);
        }

        public void DisplayRobot()
        {
            Console.WriteLine("Entertainment Robot");
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
            Console.WriteLine("Entertainment Feature: " + EntertainmentFeature);
        }
    }
}