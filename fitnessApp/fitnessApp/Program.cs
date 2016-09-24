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
		{//
			
			double theBigTotal = 0;




			while (true) 
			{
				Console.Write("Enter the amount of time you have exercised or type \"quit\\stop\" to exit: ");
				string userEntry = Console.ReadLine();

				if (userEntry.ToLower() == "quit" || userEntry.ToLower() == "exit")
				{
					break;
				}
					try 
					{
						

					double timeInMinutes = double.Parse(userEntry);
						theBigTotal += timeInMinutes;//this represents the total number of minutes given by user

						if (theBigTotal <= 0) {
							Console.WriteLine(theBigTotal + " is not an acceptable value\n");
							continue;

						}else if(theBigTotal <= 10) {
							Console.Write("You can do a little more, try harder\n");

						}else if(theBigTotal <= 30 && timeInMinutes >= 11) {
							Console.WriteLine("You are on the right track\n");

						}else{
							Console.WriteLine("Looks like you will be ready for the olympics soon!\n");
						}

						//parse
					}
					catch(FormatException) 
					{
						Console.WriteLine ("No No No");
						continue;
					}

					 //total minutes exercised assigned 

					Console.WriteLine("Your total exercise time is: " + theBigTotal + " minutes"); /*output will ask user at this point to enter in amount of time exercised.  After amount entered by user, output will display the total exercise time to the user in minutes only.*/

				// repeat until user quits
			}

			Console.WriteLine("Moses, your muscles are getting HUGE!!!");
		}
	}
};