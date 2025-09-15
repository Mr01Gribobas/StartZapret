using StartZapret.ControllerApplication;
using StartZapret.ControllerZapret;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
namespace StartZapret;

public partial class MainWindow : Window
{
    private readonly ZapretControll _zapretControll;
    private readonly BrowserControll _browserControll;
    public MainWindow()
    {
        _zapretControll = new ZapretControll();
        _browserControll = new BrowserControll();
        InitializeComponent();
        AppendEvents();
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
            _browserControll.Start();
        };
        this.ImageZapret.MouseLeftButtonDown += (sender, ev) =>
        {
            _zapretControll.Start();
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
