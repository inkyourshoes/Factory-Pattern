using System.Security.Cryptography.X509Certificates;

namespace FactoryPattern;

public class ConsoleLogging
{
    public static void VehicleStartUpDialogue()
    {
        Console.WriteLine("Put key in ignition");
        Thread.Sleep(1000);
        Console.WriteLine("Turn the Key!");
        Thread.Sleep(1000); 
        
    }
}