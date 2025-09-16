namespace StartZapret.ControllersApp;

public class ZapretControll : ControllerBase ,  IStartApp
{
    public void Start()
    {
        Process.Start("C:\\Users\\maks-\\Downloads\\zapret-discord-youtube-1.8.3\\general (ALT6).bat");
    }
}
