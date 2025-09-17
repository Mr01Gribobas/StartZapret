using StartZapret.models;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

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
            windowDialog.textBlockX.Text = "Укажите путь :";
            if(windowDialog.ShowDialog() == true)
            {
                _path = windowDialog.Path;
                SaveToFile();
                return true;

            }
            else
            { return false; }
        }
        else if(controller is BrowserControll browser)
        {
            windowDialog.textBlockX.Text = "Укажите url :";
            if(windowDialog.ShowDialog() == true)
            {
                _url = windowDialog.Path;
                SaveToFile();
                return true;
            }
            else
            { return false; }
        }
        return false;
    }
    public void SaveToFile()
    {
        FileConfig fileConfig = new FileConfig() { _urlName = _url, _pathName = _path };
        var fileJsonName = "config.json";
        var jsonFormat = new DataContractJsonSerializer(typeof(FileConfig));
        using(var fs = new FileStream(fileJsonName, FileMode.OpenOrCreate))
        {
            jsonFormat.WriteObject(fs, fileConfig);
        }
    }
    public bool ReadFromFile()
    {

        var fileJsonName = "config.json";
        var jsonFormat = new DataContractJsonSerializer(typeof(FileConfig));
        try
        {

            using(var fs = new FileStream(fileJsonName, FileMode.Open))
            {
                var deserializeResult = jsonFormat.ReadObject(fs) as FileConfig;
                if(deserializeResult != null)
                {
                    _path = deserializeResult._pathName;
                    _url = deserializeResult._urlName;
                    return true;
                }
                else
                {
                    return false;

                }
            }
        }
        catch(Exception ex)
        {

            return false; 
        }
        
    }
    public void ResetData()
    {
        StringBuilder stringBuilder = new StringBuilder(Directory.GetCurrentDirectory());
        //var result = Directory.GetCurrentDirectory();
        if (stringBuilder != null)
        {
            stringBuilder.Append("\\config.json");
            File.Delete(stringBuilder.ToString());
        }
    }





}
