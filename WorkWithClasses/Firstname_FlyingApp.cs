
namespace Firstname_FlyingApp
{
    public class Firstname_FlyingApp
    {
        static void Main(string[] args)
        {
            Pilot pilot = new Pilot(1234); // Instantiate an object of the Pilot class

            Console.WriteLine("******\nINPUT\n******");

            Console.Write("Enter the pilot's first name: ");
            pilot.Pilot_FirstName = Console.ReadLine();

            Console.Write("Enter the pilot's middle name: ");
            pilot.Pilot_Middlename = Console.ReadLine();

            Console.Write("Enter the pilot's last name: ");
            pilot.Pilot_LastName = Console.ReadLine();

            for(int i = 1; i <=5 ; i++)
            {
                Console.Write($"Enter the flying hours for day {i}:  ");
                double flyingH = Convert.ToDouble(Console.ReadLine());
                pilot.SetDaylyFlyingH(i, flyingH);
            }

            Console.WriteLine("******\nOUTPUT\n******");
            Console.Write(pilot.ToString());
        }

    }
}