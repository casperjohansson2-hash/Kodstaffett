internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== KARAKTÄRSGENERATOR ===");

        Console.Write("Vad heter din karaktär? "); 
        string namn = Console.ReadLine(); //Deklarerar variabler
        int val = 0;
        bool ickeGodkänd = true;
                                                    //Skriver ut listan av karaktärer man får välja i konsolen
        Console.WriteLine("Välj karaktärstyp:");
        Console.WriteLine("1. Krigare");
        Console.WriteLine("2. Magiker");
        Console.WriteLine("3. Tjuv");
        Console.WriteLine("4. Bågskytt");
        Console.WriteLine("5. Alchemist");
        Console.WriteLine("6. Egen");

        Console.Write("Ditt val: ");//Låter användaren välja sin typ, och kommer använda sig av catch ifall det finns risk för en krasch
        while (ickeGodkänd)
        {
            try
            {
                val = Convert.ToInt32(Console.ReadLine());
                ickeGodkänd = false;
            }
            catch
            {
                Console.WriteLine("Var god och skriv nummer 1, 2 eller 3.");
            }
        }
        string karaktärstyp = "";//Om användaren väljer 6, alltså vill skriva en egen ras, så deklarerar vi en variabel här för användaren att fylla i

        if (val == 1)           //Omvandlar användaren val i siffror, till den motsvarande typen
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
                Console.WriteLine("Vänligen skriv vilken karaktärtyp du vill vara:"); //Skriver och läser av vilken typ som användaren valt att skriva själv
                karaktärstyp = Console.ReadLine();
            }
            catch 
            {
                Console.WriteLine("Ej tillåtet."); //Stannar användaren ifall programmet riskerar att krascha
            }
        }
        else
        {

            karaktärstyp = "Okänd"; //Om användaren på något vänster lyckas ta sig förbi den första catchen, så ersätts karaktärstypen med "Okänd"
        }

        Console.WriteLine(); // Skriver ut resultatet till användaren i konsolen
        Console.WriteLine("=== DIN KARAKTÄR ===");
        Console.WriteLine("Namn: " + namn);
        Console.WriteLine("Typ: " + karaktärstyp);
    }
}