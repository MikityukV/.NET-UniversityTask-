using Firstname_FlyingApp;

class Pilot
{
    private int pilot_Num; // pilot's number
    private string pilot_Fname;//pilot's first name
    private string pilot_Mname; //pilot's middle name
    private string pilot_Lname; // pilot's last name
    private double[] flyingH = new double[5];

    //Dafault constructor
    public Pilot()
    {

    }

    //Parametrized constructor
    public Pilot ( int pilot_Num)
    {
        this.pilot_Num = pilot_Num; 
    }

    //Accessor and mutator methods for first, middle, last name
    public string Pilot_FirstName
    {
        get { return pilot_Fname; }
        set { pilot_Fname = value; }
    }

    public string Pilot_Middlename
    {
        get { return pilot_Mname; }
        set { pilot_Mname = value; }
    }

    public string Pilot_LastName
    {
        get { return pilot_Lname; }
        set { pilot_Lname = value; }
    }

    //Property for getting and setting the daily flying hours

    public double[] Pilot_FlyingHours
    {
        get { return flyingH; }
        set { flyingH = value; }
    }

    //Method to compute the total weekly flying hours
        public double ComputeWeeklyFlyingHours()
    {
        double weeklyH = 0;
        foreach (double hours in flyingH)
        {
            weeklyH += hours;
        }
        return weeklyH;
    }

    //Methods to compute the average weekly flying hours
    public double ComputerAverageFlyingHours()
    {
       double avarageH = ComputeWeeklyFlyingHours();
        return (double)avarageH / 5;
    }

    //ToString() method to display complete information about a pilot
    public override string ToString()
    {
        double avarageH = ComputerAverageFlyingHours();
        double weeklyH = ComputeWeeklyFlyingHours();
        return $"Pilot Number:                \t {pilot_Num} \n" +
            $"Pilot Name:               \t {pilot_Fname} {pilot_Mname} {pilot_Lname}\n" +
            $"Total Weekly Flying Hours:\t {weeklyH}\n" +
            $"Average Weekly Flying Hours:\t {avarageH}\n";

    }

    //Method to set the all daily flying hours
    public void SetDaylyFlyingH(int day, double hours)
    {
        flyingH[day - 1] = hours;
    }
}

