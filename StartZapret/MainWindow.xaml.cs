namespace StartZapret;

public partial class MainWindow : Window
{
    private Dictionary<string, ControllerBase> _controllers;     
    public bool _thereIs;
    public MainWindow()
    {
        Building();
        DataContext = new ApplicationManagerViewModel(this);
        InitializeComponent();
        AppendEvents();
    }

    private void Building()
    {
        _controllers = new Dictionary<string, ControllerBase>();
        _controllers["zapret"] = new ZapretControll();
        _controllers["browser"] = new BrowserControll();
    }
    public void Resets()
    {
        foreach(var item in _controllers)
        {
            item.Value.ResetData();
        }
    }




    private void AppendEvents()
    {
        this.ImageVk.MouseDown += (sender, ev) =>
        {
            if(sender is Image imageTtem)
                OpacityUpdate(imageTtem);
        };
        this.ImageVk.MouseEnter += (sender, ev) =>
        {
            if(sender is Image imageTtem)
                OpacityUpdate(imageTtem);
        };
        this.ImageZapret.MouseEnter += (sender, ev) =>
        {
            if(sender is Image imageTtem)
                OpacityUpdate(imageTtem);
        };
        this.ImageVk.MouseLeftButtonDown += (sender, ev) =>
        {

            _thereIs = _controllers["browser"].ReadFromFile();
            if(_controllers["browser"].Start())
            {
                this.Close();
            }

        };
        this.ImageZapret.MouseLeftButtonDown += (sender, ev) =>
        {
           _thereIs = _controllers["zapret"].ReadFromFile();
            if(_controllers["zapret"].Start())
            {
                this.Close();
            }
        };



        this.ImageDis.MouseEnter += (sender, ev) =>
        {
            if(sender is Image imageTtem)
                OpacityUpdate(imageTtem);
        };
        this.ImageDis.MouseLeftButtonDown += (sender, ev) =>
        {
            //
        };
    }

    private void Close_click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
    private void OpacityUpdate(Image image)
    {

        DoubleAnimation doubleAnimation = new DoubleAnimation();
        doubleAnimation.From = 0.1;
        doubleAnimation.To = 0.7;
        doubleAnimation.AutoReverse = true;
        doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
        doubleAnimation.Duration = TimeSpan.FromSeconds(2);
        image.BeginAnimation(Image.OpacityProperty, doubleAnimation);
    }

}
