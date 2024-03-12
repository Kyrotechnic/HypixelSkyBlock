namespace Atlas.Logger;

public class AtlasLogger : ILogger
{
    public string prefix {get; private set;}
    public AtlasLogger(string prefix)
    {
        this.prefix = prefix;
    }
    public void Write(string line) => Console.Write(prefix + " " + line);

    public void WriteLine(string line) => Console.WriteLine(prefix + " " + line);
}