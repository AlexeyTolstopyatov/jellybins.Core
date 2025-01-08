using System.Runtime.InteropServices.ComTypes;
using jellybins.Core.Exceptions;
using jellybins.Core.Models.Workers;

namespace jellybins.Core.Strings;

public class NewExecutableStrings : IStrings
{
    public string OperatingSystemFlagToString<T>(T os = default!) where T : IComparable
    {
        if (Convert.ToByte(os) == 0x1) return "IBM OS/2";
        if (Convert.ToByte(os) == 0x2) return "Microsoft Windows/286";
        if (Convert.ToByte(os) == 0x3) return "Microsoft DOS";
        if (Convert.ToByte(os) == 0x4) return "Microsoft Windows/386";
        if (Convert.ToByte(os) == 0x5) return "Borland OS";
        throw new UndefinedArgumentException(Convert.ToInt32(os));
    }

    public string CpuArchitectureFlagToString<T>(T cpu) where T : IComparable
    {
        if (Convert.ToByte(cpu) == 0x4) return "Intel 8086";
        if (Convert.ToByte(cpu) == 0x5) return "Intel i286";
        if (Convert.ToByte(cpu) == 0x6) return "Intel i386";
        if (Convert.ToByte(cpu) == 0x7) return "Intel i8087";
        throw new UndefinedArgumentException(Convert.ToInt32(cpu));
    }

    public string OperatingSystemVersionToString<T>(T major, T minor) where T : IComparable
    {
        return $"{major}.{minor}";
    }

    public string CpuWordLengthFlagToString()
    {
        return "16";
    }
}