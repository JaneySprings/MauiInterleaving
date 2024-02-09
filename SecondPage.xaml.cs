namespace MauiInterliving;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		var vm = new MyViewModel();
		InitializeComponent();
		BindingContext = vm;
	}
}

public class MyViewModel
{
	public List<string> Items { get; set; }

    public MyViewModel() {
        Items = new List<string>();
		Enumerable.Range(1, 10).ToList().ForEach(i => Items.Add($"Item {i}"));
    }
}