using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Loader;

/// <summary>
/// An <see cref="INativeContext"/> that uses <see cref="NativeLibrary"/>.
/// </summary>
public sealed class DefaultNativeContext : INativeContext
{
    private readonly ConcurrentDictionary<string, nint> _libCache = new();
    private readonly ConcurrentDictionary<(string, string), nint> _fnCache = new();

    /// <inheritdoc />
    public unsafe void* LoadFunction(string functionName, string libraryNameHint)
    {
        var callingAsm = Assembly.GetCallingAssembly();
        return (void*)
            _fnCache.GetOrAdd(
                (functionName, libraryNameHint),
                args =>
                {
                    var libHandle = _libCache.GetOrAdd(
                        args.Item2,
                        lib => LoaderInterface.LoadLibrary(lib, callingAsm)
                    );
                    return
                        libHandle is not 0
                        && NativeLibrary.TryGetExport(libHandle, args.Item1, out var fnAddr)
                        ? fnAddr
                        : 0;
                }
            );
    }

    /// <inheritdoc />
    public void Dispose()
    {
        foreach (var lib in _libCache.Values.Distinct())
        {
            if (lib is not 0)
            {
                NativeLibrary.Free(lib);
            }
        }
        _libCache.Clear();
        _fnCache.Clear();
    }
}
