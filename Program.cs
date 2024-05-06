using System;

class Program
{

    
    static int MAX_SIZE = 1; // Constant to define the maximum size of the inventory
    static string[] playerInventory = new string[MAX_SIZE]; // Array to hold player's inventory items   

    // Array to hold player's inventory items. 5 is the max number of items.
    static int inventoryCount = 0; // Counter for number of items in inventory

    // Function for adding items to inventory
    static void AddToInventory(string item)
    {
        // Check if inventory is not full
        if (inventoryCount < playerInventory.Length)
        {
            // Add item to inventory
            playerInventory[inventoryCount] = item;
            // Increase inventory count
            inventoryCount++;
            // Display message that says item has been added to inventory
            Console.Write($"{item} has been added to your inventory. You now have {inventoryCount} item{(inventoryCount != 1 ? "s" : "")} in your inventory.");
        }
        else
        {
            // Display message indicating inventory is full when its full
            Console.WriteLine(" Your inventory is full. You cannot carry any more items.");
        }
    }

// Main method
    static void Main(string[] args)
    {
        // Start the game // Call this later on when the 
        StartGame();
        // Ask user to rate the game // Call this later when you want use it
        RateGame();
    }

// Function for rating the game
    static void RateGame() 
    {
        // Ask user to rate the game
        Console.WriteLine("Please rate the game on a scale of 1 to 10 (1 being the lowest and 10 being the highest):");

        int rating; // Variable to hold user's rating
        bool isValidRating = false; // Flag to track if rating is valid


        // Loop until a valid rating is entered
        do
        {
            Console.Write("Your rating: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out rating))
            {
                  // Check if the user input is between 1-10
                if (rating >= 1 && rating <= 10)
                {
                    isValidRating = true;
                }
                else
                {
                    // Display error message for number outside of range
                    Console.WriteLine("Invalid rating. Please enter a number between 1 and 10.");
                }
            }
            else
            {
                // Display error message for invalid input
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (!isValidRating);
        
        // Display message thanking user for rating
        Console.WriteLine($"Thank you for your rating of {rating}! We appreciate your feedback.");
    }


// Function to start the game
    static void StartGame()
    {
        // First message the user gets asking if they want to play the game
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Do you want to play this island survival game?");
        Console.WriteLine("Type below: 'Yes' or 'No'");
        Console.WriteLine("----------------------------------------------");
        string startChoice = GetNonEmptyInput(new string[] { "yes", "no" }).ToLower();
        if (startChoice == "yes")
        {
            StartBeachScenario();
        }
        else if (startChoice == "no")
        {
               // Exit the game if user chooses not to play
            Console.WriteLine("Okay, come back when you're ready to play!");
            Environment.Exit(0);
        }
    }


// Function to start the beach scenario
    static void StartBeachScenario()
    {
         // Display beach scenario and choices
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("You were on a plane flying over the ocean when both engines burst into flames. The plane crashes into the sea during a massive storm. Clinging to a piece of the wreckage,  ");
        Console.WriteLine("you hope for rescue but drift away from the crash site. You wake up on a beach at night, alone. Calling from the top of your lungs for anyone but theres nothing. You see ");
        Console.WriteLine("a forest ahead and realise it's getting cold. You need to find shelter and warmth before its too late. ");
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("What do choose to do? (type 1 or 2 for either option below)");
        Console.WriteLine("1. Stay on the beach waiting to see if help comes");
        Console.WriteLine("2. Go into the jungle to look for a somewhere to spend the night");
        // Get user choice
        string choice = GetNonEmptyInput(new string[] { "1", "2" });
        if (choice == "1")
        {
            // Displays death message and asks user if they want to restart
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("You die due to the cold. Game over. Do you want to restart? (Yes/No)");
            Console.WriteLine("--------------------------------------------------------------------");
            string restartChoice = GetNonEmptyInput(new string[] { "yes", "no" }).ToLower();
            if (restartChoice == "yes")
            {
                Console.WriteLine("Let's try again!");
                StartBeachScenario();
            }
            else if (restartChoice == "no")
            {
                Console.WriteLine("Okay, come back when you're ready to play!");
                Environment.Exit(0);
            }
        }
        // Keep on going with the storyline
        else if (choice == "2")
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("As you venture into the jungle, you instinctively reach into your pockets and discover your phone."); AddToInventory(" A phone"); Console.Write(" You");
            Console.WriteLine("");
            Console.WriteLine("can have a maximum of 5 items in your inventory. With a rush of hope, you power it on and find it miraculously functional, despite the lack of signal. An amber alert catches your eye,");
            Console.WriteLine("urging all crash survivors on islands to gather on the beach at sunrise (7 am) and create a SOS sign for helicopter rescue. Realisation dawns — you must survive until the morning. You");
            Console.WriteLine("check the time and see it's 1 am. 6 hours remain. Determined, you keep moving into the thick trees. After trekking for a while you notice marks that look like footprints.");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("1. Follow the footprints");
            Console.WriteLine("2. Keep hiking into the jungle");

            string followChoice = GetNonEmptyInput(new string[] { "1", "2" }).ToLower();
            if (followChoice == "1")
            {
                FollowFootprints();
            }
            else if (followChoice == "2")
            {
                BuildShelter();
            }
        }
    }

    static void FollowFootprints()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("You follow these prints for about 20 minutes then discover a cave.");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("What do you choose to do?");
        Console.WriteLine("1. Enter the cave");
        Console.WriteLine("2. Ignore and go further into the forest");

        string caveChoice = GetNonEmptyInput(new string[] { "1", "2" }).ToLower();
        if (caveChoice == "1")
        {
            EnterCave();
        }
        else if (caveChoice == "2")
        {
            BuildShelter();
        }
    }

    static void EnterCave()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("You step into the cave, shrouded in darkness. Without warning, something lunges at you, catching you off guard. You manage to fend it off with a quick strike.");
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("What do you choose to do?");
        Console.WriteLine("1. Stay in the cave and examine the attacker while it's downed");
        Console.WriteLine("2. Run out of the cave and go deeper into the forest");

        string caveChoice = GetNonEmptyInput(new string[] { "1", "2" }).ToLower();
        if (caveChoice == "1")
        {
            ExamineAttacker();
        }
        else if (caveChoice == "2")
        {
            BuildShelter();
        }
    }

    static void ExamineAttacker()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("As you cautiously approach the fallen figure, you realise it's not a creature but a frightened man. You inquire about his presence and how long he's been here. He reveals ");
        Console.WriteLine("that he's been stranded for years and mistook you for an animal. He gives you an invitation back to his camp to provide you with some warmth, food and support.");
        Console.WriteLine("");
        Console.WriteLine("-------------------------");
        Console.WriteLine("What do you choose to do?");
        Console.WriteLine("1. Follow the man");
        Console.WriteLine("2. Decline the invite");

        string manChoice = GetNonEmptyInput(new string[] { "1", "2" }).ToLower();
        if (manChoice == "1")
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("You follow the unknown man back to his shelter. He provides you with a warm fire, food and water.");
            Console.WriteLine("Congratulations! You've made it to the end of the prototype for the island survival game. You can restart the game to explore different paths of the story.");
            Console.WriteLine("Hope you've enjoyed this experience!");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            RateGame();
            RestartGame();
        }
        else if (manChoice == "2")
        {
            DeclineInvite();
        }
    }

    static void DeclineInvite()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Rejecting the man's invitation only seems to worsen his mood, pushing him over the edge. Despite your attempts to calm him down, he lashes out in anger, catching you");
        Console.WriteLine("off guard. Losing your footing, you slip and collide with a rock, knocking you unconscious. Tragically, the impact proves fatal, ending your journey abruptly. Game over.");
        Console.WriteLine("");
        Console.WriteLine("Unfortunately your story ends here. Thank you for playing this prototype. You can restart the game to explore different paths of the story.");
        Console.WriteLine("Hope you've enjoyed this experience!");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        RateGame();
        RestartGame();
    }

    static void RestartGame() //Function for restarting game and taking you back to beach scenario. 
    {
        Console.WriteLine("Do you want to restart the game? (Yes/No)");
        string restartChoice = GetNonEmptyInput(new string[] { "yes", "no" }).ToLower();
        if (restartChoice == "yes")
        {
            Console.WriteLine("Let's try again!");
            StartBeachScenario(); 
        }
        else if (restartChoice == "no")
        {
            Console.WriteLine("Okay, come back when you're ready to play!");
            Environment.Exit(0);
        }
    }



    static void BuildShelter()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("As you push forward into the woods you find a rock that looks sharp enough to be used as a weapon. This might be useful later."); AddToInventory(" A sharp rock"); Console.Write("You come across a heap of logs, remnants of trees felled by the storm. These logs seem like they could make a decent shelter, providing some refuge from the");
        Console.WriteLine("");
        Console.WriteLine("elements.");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("What do you choose to do?");
        Console.WriteLine("1. Build a camp here and make yourself a shelter");
        Console.WriteLine("2. Keep moving along, hoping to find a better option");

        string shelterChoice = GetNonEmptyInput(new string[] { "1", "2" }).ToLower();
        if (shelterChoice == "1")
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You begin gathering wood, stacking the pieces together to construct a makeshift shelter. Time seems to stretch on endlessly as you work, hoping for a glimpse of dawn soon.");
            Console.WriteLine("However, when you check your phone, it's a disheartening reminder: it's only 2 am, with five long hours remaining. Undeterred, you persevere, and after a while longer, ");
            Console.WriteLine("you manage to fashion something resembling a shelter.");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("1. Lie down and try to fall asleep");
            Console.WriteLine("2. Stay awake for a while and reflect on the events of the past 24 hours.");



            string shelterOption = GetNonEmptyInput(new string[] { "1", "2" }).ToLower();
            if (shelterOption == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("As you awaken to the cheerful chirping of birds, the warm embrace of the morning sun greets your face. Reflexively, you reach for your phone, the time glaring back at you: ");
                Console.WriteLine("9:46 AM. A sudden chill grips your heart as the realization sets in — the rescue team have already evacuated the survivors. It dawns upon you that you're stranded here ");
                Console.WriteLine("forever. Game over.");
                Console.WriteLine("");
                Console.WriteLine("Unfortunately your story ends here thank you for playing this prototype, You can restart the game to explore different paths of the story.");
                Console.WriteLine("Hope you've enjoyed this experience!");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                RateGame();
                RestartGame();
            }
            else if (shelterOption == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("After being awake for about half an hour, pondering the possibility of other survivors, you're startled by the sudden rustling of bushes nearby.");
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("What do you choose to do?");
                Console.WriteLine("1. Go see what it is");
                Console.WriteLine("2. Grab your sharp rock and get ready if something's going to attack you");



                string rustlingChoice = GetNonEmptyInput(new string[] { "1", "2" }).ToLower();
                if (rustlingChoice == "1")
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You hear it again so you sprint into the bushes revealing a bird. You are really relieved and go back to your shelter.");
                    Console.WriteLine("Congratulations! You've made it to the end of the prototype for the island survival game. You can restart the game to explore different paths of the story");
                    Console.WriteLine("Hope you've enjoyed this experience!");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    RateGame();
                    RestartGame();

                }
                else if (rustlingChoice == "2")
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You decide to grab your rock and brace yourself, ready for whatever might emerge from the bushes. After a tense moment, the rustling stops, and you're left standing ");
                    Console.WriteLine("alone in the darkness, heart pounding with adrenaline.  ");
                    Console.WriteLine("Congratulations! You've made it to the end of the prototype for the island survival game. You can restart the game to explore different paths of the story");
                    Console.WriteLine("Hope you've enjoyed this experience!");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    RateGame();
                    RestartGame();
                }
            }
        }
        else if (shelterChoice == "2")
        {
            KeepMoving();
        }
    }

    static void KeepMoving()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("You opt to continue your adventure deeper into the woods. Time passes without any notable events. Glancing at your phone once more, it reads 2 am, reminding you that");
        Console.WriteLine("you have five more hours until rescue. While walking you find a rock that looks sharp enough to be used as a weapon."); Console.WriteLine("Eventually, you stumble upon some sizable berries scattered across the forest floor.");
        Console.WriteLine("");
        Console.WriteLine("-------------------------");
        Console.WriteLine("What do you choose to do?");
        Console.WriteLine("1. Pick up the berries");
        Console.WriteLine("2. Ignore");

        string berryChoice = GetNonEmptyInput(new string[] { "1", "2" }).ToLower();
        if (berryChoice == "1")
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("It appears to be a trap and you get pierced with multiple arrows and bleed out to death. Game over.");
            Console.WriteLine("Unfortunately your story ends here thank you for playing this prototype, You can restart the game to explore different paths of the story.");
            Console.WriteLine("Hope you've enjoyed this experience!");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            RateGame();
            RestartGame();
        }
        else if (berryChoice == "2")
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("You decide to leave the berries, unsure if they're safe to eat. Hunger gnaws at your stomach, but you press on, hoping to find a better source of food.");
            Console.WriteLine("");
            Console.WriteLine("Congratulations! You've made it to the end of the prototype for the island survival game. You can restart the game to explore different paths of the story.");
            Console.WriteLine("I hope you've enjoyed this experience");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------");
            RateGame();
            RestartGame();
        }
    }

    static string GetNonEmptyInput(string[] validOptions)
    {
        string input;
        do
        {
            input = Console.ReadLine().ToLower();
            if (Array.IndexOf(validOptions, input) == -1)
            {
                Console.WriteLine("Invalid input. Please enter a valid response.");
            }
        } while (Array.IndexOf(validOptions, input) == -1);

        return input;
    }
}
