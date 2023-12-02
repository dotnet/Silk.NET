namespace Silk.NET.Core.Loader;

/// <summary>
/// Represents a source of native function pointers.
/// </summary>
public interface INativeContext : IDisposable
{
    /// <summary>
    /// Gets the function pointer address for the function with the given name. The given library name hint may be used
    /// to determine the source library of the functions.
    /// </summary>
    /// <param name="functionName">The function name.</param>
    /// <param name="libraryNameHint">A library name hint.</param>
    /// <returns>The function address, or null if it could not be resolved.</returns>
    unsafe void* LoadFunction(string functionName, string libraryNameHint);
}
