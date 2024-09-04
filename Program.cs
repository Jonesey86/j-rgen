using System.Numerics;


namespace jørgen;

class Program
{
    static void Main(string[] args)
    {
        // string datatype variabel
        string helloWorld = "Hello, World!";
        // heltall variabel
        int myNumber = 10;
        // desimaltall/double variabel
        double myDecimal = 10.25;
        // bruker Console klassen til å skrive ut til terminalen
        Console.WriteLine(helloWorld);
        Console.WriteLine(myNumber);
        Console.WriteLine(myDecimal);
        
        // Skriver ut en melding til brukeren 
        Console.WriteLine("Hei, hva heter du? ");
        // string variabel navn holder på verdien vi gir til konsollen
        string? navn = Console.ReadLine();
        // skriver ut en liten melding + navnet som er gitt til konsollen
        Console.WriteLine("Hei " + navn);

        // char typen, tar en bestemt bokstav
        // char a = '@';
        // Console.WriteLine(a);
        /* vi lager et nytt array med å kalle på firkantparanteser
           vi tildeler først en type, i dette tilfelle string etterfulgt av []
           string[] <- string array, int[] <- int(heltall) array
           og vi "populerer" arrayet med verdier inne i {} klammeparanteser.
        */
        /*
        
        */

        string[] myStringArray = {"Hello", "C#", "Array!"};
        for(int i = 0; i < myStringArray.Length; i = i + 1) 
        {
            Console.WriteLine(myStringArray[i]);
        }

        // List blir en datastruktur/klasse som "utvider" array. Vi kan legge til flere verdier i listen med
        // Add() metoden f.eks: myNumbers.Add(4);
        
        // List<int> myNumbers = new List<int>();
        // myNumbers.Add(1);
        // myNumbers.Add(2);
        // myNumbers.Add(3);
        // myNumbers.Add(4);
        // for(int i = 0; i < myNumbers.Count(); i++) 
        // {
        //     Console.WriteLine(myNumbers[i]);
        // }

        // switch(statement) case

    
        string? greetings = Console.ReadLine();
        switch(greetings) 
        {
            case "Hei":
                Console.WriteLine("Hei terminal!");
                break;
            case "hade":
                Console.WriteLine("Hadebra terminal!");
                break;
            default:
                Console.WriteLine("Alrighty");
                break;
        }
    }
}
    
    

