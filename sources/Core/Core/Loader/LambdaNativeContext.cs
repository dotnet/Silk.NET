namespace Silk.NET.Core.Loader;

/// <summary>
/// Wraps a lambda such that it can be used as a <see cref="INativeContext"/>.
/// </summary>
/// <param name="loader">
/// A lambda where the first parameter is the function name and the second parameter is the library name hint.
/// </param>
public struct LambdaNativeContext(Func<string, string, nint> loader) : INativeContext
{
    /// <inheritdoc />
    public void Dispose() { }

    /// <inheritdoc />
    public unsafe void* LoadFunction(string functionName, string libraryNameHint) =>
        (void*)loader(functionName, libraryNameHint);
}
