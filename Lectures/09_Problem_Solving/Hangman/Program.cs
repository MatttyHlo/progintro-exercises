using System.Runtime.InteropServices;

string word = "hangman";
string show = "";

foreach (char l in word) {
    show = show + "_";
}
int lives = 6;

while (lives > 0)
{
    Console.WriteLine("--------------");
    Console.WriteLine(lives);
    Console.WriteLine(show);
    Console.WriteLine("Guess");
    char input = Console.ReadKey().KeyChar;
    bool found = false;
    for (int i = 0; i < word.Length; i++)
    {
        if (input == word[i])
        {
            string nShow = "";
            for (int j = 0; j < show.Length; j++)
            {
                if (i == j) nShow = nShow + input;
                else nShow = nShow + show[j];
            }
            show = nShow;
            found = true;
        }
    }
    if (!found) lives--;
    if (!show.Contains('_'))
    {
        Console.WriteLine("Succes");
        break;
    }
}
if (lives == 0) Console.WriteLine("Fail");