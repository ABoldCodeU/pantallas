using AndroidX.CardView.Widget;
using System.ComponentModel;

namespace AxitHome.Views.Controls;

public partial class ImageWithOverlay : Grid
{
	public ImageWithOverlay()
	{
		InitializeComponent();
        PropertyChanged += OnPropertyChanged;
    }
    private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
    {

    }
    public static BindableProperty OverlayTextSubtitleProperty = BindableProperty.Create(
        nameof(OverlayTextSubtitle),
        typeof(string),
        typeof(ImageWithOverlay),
        defaultValue: "",
        defaultBindingMode: BindingMode.OneWay);

    public string OverlayTextSubtitle
    {
        get => (string)GetValue(OverlayTextSubtitleProperty);
        set => SetValue(OverlayTextSubtitleProperty, value);
    }
    public static BindableProperty OverlayTextProperty = BindableProperty.Create(
        nameof(OverlayText),
        typeof(string),
        typeof(ImageWithOverlay),
        defaultValue: "",
        defaultBindingMode: BindingMode.OneWay);

    public string OverlayText
    {
        get => (string)GetValue(OverlayTextProperty);
        set => SetValue(OverlayTextProperty, value);
    }
    public static BindableProperty ImagePathProperty = BindableProperty.Create(
        nameof(ImagePath),
        typeof(string),
        typeof(ImageWithOverlay),
        defaultValue: null,
        defaultBindingMode: BindingMode.OneWay);
        
    public string ImagePath
    {
        get => (string)GetValue(ImagePathProperty);
        set => SetValue(ImagePathProperty, value);
    }
}