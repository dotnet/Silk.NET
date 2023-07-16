// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CIE4ConnectionPoint.xml' path='doc/member[@name="CIE4ConnectionPoint"]/*'/>
[Guid("00000000-0000-0000-0000-000000000000")]
[NativeTypeName("struct CIE4ConnectionPoint : IConnectionPoint")]
[NativeInheritance("IConnectionPoint")]
public unsafe partial struct CIE4ConnectionPoint : CIE4ConnectionPoint.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CIE4ConnectionPoint));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint*, Guid*, void**, int> )(lpVtbl[0]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint*, uint> )(lpVtbl[1]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint*, uint> )(lpVtbl[2]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IConnectionPoint.GetConnectionInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetConnectionInterface([NativeTypeName("IID *")] Guid* pIID)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint*, Guid*, int> )(lpVtbl[3]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), pIID);
    }

    /// <inheritdoc cref = "IConnectionPoint.GetConnectionPointContainer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetConnectionPointContainer(IConnectionPointContainer** ppCPC)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint*, IConnectionPointContainer**, int> )(lpVtbl[4]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), ppCPC);
    }

    /// <inheritdoc cref = "IConnectionPoint.Advise"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Advise(IUnknown* pUnkSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint*, IUnknown*, uint*, int> )(lpVtbl[5]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), pUnkSink, pdwCookie);
    }

    /// <inheritdoc cref = "IConnectionPoint.Unadvise"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint*, uint, int> )(lpVtbl[6]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <inheritdoc cref = "IConnectionPoint.EnumConnections"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumConnections(IEnumConnections** ppEnum)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint*, IEnumConnections**, int> )(lpVtbl[7]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='CIE4ConnectionPoint.xml' path='doc/member[@name="CIE4ConnectionPoint.DoInvokeIE4"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DoInvokeIE4(BOOL* pf, void** ppv, [NativeTypeName("DISPID")] int dispid, DISPPARAMS* pdispparams)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint*, BOOL*, void**, int, DISPPARAMS*, int> )(lpVtbl[8]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), pf, ppv, dispid, pdispparams);
    }

    /// <include file='CIE4ConnectionPoint.xml' path='doc/member[@name="CIE4ConnectionPoint.DoInvokePIDLIE4"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DoInvokePIDLIE4([NativeTypeName("DISPID")] int dispid, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, BOOL fCanCancel)
    {
        return ((delegate* unmanaged<CIE4ConnectionPoint*, int, ITEMIDLIST*, BOOL, int> )(lpVtbl[9]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), dispid, pidl, fCanCancel);
    }

    public interface Interface : IConnectionPoint.Interface
    {
        [VtblIndex(8)]
        HRESULT DoInvokeIE4(BOOL* pf, void** ppv, [NativeTypeName("DISPID")] int dispid, DISPPARAMS* pdispparams);
        [VtblIndex(9)]
        HRESULT DoInvokePIDLIE4([NativeTypeName("DISPID")] int dispid, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, BOOL fCanCancel);
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
        [NativeTypeName("HRESULT (IID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetConnectionInterface;
        [NativeTypeName("HRESULT (IConnectionPointContainer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IConnectionPointContainer**, int> GetConnectionPointContainer;
        [NativeTypeName("HRESULT (IUnknown *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint*, int> Advise;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;
        [NativeTypeName("HRESULT (IEnumConnections **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumConnections**, int> EnumConnections;
        [NativeTypeName("HRESULT (BOOL *, void **, DISPID, DISPPARAMS *)")]
        public delegate* unmanaged<TSelf*, BOOL*, void**, int, DISPPARAMS*, int> DoInvokeIE4;
        [NativeTypeName("HRESULT (DISPID, LPCITEMIDLIST, BOOL)")]
        public delegate* unmanaged<TSelf*, int, ITEMIDLIST*, BOOL, int> DoInvokePIDLIE4;
    }
}