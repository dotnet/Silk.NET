// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2433BF8E-0F9B-435C-BA2C-180611978C30")]
[NativeTypeName("struct ITfContextView : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfContextView : ITfContextView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfContextView));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfContextView, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfContextView, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfContextView, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRangeFromPoint(
        [NativeTypeName("TfEditCookie")] uint ec,
        [NativeTypeName("const POINT *")] POINT* ppt,
        [NativeTypeName("DWORD")] uint dwFlags,
        ITfRange* ppRange
    )
    {
        return (
            (delegate* unmanaged<ITfContextView, uint, POINT*, uint, ITfRange*, int>)((*lpVtbl)[3])
        )(this, ec, ppt, dwFlags, ppRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTextExt(
        [NativeTypeName("TfEditCookie")] uint ec,
        ITfRange pRange,
        RECT* prc,
        BOOL* pfClipped
    )
    {
        return (
            (delegate* unmanaged<ITfContextView, uint, ITfRange, RECT*, BOOL*, int>)((*lpVtbl)[4])
        )(this, ec, pRange, prc, pfClipped);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetScreenExt(RECT* prc)
    {
        return ((delegate* unmanaged<ITfContextView, RECT*, int>)((*lpVtbl)[5]))(this, prc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetWnd(HWND* phwnd)
    {
        return ((delegate* unmanaged<ITfContextView, HWND*, int>)((*lpVtbl)[6]))(this, phwnd);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRangeFromPoint(
            [NativeTypeName("TfEditCookie")] uint ec,
            [NativeTypeName("const POINT *")] POINT* ppt,
            [NativeTypeName("DWORD")] uint dwFlags,
            ITfRange* ppRange
        );

        [VtblIndex(4)]
        HRESULT GetTextExt(
            [NativeTypeName("TfEditCookie")] uint ec,
            ITfRange pRange,
            RECT* prc,
            BOOL* pfClipped
        );

        [VtblIndex(5)]
        HRESULT GetScreenExt(RECT* prc);

        [VtblIndex(6)]
        HRESULT GetWnd(HWND* phwnd);
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

        [NativeTypeName(
            "HRESULT (TfEditCookie, const POINT *, DWORD, ITfRange **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, POINT*, uint, ITfRange*, int> GetRangeFromPoint;

        [NativeTypeName(
            "HRESULT (TfEditCookie, ITfRange *, RECT *, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ITfRange, RECT*, BOOL*, int> GetTextExt;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> GetScreenExt;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWnd;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfContextView"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfContextView(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfContextView"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfContextView(Silk.NET.Windows.IUnknown value)
    {
        return new ITfContextView(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfContextView"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfContextView"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfContextView value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
