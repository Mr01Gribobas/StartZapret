using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using static System.Net.WebRequestMethods;

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

