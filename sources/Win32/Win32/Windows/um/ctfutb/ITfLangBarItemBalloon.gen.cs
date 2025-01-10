// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("01C2D285-D3C7-4B7B-B5B5-D97411D0C283")]
[NativeTypeName("struct ITfLangBarItemBalloon : ITfLangBarItem")]
[NativeInheritance("ITfLangBarItem")]
public unsafe partial struct ITfLangBarItemBalloon : ITfLangBarItemBalloon.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfLangBarItemBalloon));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfLangBarItemBalloon, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfLangBarItemBalloon, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfLangBarItemBalloon, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetInfo(TF_LANGBARITEMINFO* pInfo)
    {
        return (
            (delegate* unmanaged<ITfLangBarItemBalloon, TF_LANGBARITEMINFO*, int>)((*lpVtbl)[3])
        )(this, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
    {
        return ((delegate* unmanaged<ITfLangBarItemBalloon, uint*, int>)((*lpVtbl)[4]))(
            this,
            pdwStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL fShow)
    {
        return ((delegate* unmanaged<ITfLangBarItemBalloon, BOOL, int>)((*lpVtbl)[5]))(this, fShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetTooltipString([NativeTypeName("BSTR *")] ushort** pbstrToolTip)
    {
        return ((delegate* unmanaged<ITfLangBarItemBalloon, ushort**, int>)((*lpVtbl)[6]))(
            this,
            pbstrToolTip
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnClick(
        TfLBIClick click,
        POINT pt,
        [NativeTypeName("const RECT *")] RECT* prcArea
    )
    {
        return (
            (delegate* unmanaged<ITfLangBarItemBalloon, TfLBIClick, POINT, RECT*, int>)(
                (*lpVtbl)[7]
            )
        )(this, click, pt, prcArea);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPreferredSize([NativeTypeName("const SIZE *")] SIZE* pszDefault, SIZE* psz)
    {
        return ((delegate* unmanaged<ITfLangBarItemBalloon, SIZE*, SIZE*, int>)((*lpVtbl)[8]))(
            this,
            pszDefault,
            psz
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBalloonInfo(TF_LBBALLOONINFO* pInfo)
    {
        return ((delegate* unmanaged<ITfLangBarItemBalloon, TF_LBBALLOONINFO*, int>)((*lpVtbl)[9]))(
            this,
            pInfo
        );
    }

    public interface Interface : ITfLangBarItem.Interface
    {
        [VtblIndex(7)]
        HRESULT OnClick(TfLBIClick click, POINT pt, [NativeTypeName("const RECT *")] RECT* prcArea);

        [VtblIndex(8)]
        HRESULT GetPreferredSize([NativeTypeName("const SIZE *")] SIZE* pszDefault, SIZE* psz);

        [VtblIndex(9)]
        HRESULT GetBalloonInfo(TF_LBBALLOONINFO* pInfo);
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

        [NativeTypeName("HRESULT (TF_LANGBARITEMINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TF_LANGBARITEMINFO*, int> GetInfo;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetStatus;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Show;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetTooltipString;

        [NativeTypeName("HRESULT (TfLBIClick, POINT, const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TfLBIClick, POINT, RECT*, int> OnClick;

        [NativeTypeName("HRESULT (const SIZE *, SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, SIZE*, int> GetPreferredSize;

        [NativeTypeName("HRESULT (TF_LBBALLOONINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TF_LBBALLOONINFO*, int> GetBalloonInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfLangBarItemBalloon"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfLangBarItemBalloon(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfLangBarItem"/> to <see cref = "ITfLangBarItemBalloon"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfLangBarItem"/> instance to be converted </param>
    public static explicit operator ITfLangBarItemBalloon(Silk.NET.Windows.ITfLangBarItem value)
    {
        return new ITfLangBarItemBalloon(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfLangBarItemBalloon"/> to <see cref = "Silk.NET.Windows.ITfLangBarItem"/>.</summary>
    /// <param name = "value">The <see cref = "ITfLangBarItemBalloon"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfLangBarItem(ITfLangBarItemBalloon value)
    {
        return new Silk.NET.Windows.ITfLangBarItem(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfLangBarItemBalloon"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfLangBarItemBalloon(Silk.NET.Windows.IUnknown value)
    {
        return new ITfLangBarItemBalloon(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfLangBarItemBalloon"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfLangBarItemBalloon"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfLangBarItemBalloon value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
