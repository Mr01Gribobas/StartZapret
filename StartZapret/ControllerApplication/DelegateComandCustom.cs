namespace StartZapret.ControllerApplication;

public class DelegateComandCustom : ICommand
{
    private Action<object> _execute;
    private Func<object,bool> _cantExecute;
    public event EventHandler? CanExecuteChanged;
    //{
    //    add { CommandManager.RequerySuggested += value; }
    //    remove { CommandManager.RequerySuggested -= value; }

    //}

    public DelegateComandCustom(Action<object> execute , Func<object,bool> ceExecute =null )
    {
        _execute = execute;
        _cantExecute = ceExecute;
    }

    public bool CanExecute(object? parameter)
    {
        return this._cantExecute ==null || this._cantExecute(parameter);
    }

    public void Execute(object? parameter)
    {
        _execute(parameter);
    }
}
