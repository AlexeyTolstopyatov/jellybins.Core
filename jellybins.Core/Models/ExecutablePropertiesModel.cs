using System.ComponentModel;
using System.Runtime.CompilerServices;
using jellybins.Core.Models.Flags;

namespace jellybins.Core.Models;

/// <summary>
/// Represents Dynamic model of exploring Executable characteristics 
/// </summary>
public class ExecutablePropertiesModel : INotifyPropertyChanged
{
    private CommonProperties _commonProperties;
    private object _flags;
    
    public CommonProperties CommonProperties
    {
        get => _commonProperties;
        set => SetField(ref _commonProperties, value);
    }

    public object Flags
    {
        get => _flags;
        set => SetField(ref _flags, value);
    }

    public NewExecutableFlags NewExecutableFlags => (NewExecutableFlags)_flags;
    public LinearExecutableFlags LinearExecutableFlags => (LinearExecutableFlags)_flags;
    public PortableExecutableFlags PortableExecutableFlags => (PortableExecutableFlags)_flags;
    public AssemblerOutFlags AssemblerOutFlags => (AssemblerOutFlags)_flags;
    
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