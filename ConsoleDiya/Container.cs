namespace ConsoleDiya;

public class Container
{
    private IEnumerable<IDocument> _documents;

    public Container(IEnumerable<IDocument> documents)
    {
        _documents = documents;
    }

    public void SortDocuments()
    {
        Console.WriteLine("сортування за 1 параметром");
    }
    public void CustomSortDocuments()
    {
        Console.WriteLine("сортування за іншим параметром");
    }

    public void ShowDocumentsInfo()
    {
        foreach (var document in _documents)
        {
            document.ShowName();
            document.ShowPhoto();
        }
    }
    
}