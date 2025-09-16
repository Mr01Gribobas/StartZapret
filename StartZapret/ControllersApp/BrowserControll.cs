namespace StartZapret.ControllerZapret;

class BrowserControll : IStartApp 
{
    public void Start()
    {
        var url = "https://vk.com/audios237180869";
        ProcessStartInfo info = new ProcessStartInfo()
        {
            FileName = "explorer.exe",
            Arguments= url,
        };
        Process.Start(info);
    }
}

