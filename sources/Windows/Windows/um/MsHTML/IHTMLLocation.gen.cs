// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation"]/*'/>
[Guid("163BB1E0-6E00-11CF-837A-48DC04C10000")]
[NativeTypeName("struct IHTMLLocation : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLLocation : IHTMLLocation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLLocation));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLLocation*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLLocation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLLocation*, uint> )(lpVtbl[1]))((IHTMLLocation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLLocation*, uint> )(lpVtbl[2]))((IHTMLLocation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLLocation*, uint*, int> )(lpVtbl[3]))((IHTMLLocation*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLLocation*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLLocation*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLLocation*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLLocation*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLLocation*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLLocation*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.put_href"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_href([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort*, int> )(lpVtbl[7]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.get_href"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_href([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort**, int> )(lpVtbl[8]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.put_protocol"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_protocol([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort*, int> )(lpVtbl[9]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.get_protocol"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_protocol([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort**, int> )(lpVtbl[10]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.put_host"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_host([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort*, int> )(lpVtbl[11]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.get_host"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_host([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort**, int> )(lpVtbl[12]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.put_hostname"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_hostname([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort*, int> )(lpVtbl[13]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.get_hostname"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_hostname([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort**, int> )(lpVtbl[14]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.put_port"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_port([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort*, int> )(lpVtbl[15]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.get_port"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_port([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort**, int> )(lpVtbl[16]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.put_pathname"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_pathname([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort*, int> )(lpVtbl[17]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.get_pathname"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_pathname([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort**, int> )(lpVtbl[18]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.put_search"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_search([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort*, int> )(lpVtbl[19]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.get_search"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_search([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort**, int> )(lpVtbl[20]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.put_hash"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_hash([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort*, int> )(lpVtbl[21]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.get_hash"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_hash([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort**, int> )(lpVtbl[22]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.reload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT reload([NativeTypeName("VARIANT_BOOL")] short flag = 0)
    {
        return ((delegate* unmanaged<IHTMLLocation*, short, int> )(lpVtbl[23]))((IHTMLLocation*)Unsafe.AsPointer(ref this), flag);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.replace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT replace([NativeTypeName("BSTR")] ushort* bstr)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort*, int> )(lpVtbl[24]))((IHTMLLocation*)Unsafe.AsPointer(ref this), bstr);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.assign"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT assign([NativeTypeName("BSTR")] ushort* bstr)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort*, int> )(lpVtbl[25]))((IHTMLLocation*)Unsafe.AsPointer(ref this), bstr);
    }

    /// <include file='IHTMLLocation.xml' path='doc/member[@name="IHTMLLocation.toString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT toString([NativeTypeName("BSTR *")] ushort** @string)
    {
        return ((delegate* unmanaged<IHTMLLocation*, ushort**, int> )(lpVtbl[26]))((IHTMLLocation*)Unsafe.AsPointer(ref this), @string);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_href([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_href([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_protocol([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_protocol([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_host([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_host([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT put_hostname([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_hostname([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT put_port([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(16)]
        HRESULT get_port([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(17)]
        HRESULT put_pathname([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(18)]
        HRESULT get_pathname([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(19)]
        HRESULT put_search([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(20)]
        HRESULT get_search([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(21)]
        HRESULT put_hash([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(22)]
        HRESULT get_hash([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(23)]
        HRESULT reload([NativeTypeName("VARIANT_BOOL")] short flag = 0);
        [VtblIndex(24)]
        HRESULT replace([NativeTypeName("BSTR")] ushort* bstr);
        [VtblIndex(25)]
        HRESULT assign([NativeTypeName("BSTR")] ushort* bstr);
        [VtblIndex(26)]
        HRESULT toString([NativeTypeName("BSTR *")] ushort** @string);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_href;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_href;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_protocol;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_protocol;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_host;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_host;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_hostname;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_hostname;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_port;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_port;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_pathname;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_pathname;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_search;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_search;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_hash;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_hash;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> reload;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> replace;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> assign;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> toString;
    }
}