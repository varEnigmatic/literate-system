/*
These are the steps taken to create this console application on exercise using the C# syntax.
the time should be calculated in minutes
this is a parse method. This is used when needing to convert strings into intgers
Add time in minutes to existing exercise total
UI display total time in minutes exercised
*/

using System;

namespace RemoveTheWrench.FitApplication
{
	class FitnessApp
	{
		static void Main(string[] args)
		{
			int theBigTotal = 10;
			bool keepItUp = true;
			
			while (keepItUp) 
			{
				Console.Write("Enter the amount of time you have exercised: ");
				
				string userEntry = Console.ReadLine();
				
				int timeInMinutes = int.Parse(userEntry); //parse
				
				theBigTotal = theBigTotal + timeInMinutes; //total minutes exercised assigned 
				
				Console.WriteLine("Your total exercise time is: " + theBigTotal + " minutes"); /*output will ask user at this point to enter in amount of time exercised.  After amount entered by user, output will display the total exercise time to the user in minutes only.*/
			}
			
			}
		}
	}