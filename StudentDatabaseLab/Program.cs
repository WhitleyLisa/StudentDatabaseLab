// Student Database Demo!

Console.WriteLine("Hello and welcome to our student database!");

Console.WriteLine();

string[] nameOfStudent = new string[] { "Alex", "Lillieanne", "Juane", "Sabina", "Hans" };

string[] hometownOfStudent = new string[] { "Abington", "Colorado Springs", "Kalamazoo", "Heidelberg", "Tilburg" };

string[] studentsFavoriteFood = new string[] { "Mexican", "puree'd strawberries and bananans", "Chicken Curry", "Pasta", "Indian" };

var repeat = true;


Console.WriteLine();

while (repeat)
{
    Console.WriteLine("Please enter the number assoicated with the student you would like to learn about today:" +
        "\n1. Alex" +
        "\n2. Lillieanne" +
        "\n3. Juane" +
        "\n4. Sabina " +
        "\n5. Hans");

    Console.WriteLine();

    var chosenName = Console.ReadLine();

    Console.WriteLine();

    int nameSelected;

    bool realName = int.TryParse(chosenName, out nameSelected);

    string showError = "That was not a valid entry - please select the number associated with a student above that you would like to learn more about!";

    if (realName && nameSelected > 0 && nameSelected <= nameOfStudent.Length)
    {
        int namesChosen = nameSelected - 1;

        var goAgain = true;

        while (goAgain)
        {
            Console.WriteLine($"Please choose from the follwoing information you would like to learn about our student {nameOfStudent[namesChosen]}:" +
            "\nHometown" +
            "\nFavorite food");
            Console.WriteLine();
            var informationChosen = Console.ReadLine();
            Console.WriteLine();


            if (informationChosen.ToLower() == "hometown")
            {
                Console.WriteLine($"{nameOfStudent[namesChosen]}'s hometown is {hometownOfStudent[namesChosen]}!");
                goAgain = false;

                Console.WriteLine();
            }
            else if (informationChosen.ToLower() == "favorite food" || informationChosen == "Favorite Food")
            {
                Console.WriteLine($"{nameOfStudent[namesChosen]}'s favorite food is {studentsFavoriteFood[namesChosen]}!");
                goAgain = false;

                Console.WriteLine();
            }
            else
                Console.WriteLine(showError);

            Console.WriteLine();
        }
    }
    else
        Console.WriteLine(showError);

    Console.WriteLine("Would you like to learn about another student today? (y/n)");

    var tryAgain = Console.ReadLine();
    if (tryAgain == "n")
        repeat = false;

    Console.WriteLine();

    Console.WriteLine("Thank you for learning about our students! Goodbye!");

}
        