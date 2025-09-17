namespace StartZapret.ControllersApp;

public abstract class ControllerBase : IStartApp
{
    public string? _path { get; set; }
    public string? _url { get; set; }

    //public string? _key { get; set; }
    public void Init(string path)
    {
        path = "C:\\Users\\maks-\\Downloads\\zapret-discord-youtube-1.8.3\\general (ALT6).bat"; //TODO 
        _path = path;
    }
    public abstract bool Start();
    
    protected bool UpgradePath(ControllerBase controller)
    {
            WindowPath windowDialog = new WindowPath();
            MessageBox.Show("Вероятно ошибка пути к указанному файлу");
        if(controller is ZapretControll zapret)
        {
            if(windowDialog.ShowDialog() == true)
            {
                windowDialog.textBlockX.Text = "Укажите путь :";
                _path = windowDialog.Path;
                return true;
            }
        }
        else if(controller is BrowserControll browser)
        {
            if(windowDialog.ShowDialog() == true)
            {
                windowDialog.textBlockX.Text = "Укажите url :";
                _url = windowDialog.Path;
                return true;
            }
        }
        return false;
    }



    //protected bool SavePath()
    //{

    //}

}
