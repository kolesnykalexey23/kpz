namespace ConsoleDiya;

public class CopyAction : IDocumentAction
{
    public void Action(int info)
    {
        Console.WriteLine($"Копіюємо код {info}"); //(або викликаю тут метод для копіювання)
    }
}