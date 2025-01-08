using jellybins.Core.Exceptions;
using jellybins.Core.Models.Workers;

namespace jellybins.Core.Strings;

public class LinearExecutableStrings : IStrings
{
    public string OperatingSystemFlagToString<T>(T os = default(T)) where T : IComparable
    {
        if (Convert.ToInt32(os) == 1) return "IBM OS/2";
        if (Convert.ToInt32(os) == 2) return "Microsoft Windows/286";
        if (Convert.ToInt32(os) == 3) return "Microsoft DOS";
        if (Convert.ToInt32(os) == 4) return "Microsoft Windows/386";
        throw new UndefinedArgumentException(Convert.ToInt32(os));
    }

    public string CpuArchitectureFlagToString<T>(T cpu) where T : IComparable
    {
        if (Convert.ToInt32(cpu) == 1) return "Intel i286";
        if (Convert.ToInt32(cpu) == 2) return "Intel i386";
        if (Convert.ToInt32(cpu) == 3) return "Intel i486";
        throw new UndefinedArgumentException(Convert.ToInt32(cpu));
    }

    public string OperatingSystemVersionToString<T>(T major, T minor) where T : IComparable
    {
        // mind: version of LE/LX executables computing little exotic
        // I have some troubles with it.
        throw new NotImplementedException();
    }

    public string CpuWordLengthFlagToString()
    {
        // mind: Detect WORD-len by WORD_ORDER field
        throw new NotImplementedException();
    }
}