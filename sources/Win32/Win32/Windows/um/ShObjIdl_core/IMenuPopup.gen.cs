// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D1E7AFEB-6A2E-11D0-8C78-00C04FD918B4")]
[NativeTypeName("struct IMenuPopup : IDeskBar")]
[NativeInheritance("IDeskBar")]
public unsafe partial struct IMenuPopup : IMenuPopup.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMenuPopup));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMenuPopup, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMenuPopup, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMenuPopup, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IMenuPopup, HWND*, int>)((*lpVtbl)[3]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IMenuPopup, BOOL, int>)((*lpVtbl)[4]))(this, fEnterMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetClient(IUnknown punkClient)
    {
        return ((delegate* unmanaged<IMenuPopup, IUnknown, int>)((*lpVtbl)[5]))(this, punkClient);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetClient(IUnknown* ppunkClient)
    {
        return ((delegate* unmanaged<IMenuPopup, IUnknown*, int>)((*lpVtbl)[6]))(this, ppunkClient);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnPosRectChangeDB(RECT* prc)
    {
        return ((delegate* unmanaged<IMenuPopup, RECT*, int>)((*lpVtbl)[7]))(this, prc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Popup(
        POINTL* ppt,
        RECTL* prcExclude,
        [NativeTypeName("MP_POPUPFLAGS")] int dwFlags
    )
    {
        return ((delegate* unmanaged<IMenuPopup, POINTL*, RECTL*, int, int>)((*lpVtbl)[8]))(
            this,
            ppt,
            prcExclude,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnSelect([NativeTypeName("DWORD")] uint dwSelectType)
    {
        return ((delegate* unmanaged<IMenuPopup, uint, int>)((*lpVtbl)[9]))(this, dwSelectType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetSubMenu(IMenuPopup pmp, BOOL fSet)
    {
        return ((delegate* unmanaged<IMenuPopup, IMenuPopup, BOOL, int>)((*lpVtbl)[10]))(
            this,
            pmp,
            fSet
        );
    }

    public interface Interface : IDeskBar.Interface
    {
        [VtblIndex(8)]
        HRESULT Popup(
            POINTL* ppt,
            RECTL* prcExclude,
            [NativeTypeName("MP_POPUPFLAGS")] int dwFlags
        );

        [VtblIndex(9)]
        HRESULT OnSelect([NativeTypeName("DWORD")] uint dwSelectType);

        [VtblIndex(10)]
        HRESULT SetSubMenu(IMenuPopup pmp, BOOL fSet);
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

        [NativeTypeName("HRESULT (POINTL *, RECTL *, MP_POPUPFLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINTL*, RECTL*, int, int> Popup;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnSelect;

        [NativeTypeName("HRESULT (IMenuPopup *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMenuPopup, BOOL, int> SetSubMenu;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMenuPopup"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMenuPopup(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDeskBar"/> to <see cref = "IMenuPopup"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDeskBar"/> instance to be converted </param>
    public static explicit operator IMenuPopup(Silk.NET.Windows.IDeskBar value)
    {
        return new IMenuPopup(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMenuPopup"/> to <see cref = "Silk.NET.Windows.IDeskBar"/>.</summary>
    /// <param name = "value">The <see cref = "IMenuPopup"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDeskBar(IMenuPopup value)
    {
        return new Silk.NET.Windows.IDeskBar(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IMenuPopup"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IMenuPopup(Silk.NET.Windows.IOleWindow value)
    {
        return new IMenuPopup(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMenuPopup"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IMenuPopup"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IMenuPopup value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMenuPopup"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMenuPopup(Silk.NET.Windows.IUnknown value)
    {
        return new IMenuPopup(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMenuPopup"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMenuPopup"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMenuPopup value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
