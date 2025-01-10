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

[Guid("A5CD92FF-29BE-454C-8D04-D82879FB3F1B")]
[NativeTypeName("struct IVirtualDesktopManager : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IVirtualDesktopManager : IVirtualDesktopManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVirtualDesktopManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVirtualDesktopManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVirtualDesktopManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVirtualDesktopManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsWindowOnCurrentVirtualDesktop(HWND topLevelWindow, BOOL* onCurrentDesktop)
    {
        return ((delegate* unmanaged<IVirtualDesktopManager, HWND, BOOL*, int>)((*lpVtbl)[3]))(
            this,
            topLevelWindow,
            onCurrentDesktop
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetWindowDesktopId(HWND topLevelWindow, Guid* desktopId)
    {
        return ((delegate* unmanaged<IVirtualDesktopManager, HWND, Guid*, int>)((*lpVtbl)[4]))(
            this,
            topLevelWindow,
            desktopId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveWindowToDesktop(
        HWND topLevelWindow,
        [NativeTypeName("const GUID &")] Guid* desktopId
    )
    {
        return ((delegate* unmanaged<IVirtualDesktopManager, HWND, Guid*, int>)((*lpVtbl)[5]))(
            this,
            topLevelWindow,
            desktopId
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsWindowOnCurrentVirtualDesktop(HWND topLevelWindow, BOOL* onCurrentDesktop);

        [VtblIndex(4)]
        HRESULT GetWindowDesktopId(HWND topLevelWindow, Guid* desktopId);

        [VtblIndex(5)]
        HRESULT MoveWindowToDesktop(
            HWND topLevelWindow,
            [NativeTypeName("const GUID &")] Guid* desktopId
        );
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

        [NativeTypeName("HRESULT (HWND, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, BOOL*, int> IsWindowOnCurrentVirtualDesktop;

        [NativeTypeName("HRESULT (HWND, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, int> GetWindowDesktopId;

        [NativeTypeName("HRESULT (HWND, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, int> MoveWindowToDesktop;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVirtualDesktopManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVirtualDesktopManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVirtualDesktopManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVirtualDesktopManager(Silk.NET.Windows.IUnknown value)
    {
        return new IVirtualDesktopManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVirtualDesktopManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVirtualDesktopManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVirtualDesktopManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
