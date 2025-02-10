namespace COMP003A.LectureActivity5_1
{
    internal class Car
    {
        // Fields
        public string Make;
        public string Model;
        public int Year;

        /// <summary>
        /// Display the car information
        /// </summary>
        /// 
        public void DisplayInfor()
        {
            Console.WriteLine($"Car: {Year} {Make} {Model}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(); // Create a new Car
            myCar.Make = "Toyota"; // Set the car's make
            myCar.Model = "Supra"; // Set the car's model
            myCar.Year = 2024; // Set the car's year

            myCar.DisplayInfor(); // Display the car's information
        }
    }


}
