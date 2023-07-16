// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfContextOwner.xml' path='doc/member[@name="ITfContextOwner"]/*'/>
[Guid("AA80E80C-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITfContextOwner : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfContextOwner : ITfContextOwner.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfContextOwner));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfContextOwner*, Guid*, void**, int> )(lpVtbl[0]))((ITfContextOwner*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfContextOwner*, uint> )(lpVtbl[1]))((ITfContextOwner*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfContextOwner*, uint> )(lpVtbl[2]))((ITfContextOwner*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfContextOwner.xml' path='doc/member[@name="ITfContextOwner.GetACPFromPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetACPFromPoint([NativeTypeName("const POINT *")] POINT* ptScreen, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG *")] int* pacp)
    {
        return ((delegate* unmanaged<ITfContextOwner*, POINT*, uint, int*, int> )(lpVtbl[3]))((ITfContextOwner*)Unsafe.AsPointer(ref this), ptScreen, dwFlags, pacp);
    }

    /// <include file='ITfContextOwner.xml' path='doc/member[@name="ITfContextOwner.GetTextExt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTextExt([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, RECT* prc, BOOL* pfClipped)
    {
        return ((delegate* unmanaged<ITfContextOwner*, int, int, RECT*, BOOL*, int> )(lpVtbl[4]))((ITfContextOwner*)Unsafe.AsPointer(ref this), acpStart, acpEnd, prc, pfClipped);
    }

    /// <include file='ITfContextOwner.xml' path='doc/member[@name="ITfContextOwner.GetScreenExt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetScreenExt(RECT* prc)
    {
        return ((delegate* unmanaged<ITfContextOwner*, RECT*, int> )(lpVtbl[5]))((ITfContextOwner*)Unsafe.AsPointer(ref this), prc);
    }

    /// <include file='ITfContextOwner.xml' path='doc/member[@name="ITfContextOwner.GetStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStatus([NativeTypeName("TF_STATUS *")] TS_STATUS* pdcs)
    {
        return ((delegate* unmanaged<ITfContextOwner*, TS_STATUS*, int> )(lpVtbl[6]))((ITfContextOwner*)Unsafe.AsPointer(ref this), pdcs);
    }

    /// <include file='ITfContextOwner.xml' path='doc/member[@name="ITfContextOwner.GetWnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetWnd(HWND* phwnd)
    {
        return ((delegate* unmanaged<ITfContextOwner*, HWND*, int> )(lpVtbl[7]))((ITfContextOwner*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <include file='ITfContextOwner.xml' path='doc/member[@name="ITfContextOwner.GetAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAttribute([NativeTypeName("const GUID &")] Guid* rguidAttribute, VARIANT* pvarValue)
    {
        return ((delegate* unmanaged<ITfContextOwner*, Guid*, VARIANT*, int> )(lpVtbl[8]))((ITfContextOwner*)Unsafe.AsPointer(ref this), rguidAttribute, pvarValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetACPFromPoint([NativeTypeName("const POINT *")] POINT* ptScreen, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG *")] int* pacp);
        [VtblIndex(4)]
        HRESULT GetTextExt([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, RECT* prc, BOOL* pfClipped);
        [VtblIndex(5)]
        HRESULT GetScreenExt(RECT* prc);
        [VtblIndex(6)]
        HRESULT GetStatus([NativeTypeName("TF_STATUS *")] TS_STATUS* pdcs);
        [VtblIndex(7)]
        HRESULT GetWnd(HWND* phwnd);
        [VtblIndex(8)]
        HRESULT GetAttribute([NativeTypeName("const GUID &")] Guid* rguidAttribute, VARIANT* pvarValue);
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
}