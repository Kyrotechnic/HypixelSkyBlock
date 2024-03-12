namespace Atlas.Logger;

public interface IDebugger : ILogger
{
    public void WriteDebug(string line);
    public void WriteInfo(string line);
    public void WriteError(string line);
    public void WriteWarning(string line);
}