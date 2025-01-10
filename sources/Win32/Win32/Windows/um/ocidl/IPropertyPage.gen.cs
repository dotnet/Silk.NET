// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B196B28D-BAB4-101A-B69C-00AA00341D07")]
[NativeTypeName("struct IPropertyPage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyPage : IPropertyPage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyPage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyPage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertyPage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyPage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPageSite(IPropertyPageSite pPageSite)
    {
        return ((delegate* unmanaged<IPropertyPage, IPropertyPageSite, int>)((*lpVtbl)[3]))(
            this,
            pPageSite
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Activate(HWND hWndParent, [NativeTypeName("LPCRECT")] RECT* pRect, BOOL bModal)
    {
        return ((delegate* unmanaged<IPropertyPage, HWND, RECT*, BOOL, int>)((*lpVtbl)[4]))(
            this,
            hWndParent,
            pRect,
            bModal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Deactivate()
    {
        return ((delegate* unmanaged<IPropertyPage, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPageInfo(PROPPAGEINFO* pPageInfo)
    {
        return ((delegate* unmanaged<IPropertyPage, PROPPAGEINFO*, int>)((*lpVtbl)[6]))(
            this,
            pPageInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetObjects([NativeTypeName("ULONG")] uint cObjects, IUnknown* ppUnk)
    {
        return ((delegate* unmanaged<IPropertyPage, uint, IUnknown*, int>)((*lpVtbl)[7]))(
            this,
            cObjects,
            ppUnk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Show(uint nCmdShow)
    {
        return ((delegate* unmanaged<IPropertyPage, uint, int>)((*lpVtbl)[8]))(this, nCmdShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Move([NativeTypeName("LPCRECT")] RECT* pRect)
    {
        return ((delegate* unmanaged<IPropertyPage, RECT*, int>)((*lpVtbl)[9]))(this, pRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsPageDirty()
    {
        return ((delegate* unmanaged<IPropertyPage, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Apply()
    {
        return ((delegate* unmanaged<IPropertyPage, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Help([NativeTypeName("LPCOLESTR")] ushort* pszHelpDir)
    {
        return ((delegate* unmanaged<IPropertyPage, ushort*, int>)((*lpVtbl)[12]))(
            this,
            pszHelpDir
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT TranslateAccelerator(MSG* pMsg)
    {
        return ((delegate* unmanaged<IPropertyPage, MSG*, int>)((*lpVtbl)[13]))(this, pMsg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetPageSite(IPropertyPageSite pPageSite);

        [VtblIndex(4)]
        HRESULT Activate(HWND hWndParent, [NativeTypeName("LPCRECT")] RECT* pRect, BOOL bModal);

        [VtblIndex(5)]
        HRESULT Deactivate();

        [VtblIndex(6)]
        HRESULT GetPageInfo(PROPPAGEINFO* pPageInfo);

        [VtblIndex(7)]
        HRESULT SetObjects([NativeTypeName("ULONG")] uint cObjects, IUnknown* ppUnk);

        [VtblIndex(8)]
        HRESULT Show(uint nCmdShow);

        [VtblIndex(9)]
        HRESULT Move([NativeTypeName("LPCRECT")] RECT* pRect);

        [VtblIndex(10)]
        HRESULT IsPageDirty();

        [VtblIndex(11)]
        HRESULT Apply();

        [VtblIndex(12)]
        HRESULT Help([NativeTypeName("LPCOLESTR")] ushort* pszHelpDir);

        [VtblIndex(13)]
        HRESULT TranslateAccelerator(MSG* pMsg);
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

        [NativeTypeName("HRESULT (IPropertyPageSite *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyPageSite, int> SetPageSite;

        [NativeTypeName("HRESULT (HWND, LPCRECT, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, RECT*, BOOL, int> Activate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Deactivate;

        [NativeTypeName("HRESULT (PROPPAGEINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPPAGEINFO*, int> GetPageInfo;

        [NativeTypeName("HRESULT (ULONG, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown*, int> SetObjects;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Show;

        [NativeTypeName("HRESULT (LPCRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> Move;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsPageDirty;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Apply;

        [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> Help;

        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> TranslateAccelerator;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyPage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyPage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyPage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyPage(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyPage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyPage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyPage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyPage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
