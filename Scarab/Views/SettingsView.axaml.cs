using Avalonia.ReactiveUI;
using Scarab.ViewModels;

namespace Scarab.Views;

public partial class SettingsView : ReactiveUserControl<SettingsViewModel>
{
    public SettingsView()
    {
        InitializeComponent();
    }
}