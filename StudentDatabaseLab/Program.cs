//make arrays with student info
string[] name = { "Justin Jones", "Connor Wood", "Kris Pranger", "Josh Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali Al-Hashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt", "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi" };
string[] faveFood = { "Baja Blast", "Chicken Sandwich", "Sushi", "Naleśniki", "Sushi", "General Tso's", "Jerk chicken", "Steak", "Sushi", "Rice and Dodo", "Bread", "Steak", "BBQ", "Thai", "tacos", "Pasta", "Pounded Yam" };
string[] hometown = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI", "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };
bool runProgram = true;
while (runProgram)
{
    //get index from user
    Console.WriteLine($"Welcome to the student database!\nWhich student would you like to learn more about?\nEnter a number 1 - {name.Length}, enter a student's name, or enter \"all\" to view the list of all students.");
    string input = Console.ReadLine();
    int index = -1;
    if (input.ToLower().Trim() == "all")
    {
        listAll(name);
        continuePrompt(ref runProgram);
        continue;
    }
    else if (input.Any(char.IsDigit))
    {
        index = int.Parse(input) - 1;
    }
    else
    { 
        index = Array.IndexOf(name, input);
    }
    if (index < 0 || index > name.Length - 1)
    {
        Console.WriteLine("Student number or name not found in the database.");
        continue;
    }
    
        //ask user what piece of info they want
        Console.WriteLine($"Student {index + 1} is {name[index]}. What would you like to know? Enter \"hometown\" or \"favorite food\":");
    while (true)
    {
        string choice = Console.ReadLine();
        //display info of user's choice
        if (choice.ToLower().Trim().Contains("home") || choice.ToLower().Trim().Contains("town"))
        {
            Console.WriteLine(hometown[index]);
            break;
        }
        else if (choice.ToLower().Trim().Contains("food") || choice.ToLower().Trim().Contains("fav"))
        {
            Console.WriteLine(faveFood[index]);
            break;
        }
        else
        {
            //handle unaccepted response
            Console.WriteLine("That category does not exist.Please try again. Enter \"hometown\" or \"favorite food\": ");
            continue;
        }
    }
    //ask if user wants to continue
    continuePrompt(ref runProgram);
}

//Methods
//method to ask if user wants to run program again in middle
static void continuePrompt(ref bool run)
{
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("Would you like to continue searching the student database? (yes/y, no/n)");
        string restart = Console.ReadLine();
        if (restart.ToLower().Trim() == "yes" || restart.ToLower().Trim() == "y")
        {
            break;
        }
        else if (restart.ToLower().Trim() == "no" || restart.ToLower().Trim() == "n")
        {
            run = false;
            break;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Please enter yes/y or no/n");
            continue;
        }
    }
}
//method to display list of all students
static void listAll(string[] str)
{
    foreach (string s in str)
    {
        Console.WriteLine((Array.IndexOf(str, s) +1) + " " + s);
    }
}