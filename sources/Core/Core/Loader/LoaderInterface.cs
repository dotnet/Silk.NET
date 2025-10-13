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
    private static DllImportResolver? _dllImportResolver;
    private static ConcurrentDictionary<string, nint> _loaded = new();
    private static ConditionalWeakTable<AssemblyLoadContext, HookState> _hooked = new();

    private class HookState
    {
        public bool IsContextHooked;
        public string? Current;
        public bool IsInDllImport;
    }

    static LoaderInterface() => ResolvingLibrary += LoadAlternativeNames;

    /// <summary>
    /// Registers the <see cref="ResolvingLibrary"/> <see cref="DllImportResolver"/> multiplexer using
    /// <see cref="NativeLibrary.SetDllImportResolver"/> for the given assembly.
    /// </summary>
    /// <param name="asm">The assembly to register for. Defaults to the calling assembly.</param>
    public static void RegisterHook(Assembly? asm)
    {
        asm ??= Assembly.GetCallingAssembly();
        if (AssemblyLoadContext.GetLoadContext(asm) is not { } alc)
        {
            throw new ArgumentException(
                "Assembly must be provided by the runtime (and thereby have an AssemblyLoadContext).",
                nameof(asm)
            );
        }

        var box = _hooked.GetOrCreateValue(alc);
        if (!box.IsContextHooked)
        {
            box.IsContextHooked = true;
            alc.ResolvingUnmanagedDll += (loadingAsm, lib) =>
            {
                var wasInDllImport = box.IsInDllImport;
                if (!wasInDllImport && box.Current == lib)
                {
                    // Cycle detected.
                    return 0;
                }

                box.IsInDllImport = false;
                var ret = OnDllImport(box, lib, loadingAsm, null);
                box.IsInDllImport = wasInDllImport;
                return ret;
            };
        }

        NativeLibrary.SetDllImportResolver(
            asm,
            (x, y, z) =>
            {
                var wasInDllImport = box.IsInDllImport;
                box.IsInDllImport = true;
                var ret = OnDllImport(box, x, y, z);
                box.IsInDllImport = wasInDllImport;
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
        HookState box,
        string libraryname,
        Assembly assembly,
        DllImportSearchPath? searchpath
    ) =>
        _loaded.GetOrAdd(
            libraryname,
            _ =>
            {
                var before = box.Current;
                box.Current = libraryname;
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

                    box.Current = before;
                    return handle;
                }

                box.Current = before;
                return 0;
            }
        );

    /// <summary>
    /// Registers an alternative name for the given library name.
    /// </summary>
    /// <param name="libraryName">The library name.</param>
    /// <param name="altName">The alternative name to use when we can't load the usual name.</param>
    public static void RegisterAlternativeName(string libraryName, string altName) =>
        (
            AlternativeNames.TryGetValue(libraryName, out var alts)
                ? alts
                : AlternativeNames[libraryName] = []
        ).Add(altName);

    /// <summary>
    /// Gets the backing dictionary for <see cref="RegisterAlternativeName"/>. This can be manually modified if desired.
    /// </summary>
    public static Dictionary<string, List<string>> AlternativeNames { get; } = new();

    /// <summary>
    /// A <see cref="DllImportResolver"/> that uses <see cref="AlternativeNames"/> to resolve the library.
    /// </summary>
    /// <remarks>
    /// This is publicised such that advanced users can remove this from <see cref="ResolvingLibrary"/> if desired, as
    /// it is added by default.
    /// </remarks>
    /// <param name="libraryName">The library name as seen in <see cref="DllImportAttribute"/>.</param>
    /// <param name="assembly">The resolving assembly.</param>
    /// <param name="searchPath">The search path.</param>
    /// <returns>The <see cref="NativeLibrary"/> handle.</returns>
    /// <seealso cref="DllImportResolver"/>
    public static IntPtr LoadAlternativeNames(
        string libraryName,
        Assembly assembly,
        DllImportSearchPath? searchPath
    )
    {
        if (!AlternativeNames.TryGetValue(libraryName, out var alts))
        {
            return 0;
        }

        foreach (var alt in alts)
        {
            if (NativeLibrary.TryLoad(alt, assembly, searchPath, out var handle))
            {
                return handle;
            }
        }

        return 0;
    }
}
