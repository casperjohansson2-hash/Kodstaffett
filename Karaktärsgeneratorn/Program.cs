internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== KARAKTÄRSGENERATOR ===");

        Console.Write("Vad heter din karaktär? ");
        string namn = Console.ReadLine();
        int val = 0;

        Console.WriteLine("Välj karaktärstyp:");
        Console.WriteLine("1. Krigare");
        Console.WriteLine("2. Magiker");
        Console.WriteLine("3. Tjuv");
        Console.WriteLine("4. Bågskytt");
        Console.WriteLine("5. Alchemist");
        Console.WriteLine("6. Egen");

        Console.Write("Ditt val: ");
        try 
        { 
            val = Convert.ToInt32(Console.ReadLine()); 
        }
        catch
        {
            Console.WriteLine("Var god och skriv nummer 1, 2 eller 3.");
        }

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
        else if (val == 4)
        {
            karaktärstyp = "Bågskytt";
        }
        else if (val == 5)
        {
            karaktärstyp = "Alchemist";
        }
        else if (val == 6)
        {
            
            try 
            {
                Console.WriteLine("Vänligen skriv vilken karaktärtyp du vill vara:");
                karaktärstyp = Console.ReadLine();
            }
            catch 
            {
                Console.WriteLine("Ej tillåtet.");
            }
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