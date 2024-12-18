namespace FontRepo.Controls;

public partial class Highlight : ContentView
{
	public static readonly BindableProperty LabelProperty = BindableProperty.Create(nameof(Label), typeof(string), typeof(Highlight), string.Empty, BindingMode.OneWay);
	public string Label
	{
		get => (string)GetValue(LabelProperty);
		set => SetValue(LabelProperty, value);
	}

	public Highlight()
	{
		InitializeComponent();
	}
}