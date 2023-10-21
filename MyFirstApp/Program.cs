// this is a comment to my code

//Rakendus küsib kasutaja sisestada oma nime

Console.WriteLine("Enter you name:"); //output
//string - sõne
string userName = Console.ReadLine(); //input
// = - salvesta


//rakendus tervitav kasutajat nimepidi
Console.WriteLine("Hello" + ", " + userName + "!"); //output
// string interpolation
Console.WriteLine($"Hello, {userName}!"); //output

