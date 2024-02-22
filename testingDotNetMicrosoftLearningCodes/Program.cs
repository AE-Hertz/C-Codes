/*Each 3 Line GAP means NEW QUESTION SOLUTION*/


//console.writeline("hello, world!");
//random dice = new random();
//int roll = dice.next(1, 17);
//console.writeline(@$"random generated number is - {roll}");  //here i have shown concepts of (verbatim @ string literal) & (interpolation $ string literal)
//console.writeline(dice.next(18, 67));


//int firstValue = 500;
//int secondValue = 600;
//int largerValue;
//largerValue = Math.Max(firstValue, secondValue);    
//Console.WriteLine(largerValue);


//Random random = new Random();
//int daysUntilExpiration = random.Next(12);
//int discountPercentage = 0;
//Console.WriteLine("Days Left - " + daysUntilExpiration);
//if (daysUntilExpiration < 11)
//{
//    if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
//    {
//        Console.WriteLine("Your subscription will expire soon. Renew now!");
//    }
//    else if (daysUntilExpiration <=5  && daysUntilExpiration < 1)
//    {
//        discountPercentage = 10;
//        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\r\nRenew now and save {discountPercentage}%!");
//    }
//    else if (daysUntilExpiration == 1)
//    {
//        discountPercentage = 20;
//        Console.WriteLine($"Your subscription expires within a day!\r\nRenew now and save {discountPercentage}%!");
//    }
//    else if (daysUntilExpiration < 1)
//            {
//        Console.WriteLine("Your subscription has expired.");
//    }

//}



//string[] Orderid = { "B123","C234","A345","C15","B177","G3003","C235","B179" };
//foreach (string orderid in Orderid)                                                 //here "orderid" is basically iterating through all the array indexes starting from 0 like Orderid[0] then Orderid[1]
//{
//    if (orderid.StartsWith("B"))
//    {
//        Console.WriteLine(orderid);
//    }
//}



// initialize variables - graded assignments 
//int currentAssignments = 5;

////int sophia1 = 90;
////int sophia2 = 86;
////int sophia3 = 87;
////int sophia4 = 98;
////int sophia5 = 100;
//int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };

////int andrew1 = 92;
////int andrew2 = 89;
////int andrew3 = 81;
////int andrew4 = 96;
////int andrew5 = 90;
//int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };

////int emma1 = 90;
////int emma2 = 85;
////int emma3 = 87;
////int emma4 = 98;
////int emma5 = 68;
//int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };

////int logan1 = 90;
////int logan2 = 95;
////int logan3 = 87;
////int logan4 = 88;
////int logan5 = 96;
//int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

//int sophiaSum = 0;
////int andrewSum = 0;
////int emmaSum = 0;
////int loganSum = 0;

//decimal sophiaScore;
//decimal andrewScore;
//decimal emmaScore;
//decimal loganScore;

//sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
//andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
//emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
//loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

//sophiaScore = (decimal)sophiaSum / currentAssignments;
//andrewScore = (decimal)andrewSum / currentAssignments;
//emmaScore = (decimal)emmaSum / currentAssignments;
//loganScore = (decimal)loganSum / currentAssignments;

//foreach(int score in sophiaScores)
//{
//    sophiaSum += score;
//}
//sophiaScore = (decimal)sophiaSum / currentAssignments;

//Console.WriteLine("Student\t\tGrade\n");
//Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
////Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
////Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
////Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

//Console.WriteLine("Press the Enter key to continue");
//Console.ReadLine();


//Console.WriteLine("a" == "a");
//Console.WriteLine("a" == "A");
//Console.WriteLine(1 == 2);

//string myValue = "a";
//Console.WriteLine(myValue == "a");

//Random random = new Random();
//int value = random.Next(1, 100);

//Console.WriteLine(@$"Value = {value}");
//Console.WriteLine(@$"Result is - {(value > 50? "head" : "tail")} ");




/* SKU = Stock Keeping Unit. 
SKU value format: <product #>-<2-letter color code>-<size code>  */
//string sku = "01-MN-L";

//string[] product = sku.Split('-');

//string type = "";
//string color = "";
//string size = "";

////if (product[0] == "01")
////{
////    type = "Sweat shirt";
////}
////else if (product[0] == "02")
////{
////    type = "T-Shirt";
////}
////else if (product[0] == "03")
////{
////    type = "Sweat pants";
////}
////else
////{
////    type = "Other";
////}
//switch(product[0])
//{
//    case "01":
//        {
//            type = "Sweat Shirt";
//            break;
//        }
//    case "02":
//        {
//            type = "T-Shirt";
//            break;
//        }
//    case "03":
//        {
//            type = "Sweat pants";
//            break;
//        }
//    default:
//         {
//            type = "Others";
//            break;
//        }
//}

////if (product[1] == "BL")
////{
////    color = "Black";
////}
////else if (product[1] == "MN")
////{
////    color = "Maroon";
////}
////else
////{
////    color = "White";
////}

//switch(product[1])
//{
//    case "BL":
//        {
//            color = "Black";
//            break;
//        }
//    case "MN":
//        {
//            color = "Maroon";
//            break;
//        }
//    default:
//        {
//            color = "White";
//            break;
//        }
//}



////if (product[2] == "S")
////{
////    size = "Small";
////}
////else if (product[2] == "M")
////{
////    size = "Medium";
////}
////else if (product[2] == "L")
////{
////    size = "Large";
////}
////else
////{
////    size = "One Size Fits All";
////}
//switch(product[2])
//{
//    case "s":
//        {
//            size = "Small";
//            break;
//        }
//    case "M":
//        {
//            size = "Medium";
//            break;
//        }
//    case "L":
//        {
//            size = "Large";
//            break;
//        }
//    default:
//        {
//            size = " One Size Fits All";
//            break;
//        }
//}

//Console.WriteLine($"Product: {size} {color} {type}");



/*PROBLEM STATEMENT:
    
    Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
    When the current value is divisible by 3, print the term Fizz next to the number.
    When the current value is divisible by 5, print the term Buzz next to the number.
    When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.  */

//for (int currentValue = 1; currentValue <= 100; currentValue++)
//{
//    if (currentValue % 3 == 0 && currentValue % 5 == 0)
//        Console.WriteLine($"{currentValue} - FizzBuzz");

//    {
//        if (currentValue % 3 == 0)
//            Console.WriteLine($@"{currentValue} - Fizz");

//        else if (currentValue % 5 == 0)
//            Console.WriteLine($@"{currentValue} - Buzz");


//        else
//            Console.WriteLine(currentValue);
//    }
//}



/*PROBLEM STATEMENT :-
You must use either the do-while statement or the while statement as an outer game loop.
    The hero and the monster will start with 10 health points.
    All attacks will be a value between 1 and 10.
    The hero will attack first.
    Print the amount of health the monster lost and their remaining health.
    If the monster's health is greater than 0, it can attack the hero.
    Print the amount of health the hero lost and their remaining health.
    Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
    Print the winner.
*/

//int heroHealth = 10, monsterHealth = 10;
//bool hero = true;
//do
//{
//    if (hero)
//    {
//        Random attackDamage = new Random();
//        int heroDamage = attackDamage.Next(1, 10);
//        monsterHealth -= heroDamage;
//        Console.WriteLine($"Hero attacked Monster with {heroDamage} damage having health {monsterHealth} left");
//    }

//    else
//    {
//        Random attackDamage = new Random();
//        int monsterDamage = attackDamage.Next(1, 10);
//        heroHealth -= monsterDamage;
//        Console.WriteLine($"Monster attacked Hero with {monsterDamage} damage having health {heroHealth} left");
//    }
//    hero = !hero ; 
//}
//while (heroHealth > 0 && monsterHealth > 0);
//{
//    if (heroHealth <= 0)
//    {
//        Console.WriteLine("Monster WINS");
//    }
//    else if (monsterHealth <= 0)
//    { 
//        Console.WriteLine("Hero WINS"); 
//    }
//}



/* PROBLEM STATEMENT ;-
 * write code that validates integer input
 */

//Console.WriteLine("integer value between 5 and 10");
//int validNum = 0;
//do
//{
//    validNum = int.Parse(Console.ReadLine());
//    if (validNum > 5 && validNum < 10)
//        Console.WriteLine("Your value accepted");
//    else
//        Console.WriteLine("Enter valid input between 5 & 10");
//        validNum = int.Parse(Console.ReadLine());
//}
//while (validNum >= 5 && validNum <= 10);
//{
//    Console.WriteLine("input value has been accepted");
//}

//string? readResult;
//int numericValue = 0;
//bool validEntry = false;
//Console.WriteLine("Enter a number :");
//do
//{
//    readResult = Console.ReadLine();
//    validEntry = int.TryParse(readResult, out numericValue);                    // capture user input in a string variable named readResult

//    if (validEntry == true)
//    {
//        if (numericValue > 4 && numericValue < 11)
//        {
//            Console.WriteLine("Valid Number");
//        }

//        else
//        {
//            Console.WriteLine("Your input is invalid, please try again.");
//            validEntry = false;
//        }
//    }
//} 
//while (validEntry == false);
//{
//    Console.WriteLine($"value entered {numericValue}");
//    Console.ReadLine();
//}




/*PROBLEM STATEMENT :-
 *  write code that validates string input 
 */

//string? readInput;
//string? role;
//bool validEntry = false;
//Console.WriteLine("Enter one of three role names: Admin, Manager, or User");
//do
//{
//    readInput = Console.ReadLine();
//    readInput = readInput.ToLower();
//    role = readInput.Trim();
//    if (readInput != null)
//    {
//        if (role == "admin" || role == "manager" || role == "user")
//        {
//            validEntry = true;
//        }
//        else
//        {
//            Console.WriteLine("enter valid role");
//            validEntry = false;
//        }

//    }
//}
//while (validEntry == false);
//{
//    Console.WriteLine($"Role entered {role}");
//    Console.ReadLine();
//}



/*PROBLEM STATEMENT :-
 * Write code that processes the contents of a string array
 */

//string[] myStrings = new string[2] { "I like pizza. I like roast chicken.           I like salad", "I like all three of the menu choices" };
//int stringsCount = myStrings.Length;
//string myString = "";
//int periodLocation = 0;

//for (int i = 0; i < stringsCount; i++)
//{
//    myString = myStrings[i];
//    Console.WriteLine($"{myString} myString HERE");
//    periodLocation = myString.IndexOf(".");
//    Console.WriteLine(periodLocation);

//    string mySentance;

//    while (periodLocation != -1)
//    {
//        mySentance = myString.Remove(periodLocation);

//        myString = myString.Substring(periodLocation + 1);

//        myString = myString.TrimStart();

//        periodLocation = myString.IndexOf(".");

//        Console.WriteLine(mySentance);
//    }
//    mySentance = myString.Trim();
//    Console.WriteLine(mySentance);
//}



/* GUIDED PROJECT _________________________________________________________________________________________________________________________________________________________________AHEAD_______________*/
/*PROBLEM  STATEMENT :-
 * Guided Project - Pets Application
 * Code review: review the contents of the Program.cs file.
    Sample data: convert the if-elseif-else structure to switch-case structure that improves readability.
    Menu loop: enclose the main menu and menu item selection in a loop that iterates until the user enters "exit".
    Menu selections: write the code for a switch-case structure that establishes separate code branches for each menu option.
    Code branches: write placeholder within the menu item branches that provides user feedback until app features are developed.
    Verification test: perform verification tests for the code that you develop in this exercise
 */

//// the ourAnimals array will store the following: 
//string animalSpecies = "";
//string animalID = "";
//string animalAge = "";
//string animalPhysicalDescription = "";
//string animalPersonalityDescription = "";
//string animalNickname = "";

//// variables that support data entry
//int maxPets = 8;
//string? readResult;
//string menuSelection = "";
//int petAge = 0;
//bool validEntry = false;



//// array used to store runtime data, there is no persisted data
//string[,] ourAnimals = new string[maxPets, 6];

//// TODO: Convert the if-elseif-else construct to a switch statement

//// create some initial ourAnimals array entries
//for (int i = 0; i < maxPets; i++)
//{
//    switch (i)
//    {
//        case 0:
//            {
//                animalSpecies = "dog";
//                animalID = "d1";
//                animalAge = "2";
//                animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
//                animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//                animalNickname = "lola";
//                break;
//            }
//        case 1:
//            {
//                animalSpecies = "dog";
//                animalID = "d2";
//                animalAge = "9";
//                animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//                animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//                animalNickname = "loki";
//                break;
//            }
//        case 2:
//            {
//                animalSpecies = "cat";
//                animalID = "c3";
//                animalAge = "1";
//                animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//                animalPersonalityDescription = "friendly";
//                animalNickname = "Puss";
//                break;
//            }
//        case 3:
//            {
//                animalSpecies = "cat";
//                animalID = "c4";
//                animalAge = "?";
//                animalPhysicalDescription = "";
//                animalPersonalityDescription = "";
//                animalNickname = "";
//                break;
//            }
//        default:
//            {
//                animalSpecies = "";
//                animalID = "";
//                animalAge = "";
//                animalPhysicalDescription = "";
//                animalPersonalityDescription = "";
//                animalNickname = "";
//                break;
//            }
//    }

//    ourAnimals[i, 0] = "ID #: " + animalID;
//    ourAnimals[i, 1] = "Species: " + animalSpecies;
//    ourAnimals[i, 2] = "Age: " + animalAge;
//    ourAnimals[i, 3] = "Nickname: " + animalNickname;
//    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
//}

//// display the top-level menu options

//Console.Clear();
//do
//{
//    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//    Console.WriteLine(" 1. List all of our current pet information");
//    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
//    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
//    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
//    Console.WriteLine(" 5. Edit an animal’s age");
//    Console.WriteLine(" 6. Edit an animal’s personality description");
//    Console.WriteLine(" 7. Display all cats with a specified characteristic");
//    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
//    Console.WriteLine();
//    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//    readResult = Console.ReadLine();
//    if (readResult != null)
//    {
//        menuSelection = readResult.ToLower();
//    }

//    //Console.WriteLine($"You selected menu option {menuSelection}.");
//    //Console.WriteLine("Press the Enter key to continue");

//    //// pause code execution
//    //readResult = Console.ReadLine();
//    switch (menuSelection)
//    {
//        case "1":
//            // List all of our current pet information
//            //Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i, 0] != "ID #: ")
//                {
//                    Console.WriteLine(ourAnimals[i, 0]);
//                    Console.WriteLine();
//                    for (int j = 0; j < 6; j++)
//                    {
//                        Console.WriteLine(ourAnimals[i, j]);
//                    }
//                }
//            }
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;

//        case "2":
//            //Add a new animal friend to the ourAnimals array Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//            string anotherPet = "y";
//            int petCount = 0;
//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i, 0] != "ID #: ")
//                {
//                    petCount += 1;
//                }
//            }

//            if (petCount < maxPets)
//            {
//                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
//            }

//            // get species (cat or dog) - string animalSpecies is a required field 
//            do
//            {
//                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
//                readResult = Console.ReadLine();
//                if (readResult != null)
//                {
//                    animalSpecies = readResult.ToLower();
//                    if (animalSpecies != "dog" && animalSpecies != "cat")
//                    {
//                        validEntry = false;
//                    }
//                    else
//                    {
//                        validEntry = true;
//                    }
//                }
//            } while (validEntry == false);

//            // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
//            animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
//            // get the pet's age. can be ? at initial entry. 
//            do
//            {
//                Console.WriteLine("Enter the pet's age or enter ? if unknown");
//                readResult = Console.ReadLine();
//                if (readResult != null)
//                {
//                    animalSpecies = readResult;
//                    if (animalSpecies != "?")
//                    {
//                        validEntry = int.TryParse(animalAge, out petAge);
//                    }
//                    else
//                    {
//                        validEntry = true;
//                    }
//                }
//            } while (validEntry == false);

//            // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
//            do
//            {
//                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
//                readResult = Console.ReadLine();
//                if (readResult != null)
//                {
//                    animalPhysicalDescription = readResult.ToLower();
//                    if (animalPhysicalDescription == "")
//                    {
//                        animalPhysicalDescription = "tbd";
//                    }
//                }
//            } while (animalPhysicalDescription == "");

//            // get a description of the pet's personality - animalPersonalityDescription can be blank.
//            do
//            {
//                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
//                readResult = Console.ReadLine();
//                if (readResult != null)
//                {
//                    animalPersonalityDescription = readResult.ToLower();
//                    if (animalPersonalityDescription == "")
//                    {
//                        animalPersonalityDescription = "tbd";
//                    }
//                }
//            } while (animalPersonalityDescription == "");

//            // get the pet's nickname. animalNickname can be blank.
//            do
//            {
//                Console.WriteLine("Enter a nickname for the pet");
//                readResult = Console.ReadLine();
//                if (readResult != null)
//                {
//                    animalNickname = readResult.ToLower();
//                    if (animalNickname == "")
//                    {
//                        animalNickname = "tbd";
//                    }
//                }
//            } while (animalNickname == "");

//            // store the pet information in the ourAnimals array (zero based)
//            ourAnimals[petCount, 0] = "ID #: " + animalID;
//            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
//            ourAnimals[petCount, 2] = "Age: " + animalAge;
//            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
//            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
//            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

//            while (anotherPet == "y" && petCount < maxPets)
//            {
//                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
//                petCount = petCount + 1;
//                // check maxPet limit
//                if (petCount < maxPets)
//                {
//                    // another pet?
//                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
//                    do
//                    {
//                        readResult = Console.ReadLine();
//                        if (readResult != null)
//                        {
//                            anotherPet = readResult.ToLower();
//                        }

//                    } while (anotherPet != "y" && anotherPet != "n");
//                }
//            }

//            if (petCount >= maxPets)
//            {
//                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
//                Console.WriteLine("Press the Enter key to continue.");
//                readResult = Console.ReadLine();
//            }

//            break;


//        case "3":
//            // Ensure animal ages and physical descriptions are complete
//            //
//            //    ourAnimals[i, 2] = "Age: " + animalAge;
//            //    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;

//            //Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//            //Console.WriteLine("Challenge Project - please check back soon to see progress.");

//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i,2] == "Age: ?"  && ourAnimals[i,0] == "ID #: ")
//                {
//                    do
//                    {
//                        Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
//                        readResult = Console.ReadLine();
//                        if (readResult != null)
//                        {
//                            animalAge = readResult;
//                            validEntry = int.TryParse(animalAge, out petAge);
//                        }
//                    } while (validEntry == false);
//                    ourAnimals[i, 2] = "Age: " + animalAge.ToString();
//                }
//                if (ourAnimals[i,4] == "Physical description: "  && ourAnimals[i,0] == "ID #:")
//                {
//                    do
//                    {
//                        Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]}");
//                        readResult = Console.ReadLine();
//                        if (readResult != null)
//                        {
//                            animalPhysicalDescription = readResult.ToLower();
//                            if (animalPhysicalDescription == "")
//                            {
//                                validEntry = false;
//                            }
//                            else
//                            {
//                                validEntry = true;
//                            }
//                        }

//                    } while (validEntry == false);
//                    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//                    }
//            }

//            Console.WriteLine("Age and physical description fields are complete for all of our animals");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "4":
//            // Ensure animal nicknames and personality descriptions are complete
//            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "5":
//            //  Edit an animal’s age
//            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "6":
//            // Edit an animal’s personality description
//            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "7":
//            // Display all cats with a specified characteristic
//            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;
//        case "8":
//            // Display all dogs with a specified characteristic
//            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;

//    }
//} while (menuSelection != "exit");

/* GUIDED PROJECT ENDS 
 * ________________________________________________________________________________________________________________________________________________________________________HERE________________________*/




//Console.WriteLine("Signed integral types:");

//Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
//Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
//Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
//Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

//Console.WriteLine("");
//Console.WriteLine("Unsigned integral types:");

//Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
//Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
//Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
//Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

//Console.WriteLine("");
//Console.WriteLine("Floating point types:");
//Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
//Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
//Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");



//string a = "5";
//string b = "99.57868675";
//decimal result = Convert.ToInt32(a) + decimal.Parse(b) ;
//Console.WriteLine(result);



/*  Challenge :-
Rule 1: If the value is alphabetical, concatenate it to form a message.

Rule 2: If the value is numeric, add it to the total.

Rule 3: The result should match the following output:
Message: ABCDEF
Total: 68.3
*/

//string[] values = { "12.3", "45", "ABC", "11", "DEF" };
//decimal totalNum = 0m;
//decimal totalValue = 0m;
//string message = "";
//string fMessage = "";
//for (int i = 0; i < values.Length; i++)
//{

//    if (decimal.TryParse(values[i], out totalNum))
//    {
//        totalValue += totalNum;
//    }
//    else
//    {
//        fMessage += values[i];
//    }



//}
//Console.WriteLine($"Message : {fMessage}");
//Console.WriteLine($"Total : {totalValue}");



/* Challenge 2 :-
 */

//int value1 = 12;
//decimal value2 = 6.6m;
//float value3 = 4.3f;

//// Your code here to set result1
//// Hint: You need to round the result to nearest integer (don't just truncate)
//int result1 = value1 / (int)value2;                                                             //i did wrong below is the correct method to do, my method will truncate the value2
//Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//int result11 = Convert.ToInt32((decimal)value1 / value2);
//Console.WriteLine($"Divide value1 by value2, display the result as an int: {result11}");

//// Your code here to set result2
//decimal result2 = value2 / (decimal)value3;
//Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//// Your code here to set result3
//float result3 = value3 / (float)value1;
//Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");



/* Challenge - Write code to reverse each word in a message 
 */
//using System;

//string pangram = "The quick brown fox jumps over the lazy dog";
//string[] splitArray = pangram.Split() ;
//string[] finalArray = new string[splitArray.Length];


//for (int cha = 0 ; cha < splitArray.Length; cha++)
//{  char[] chars = splitArray[cha].ToCharArray();
//    Array.Reverse(chars);
//    finalArray[cha] = new string (chars);
//}
//string result = string.Join(" ", finalArray);
//Console.WriteLine(result);



/* Challenge 2 - to parse a string of orders, sort the orders and tag possible errors
 */

//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
//string[] splitArray = orderStream.Split(",");
//string[] finalArray = new string[splitArray.Length];
//string[] orderID = new string[splitArray.Length];

//for(int i= 0; i < finalArray.Length; i++)
//{
//    char[] chars = splitArray[i].ToCharArray();
//    finalArray[i] = new string (chars);

//}

//Array.Sort(finalArray);

//for (int i = 0; i < finalArray.Length; i++)
//{
//    Console.WriteLine(finalArray[i]);
//}

//for (int i = 0;i < finalArray.Length; i++)
//{
//    if (finalArray[i].Length == 4)
//    {
//        Console.WriteLine($"OrderID - {finalArray[i]}");
//    }
//    else
//    {
//        Console.WriteLine($"OrderID - {finalArray[i]} -- Error");
//    }
//    orderID[i] = finalArray[i];
//}




/* Challenge -  To apply string interpolation to a form letter
 * Expected Output - 
 * Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   $55,000,000.00      
Glorious Future     13.13 %   $63,000,000.00
 */

//string customerName = "Ms. Barros";

//string currentProduct = "Magic Yield";
//int currentShares = 2975000;
//decimal currentReturn = 0.1275m;
//decimal currentProfit = 55000000.0m;

//string newProduct = "Glorious Future";
//decimal newReturn = 0.13125m;
//decimal newProfit = 63000000.0m;

//// Your logic here
//Console.WriteLine($"Dear {customerName} ");
//Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\r\n");
//Console.WriteLine($"Currently, you own {currentShares:N2} share at a return of {currentReturn:p2} % ");
//Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:p2} %.  Given your current volume, your potential profit would be {newProfit:c} .\r\n");

//Console.WriteLine("Here's a quick comparison:\n");

//string comparisonMessage = "";

//// Your logic here
//comparisonMessage = ($"{currentProduct}             {currentReturn:p2} %        {currentProfit:c} \n{newProduct}         {newReturn:p2} %        {newProfit:c} ");
//Console.WriteLine(comparisonMessage);




/* Challenge - To extract, replace, and remove data from an input string
 * Desired output - 
 * Quantity: 5000
 * Output: <h2>Widgets &reg;</h2><span>5000</span>
 */

//const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

//string quantity = "";
//string output = "";

//// Your work here
//const string spanOpen = "<span>";
//const string spanClose = "</span>";

//int spanOpening = input.IndexOf(spanOpen);
//int spanClosing = input.IndexOf(spanClose);
//spanOpening += spanOpen.Length ;
//int spanLength = spanClosing - spanOpening;
//quantity = input.Substring(spanOpening, spanLength);

//const string hopen = "<div>";
//const string hclose = "</div>";

//int hOpening = input.IndexOf(hopen);
//int hClosing = input.IndexOf(hclose);
//hOpening += hopen.Length ;
//output = input.Substring(hOpening, hClosing -  hOpening);
//output = input.Replace("&trade", "&reg");


//Console.WriteLine(quantity);
//Console.WriteLine(output);



/* Challenge ---------------------------------------------------------------------------------------------------------------------------
 * 
 */

//// ourAnimals array will store the following: 
//string animalSpecies = "";
//string animalID = "";
//string animalAge = "";
//string animalPhysicalDescription = "";
//string animalPersonalityDescription = "";
//string animalNickname = "";
//string suggestedDonation = "";

//// variables that support data entry
//int maxPets = 8;
//string? readResult;
//string menuSelection = "";
//decimal decimalDonation = 0.00m;

//// array used to store runtime data
//string[,] ourAnimals = new string[maxPets, 7];

//// sample data ourAnimals array entries
//for (int i = 0; i < maxPets; i++)
//{
//    switch (i)
//    {
//        case 0:
//            animalSpecies = "dog";
//            animalID = "d1";
//            animalAge = "2";
//            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
//            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//            animalNickname = "lola";
//            suggestedDonation = "85.00";
//            break;

//        case 1:
//            animalSpecies = "dog";
//            animalID = "d2";
//            animalAge = "9";
//            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//            animalNickname = "gus";
//            suggestedDonation = "49.99";
//            break;

//        case 2:
//            animalSpecies = "cat";
//            animalID = "c3";
//            animalAge = "1";
//            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//            animalPersonalityDescription = "friendly";
//            animalNickname = "snow";
//            suggestedDonation = "40.00";
//            break;

//        case 3:
//            animalSpecies = "cat";
//            animalID = "c4";
//            animalAge = "";
//            animalPhysicalDescription = "";
//            animalPersonalityDescription = "";
//            animalNickname = "lion";
//            suggestedDonation = "";

//            break;

//        default:
//            animalSpecies = "";
//            animalID = "";
//            animalAge = "";
//            animalPhysicalDescription = "";
//            animalPersonalityDescription = "";
//            animalNickname = "";
//            suggestedDonation = "";
//            break;

//    }

//    ourAnimals[i, 0] = "ID #: " + animalID;
//    ourAnimals[i, 1] = "Species: " + animalSpecies;
//    ourAnimals[i, 2] = "Age: " + animalAge;
//    ourAnimals[i, 3] = "Nickname: " + animalNickname;
//    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

//    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
//    {
//        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
//    }
//    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
//}

//// top-level menu options
//do
//{
//    // NOTE: the Console.Clear method is throwing an exception in debug sessions
//    Console.Clear();

//    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//    Console.WriteLine(" 1. List all of our current pet information");
//    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
//    Console.WriteLine();
//    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//    readResult = Console.ReadLine();
//    if (readResult != null)
//    {
//        menuSelection = readResult.ToLower();
//    }

//    // switch-case to process the selected menu option
//    switch (menuSelection)
//    {
//        case "1":
//            // list all pet info
//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i, 0] != "ID #: ")
//                {
//                    Console.WriteLine();
//                    for (int j = 0; j < 7; j++)
//                    {
//                        Console.WriteLine(ourAnimals[i, j].ToString());
//                    }
//                }
//            }

//            Console.WriteLine("\r\nPress the Enter key to continue");
//            readResult = Console.ReadLine();

//            break;

//        case "2":
//            // #1 Display all dogs with a multiple search characteristics

//            string dogCharacteristics = "";

//            while (dogCharacteristics == "")
//            {
//                // #2 have user enter multiple comma separated characteristics to search for
//                Console.WriteLine($"\r\nEnter one desired dog characteristic to search for");
//                readResult = Console.ReadLine();
//                if (readResult != null)
//                {
//                    dogCharacteristics = readResult.ToLower().Trim();
//                    Console.WriteLine();
//                }
//            }
//            string[] dogSearches = dogCharacteristics.Split(",");
//            // trim leading and trailing spaces from each search term
//            for (int i = 0; i < dogSearches.Length; i++)
//            {
//                dogSearches[i] = dogSearches[i].Trim();
//            }

//            Array.Sort(dogSearches);

//            bool matchesAnyDog = false;
//            string dogDescription = "";

//            // #4 update to "rotating" animation with countdown
//            string[] searchingIcons = { " /", " | ","\"", "==", " //"};

//            // loop ourAnimals array to search for matching animals
//            for (int i = 0; i < maxPets; i++)
//            {

//                if (ourAnimals[i, 1].Contains("dog"))
//                {

//                    // Search combined descriptions and report results
//                    dogDescription = ourAnimals[i, 4] + "\r\n" + ourAnimals[i, 5];
//                    bool matchesCurrentDog = false;

//                    foreach (string term in dogSearches)
//                    {
//                        if (term != null && term.Trim() != "")
//                        {
//                            for (int j = 2; j > -1; j--)
//                            {
//                                // #5 update "searching" message to show countdown 
//                                foreach (string icon in searchingIcons)
//                                {
//                                    Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {dogCharacteristics} {icon}");
//                                    Thread.Sleep(250);
//                                }

//                                Console.Write($"\r{new String(' ', Console.BufferWidth)}");
//                            }

//                            // #3a iterate submitted characteristic terms and search description for each term

//                            if (dogDescription.Contains(term.Trim()))
//                            {
//                                // #3b update message to reflect term 
//                                // #3c set a flag "this dog" is a match
//                                Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match for {term.Trim()}");

//                                matchesCurrentDog = true;
//                                matchesAnyDog = true;
//                            }
//                        }
//                    }
//                    // #3d if "this dog" is match write match message + dog description



//                    if (matchesCurrentDog)
//                    {
//                        Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
//                    }
//                }
//            }
//            if (!matchesAnyDog)
//            {
//                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristics);
//            }

//            Console.WriteLine("\n\rPress the Enter key to continue");
//            readResult = Console.ReadLine();

//            break;

//        default:
//            break;
//    }

//} while (menuSelection != "exit");





/*A valid IPv4 address consists of four numbers separated by dots
    Each number must not contain leading zeroes
    Each number must range from 0 to 255

1.1.1.1 and 255.255.255.255 are examples of valid IP addresses.*/

//string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
//string[] address;
//bool validLength = false;
//bool validRange = false;
//bool validZeros = false;

//foreach (string number in ipv4Input)
//{
//    address = number.Split('.', StringSplitOptions.RemoveEmptyEntries);
//    ValidateLength();
//    ValidateZeros();
//    ValidateRange();

//    if (validLength && validRange && validZeros)
//    {
//        Console.WriteLine($"This ip is a valid IPv4 address          --        {number}");
//    }
//    else
//    {
//        Console.WriteLine($"This ip is an invalid IPv4 address       --        {number}");
//    }
//}
//void ValidateLength() 
//{
//    validLength = address.Length == 4;
//};
//void ValidateRange() 
//{
//    foreach(string number in address)
//    {
//        int value = int.Parse(number);
//        if(value < 0 || value > 255)
//        {
//            validRange = false;
//            return;
//        }

//    }
//    validRange = true;
//}
//void ValidateZeros() 
//{
//    foreach (string number in address)
//    {
//        if(number.Length > 1 && number.StartsWith("0"))
//        {
//            validZeros = false;
//            return;
//        }
//    }
//    validZeros = true;
//}




/* Challenge - Resuable method Tell a fortune _________________________________________________________________________________________________________ 
 * 
 */

//Random random = new Random();
//int luck = random.Next(100);

//string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };

//string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
//string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
//string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };


//Display();
//luck = random.Next(100);
//Display();

//void Display()
//{
//    Console.WriteLine("A fortune teller whispers the following words:");
//    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//    for (int i = 0; i < 4; i++)
//    {
//        Console.Write($"{text[i]} {fortune[i]} \n");
//    }
//    Console.WriteLine("");
//}



/*Challenge              ----------------------------------------------------------------------------------------------------------------------------------
 * Desire Output : 
robavin@contoso.com
sibright@contoso.com
kisinclair@contoso.com
aakamath@contoso.com
sadelucchi@contoso.com
siali@contoso.com
viashton@hayworth.com
codysart@hayworth.com
shlawrence@hayworth.com
davaldes@hayworth.com
 *
 */

//string[,] corporate =
//{
//    {"Robert", "Bavin"}, {"Simon", "Bright"},
//    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
//};

//string[,] external =
//{
//    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
//};

//string externalDomain = "hayworth.com";
//string internalDomain = "contoso.com";

//for (int i = 0; i < corporate.GetLength(0); i++)
//{
//    // display internal email addresses
//    for (int j = 0; j < 1; j++)
//    {
//        string email = corporate[i, 0].Substring(0, 2) + corporate[i,1] ;
//        string finalEmail = email.ToLower();
//        Console.WriteLine($"{finalEmail}@{internalDomain}");

//    }

//}

//for (int i = 0; i < external.GetLength(0); i++)
//{
//    // display external email addresses
//    for(int j = 0; j < 1; j++)
//    {
//        string email = external[i, 0].Substring(0, 2) + external[i, 1];
//        string finalEmail = email.ToLower();
//        Console.WriteLine($"{finalEmail}@{externalDomain}");
//    }
//}



/* Challenge - 
 * Your challenge is to create the ShouldPlay and WinOrLose methods, and create methods that set target and roll to random values in the correct range. 
 * When all the methods are complete, the game should run successfully.
 * ShouldPlay: This method should retrieve user input and determine if the user wants to play again 
 * WinOrLose: This method should determine if the player has won or lost
 *
 */

//Random random = new Random();

//Console.WriteLine("Would you like to play? (Y/N)");
//if (ShouldPlay() == true)
//{
//    PlayGame();
//}
//if (ShouldPlay() == false)
//{
//    Console.WriteLine("Exiting");
//    return;
//}

//string WinOrLose(int Target , int Roll)
//{
//    if(Target < Roll)
//    {
//        return "Won";
//    }
//    else
//    {
//        return "Lose";
//    }
//}
//void PlayGame()
//{
//    var play = true;

//    while (play)
//    {
//        var target = random.Next(1,5);
//        var roll = random.Next(1,6);

//        Console.WriteLine($"Roll a number greater than {target} to win!");
//        Console.WriteLine($"You rolled a {roll}");
//        Console.WriteLine(WinOrLose(target,roll));
//        Console.WriteLine("\nPlay again? (Y/N)");

//        play = ShouldPlay();
//    }
//}

//bool ShouldPlay()
//{
//    string result0 = Console.ReadLine();
//    string result = result0.ToLower();
//    if(result == "y")
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}




/* Challenge ---
 * Expected Output :
 * - The code declares the following variables:
    - Variables to determine the size of the Terminal window.
    - Variables to track the locations of the player and food.
    - Arrays `states` and `foods` to provide available player and food appearances
    - Variables to track the current player and food appearance

- The code provides the following methods:
    - A method to determine if the Terminal window was resized.
    - A method to display a random food appearance at a random location.
    - A method that changes the player appearance to match the food consumed.
    - A method that temporarily freezes the player movement.
    - A method that moves the player according to directional input.
    - A method that sets up the initial game state.

- The code doesn't call the methods correctly to make the game playable. The following features are missing:
    - Code to determine if the player has consumed the food displayed.
    - Code to determine if the food consumed should freeze player movement.
    - Code to determine if the food consumed should increase player movement.
    - Code to increase movement speed.
    - Code to redisplay the food after it's consumed by the player.
    - Code to terminate execution if an unsupported key is entered.
    - Code to terminate execution if the terminal was resized.
 * 
*/

//Random random = new Random();
//Console.CursorVisible = false;
//int height = Console.WindowHeight - 1;
//int width = Console.WindowWidth - 5;
//bool shouldExit = false;

//// Console position of the player
//int playerX = 0;
//int playerY = 0;

//// Console position of the food
//int foodX = 0;
//int foodY = 0;

//// Available player and food strings
//string[] states = {"('-')", "(^-^)", "(X_X)"};
//string[] foods = {"@@@@@", "$$$$$", "#####"};

//// Current player string displayed in the Console
//string player = states[0];

//// Index of the current food
//int food = 0;


//InitializeGame();

//while (!shouldExit) 
//{
//    Move();
//}

//// Returns true if the Terminal was resized 
//bool TerminalResized() 
//{   
//    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
//}

//// Displays random food at a random location
//void ShowFood() 
//{
//    // Update food to a random index
//    food = random.Next(0, foods.Length);
//    // Update food position to a random location
//    foodX = random.Next(0, width - player.Length);
//    foodY = random.Next(0, height - 1);

//    // Display the food at the location
//    Console.SetCursorPosition(foodX, foodY);
//    Console.Write(foods[food]);
//}

//// Changes the player to match the food consumed
//void ChangePlayer() 
//{

//    player = states[food];
//    Console.SetCursorPosition(playerX, playerY);
//    Console.Write(player);
//}

//// Temporarily stops the player from moving
//void FreezePlayer() 
//{
//    if (player == states[2])
//    {
//        System.Threading.Thread.Sleep(1000);
//        player = states[0];
//    }
//}

//// Reads directional input from the Console and moves the player
//void Move() 
//{
//    int lastX = playerX;
//    int lastY = playerY;

//    if (TerminalResized() == false)
//    {
//        //InitializeGame();
//        switch (Console.ReadKey(true).Key)
//        {
//            case ConsoleKey.UpArrow:
//                playerY--;
//                break;
//            case ConsoleKey.DownArrow:
//                playerY++;
//                break;
//            case ConsoleKey.LeftArrow:
//                playerX--;
//                break;
//            case ConsoleKey.RightArrow:
//                playerX++;
//                break;
//            case ConsoleKey.Escape:
//                shouldExit = true;
//                break;
//            default:
//                shouldExit = true;
//                break;
//        }
//        FreezePlayer();
//    }
//    else
//    {
//        Console.WriteLine(" Console was resized. Program exiting  \n ");
//        shouldExit = true;
//    }

//    // Clear the characters at the previous position
//    Console.SetCursorPosition(lastX, lastY);
//    for (int i = 0; i < player.Length; i++) 
//    {
//        Console.Write(" ");
//    }

//    // Keep player position within the bounds of the Terminal window
//    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
//    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

//    // Draw the player at the new location
//    Console.SetCursorPosition(playerX, playerY);
//    Console.Write(player);


//}

//// Clears the console, displays the food and player
//void InitializeGame() 
//{
//    Console.Clear();
//    ShowFood();
//    ChangePlayer();
//    //Console.SetCursorPosition(0, 0);
//    //Console.Write(player);
//}



/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
//int x = 5;

//x = ChangeValue(x);

//Console.WriteLine(x);

//int ChangeValue(int value)
//{

//    value = 10;
//    return value;
//}



// EXCEPTION ------                     DivideByZeroException
//try
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;

//    Console.WriteLine(float1 / float2);
//    Console.WriteLine(number1 / number2);
//    Console.WriteLine("Exit program");
//}
//catch
//{
//    Console.WriteLine("CANT DIVIDE BY ZERO");
//}



/* Exception Handling Challenge --------------------------     System.DivideByZeroException ---------------------------Using Try-Catch
 */

//try
//{
//    Process1();
//}
//catch
//{
//    Console.WriteLine("An exception has occurred");
//}

//Console.WriteLine("Exit program");

//static void Process1()
//{
//    try
//    {
//        WriteMessage();
//    }
//    catch(Exception ex)
//    {
//        Console.WriteLine($"Exception caught in Process1    {ex.Message}");
//    }
//}

//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;

//    Console.WriteLine(float1 / float2);
//    Console.WriteLine(number1 / number2);
//}

/* 2nd CHALLENGE 
 * 
 * 
 */
//try
//{
//    try
//    {
//        int num1 = int.MaxValue;
//        int num2 = int.MaxValue;
//        int result = num1 + num2;
//        Console.WriteLine("Result: " + result);
//    }
//    catch (OverflowException ex)
//    {
//        Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
//    }
//    try
//    {
//        string str = null;
//        string length = str.Length;
//        Console.WriteLine("String Length: " + length);
//    }
//    catch (NullReferenceException ex)
//    {
//        Console.WriteLine("Error: The reference is null." + ex.Message);
//    }

//    try
//    {
//        int[] numbers = new int[5];
//        numbers[5] = 10;
//        Console.WriteLine("Number at index 5: " + numbers[5]);
//    }
//    catch (IndexOutOfRangeException ex)
//    {
//        Console.WriteLine("Error: Index out of range." + ex.Message);
//    }

//    try
//    {
//        int num3 = 10;
//        int num4 = 0;
//        int result2 = num3 / num4;
//        Console.WriteLine("Result: " + result2);
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
//    }

//}
//catch
//{
//    Console.WriteLine("Exiting program.");
//}




/* INHERITANCE  
 *                                                                                                                                  MAKE THE VIDEO ON EXPLANING CONSTRUCTOR FOR LEARN IN PUBLIC
 * */

//using System;
//namespace testingDotNetMicrosoftLearningCodes
//{
//    class AnimalKingdom
//    {
//        class Animal
//        {
//            public string? name;
//            public int age;
//            public int spotCounts;
//            public float happiness;
//            public float cuteness;


//            public void PrintBase()             //  METHOD of Return-Type Void
//            {
//                Console.WriteLine($"Name       -  " + name);
//                Console.WriteLine($"Age        -  " + age);
//                Console.WriteLine($"Happiness  -  " + happiness);
//                Console.WriteLine($"Cuteness   -  " + cuteness);
//                Console.WriteLine($"Spotcounts -  " + spotCounts);
//            }
//        }

//        class Dog : Animal                  //  Class named "DOG"  inheriting all the properties of class named "Animal"      its known as inheritence
//        {
//            public int spotCount;
//            public Dog(string _name, int _age, float _happiness, float _cuteness, int _spotCount)    // Its a CONSTRUCTOR
//            {
//                name = _name;
//                age = _age;
//                happiness = _happiness;
//                cuteness = _cuteness;
//                spotCounts = _spotCount;
//            }
//            public void Bark()                  // Method
//            {
//                Console.WriteLine("WUF");
//            }
//        }
//        class Cat : Animal
//        {
//            public float spotCount;
//            public Cat(string _name, int _age, float _happiness, float _cuteness, int _spotCount)
//            {
//                name = _name;
//                age = _age;
//                happiness = _happiness;
//                cuteness = _cuteness;
//                spotCount = _spotCount;
//            }
//            public void Meow()
//            {
//                Console.WriteLine("Meow");
//            }
//        }
//        public static void Main(string[] args)
//        {
//            Dog spotty = new Dog("Spotty", 4, 0.8f, 0.4f, 25);
//            spotty.PrintBase();
//            spotty.Bark(); ;

//            Console.WriteLine();
//            Console.WriteLine();


//            Cat heisenberg = new Cat("Heisenberg", 13, 0.3f, 0.4f, 2);
//            heisenberg.PrintBase();
//            heisenberg.Meow();

//            Console.ReadKey();
//        }
//    }
//}



//// using trial division method
//using System;
//using System.Diagnostics;

//class HelloWorld
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter till you want to find Prime Numbers");
//        int limit = Convert.ToInt32(Console.ReadLine());
//        int count = 0;

//        Stopwatch stopwatch = new Stopwatch();
//        stopwatch.Start();
//        for (int i = 2; i <= limit; i++)
//        {
//            for (int j = 2; j <= i - 1; j++)
//            {
//                if (i % j == 0)
//                    count++;

//            }

//            if (count == 0)
//            {
//                Console.WriteLine(i);

//            }
//            count = 0;
//        }
//        stopwatch.Stop();
//        TimeSpan elaspedTime = stopwatch.Elapsed;
//        Console.WriteLine($"Elapsed Time    -    {elaspedTime}");
//        Console.WriteLine($"For finding prime numbers till  - {limit}");                //Elapsed Time    -    00:00:20.2490548
//                                                                                        //For finding prime numbers till - 99999
//    }
//}

//using sieve of eratosthenes alogorithm
using System;
using System.Diagnostics;

namespace primeProgram
{   class Main
    {
        static void Main(string[] args)
        {
            int limit = 0;
                                                                            
            Console.WriteLine("Enter till you want to find Prime Numbers");
            limit = int.Parse(Console.ReadLine());
                                                                                    
            int[] arr1 = new int[limit+1];                                                                  

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 2; i*i <= limit; i++)                                                      // iterates from 2 to user given limit
            {
                if (arr1[i] == 0)                                                                   // array to check the value condition , as if the prime value will be 0, like arr1[2] will be 0 as its a prime
                    for(int j = i*i; j <= limit; j += i )                                           // arr2[2] , j = 2X2 = 4 ; 4 <= limit ; j = 6 .  
                    {
                        arr1[j] = 1;                                                                // now all the squares will be marked OR assigned value 1 while prime numbers will have value 0
                    }
            }

            for(int i = 2; i <=limit; i++)                                                          // Printing the array value Prime Number
            {
                if (arr1[i] == 0)
                    Console.WriteLine($"{i}");
            }

            stopwatch.Stop();
            TimeSpan elaspedTime = stopwatch.Elapsed;

            Console.WriteLine($"Elasped Time     -  {elaspedTime} ");
            Console.WriteLine($"For finding prime numbers till   -  {limit}");                      //Elasped Time     -00:00:00.4988328
                                                                                                    //For finding prime numbers till - 99999

        }

    }
}

