namespace jellybins.Core.Models;

/// <summary>
/// Represents important fields of exploring executable
/// that must be filled for everyone
/// </summary>
public struct CommonProperties
{
    /// <summary>
    /// Name inside FileSystem
    /// </summary>
    public string Name;
    /// <summary>
    /// Path + Name of binary
    /// </summary>
    public string Path;
    /// <summary>
    /// Major version
    /// </summary>
    public string MajorVersion;
    /// <summary>
    /// Minor version
    /// </summary>
    public string MinorVersion;
    /// <summary>
    /// Last Major compatible version of OS
    /// </summary>
    public string EarlyMajorVersion;
    /// <summary>
    /// Last Minor compatible OS version
    /// </summary>
    public string EarlyMinorVersion;
    /// <summary>
    /// Required CPU Architecture for running
    /// </summary>
    public string Architecture;
    /// <summary>
    /// Required OS for Running
    /// </summary>
    public string OperatingSystem;
    /// <summary>
    /// Name of Microsoft Windows Subsystem
    /// Microsoft binaries contain information
    /// about using layer of Operating System (Win32, POSIX compat, OS/2 compat etc...)
    /// </summary>
    public string Subsystem;
    /// <summary>
    /// Type of exploring binary file (e.g. Library, Executable, Archive, etc.) 
    /// </summary>
    public string BinaryType;
}
