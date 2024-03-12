namespace Atlas.Logger;

public class DebugLogger : AtlasLogger, IDebugger
{
    public bool IsDebug;
    public DebugLogger(string prefix, bool debug = true) : base(prefix)
    {
       IsDebug = debug; 
    }

    public void WriteDebug(string line) => WriteLine((IsDebug ? "[DEBUG] " : "") + line);

    public void WriteError(string line) => WriteLine("[ERROR] " + line);

    public void WriteInfo(string line) => WriteLine("[INFO] " + line);

    public void WriteWarning(string line) => WriteLine("[WARN] " + line);
}