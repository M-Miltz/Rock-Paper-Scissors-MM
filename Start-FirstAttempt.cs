namespace Rock_Paper_Scissors_MM
{
    internal class Start
    {


        public static void Main(string[] args)
        {
            // I
            // Ask player for their choice:

                Console.Write("Please Enter your name: ");
                string name = Console.ReadLine();
                string nameFormatted = name.ToUpper();

                Console.Write("Hi, " + nameFormatted  + "!\nPlease type in ROCK, PAPER, or SCISSORS:");
                string playerChoiceUnformatted = Console.ReadLine();
                string playerChoice = playerChoiceUnformatted.ToUpper();

            // II
            // Produce a random move for the computer player:


            // 1. string list containing rps options

            var rpsList = new List<string> { "ROCK", "PAPER", "SCISSORS" };


                // 2. select a random index from the array

                    var randomiser = new Random();
                    string randomChoice = rpsList[randomiser.Next(0, rpsList.Count)];
            



            // 3. print random choice as a string:

            Console.WriteLine("Good choice, " + nameFormatted + "! \nMy random choice is " + (randomChoice)+ ".");



            // III
            // Compare player's choice (playerChoice) to computer answer (randomChoice)
            // and
            // State if there is a winner or a draw. 

            // check if a draw happened. if not
            // rock wins against scissors; paper wins against rock; and scissors wins against paper.


            bool isEqual = playerChoice == randomChoice;
            bool playerRock = playerChoice == "ROCK" && randomChoice == "SCISSORS";                  
            bool playerPaper = playerChoice == "PAPER" && randomChoice == "ROCK";           
            bool playerScissors = playerChoice == "SCISSORS" && randomChoice == "PAPER";
            bool randomRock = randomChoice == "ROCK" && playerChoice == "SCISSORS";
            bool randomPaper = randomChoice == "PAPER" && playerChoice == "ROCK";
            bool randomScissors = randomChoice == "SCISSORS" && playerChoice == "PAPER";

            // try while loop?

            if (isEqual)
            {
                //draw - this needs to happen every time there is a draw. LOGIC DOESN'T WORK IF THERE IS A SECOND DRAW

                Console.WriteLine("Oops, " + nameFormatted + "! The game was a draw. Let's try again.\nPlease type in Rock, Paper, or Scissors:");

                Console.ReadLine();
                Console.WriteLine("Good choice, " + nameFormatted + "! \nMy random choice is " + (randomChoice) + ".");


                if (playerRock)

                //game rules - player wins

                {
                    Console.WriteLine("ROCK beats SCISSORS!" + nameFormatted + " wins!");
                }

                else if (playerPaper)

                {
                    Console.WriteLine("PAPER beats ROCK!" + nameFormatted + " wins!");
                }

                else if (playerScissors)

                {
                    Console.WriteLine("SCISSORS beats PAPER!" + nameFormatted + " wins!");
                }

                // game rules - computer wins

                else if (randomRock)

                {
                    Console.WriteLine("ROCK beats SCISSORS. I win! ");

                }

                else if (randomPaper)

                {
                    Console.WriteLine("PAPER beats ROCK. I win!");
                }

                else

                {
                    Console.WriteLine("SCISSORS beats PAPER. I win!");
                }


            }

            else if (playerRock)

            //game rules - player wins

            {
                Console.WriteLine("ROCK beats SCISSORS!" + nameFormatted + " wins!");
            }

            else if (playerPaper)

            {
                Console.WriteLine("PAPER beats ROCK!" + nameFormatted + " wins!");
            }

            else if (playerScissors)

            {
                Console.WriteLine("SCISSORS beats PAPER!" + nameFormatted + " wins!");
            }

            // game rules - computer wins

            else if (randomRock)

            {
                Console.WriteLine("ROCK beats SCISSORS. I win! ");

            }

            else if (randomPaper)

            {
                Console.WriteLine("PAPER beats ROCK. I win!");
            }

            else

            {
            Console.WriteLine("SCISSORS beats PAPER. I win!");
            }

          
       Console.WriteLine("Thanks for playing, " + nameFormatted + ".");
            string message = @"
  _    _       _   _ _                   _     _   _                
 | |  | |     | | (_) |                 | |   | | (_)               
 | |  | |_ __ | |_ _| |  _ __   _____  _| |_  | |_ _ _ __ ___   ___ 
 | |  | | '_ \| __| | | | '_ \ / _ \ \/ / __| | __| | '_ ` _ \ / _ \
 | |__| | | | | |_| | | | | | |  __/>  <| |_  | |_| | | | | | |  __/
  \____/|_| |_|\__|_|_| |_| |_|\___/_/\_\\__|  \__|_|_| |_| |_|\___|";
            Console.WriteLine(message);






            //if (playerChoice == "ROCK" && randomChoice == "SCISSORS")

            // game rules - player wins

            //{
            // Console.WriteLine("ROCK beats SCISSORS!" + nameFormatted + " wins!");
            //}

            //else if (playerChoice == "PAPER" && randomChoice == "ROCK")

            //{
            //Console.WriteLine("PAPER beats ROCK!" + nameFormatted + " wins!");
            //}

            //else if (playerChoice == "SCISSORS" && randomChoice == "PAPER")

            //{
            //Console.WriteLine("SCISSORS beats PAPER!" + nameFormatted + " wins!");
            //}

            // game rules - computer wins

            //else if (randomChoice == "ROCK" && playerChoice == "SCISSORS")

            //{
            // Console.WriteLine("ROCK beats SCISSORS! I win :p");

            //}

            //else if (randomChoice == "PAPER" && playerChoice == "ROCK")

            //{
            //Console.WriteLine("PAPER beats ROCK!" + nameFormatted + " wins!");
            //}

            //else if (randomChoice == "SCISSORS" && playerChoice == "PAPER")

            //{
            // Console.WriteLine("SCISSORS beats PAPER!" + nameFormatted + " wins!");
            //}
            //else
            //{   //draw
            //Console.WriteLine("Oops, " + nameFormatted + "! The game was a draw. Let's try again.\nPlease type in Rock, Paper, or Scissors:");
            //}






























        }

    }
   
   
 
        
}
