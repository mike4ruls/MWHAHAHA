//Michael Ray
//Mad Scientist Class
//Everything is done in the main and should portray a choice based game where you decide whats happenes next
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mwahahaha
{
    class MadScientist
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            // Stating universal Variables
            int result1 = 0;
            int result2 = 0;
            int giveIn = 0;
            int finale = 0;
            int selection1 = 0;
            int selection2 = 0;
            int selection3 = 0;
            string project = "";
            string loc = "";
            string name = "";

            // My little twist on this home work, just letting more interaction with the user
            Console.WriteLine("What is your evil scientist name? ");
            name = Console.ReadLine();
            Console.WriteLine();

            /// Frist Do While Loop:
            ///  This first "do while" loop should ask what evil project they want to choose.
            ///  also catch if something doesn't get input right.
            ///
            do{
            Console.WriteLine("Select an evil project");
            Console.WriteLine("1 - Raising the dead\n2 - Destabilizing the Earth's core\n3 - building a giant robot");
            Console.WriteLine("Enter in the number of your selection:");
            string selStrg = Console.ReadLine();
            Boolean Parsed = int.TryParse(selStrg, out selection1);

                // if what they wrote is not a number
                if (Parsed == false) 
                {
                    Console.WriteLine("Enter in a real number, don't FOOL AROUND!!!\n");
                    continue;
                }

                // if the number they choose wasn't a choice
                else if (selection1 < 1 || selection1 > 3) 
                {
                    Console.WriteLine("That number was not one of your options. Go jump off a bridge and do it again.\n");
                    continue;
                }
                    // If they passed the first two tests then they have obviously entered in a right number
                else
                {
                    switch (selection1)
                    {
                        case 1:
                            Console.WriteLine("You have selected: Raising the dead.. fuck you");
                            // Setting the universal variable from their choice
                            project = "Raising the dead";
                            break;
                        case 2:
                            Console.WriteLine("You have selected: Destabilizing the Earth's core (You monster)");
                            project = "Destabilizing the Earth's core";
                            break;
                        case 3:
                            Console.WriteLine("You have selected: Building a giant robot (I actually don't know how to feel \nabout that...)");
                            project = "Building a giant robot";
                            break;
                        default:
                            break;
                    }
                }
               // Console.WriteLine("End"); <-- testing if it passed through
            } while (selection1 < 1 || selection1 > 3);



            ///Second Do While Loop:
            /// This do while loop should ask for what location they should terrorize
            /// and catch false input, kind of the same as the first do while loop
            ///
            do
            {
                Console.WriteLine("\nSelect a city to terrorize");
                Console.WriteLine("1 - Rochester\n2 - Miami\n3 - Washington");
                Console.WriteLine("Enter in the number of your selection:");
                string selStrg = Console.ReadLine();
                Boolean Parsed = int.TryParse(selStrg, out selection2);
                if (Parsed == false)
                {
                    Console.WriteLine("That is not a numberr!! enter in something right or get hit by a bus");
                    continue;
                }
                else if (selection2 < 1 || selection2 > 3)
                {
                    Console.WriteLine("That number was not one of your options. You really wanna do this...");
                    continue;
                }
                else
                {
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("You have selected: Rochester (Meh its a swamp anyways)");
                            loc = "Rochester";
                            giveIn = 6;
                            break;
                        case 2:
                            Console.WriteLine("You have selected: Miami (You monster frisbee)");
                            loc = "Miami";
                            giveIn = 4;
                            break;
                        case 3:
                            Console.WriteLine("You have selected: Washington (Good choice i like the white house)");
                            loc = "Washington";
                            giveIn = 2;
                            break;
                        default:
                            break;
                    }
                }
                //Console.WriteLine("End");
            } while (selection2 < 1 || selection2 > 3);

            // Printing out the results of their choices
            Console.WriteLine("\nAttention " + loc);
            Console.WriteLine("I, {0}, will destroy your city by {1}\nunless I recieve 2 supercomputers.", name, project);
            Console.WriteLine("You have 10 minutes to respond...or die.");
            Console.WriteLine("(Press Enter to continue)");
            Console.WriteLine();
            Console.ReadLine();


            // Getting a random number
            result1 = num.Next(10);


            // Here is printing out wheather the location the user chose gave in or wanted to fight
            Console.WriteLine("From: " + loc);
            if (result1 < giveIn)
            {
                Console.WriteLine("Ummm we can't fight you so we will give you what you want. don't hurt us;-;\n");
            }
            else
            {
                Console.WriteLine("We will not give into you, fuck you. we will fight you back\n");
            }


            ///Third Do While Loop:
            /// This loop should do the same exact thing as the fist and second loop
            /// but this loop asks for how do you respond to the actions of the location
            ///
            do
            {
                Console.WriteLine("Select how you want to respond");
                Console.WriteLine("1 - Declare war on {0}\n2 - Bitch out\n3 - BLOW UP THE WORLD", loc);
                Console.WriteLine("Enter in the number of your selection:");
                string selStrg = Console.ReadLine();
                Boolean Parsed = int.TryParse(selStrg, out selection3);
                if (Parsed == false)
                {
                    Console.WriteLine("Enter in a real number, stop be stupid you were doing fine earlier\n");
                    continue;
                }
                else if (selection3 < 1 || selection3 > 3)
                {
                    Console.WriteLine("That number was not one of your options. Like i know you know how to do this so stop being bronze.\n");
                    continue;
                }
                else
                {
                    switch (selection3)
                    {
                        case 1:
                            Console.WriteLine("You have selected: Declare war on " + loc + " (You savage)\n");
                            finale = 1;
                            break;
                        case 2:
                            Console.WriteLine("You have selected: Bitch out (Shaking my head)\n");
                            finale = 2;
                            break;
                        case 3:
                            Console.WriteLine("You have selected: BLOW UP THE WHOLE DAMN WORLD (YOU SAVAGE, I LIVE HERE TOO)\n");
                            finale = 3;
                            break;
                        default:
                            break;
                    }
                }
                // Console.WriteLine("End");
            } while (selection3 < 1 || selection3 > 3);



            //Generationg a random number from 100
            result2 = num.Next(100);

            //Printing out the finale results or the end of the story
            if (finale == 1)
            {
                Console.WriteLine("Hey {0} i don't care what you say ima still fight you mwahahaahahaa!!", loc);
                Console.WriteLine("\nEpilogue: ");
                //If you chose to fight them but they had already give up
                if (result1 < giveIn)
                {
                    Console.WriteLine("Even though {0} gave in to you, you still killed most of them and took everything you wanted. Savage...THE END", loc);
                }
                // I felt that this option needed its own ending since it's really different than the other options
                else if (project == "Destabilizing the Earth's core")
                {
                    Console.Write("You started your meniacle project of destabilizing the Earth's core.");

                    //Comparing the results of the random number to 50 so there would be two outcomes
                    if (result2 < 50)
                    {
                        Console.WriteLine(" But {0} intercepted your plans, shut down the destabilizer, and locked you in jail. Get wrekt kid. THE END", loc);
                    }
                    else
                    {
                        Console.WriteLine("Then you made the world implode on itself because no one could stop you in time...are you happy now? you killed youself...THE END");
                    }
                }
                 
                else
                {
                    // Printing different results from what you chose
                    if (project == "Raising the dead")
                    {
                        Console.Write("you prepared your army of Zambies to fight. ");
                    }
                    else
                    {
                        Console.Write("you prepared your army of Gaint Robots to fight. ");
                    }

                    // Printing out results if you won the fight or not 
                    if (result2 < 50)
                    {
                        Console.WriteLine("And you misreably lost the war. Like damn... you got destroyed. THE END");
                    }
                    else
                    {
                        Console.WriteLine("It was a long and hard fight but you won. good job you have you super computers now, you jerk...THE END");
                    }
                }
            }
                // When you wanted to bitch out
            else if (finale == 2)
            {
                Console.WriteLine("LOL You thought i was serious?? nah i was just joking pfffttttt just ha just joking....\n");
                Console.WriteLine("Epilogue:\nYou were thrown in jail...THE END");
            }
                //You basically killed the world gg
            else if (finale == 3)
            {
                Console.WriteLine("Nah I just don't care anymore, ima blow up the entire world");
                Console.WriteLine("\nEpiolgue:\nWelp you killed everyone...THE END");
            }
        }
    }
}
