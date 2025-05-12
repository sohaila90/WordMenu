namespace WordMenu;

public class Menu
{
    public void Run()
    {
    Console.WriteLine("1-RotateText");
    Console.WriteLine("2-Change Word");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine("Skriv inn et ord");
            string input2 = Console.ReadLine();
            Console.WriteLine(RotateText(input2));
        break;
        case "2":
            Console.WriteLine("Skriv inn et ord som inneholder a for å bytte til bokstav e");
            string input3 = Console.ReadLine();
            Console.WriteLine(ChangeWord(input3));
            break;
        default:
            Run();
            break;
    }
    }

    public string RotateText(string text)
    {
        string result = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            result += text[i];
        }
        return result;
    }

    public string ChangeWord(string text)
    {
        string result = "";
        for (int i = text.Length; i < 1; i++)
        {
           // if ()
           {
                
           }
           return result;
        }
        return result;
    }
}