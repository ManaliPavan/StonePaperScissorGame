using System;

namespace StonePaperScissorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----------------------------------------->>> Game :: Stone-Paper-Scissor <<<--------------------------------------------");
            Console.WriteLine("\n\n\n"); 
            int playerpoints=0;
            int computerpoints=0;
            Console.Write("Player ID :\t");
            string name = Console.ReadLine();
            Boolean loop = true;
            Console.WriteLine($"----------------------------------------------->>> WELCOME  {name} <<<-------------------------------------------------\n");
            while (loop)
            {
                Console.Write("Enter number of rounds :\t");
                int r = Convert.ToInt32(Console.ReadLine());
                while(r!=0)
                {
                    r--;
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"Start game:\nits your turn {name}...\n");

                    Console.WriteLine("1.Rock");
                    Console.WriteLine("2.Paper");
                    Console.WriteLine("3.Scissors");
                    int playeroption = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    
                    Random random = new Random();
                    int computeroption = random.Next(1, 3);
                    switch (computeroption)
                    {
                        case 1:
                            if (playeroption == 1)
                            {
                                Console.WriteLine("\tPlayer : Rock");
                                Console.WriteLine("\tComputer : Rock");
                                Console.WriteLine("\n\tIt's tie...\n\tBetter luck next time...");
                                Console.WriteLine($"\n\tPlayer :{playerpoints} \t\t\t\t\t Computer : {computerpoints}");
                            }

                            else if (playeroption == 2)
                            {
                                Console.WriteLine("\tPlayer : Paper");
                                Console.WriteLine("\tComputer : Rock");
                                Console.WriteLine("\n\tPlayer wins..\n\t\t\t\t\t\tPlayer : +1 point");
                                playerpoints++;
                                Console.WriteLine($"\n\tPlayer :{playerpoints} \t\t\t\t\t Computer : {computerpoints}");
                            }
                            else if (playeroption == 3)
                            {
                                Console.WriteLine("\tPlayer : Scissors");
                                Console.WriteLine("\tComputer : Rock");
                                Console.WriteLine("\n\tComputer wins..\n\t\t\t\t\t\t Computer : +1 point");
                                computerpoints++;
                                Console.WriteLine($"\n\tPlayer :{playerpoints} \t\t\t\t\t Computer : {computerpoints}");
                            }
                            break;

                        case 2:
                            if (playeroption == 1)
                            {

                                Console.WriteLine("\tPlayer : Rock");
                                Console.WriteLine("\tComputer : Paper");
                                Console.WriteLine("\n\tComputer wins..\n\t\t\t\t\t\t Computer : +1 point");
                                computerpoints++;
                                Console.WriteLine($"\n\tPlayer :{playerpoints} \t\t\t\t\t Computer : {computerpoints}");
                            }

                            else if (playeroption == 2)
                            {
                                Console.WriteLine("\tPlayer : Paper");
                                Console.WriteLine("\tComputer : Paper");
                                Console.WriteLine("\n\tIt's tie...\n\tBetter luck next time...");
                                Console.WriteLine($"\n\tPlayer :{playerpoints} \t\t\t\t\t Computer : {computerpoints}");
                            }
                            else if (playeroption == 3)
                            {
                                Console.WriteLine("\tPlayer : Scissors");
                                Console.WriteLine("\tComputer : Rock");
                                Console.WriteLine("\tComputer wins..\n\t\t\t\t\t\tComputer : +1 point");
                                computerpoints++;
                                Console.WriteLine($"\n\tPlayer :{playerpoints} \t\t\t\t\t Computer : {computerpoints}");
                            }
                            break;

                        case 3:
                            if (playeroption == 1)
                            {

                                Console.WriteLine("\tPlayer : Rock");
                                Console.WriteLine("\tComputer :Scissor");
                                Console.WriteLine("\n\tPlayer wins..\n\t\t\t\t\t\tPlayer : +1 point");
                                playerpoints++;
                                Console.WriteLine($"\n\tPlayer :{playerpoints} \t\t\t\t\t Computer : {computerpoints}");
                            }
                            else if (playeroption == 2)
                            {
                                Console.WriteLine("\tPlayer : Paper");
                                Console.WriteLine("\tComputer : Scissor");
                                Console.WriteLine("\n\tComputer wins..\n\t\t\t\t\t\tComputer : +1 point");
                                computerpoints++;
                                Console.WriteLine($"\n\tPlayer :{playerpoints} \t\t\t\t\t Computer : {computerpoints}");
                            }
                            else if (playeroption == 3)
                            {
                                Console.WriteLine("\tPlayer : Scissors");
                                Console.WriteLine("\tComputer : Scissor");
                                Console.WriteLine("\n\tIt's tie...\n\tBetter luck next time...");
                                Console.WriteLine($"\n\tPlayer :{playerpoints} \t\t\t\t\t Computer : {computerpoints}");
                            }
                            break;
                            
                    }
                }
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                if (playerpoints>computerpoints)
                    Console.WriteLine($"\nfinal winner : {name}");
                else if(playerpoints < computerpoints)
                    Console.WriteLine($"\nfinal winner : computer");
                else
                    Console.WriteLine("\nTie : let's try again..");
                Console.WriteLine("Continue playing..(Y/N)");
                string choice = Console.ReadLine();
                if(choice=="N" || choice=="n")
                   loop = false;
            }
        }
    }
}

