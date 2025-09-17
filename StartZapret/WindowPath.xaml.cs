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
        if(Path != string.Empty)
        {
            this.DialogResult = true;

        }
        else
        {
            this.DialogResult = false;
        }
    }

    public string Path
    {
        get { return boxPath.Text; }
    }

}
