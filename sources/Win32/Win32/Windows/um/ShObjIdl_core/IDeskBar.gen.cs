// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EB0FE173-1A3A-11D0-89B3-00A0C90A90AC")]
[NativeTypeName("struct IDeskBar : IOleWindow")]
[NativeInheritance("IOleWindow")]
public unsafe partial struct IDeskBar : IDeskBar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeskBar));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeskBar, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDeskBar, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeskBar, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IDeskBar, HWND*, int>)((*lpVtbl)[3]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IDeskBar, BOOL, int>)((*lpVtbl)[4]))(this, fEnterMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetClient(IUnknown punkClient)
    {
        return ((delegate* unmanaged<IDeskBar, IUnknown, int>)((*lpVtbl)[5]))(this, punkClient);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetClient(IUnknown* ppunkClient)
    {
        return ((delegate* unmanaged<IDeskBar, IUnknown*, int>)((*lpVtbl)[6]))(this, ppunkClient);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnPosRectChangeDB(RECT* prc)
    {
        return ((delegate* unmanaged<IDeskBar, RECT*, int>)((*lpVtbl)[7]))(this, prc);
    }

    public interface Interface : IOleWindow.Interface
    {
        [VtblIndex(5)]
        HRESULT SetClient(IUnknown punkClient);

        [VtblIndex(6)]
        HRESULT GetClient(IUnknown* ppunkClient);

        [VtblIndex(7)]
        HRESULT OnPosRectChangeDB(RECT* prc);
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> SetClient;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> GetClient;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> OnPosRectChangeDB;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeskBar"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeskBar(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IDeskBar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IDeskBar(Silk.NET.Windows.IOleWindow value)
    {
        return new IDeskBar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeskBar"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IDeskBar"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IDeskBar value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeskBar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeskBar(Silk.NET.Windows.IUnknown value)
    {
        return new IDeskBar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeskBar"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeskBar"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeskBar value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
