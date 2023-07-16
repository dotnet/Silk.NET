// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2"]/*'/>
[Guid("3050F82D-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLTableCell2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLTableCell2 : IHTMLTableCell2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLTableCell2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, uint> )(lpVtbl[1]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, uint> )(lpVtbl[2]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, uint*, int> )(lpVtbl[3]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2.put_abbr"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_abbr([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, ushort*, int> )(lpVtbl[7]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2.get_abbr"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_abbr([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, ushort**, int> )(lpVtbl[8]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2.put_axis"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_axis([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, ushort*, int> )(lpVtbl[9]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2.get_axis"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_axis([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, ushort**, int> )(lpVtbl[10]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2.put_ch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ch([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, ushort*, int> )(lpVtbl[11]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2.get_ch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ch([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, ushort**, int> )(lpVtbl[12]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2.put_chOff"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_chOff([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, ushort*, int> )(lpVtbl[13]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2.get_chOff"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_chOff([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, ushort**, int> )(lpVtbl[14]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2.put_headers"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_headers([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, ushort*, int> )(lpVtbl[15]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2.get_headers"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_headers([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, ushort**, int> )(lpVtbl[16]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2.put_scope"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_scope([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, ushort*, int> )(lpVtbl[17]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableCell2.xml' path='doc/member[@name="IHTMLTableCell2.get_scope"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_scope([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableCell2*, ushort**, int> )(lpVtbl[18]))((IHTMLTableCell2*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_abbr([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_abbr([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_axis([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_axis([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_ch([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_ch([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT put_chOff([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_chOff([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT put_headers([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(16)]
        HRESULT get_headers([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(17)]
        HRESULT put_scope([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(18)]
        HRESULT get_scope([NativeTypeName("BSTR *")] ushort** p);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_abbr;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_abbr;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_axis;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_axis;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_ch;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ch;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_chOff;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_chOff;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_headers;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_headers;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_scope;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_scope;
    }
}