using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Loader;

namespace Silk.NET.Core.Loader;

/// <summary>
/// Contains helpers for DllImport resolution, essentially acting as a <see cref="DllImportResolver"/> multiplexer
/// (<see cref="LoaderInterface.ResolvingLibrary"/>).
/// </summary>
public static class LoaderInterface
{
    private static string? _current;
    private static bool _isInDllImport = false;
    private static DllImportResolver? _dllImportResolver;
    private static ConcurrentDictionary<string, nint> _loaded = new();
    private static ConditionalWeakTable<AssemblyLoadContext, StrongBox<bool>> _hooked = new();

    /// <summary>
    /// Registers the <see cref="ResolvingLibrary"/> <see cref="DllImportResolver"/> multiplexer using
    /// <see cref="NativeLibrary.SetDllImportResolver"/> for the given assembly.
    /// </summary>
    /// <param name="asm">The assembly to register for. Defaults to the calling assembly.</param>
    public static void RegisterHook(Assembly? asm)
    {
        asm ??= Assembly.GetCallingAssembly();
        if (
            AssemblyLoadContext.GetLoadContext(asm) is { } alc
            && _hooked.GetOrCreateValue(alc) is { Value: false } box
        )
        {
            box.Value = true;
            alc.ResolvingUnmanagedDll += static (loadingAsm, lib) =>
            {
                var wasInDllImport = _isInDllImport;
                if (!wasInDllImport && _current == lib)
                {
                    // Cycle detected.
                    return 0;
                }

                _isInDllImport = false;
                var ret = OnDllImport(lib, loadingAsm, null);
                _isInDllImport = wasInDllImport;
                return ret;
            };
        }
        NativeLibrary.SetDllImportResolver(
            asm,
            static (x, y, z) =>
            {
                var wasInDllImport = _isInDllImport;
                _isInDllImport = true;
                var ret = OnDllImport(x, y, z);
                _isInDllImport = wasInDllImport;
                return ret;
            }
        );
    }

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

        foreach (
            var @delegate in _dllImportResolver?.GetInvocationList() ?? Enumerable.Empty<Delegate>()
        )
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
    ) =>
        _loaded.GetOrAdd(
            libraryname,
            _ =>
            {
                var before = _current;
                _current = libraryname;
                foreach (
                    var @delegate in (
                        _dllImportResolver?.GetInvocationList() ?? Enumerable.Empty<Delegate>()
                    ).OfType<DllImportResolver>()
                )
                {
                    if (@delegate(libraryname, assembly, searchpath) is not (not 0 and var handle))
                    {
                        continue;
                    }

                    _current = before;
                    return handle;
                }

                _current = before;
                return 0;
            }
        );

    /// <summary>
    /// Registers an alternative name for the given library name.
    /// </summary>
    /// <param name="libraryName">The library name.</param>
    /// <param name="altName">The alternative name to use when we can't load the usual name.</param>
    public static void RegisterAlternativeName(string libraryName, string altName) =>
        ResolvingLibrary += (loadingLib, loadingAsm, searchPath) =>
            loadingLib == libraryName
                ? NativeLibrary.TryLoad(altName, loadingAsm, searchPath, out var handle)
                    ? handle
                    : 0
                : 0;
}
