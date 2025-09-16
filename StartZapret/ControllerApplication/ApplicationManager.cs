namespace StartZapret.ControllerApplication;

public class ApplicationManagerViewModel : INotifyPropertyChanged,IDisposable
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

                //Thread thread = new Thread(new ThreadStart(OpacityUpdate));
                //thread.Start();

            });
        }
    }

    private async void OpacityUpdate()
    {
        while(true)
        {
            if(OpacityPropyrty < 0.7)
            {
                OpacityPropyrty += 0.2;
            }
            else if(OpacityPropyrty > 0.7)
            {
                OpacityPropyrty -= 0.2;
            }
        }
    }

    private double _opacityProperty = 0.2;
    public double OpacityPropyrty
    {
        get => _opacityProperty;
        set
        {
            _opacityProperty = value;
            OnPropertyChanges(nameof(OpacityPropyrty));

        }
    }
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanges([CallerMemberName] string? property = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

    }

    public void Dispose()
    {
        this.Dispose();
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
