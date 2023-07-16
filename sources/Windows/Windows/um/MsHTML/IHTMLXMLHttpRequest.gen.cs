// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest"]/*'/>
[Guid("3051040A-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLXMLHttpRequest : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLXMLHttpRequest : IHTMLXMLHttpRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLXMLHttpRequest));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, uint> )(lpVtbl[1]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, uint> )(lpVtbl[2]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, uint*, int> )(lpVtbl[3]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.get_readyState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_readyState([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, int*, int> )(lpVtbl[7]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.get_responseBody"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_responseBody(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, VARIANT*, int> )(lpVtbl[8]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.get_responseText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_responseText([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, ushort**, int> )(lpVtbl[9]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.get_responseXML"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_responseXML(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, IDispatch**, int> )(lpVtbl[10]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.get_status"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_status([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, int*, int> )(lpVtbl[11]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.get_statusText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_statusText([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, ushort**, int> )(lpVtbl[12]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.put_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_onreadystatechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, VARIANT, int> )(lpVtbl[13]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.get_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_onreadystatechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, VARIANT*, int> )(lpVtbl[14]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.abort"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT abort()
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, int> )(lpVtbl[15]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.open"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT open([NativeTypeName("BSTR")] ushort* bstrMethod, [NativeTypeName("BSTR")] ushort* bstrUrl, VARIANT varAsync, VARIANT varUser, VARIANT varPassword)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, ushort*, ushort*, VARIANT, VARIANT, VARIANT, int> )(lpVtbl[16]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrMethod, bstrUrl, varAsync, varUser, varPassword);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.send"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT send(VARIANT varBody)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, VARIANT, int> )(lpVtbl[17]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), varBody);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.getAllResponseHeaders"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT getAllResponseHeaders([NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLXMLHttpRequest0000)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, ushort**, int> )(lpVtbl[18]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), __MIDL__IHTMLXMLHttpRequest0000);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.getResponseHeader"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT getResponseHeader([NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLXMLHttpRequest0001)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, ushort*, ushort**, int> )(lpVtbl[19]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrHeader, __MIDL__IHTMLXMLHttpRequest0001);
    }

    /// <include file='IHTMLXMLHttpRequest.xml' path='doc/member[@name="IHTMLXMLHttpRequest.setRequestHeader"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT setRequestHeader([NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR")] ushort* bstrValue)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest*, ushort*, ushort*, int> )(lpVtbl[20]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrHeader, bstrValue);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_readyState([NativeTypeName("long *")] int* p);
        [VtblIndex(8)]
        HRESULT get_responseBody(VARIANT* p);
        [VtblIndex(9)]
        HRESULT get_responseText([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(10)]
        HRESULT get_responseXML(IDispatch** p);
        [VtblIndex(11)]
        HRESULT get_status([NativeTypeName("long *")] int* p);
        [VtblIndex(12)]
        HRESULT get_statusText([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT put_onreadystatechange(VARIANT v);
        [VtblIndex(14)]
        HRESULT get_onreadystatechange(VARIANT* p);
        [VtblIndex(15)]
        HRESULT abort();
        [VtblIndex(16)]
        HRESULT open([NativeTypeName("BSTR")] ushort* bstrMethod, [NativeTypeName("BSTR")] ushort* bstrUrl, VARIANT varAsync, VARIANT varUser, VARIANT varPassword);
        [VtblIndex(17)]
        HRESULT send(VARIANT varBody);
        [VtblIndex(18)]
        HRESULT getAllResponseHeaders([NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLXMLHttpRequest0000);
        [VtblIndex(19)]
        HRESULT getResponseHeader([NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLXMLHttpRequest0001);
        [VtblIndex(20)]
        HRESULT setRequestHeader([NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR")] ushort* bstrValue);
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
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_readyState;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_responseBody;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_responseText;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_responseXML;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_status;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_statusText;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreadystatechange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreadystatechange;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> abort;
        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT, VARIANT, VARIANT, int> open;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> send;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> getAllResponseHeaders;
        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> getResponseHeader;
        [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> setRequestHeader;
    }
}