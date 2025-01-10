// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79D16DE4-ABEE-4021-8D9D-9169B261D657")]
[NativeTypeName("struct IDeskBand2 : IDeskBand")]
[NativeInheritance("IDeskBand")]
public unsafe partial struct IDeskBand2 : IDeskBand2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeskBand2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeskBand2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDeskBand2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeskBand2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IDeskBand2, HWND*, int>)((*lpVtbl)[3]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IDeskBand2, BOOL, int>)((*lpVtbl)[4]))(this, fEnterMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ShowDW(BOOL fShow)
    {
        return ((delegate* unmanaged<IDeskBand2, BOOL, int>)((*lpVtbl)[5]))(this, fShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CloseDW([NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<IDeskBand2, uint, int>)((*lpVtbl)[6]))(this, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResizeBorderDW(
        [NativeTypeName("LPCRECT")] RECT* prcBorder,
        IUnknown punkToolbarSite,
        BOOL fReserved
    )
    {
        return ((delegate* unmanaged<IDeskBand2, RECT*, IUnknown, BOOL, int>)((*lpVtbl)[7]))(
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
        return ((delegate* unmanaged<IDeskBand2, uint, uint, DESKBANDINFO*, int>)((*lpVtbl)[8]))(
            this,
            dwBandID,
            dwViewMode,
            pdbi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CanRenderComposited(BOOL* pfCanRenderComposited)
    {
        return ((delegate* unmanaged<IDeskBand2, BOOL*, int>)((*lpVtbl)[9]))(
            this,
            pfCanRenderComposited
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetCompositionState(BOOL fCompositionEnabled)
    {
        return ((delegate* unmanaged<IDeskBand2, BOOL, int>)((*lpVtbl)[10]))(
            this,
            fCompositionEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCompositionState(BOOL* pfCompositionEnabled)
    {
        return ((delegate* unmanaged<IDeskBand2, BOOL*, int>)((*lpVtbl)[11]))(
            this,
            pfCompositionEnabled
        );
    }

    public interface Interface : IDeskBand.Interface
    {
        [VtblIndex(9)]
        HRESULT CanRenderComposited(BOOL* pfCanRenderComposited);

        [VtblIndex(10)]
        HRESULT SetCompositionState(BOOL fCompositionEnabled);

        [VtblIndex(11)]
        HRESULT GetCompositionState(BOOL* pfCompositionEnabled);
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

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> CanRenderComposited;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetCompositionState;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetCompositionState;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeskBand2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeskBand2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDeskBand"/> to <see cref = "IDeskBand2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDeskBand"/> instance to be converted </param>
    public static explicit operator IDeskBand2(Silk.NET.Windows.IDeskBand value)
    {
        return new IDeskBand2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeskBand2"/> to <see cref = "Silk.NET.Windows.IDeskBand"/>.</summary>
    /// <param name = "value">The <see cref = "IDeskBand2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDeskBand(IDeskBand2 value)
    {
        return new Silk.NET.Windows.IDeskBand(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDockingWindow"/> to <see cref = "IDeskBand2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDockingWindow"/> instance to be converted </param>
    public static explicit operator IDeskBand2(Silk.NET.Windows.IDockingWindow value)
    {
        return new IDeskBand2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeskBand2"/> to <see cref = "Silk.NET.Windows.IDockingWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IDeskBand2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDockingWindow(IDeskBand2 value)
    {
        return new Silk.NET.Windows.IDockingWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IDeskBand2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IDeskBand2(Silk.NET.Windows.IOleWindow value)
    {
        return new IDeskBand2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeskBand2"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IDeskBand2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IDeskBand2 value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeskBand2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeskBand2(Silk.NET.Windows.IUnknown value)
    {
        return new IDeskBand2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeskBand2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeskBand2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeskBand2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
