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
    public MainWindow()
    {
        _zapretControll = new ZapretControll();
        //this.DataContext = new ApplicationManagerViewModel(this);
        InitializeComponent();
        
    }




    private void Close_click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void ImageZapret_MouseEnter(object sender, MouseEventArgs e)
    {
        OpacityUpdate();
    }

    private void OpacityUpdate()
    {
        this.ImageZapret.Opacity = 4;
        DoubleAnimation doubleAnimation = new DoubleAnimation();
        doubleAnimation.From = 0.1;
        doubleAnimation.To = 0.7;
        doubleAnimation.AutoReverse = true;
        doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
        doubleAnimation.Duration = TimeSpan.FromSeconds(2);
        ImageZapret.BeginAnimation(Image.OpacityProperty, doubleAnimation);
    }


    private void ImageZapret_MouseLeave(object sender, MouseEventArgs e)
    {
        
    }

    private void ImageZapret_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        _zapretControll.Start();
    }
}
