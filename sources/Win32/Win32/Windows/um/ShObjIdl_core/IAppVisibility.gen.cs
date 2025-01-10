// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2246EA2D-CAEA-4444-A3C4-6DE827E44313")]
[NativeTypeName("struct IAppVisibility : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppVisibility : IAppVisibility.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppVisibility));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppVisibility, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppVisibility, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppVisibility, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAppVisibilityOnMonitor(HMONITOR hMonitor, MONITOR_APP_VISIBILITY* pMode)
    {
        return (
            (delegate* unmanaged<IAppVisibility, HMONITOR, MONITOR_APP_VISIBILITY*, int>)(
                (*lpVtbl)[3]
            )
        )(this, hMonitor, pMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsLauncherVisible(BOOL* pfVisible)
    {
        return ((delegate* unmanaged<IAppVisibility, BOOL*, int>)((*lpVtbl)[4]))(this, pfVisible);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Advise(
        IAppVisibilityEvents pCallback,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return (
            (delegate* unmanaged<IAppVisibility, IAppVisibilityEvents, uint*, int>)((*lpVtbl)[5])
        )(this, pCallback, pdwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IAppVisibility, uint, int>)((*lpVtbl)[6]))(this, dwCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAppVisibilityOnMonitor(HMONITOR hMonitor, MONITOR_APP_VISIBILITY* pMode);

        [VtblIndex(4)]
        HRESULT IsLauncherVisible(BOOL* pfVisible);

        [VtblIndex(5)]
        HRESULT Advise(IAppVisibilityEvents pCallback, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [VtblIndex(6)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (HMONITOR, MONITOR_APP_VISIBILITY *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            HMONITOR,
            MONITOR_APP_VISIBILITY*,
            int> GetAppVisibilityOnMonitor;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsLauncherVisible;

        [NativeTypeName("HRESULT (IAppVisibilityEvents *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppVisibilityEvents, uint*, int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppVisibility"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppVisibility(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppVisibility"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppVisibility(Silk.NET.Windows.IUnknown value)
    {
        return new IAppVisibility(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppVisibility"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppVisibility"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppVisibility value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
