// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AA80E80C-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITfContextOwner : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfContextOwner : ITfContextOwner.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfContextOwner));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfContextOwner, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfContextOwner, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfContextOwner, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetACPFromPoint(
        [NativeTypeName("const POINT *")] POINT* ptScreen,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LONG *")] int* pacp
    )
    {
        return ((delegate* unmanaged<ITfContextOwner, POINT*, uint, int*, int>)((*lpVtbl)[3]))(
            this,
            ptScreen,
            dwFlags,
            pacp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTextExt(
        [NativeTypeName("LONG")] int acpStart,
        [NativeTypeName("LONG")] int acpEnd,
        RECT* prc,
        BOOL* pfClipped
    )
    {
        return ((delegate* unmanaged<ITfContextOwner, int, int, RECT*, BOOL*, int>)((*lpVtbl)[4]))(
            this,
            acpStart,
            acpEnd,
            prc,
            pfClipped
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetScreenExt(RECT* prc)
    {
        return ((delegate* unmanaged<ITfContextOwner, RECT*, int>)((*lpVtbl)[5]))(this, prc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStatus([NativeTypeName("TF_STATUS *")] TS_STATUS* pdcs)
    {
        return ((delegate* unmanaged<ITfContextOwner, TS_STATUS*, int>)((*lpVtbl)[6]))(this, pdcs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetWnd(HWND* phwnd)
    {
        return ((delegate* unmanaged<ITfContextOwner, HWND*, int>)((*lpVtbl)[7]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAttribute(
        [NativeTypeName("const GUID &")] Guid* rguidAttribute,
        VARIANT* pvarValue
    )
    {
        return ((delegate* unmanaged<ITfContextOwner, Guid*, VARIANT*, int>)((*lpVtbl)[8]))(
            this,
            rguidAttribute,
            pvarValue
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetACPFromPoint(
            [NativeTypeName("const POINT *")] POINT* ptScreen,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("LONG *")] int* pacp
        );

        [VtblIndex(4)]
        HRESULT GetTextExt(
            [NativeTypeName("LONG")] int acpStart,
            [NativeTypeName("LONG")] int acpEnd,
            RECT* prc,
            BOOL* pfClipped
        );

        [VtblIndex(5)]
        HRESULT GetScreenExt(RECT* prc);

        [VtblIndex(6)]
        HRESULT GetStatus([NativeTypeName("TF_STATUS *")] TS_STATUS* pdcs);

        [VtblIndex(7)]
        HRESULT GetWnd(HWND* phwnd);

        [VtblIndex(8)]
        HRESULT GetAttribute(
            [NativeTypeName("const GUID &")] Guid* rguidAttribute,
            VARIANT* pvarValue
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

        [NativeTypeName("HRESULT (const POINT *, DWORD, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, uint, int*, int> GetACPFromPoint;

        [NativeTypeName("HRESULT (LONG, LONG, RECT *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, RECT*, BOOL*, int> GetTextExt;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> GetScreenExt;

        [NativeTypeName("HRESULT (TF_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TS_STATUS*, int> GetStatus;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWnd;

        [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT*, int> GetAttribute;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfContextOwner"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfContextOwner(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfContextOwner"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfContextOwner(Silk.NET.Windows.IUnknown value)
    {
        return new ITfContextOwner(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfContextOwner"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfContextOwner"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfContextOwner value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
