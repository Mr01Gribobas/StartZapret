namespace StartZapret.ControllerZapret;

class BrowserControll : ControllerBase
{
    public override bool Start()
    {
        try
        {
            var url = "https://vk.com/audios237180869";
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = "explorer.exe",
                Arguments = url,
            };
            Process.Start(info);
            return true;

        }
        catch(ArgumentNullException ex)
        {
            return UpgradePath(this);
        }

    }



}

