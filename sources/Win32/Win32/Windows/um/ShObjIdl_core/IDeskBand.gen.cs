// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EB0FE172-1A3A-11D0-89B3-00A0C90A90AC")]
[NativeTypeName("struct IDeskBand : IDockingWindow")]
[NativeInheritance("IDockingWindow")]
public unsafe partial struct IDeskBand : IDeskBand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeskBand));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeskBand, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDeskBand, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeskBand, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IDeskBand, HWND*, int>)((*lpVtbl)[3]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IDeskBand, BOOL, int>)((*lpVtbl)[4]))(this, fEnterMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ShowDW(BOOL fShow)
    {
        return ((delegate* unmanaged<IDeskBand, BOOL, int>)((*lpVtbl)[5]))(this, fShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CloseDW([NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<IDeskBand, uint, int>)((*lpVtbl)[6]))(this, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResizeBorderDW(
        [NativeTypeName("LPCRECT")] RECT* prcBorder,
        IUnknown punkToolbarSite,
        BOOL fReserved
    )
    {
        return ((delegate* unmanaged<IDeskBand, RECT*, IUnknown, BOOL, int>)((*lpVtbl)[7]))(
            this,
            prcBorder,
            punkToolbarSite,
            fReserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBandInfo(
        [NativeTypeName("DWORD")] uint dwBandID,
        [NativeTypeName("DWORD")] uint dwViewMode,
        DESKBANDINFO* pdbi
    )
    {
        return ((delegate* unmanaged<IDeskBand, uint, uint, DESKBANDINFO*, int>)((*lpVtbl)[8]))(
            this,
            dwBandID,
            dwViewMode,
            pdbi
        );
    }

    public interface Interface : IDockingWindow.Interface
    {
        [VtblIndex(8)]
        HRESULT GetBandInfo(
            [NativeTypeName("DWORD")] uint dwBandID,
            [NativeTypeName("DWORD")] uint dwViewMode,
            DESKBANDINFO* pdbi
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

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWindow;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ContextSensitiveHelp;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ShowDW;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> CloseDW;

        [NativeTypeName("HRESULT (LPCRECT, IUnknown *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, IUnknown, BOOL, int> ResizeBorderDW;

        [NativeTypeName("HRESULT (DWORD, DWORD, DESKBANDINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, DESKBANDINFO*, int> GetBandInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeskBand"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeskBand(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDockingWindow"/> to <see cref = "IDeskBand"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDockingWindow"/> instance to be converted </param>
    public static explicit operator IDeskBand(Silk.NET.Windows.IDockingWindow value)
    {
        return new IDeskBand(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeskBand"/> to <see cref = "Silk.NET.Windows.IDockingWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IDeskBand"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDockingWindow(IDeskBand value)
    {
        return new Silk.NET.Windows.IDockingWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IDeskBand"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IDeskBand(Silk.NET.Windows.IOleWindow value)
    {
        return new IDeskBand(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeskBand"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IDeskBand"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IDeskBand value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeskBand"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeskBand(Silk.NET.Windows.IUnknown value)
    {
        return new IDeskBand(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeskBand"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeskBand"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeskBand value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
