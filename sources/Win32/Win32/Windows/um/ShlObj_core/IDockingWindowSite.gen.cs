// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2A342FC2-7B26-11D0-8CA9-00A0C92DBFE8")]
[NativeTypeName("struct IDockingWindowSite : IOleWindow")]
[NativeInheritance("IOleWindow")]
public unsafe partial struct IDockingWindowSite : IDockingWindowSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDockingWindowSite));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDockingWindowSite, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDockingWindowSite, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDockingWindowSite, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IDockingWindowSite, HWND*, int>)((*lpVtbl)[3]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IDockingWindowSite, BOOL, int>)((*lpVtbl)[4]))(
            this,
            fEnterMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBorderDW(IUnknown punkObj, RECT* prcBorder)
    {
        return ((delegate* unmanaged<IDockingWindowSite, IUnknown, RECT*, int>)((*lpVtbl)[5]))(
            this,
            punkObj,
            prcBorder
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestBorderSpaceDW(
        IUnknown punkObj,
        [NativeTypeName("LPCBORDERWIDTHS")] RECT* pbw
    )
    {
        return ((delegate* unmanaged<IDockingWindowSite, IUnknown, RECT*, int>)((*lpVtbl)[6]))(
            this,
            punkObj,
            pbw
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetBorderSpaceDW(IUnknown punkObj, [NativeTypeName("LPCBORDERWIDTHS")] RECT* pbw)
    {
        return ((delegate* unmanaged<IDockingWindowSite, IUnknown, RECT*, int>)((*lpVtbl)[7]))(
            this,
            punkObj,
            pbw
        );
    }

    public interface Interface : IOleWindow.Interface
    {
        [VtblIndex(5)]
        HRESULT GetBorderDW(IUnknown punkObj, RECT* prcBorder);

        [VtblIndex(6)]
        HRESULT RequestBorderSpaceDW(
            IUnknown punkObj,
            [NativeTypeName("LPCBORDERWIDTHS")] RECT* pbw
        );

        [VtblIndex(7)]
        HRESULT SetBorderSpaceDW(IUnknown punkObj, [NativeTypeName("LPCBORDERWIDTHS")] RECT* pbw);
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

        [NativeTypeName(
            "HRESULT (IUnknown *, RECT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUnknown, RECT*, int> GetBorderDW;

        [NativeTypeName(
            "HRESULT (IUnknown *, LPCBORDERWIDTHS) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUnknown, RECT*, int> RequestBorderSpaceDW;

        [NativeTypeName(
            "HRESULT (IUnknown *, LPCBORDERWIDTHS) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUnknown, RECT*, int> SetBorderSpaceDW;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDockingWindowSite"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDockingWindowSite(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IDockingWindowSite"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IDockingWindowSite(Silk.NET.Windows.IOleWindow value)
    {
        return new IDockingWindowSite(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDockingWindowSite"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IDockingWindowSite"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IDockingWindowSite value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDockingWindowSite"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDockingWindowSite(Silk.NET.Windows.IUnknown value)
    {
        return new IDockingWindowSite(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDockingWindowSite"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDockingWindowSite"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDockingWindowSite value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
