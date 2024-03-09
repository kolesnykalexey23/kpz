namespace ConsoleDiya;

public class DriverLicenseAction :IDocumentAction
{
    public void Action(int info)
    {
        Console.WriteLine($"Права потрібно буде оновити через {info} днів");
    }
}