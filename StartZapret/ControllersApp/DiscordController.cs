namespace StartZapret.ControllersApp;

public class DiscordController : ControllerBase
{
    public override bool Start()
    {
		try
		{
            Process.Start(_pathDis);
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
