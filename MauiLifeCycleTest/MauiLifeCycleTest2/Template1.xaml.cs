namespace MauiLifeCycleTest2;

public partial class Template1 : ContentView
{
	public Template1()
	{
		InitializeComponent();
        HandlerChanged += Template1_HandlerChanged;
        Loaded += Template1_Loaded;
        Unloaded += Template1_Unloaded;
	}

    private void Template1_Loaded(object? sender, EventArgs e)
    {
        
    }

    private void Template1_Unloaded(object? sender, EventArgs e)
    {
        
    }

    protected override void OnHandlerChanged()
    {
        base.OnHandlerChanged();
    }

    private void Template1_HandlerChanged(object? sender, EventArgs e)
    {
        var h = Handler;
    }
}