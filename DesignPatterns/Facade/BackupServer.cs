namespace DesignPatterns.Facade;

public class BackupServer
{
    #region Startup processes
    public void Boot()
    {
        Console.WriteLine("Server is booting...");
    }

    public void DiskHealthCheck()
    {
        Console.WriteLine("Running disk health checks...");
    }

    public void StartProcesses()
    {
        Console.WriteLine("Starting processes...");
    }

    public void InitializeListeners()
    {
        Console.WriteLine("Initializing listeners...");
    }
    #endregion


    #region Stopping processes
    public void Shutdown()
    {
        Console.WriteLine("Server is shutting down...");
    }

    public void EjectDrives()
    {
        Console.WriteLine("Safely injecting disks...");
    }

    public void ReleaseProcesses()
    {
        Console.WriteLine("Releasing processes...");
    }

    public void DestroyListeners()
    {
        Console.WriteLine("Destroying listeners...");
    }
    #endregion
}
