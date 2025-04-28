using System;

public class Con
{
    public string Name { get; set; }
    public string Number { get; set; }
    public DateTime StartDate { get; set; }

    public Con() { }

    public Con(string name, string number, DateTime startDate)
    {
        Name = name;
        Number = number;
        StartDate = startDate;
    }

    public string GetName() => Name;
    public string GetNumber() => Number;
    public DateTime GetStartDate() => StartDate;

    public void SetName(string name) => Name = name;
    public void SetNumber(string number) => Number = number;
    public void SetStartDate(DateTime startDate) => StartDate = startDate;

    public override string ToString()
    {
        return $"Contractor: {Name} (Number: {Number}), Start Date: {StartDate.ToShortDateString()}";
    }
}

public class SCon : Con
{
    public const int DAY = 1;
    public const int NIGHT = 2;

    public int Shift { get; set; }
    public double HourlyPR { get; set; }

    public SCon() { }

    public SCon(string name, string number, DateTime startDate, 
                        int shift, double hourlyPR) : base(name, number, startDate)
    {
        Shift = shift;
        HourlyPR = hourlyPR;
    }

    public int GetShift() => Shift;
    public double GetHourlyPR() => HourlyPR;

    public float CalculatePay(float hoursWorked)
    {
        float basePay = (float)(hoursWorked * HourlyPR);
        
        if (Shift == NIGHT)
        {
            return basePay * 1.03f;
        }
        
        return basePay;
    }

    public override string ToString()
    {
        string shiftName = Shift == DAY ? "Day" : "Night";
        return base.ToString() + $", Shift: {shiftName}, Hourly Rate: {HourlyPR:C}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Subcontractor system");
        
        List<SCon> SCons = new List<SCon>();
        
        bool addMore = true;
        while (addMore)
        {
            Console.Write("\nEnter subcontractor: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter subcontractor number: ");
            string number = Console.ReadLine();
            
            Console.Write("Enter start date (MM/DD/YYYY): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            
            Console.Write("Enter shift (1-Day, 2-Night): ");
            int shift = int.Parse(Console.ReadLine());
            
            Console.Write("Enter hourly pay rate: ");
            double payRate = double.Parse(Console.ReadLine());
            
            SCon sub = new SCon(name, number, startDate, shift, payRate);
            SCons.Add(sub);
            
            Console.WriteLine("\nSubcontractor added");
            Console.WriteLine(sub);
            
            float samplePay = sub.CalculatePay(40);
            Console.WriteLine($"Sample weekly pay (40 hours): {samplePay:C}");
            
            Console.Write("\nAdd another subcontractor(Y/N): ");
            addMore = Console.ReadLine().ToUpper() == "Y";
        }
        
        Console.WriteLine("\nAll subcontractors:");
        foreach (var sub in SCons)
        {
            Console.WriteLine(sub);
        }
    }
}
