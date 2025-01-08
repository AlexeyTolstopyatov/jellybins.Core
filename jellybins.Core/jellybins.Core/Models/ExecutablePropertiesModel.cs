using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace jellybins.Core.Models;

/// <summary>
/// Represents Dynamic model of exploring Executable characteristics 
/// </summary>
public class ExecutablePropertiesModel : INotifyPropertyChanged
{
    private CommonProperties _commonProperties;

    public CommonProperties CommonProperties
    {
        get => _commonProperties;
        set => SetField(ref _commonProperties, value);
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}