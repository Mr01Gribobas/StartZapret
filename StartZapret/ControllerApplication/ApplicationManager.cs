using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
namespace StartZapret.ControllerApplication;


public class ApplicationManagerViewModel : INotifyPropertyChanged
{
    public static MainWindow? _mainWindow;
    public ApplicationManagerViewModel(MainWindow main)
    {
        _mainWindow = main;
    }

    public ApplicationManagerViewModel()
    {

    }

       
    public ICommand My_command
    {
        get
        {
            return new DelegateComandCustom((objAction) =>
            {
                TestTitle++;
                for(Int32 i = 0; i < 3; i++)
                {
                    Task.Delay(1000).Wait();
                    TestTitle++;

                }

            });
        }
    }

    private double _opacityProperty = 0.2;
    public double OpacityPropyrty
    {
        get => _opacityProperty;
        set
        {
            _opacityProperty = value;
            OnPropertyChanges("OpacityPropyrty");

        }
    }
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanges([CallerMemberName] string? property = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

    }
    private int _testTitle = 0;
    public int TestTitle
    {
        get => _testTitle;
        set
        {
            _testTitle = value;
            OnPropertyChanges(nameof(TestTitle));
        }
    }
}
