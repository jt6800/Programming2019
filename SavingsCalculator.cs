using System;
					
public class Program
{
	public static void Main()
	{
        double startValue = 0;
        double yearlyContribution = 0;
        double percentage = 0;
        double years = 0;
        double yearIndex = 0;
        double currentValue = 0;
        Console.WriteLine("Enter Starting Balance in dollars");
        startValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Yearly Contribution in dollars");
        yearlyContribution = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Average Return on Investment as %");
        percentage = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Number of years for the report.");
        years = Convert.ToDouble(Console.ReadLine());
        currentValue = startValue;
        while (yearIndex < (years + 1))
        {
            Console.Write("Year ");
            Console.Write(yearIndex);
            Console.Write(": ");
            currentValue = Math.Pow(((1 + (percentage / 100)) * (currentValue + yearlyContribution)), yearIndex));
            Console.Write(currentValue);
            Console.WriteLine();
            yearIndex++;
        }
		
	}
}