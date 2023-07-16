// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLAnchorElement2.xml' path='doc/member[@name="IHTMLAnchorElement2"]/*'/>
[Guid("3050F825-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLAnchorElement2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLAnchorElement2 : IHTMLAnchorElement2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLAnchorElement2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, uint> )(lpVtbl[1]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, uint> )(lpVtbl[2]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, uint*, int> )(lpVtbl[3]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLAnchorElement2.xml' path='doc/member[@name="IHTMLAnchorElement2.put_charset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_charset([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, ushort*, int> )(lpVtbl[7]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement2.xml' path='doc/member[@name="IHTMLAnchorElement2.get_charset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_charset([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, ushort**, int> )(lpVtbl[8]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement2.xml' path='doc/member[@name="IHTMLAnchorElement2.put_coords"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_coords([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, ushort*, int> )(lpVtbl[9]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement2.xml' path='doc/member[@name="IHTMLAnchorElement2.get_coords"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_coords([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, ushort**, int> )(lpVtbl[10]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement2.xml' path='doc/member[@name="IHTMLAnchorElement2.put_hreflang"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_hreflang([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, ushort*, int> )(lpVtbl[11]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement2.xml' path='doc/member[@name="IHTMLAnchorElement2.get_hreflang"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_hreflang([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, ushort**, int> )(lpVtbl[12]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement2.xml' path='doc/member[@name="IHTMLAnchorElement2.put_shape"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_shape([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, ushort*, int> )(lpVtbl[13]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement2.xml' path='doc/member[@name="IHTMLAnchorElement2.get_shape"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_shape([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, ushort**, int> )(lpVtbl[14]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement2.xml' path='doc/member[@name="IHTMLAnchorElement2.put_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_type([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, ushort*, int> )(lpVtbl[15]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement2.xml' path='doc/member[@name="IHTMLAnchorElement2.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement2*, ushort**, int> )(lpVtbl[16]))((IHTMLAnchorElement2*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_charset([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_charset([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_coords([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_coords([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_hreflang([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_hreflang([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT put_shape([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_shape([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT put_type([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(16)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_charset;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_charset;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_coords;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_coords;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_hreflang;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_hreflang;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_shape;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_shape;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_type;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;
    }
}