using System.Reflection;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Loader;

/// <summary>
/// Contains helpers for DllImport resolution, essentially acting as a <see cref="DllImportResolver"/> multiplexer
/// (<see cref="LoaderInterface.ResolvingLibrary"/>).
/// </summary>
public static class LoaderInterface
{
    private static DllImportResolver? _dllImportResolver;

    /// <summary>
    /// Registers the <see cref="ResolvingLibrary"/> <see cref="DllImportResolver"/> multiplexer using
    /// <see cref="NativeLibrary.SetDllImportResolver"/> for the given assembly.
    /// </summary>
    /// <param name="asm">The assembly to register for. Defaults to the calling assembly.</param>
    public static void RegisterHook(Assembly? asm) =>
        NativeLibrary.SetDllImportResolver(asm ?? Assembly.GetCallingAssembly(), OnDllImport);

    /// <summary>
    /// Loads a library using the <see cref="ResolvingLibrary"/> event.
    /// </summary>
    /// <param name="name">The library name.</param>
    /// <param name="asm">The assembly for the <see cref="DllImportResolver"/>.</param>
    /// <returns>The library handle, or 0 if loading was unsuccessful.</returns>
    public static nint LoadLibrary(string name, Assembly asm)
    {
        if (NativeLibrary.TryLoad(name, asm, null, out var handle))
        {
            return handle;
        }

        foreach (var @delegate in _dllImportResolver?.GetInvocationList() ?? Enumerable.Empty<Delegate>())
        {
            handle = (@delegate as DllImportResolver)?.Invoke(name, asm, null) ?? 0;
            if (handle is not 0)
            {
                return handle;
            }
        }

        return 0;
    }

    /// <summary>
    /// Raised whenever a native library is loaded. Handlers can be added to this event to customize how libraries are loaded, and they will be used first whenever a new native library is being resolved
    /// </summary>
    public static event DllImportResolver? ResolvingLibrary
    {
        // Manually specialised so one assembly can't hijack all loading.
        add => _dllImportResolver += value;
        remove => _dllImportResolver -= value;
    }

    private static IntPtr OnDllImport(
        string libraryname,
        Assembly assembly,
        DllImportSearchPath? searchpath
    )
    {
        throw new NotImplementedException();
    }
}
