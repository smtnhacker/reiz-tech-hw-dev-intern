// Take the user's input
Console.WriteLine("Please input current hour: ");
float hours = (float) Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input current minute: ");
float minutes = (float) Convert.ToInt32(Console.ReadLine());

// Normalize hours
if (hours == 12)
{
    hours = 0;
}

// Consider the movement of the hour hand
// due to the movement of the minute hand
hours += minutes / 60;

// Define constants for clarity
const float HourRate = 360f / 12f;
const float MinuteRate = 360f / 60f;

// Compute the angle
float angle = Math.Abs(HourRate * hours - MinuteRate * minutes);

// Take the lesser angle
float ans = Math.Min(angle, 360 - angle);

// Finally, print the output
Console.WriteLine(String.Format("The angle is {0} deg.", ans));