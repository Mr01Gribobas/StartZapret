namespace StartZapret.ControllerZapret;

class BrowserControll : ControllerBase
{
    public override bool Start()
    {
        try
        {
            if(_url == null)
            {
                throw new NullReferenceException();
            }
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = "explorer.exe",
                Arguments = _url,
            };
            Process.Start(info);
            return true;

        }
        catch(NullReferenceException ex)
        {
            if(UpgradePath(this))
            {
                this.Start();
                return true;
            }
            return false;
            
        }

    }



}

