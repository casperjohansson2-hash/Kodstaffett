internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== KARAKTÄRSGENERATOR ===");

        Console.Write("Vad heter din karaktär? ");
        string namn = Console.ReadLine();

        Console.WriteLine("Välj karaktärstyp:");
        Console.WriteLine("1. Krigare");
        Console.WriteLine("2. Magiker");
        Console.WriteLine("3. Tjuv");

        Console.Write("Ditt val: ");
        int val = Convert.ToInt32(Console.ReadLine());

        string karaktärstyp = "";

        if (val == 1)
        {
            karaktärstyp = "Krigare";
        }
        else if (val == 2)
        {
            karaktärstyp = "Magiker";
        }
        else if (val == 3)
        {
            karaktärstyp = "Tjuv";
        }
        else
        {

            karaktärstyp = "Okänd";
        }

        Console.WriteLine();
        Console.WriteLine("=== DIN KARAKTÄR ===");
        Console.WriteLine("Namn: " + namn);
        Console.WriteLine("Typ: " + karaktärstyp);
    }
}