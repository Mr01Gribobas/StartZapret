namespace StartZapret.ControllersApp;

public  class ZapretControll : ControllerBase
{
    public override bool Start()
    {
        try
        {
            Process.Start(_path);
            return true;
        }
        catch(Exception ex)
        {
            return UpgradePath(this);
        }
    }
}