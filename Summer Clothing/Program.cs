using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Summer_Clothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature=int.Parse(Console.ReadLine());
            string timeOfTheDay=Console.ReadLine();

            string clothing = "";
            string shoes = ""; 

            switch (timeOfTheDay)
            {
                case "Morning":
                    { 
                        if (10<=temperature&&temperature<=18) 
                        {
                            clothing = "Sweatshirt ";
                            shoes = "Sneakers";
                        }
                        else if (18 < temperature && temperature <= 24)
                        {
                            clothing = "Shirt ";
                            shoes = "Moccasins";
                        }
                        else if (temperature >= 25)
                        {
                            clothing = "T-Shirt ";
                            shoes = "Sandals";
                        }

                    }
                    break;
                case "Afternoon":
                    {
                        if (10 <= temperature && temperature <= 18)
                        {
                            clothing = "Shirt ";
                            shoes = "Moccasins";
                        }
                        else if (18 < temperature && temperature <= 24)
                        {
                            clothing = "T-Shirt ";
                            shoes = "Sandals";
                        }
                        else if (temperature >= 25)
                        {
                            clothing = "Swim Suit";
                            shoes = "Barefoot";
                        }

                    }
                    break;
                case "Evening":
                    {
                        clothing = "Shirt ";
                        shoes = "Moccasins";
                    }
                    break;

            }

            Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
        }
    }
}