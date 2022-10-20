/*
Carlos Felipe 
10/20/22
Mini Challenge #1 - Say Hello
I wrote some code that prints out a prompt.
It then saves the user's input as a variable.
It then prints out another response plus the user's name.
*/

Console.Clear();

bool run = true;
string runChoice;

while(run){
Console.Write("What is your name?: ");
string userInput = Console.ReadLine();
if(userInput == ""){
    Console.WriteLine("Hello blank.");
}
else{
    Console.WriteLine($"Hello {userInput}!");
}

Console.Write("Run program again?: \nYES or NO: ");
runChoice = Console.ReadLine().ToUpper();

while(runChoice != "NO" && runChoice != "YES"){
    Console.Write("I said 'YES' or 'NO' \nTry again: ");
    runChoice = Console.ReadLine().ToUpper();
}

if(runChoice == "YES"){
    run = true;
}
else{
    run = false;
    Console.WriteLine("Okay goodbye.");
}
}