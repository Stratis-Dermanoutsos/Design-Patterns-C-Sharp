namespace DesignPatterns.Facade;

public class BackupServerFacade
{
    private readonly BackupServer backupServer;

    public BackupServerFacade(BackupServer backupServer)
    {
        this.backupServer = backupServer;
    }

    public void StartServer()
    {
        backupServer.Boot();
        backupServer.DiskHealthCheck();
        backupServer.StartProcesses();
        backupServer.InitializeListeners();
    }

    public void StopServer()
    {
        backupServer.DestroyListeners();
        backupServer.ReleaseProcesses();
        backupServer.EjectDrives();
        backupServer.Shutdown();
    }
}
