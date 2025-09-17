namespace StartZapret;


public partial class WindowPath : Window
{
    public WindowPath()
    {
        InitializeComponent();
        btnSave.Click += BtnSave_Click;
    }

    private void BtnSave_Click(object sender, RoutedEventArgs e)
    {
        this.DialogResult = true;
    }

    public string Path 
    {
        get  { return boxPath.Text ; }
    }

}
