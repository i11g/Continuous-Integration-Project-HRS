namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfScreening=Console.ReadLine();
            int numberOfRows=int.Parse(Console.ReadLine());
            int numberOfColumns=int.Parse(Console.ReadLine());

            double numberOfSeats = numberOfColumns * numberOfRows;
            double revenue = 0;

            if (typeOfScreening== "Premiere")
            {
                revenue = numberOfSeats * 12.00;
            }
            else if (typeOfScreening == "Normal")
            {
                revenue = numberOfSeats * 7.50;
            }
            else
            {
                revenue = numberOfSeats * 5.00;
            }

            Console.WriteLine("{0:f2} leva", revenue);
        }
    }
}