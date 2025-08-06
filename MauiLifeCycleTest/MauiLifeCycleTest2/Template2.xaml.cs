namespace MauiLifeCycleTest2;

public partial class Template2 : ContentView
{
	public Template2()
	{
		InitializeComponent();
        HandlerChanged += Template2_HandlerChanged;
        Loaded += Template2_Loaded;
        Unloaded += Template2_Unloaded;
	}

    private void Template2_Loaded(object? sender, EventArgs e)
    {
        
    }

    private void Template2_Unloaded(object? sender, EventArgs e)
    {
        
    }

    private void Template2_HandlerChanged(object? sender, EventArgs e)
    {
        
    }
}