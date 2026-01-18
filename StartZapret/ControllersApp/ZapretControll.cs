namespace StartZapret.ControllersApp;

public  class ZapretControll : ControllerBase
{
    public override bool Start()
    {
        ProcessStartInfo info = new ProcessStartInfo() 
        {
            FileName = _path,
            UseShellExecute = true,
            Verb = "runas",
            WindowStyle = ProcessWindowStyle.Normal
        };
        try
        {
            Process.Start(info);
            return true;
        }
        catch(Exception ex)
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