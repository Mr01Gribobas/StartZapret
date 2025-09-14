using System.Diagnostics;

namespace StartZapret.ControllerZapret;

public class ZapretControll : IZapretStart
{
    public void Start()
    {
        Process.Start("C:\\Users\\maks-\\Downloads\\zapret-discord-youtube-1.8.3\\general (ALT6).bat");
    }
}
