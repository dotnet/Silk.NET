using System.Runtime.Versioning;

/// <summary>
/// Represents an application running within a surface.
/// </summary>
public interface ISurfaceApplication
{
    /// <summary>
    /// An optional window class.
    /// </summary>
    static virtual string? WindowClass => null;

    /// <summary>
    /// Called upon initialization of the application.
    /// </summary>
    static abstract void Initialize<TSurface>(TSurface surface)
        where TSurface : Surface;

    /// <summary>
    /// Runs an application using the reference implementation of Silk.NET.Windowing.
    /// </summary>
    /// <typeparam name="T">The application.</typeparam>
    [UnsupportedOSPlatform("android")]
    public static sealed void Run<T>()
        where T : ISurfaceApplication => throw new NotImplementedException();
}
