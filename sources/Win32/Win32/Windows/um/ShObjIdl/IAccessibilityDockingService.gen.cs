// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8849DC22-CEDF-4C95-998D-051419DD3F76")]
[NativeTypeName("struct IAccessibilityDockingService : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAccessibilityDockingService
    : IAccessibilityDockingService.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccessibilityDockingService));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAccessibilityDockingService, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAccessibilityDockingService, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAccessibilityDockingService, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAvailableSize(HMONITOR hMonitor, uint* pcxFixed, uint* pcyMax)
    {
        return (
            (delegate* unmanaged<IAccessibilityDockingService, HMONITOR, uint*, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, hMonitor, pcxFixed, pcyMax);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DockWindow(
        HWND hwnd,
        HMONITOR hMonitor,
        uint cyRequested,
        IAccessibilityDockingServiceCallback pCallback
    )
    {
        return (
            (delegate* unmanaged<
                IAccessibilityDockingService,
                HWND,
                HMONITOR,
                uint,
                IAccessibilityDockingServiceCallback,
                int>)((*lpVtbl)[4])
        )(this, hwnd, hMonitor, cyRequested, pCallback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT UndockWindow(HWND hwnd)
    {
        return ((delegate* unmanaged<IAccessibilityDockingService, HWND, int>)((*lpVtbl)[5]))(
            this,
            hwnd
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAvailableSize(HMONITOR hMonitor, uint* pcxFixed, uint* pcyMax);

        [VtblIndex(4)]
        HRESULT DockWindow(
            HWND hwnd,
            HMONITOR hMonitor,
            uint cyRequested,
            IAccessibilityDockingServiceCallback pCallback
        );

        [VtblIndex(5)]
        HRESULT UndockWindow(HWND hwnd);
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

        [NativeTypeName("HRESULT (HMONITOR, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMONITOR, uint*, uint*, int> GetAvailableSize;

        [NativeTypeName(
            "HRESULT (HWND, HMONITOR, UINT, IAccessibilityDockingServiceCallback *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            HMONITOR,
            uint,
            IAccessibilityDockingServiceCallback,
            int> DockWindow;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> UndockWindow;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAccessibilityDockingService"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAccessibilityDockingService(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAccessibilityDockingService"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAccessibilityDockingService(Silk.NET.Windows.IUnknown value)
    {
        return new IAccessibilityDockingService(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAccessibilityDockingService"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAccessibilityDockingService"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAccessibilityDockingService value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
