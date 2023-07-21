// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6"]/*' />
[Guid("305106F8-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLElement6 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLElement6 : IHTMLElement6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLElement6));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLElement6*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElement6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLElement6*, uint>)(lpVtbl[1]))((IHTMLElement6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLElement6*, uint>)(lpVtbl[2]))((IHTMLElement6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLElement6*, uint*, int>)(lpVtbl[3]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLElement6*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElement6*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLElement6*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElement6*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLElement6*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElement6*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.getAttributeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT getAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* AttributeValue)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, ushort*, VARIANT*, int>)(lpVtbl[7]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pvarNS, strAttributeName, AttributeValue);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.setAttributeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT setAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* pvarAttributeValue)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, ushort*, VARIANT*, int>)(lpVtbl[8]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pvarNS, strAttributeName, pvarAttributeValue);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.removeAttributeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT removeAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* strAttributeName)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, ushort*, int>)(lpVtbl[9]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pvarNS, strAttributeName);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.getAttributeNodeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT getAttributeNodeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrname, IHTMLDOMAttribute2** ppretAttribute)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, ushort*, IHTMLDOMAttribute2**, int>)(lpVtbl[10]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pvarNS, bstrname, ppretAttribute);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.setAttributeNodeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT setAttributeNodeNS(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute)
    {
        return ((delegate* unmanaged<IHTMLElement6*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int>)(lpVtbl[11]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.hasAttributeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT hasAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("VARIANT_BOOL *")] short* pfHasAttribute)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, ushort*, short*, int>)(lpVtbl[12]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pvarNS, name, pfHasAttribute);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.getAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* AttributeValue)
    {
        return ((delegate* unmanaged<IHTMLElement6*, ushort*, VARIANT*, int>)(lpVtbl[13]))((IHTMLElement6*)Unsafe.AsPointer(ref this), strAttributeName, AttributeValue);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.setAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* pvarAttributeValue)
    {
        return ((delegate* unmanaged<IHTMLElement6*, ushort*, VARIANT*, int>)(lpVtbl[14]))((IHTMLElement6*)Unsafe.AsPointer(ref this), strAttributeName, pvarAttributeValue);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.removeAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName)
    {
        return ((delegate* unmanaged<IHTMLElement6*, ushort*, int>)(lpVtbl[15]))((IHTMLElement6*)Unsafe.AsPointer(ref this), strAttributeName);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.getAttributeNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT getAttributeNode([NativeTypeName("BSTR")] ushort* strAttributeName, IHTMLDOMAttribute2** ppretAttribute)
    {
        return ((delegate* unmanaged<IHTMLElement6*, ushort*, IHTMLDOMAttribute2**, int>)(lpVtbl[16]))((IHTMLElement6*)Unsafe.AsPointer(ref this), strAttributeName, ppretAttribute);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.setAttributeNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT setAttributeNode(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute)
    {
        return ((delegate* unmanaged<IHTMLElement6*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int>)(lpVtbl[17]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.removeAttributeNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT removeAttributeNode(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute)
    {
        return ((delegate* unmanaged<IHTMLElement6*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int>)(lpVtbl[18]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.hasAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT hasAttribute([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("VARIANT_BOOL *")] short* pfHasAttribute)
    {
        return ((delegate* unmanaged<IHTMLElement6*, ushort*, short*, int>)(lpVtbl[19]))((IHTMLElement6*)Unsafe.AsPointer(ref this), name, pfHasAttribute);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.getElementsByTagNameNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT getElementsByTagNameNS(VARIANT* varNS, [NativeTypeName("BSTR")] ushort* bstrLocalName, IHTMLElementCollection** pelColl)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, ushort*, IHTMLElementCollection**, int>)(lpVtbl[20]))((IHTMLElement6*)Unsafe.AsPointer(ref this), varNS, bstrLocalName, pelColl);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_tagName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_tagName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, ushort**, int>)(lpVtbl[21]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_nodeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, ushort**, int>)(lpVtbl[22]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.getElementsByClassName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT getElementsByClassName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pel)
    {
        return ((delegate* unmanaged<IHTMLElement6*, ushort*, IHTMLElementCollection**, int>)(lpVtbl[23]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v, pel);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.msMatchesSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT msMatchesSelector([NativeTypeName("BSTR")] ushort* v, [NativeTypeName("VARIANT_BOOL *")] short* pfMatches)
    {
        return ((delegate* unmanaged<IHTMLElement6*, ushort*, short*, int>)(lpVtbl[24]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v, pfMatches);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onabort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_onabort(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[25]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onabort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_onabort(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[26]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_oncanplay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_oncanplay(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[27]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_oncanplay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_oncanplay(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[28]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_oncanplaythrough"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_oncanplaythrough(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[29]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_oncanplaythrough"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_oncanplaythrough(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[30]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onchange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_onchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[31]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onchange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_onchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[32]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_ondurationchange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_ondurationchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[33]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_ondurationchange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_ondurationchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[34]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onemptied"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_onemptied(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[35]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onemptied"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_onemptied(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[36]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onended"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_onended(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[37]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onended"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_onended(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[38]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onerror"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_onerror(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[39]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onerror"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_onerror(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[40]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_oninput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_oninput(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[41]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_oninput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_oninput(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[42]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_onload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[43]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_onload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[44]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onloadeddata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_onloadeddata(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[45]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onloadeddata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_onloadeddata(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[46]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onloadedmetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_onloadedmetadata(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[47]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onloadedmetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_onloadedmetadata(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[48]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onloadstart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_onloadstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[49]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onloadstart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_onloadstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[50]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onpause"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_onpause(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[51]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onpause"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_onpause(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[52]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onplay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_onplay(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[53]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onplay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_onplay(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[54]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onplaying"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT put_onplaying(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[55]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onplaying"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_onplaying(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[56]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onprogress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT put_onprogress(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[57]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onprogress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_onprogress(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[58]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onratechange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT put_onratechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[59]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onratechange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_onratechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[60]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onreset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT put_onreset(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[61]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onreset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_onreset(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[62]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onseeked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT put_onseeked(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[63]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onseeked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_onseeked(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[64]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onseeking"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT put_onseeking(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[65]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onseeking"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT get_onseeking(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[66]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onselect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT put_onselect(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[67]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onselect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT get_onselect(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[68]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onstalled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT put_onstalled(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[69]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onstalled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_onstalled(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[70]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onsubmit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT put_onsubmit(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[71]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onsubmit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_onsubmit(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[72]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onsuspend"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT put_onsuspend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[73]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onsuspend"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_onsuspend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[74]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_ontimeupdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT put_ontimeupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[75]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_ontimeupdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_ontimeupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[76]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onvolumechange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT put_onvolumechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[77]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onvolumechange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_onvolumechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[78]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.put_onwaiting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT put_onwaiting(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[79]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.get_onwaiting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_onwaiting(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[80]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement6.xml' path='doc/member[@name="IHTMLElement6.hasAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT hasAttributes([NativeTypeName("VARIANT_BOOL *")] short* pfHasAttributes)
    {
        return ((delegate* unmanaged<IHTMLElement6*, short*, int>)(lpVtbl[81]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pfHasAttributes);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT getAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* AttributeValue);

        [VtblIndex(8)]
        HRESULT setAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* pvarAttributeValue);

        [VtblIndex(9)]
        HRESULT removeAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* strAttributeName);

        [VtblIndex(10)]
        HRESULT getAttributeNodeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrname, IHTMLDOMAttribute2** ppretAttribute);

        [VtblIndex(11)]
        HRESULT setAttributeNodeNS(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute);

        [VtblIndex(12)]
        HRESULT hasAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("VARIANT_BOOL *")] short* pfHasAttribute);

        [VtblIndex(13)]
        HRESULT getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* AttributeValue);

        [VtblIndex(14)]
        HRESULT setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* pvarAttributeValue);

        [VtblIndex(15)]
        HRESULT removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName);

        [VtblIndex(16)]
        HRESULT getAttributeNode([NativeTypeName("BSTR")] ushort* strAttributeName, IHTMLDOMAttribute2** ppretAttribute);

        [VtblIndex(17)]
        HRESULT setAttributeNode(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute);

        [VtblIndex(18)]
        HRESULT removeAttributeNode(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute);

        [VtblIndex(19)]
        HRESULT hasAttribute([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("VARIANT_BOOL *")] short* pfHasAttribute);

        [VtblIndex(20)]
        HRESULT getElementsByTagNameNS(VARIANT* varNS, [NativeTypeName("BSTR")] ushort* bstrLocalName, IHTMLElementCollection** pelColl);

        [VtblIndex(21)]
        HRESULT get_tagName([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(22)]
        HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(23)]
        HRESULT getElementsByClassName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pel);

        [VtblIndex(24)]
        HRESULT msMatchesSelector([NativeTypeName("BSTR")] ushort* v, [NativeTypeName("VARIANT_BOOL *")] short* pfMatches);

        [VtblIndex(25)]
        HRESULT put_onabort(VARIANT v);

        [VtblIndex(26)]
        HRESULT get_onabort(VARIANT* p);

        [VtblIndex(27)]
        HRESULT put_oncanplay(VARIANT v);

        [VtblIndex(28)]
        HRESULT get_oncanplay(VARIANT* p);

        [VtblIndex(29)]
        HRESULT put_oncanplaythrough(VARIANT v);

        [VtblIndex(30)]
        HRESULT get_oncanplaythrough(VARIANT* p);

        [VtblIndex(31)]
        HRESULT put_onchange(VARIANT v);

        [VtblIndex(32)]
        HRESULT get_onchange(VARIANT* p);

        [VtblIndex(33)]
        HRESULT put_ondurationchange(VARIANT v);

        [VtblIndex(34)]
        HRESULT get_ondurationchange(VARIANT* p);

        [VtblIndex(35)]
        HRESULT put_onemptied(VARIANT v);

        [VtblIndex(36)]
        HRESULT get_onemptied(VARIANT* p);

        [VtblIndex(37)]
        HRESULT put_onended(VARIANT v);

        [VtblIndex(38)]
        HRESULT get_onended(VARIANT* p);

        [VtblIndex(39)]
        HRESULT put_onerror(VARIANT v);

        [VtblIndex(40)]
        HRESULT get_onerror(VARIANT* p);

        [VtblIndex(41)]
        HRESULT put_oninput(VARIANT v);

        [VtblIndex(42)]
        HRESULT get_oninput(VARIANT* p);

        [VtblIndex(43)]
        HRESULT put_onload(VARIANT v);

        [VtblIndex(44)]
        HRESULT get_onload(VARIANT* p);

        [VtblIndex(45)]
        HRESULT put_onloadeddata(VARIANT v);

        [VtblIndex(46)]
        HRESULT get_onloadeddata(VARIANT* p);

        [VtblIndex(47)]
        HRESULT put_onloadedmetadata(VARIANT v);

        [VtblIndex(48)]
        HRESULT get_onloadedmetadata(VARIANT* p);

        [VtblIndex(49)]
        HRESULT put_onloadstart(VARIANT v);

        [VtblIndex(50)]
        HRESULT get_onloadstart(VARIANT* p);

        [VtblIndex(51)]
        HRESULT put_onpause(VARIANT v);

        [VtblIndex(52)]
        HRESULT get_onpause(VARIANT* p);

        [VtblIndex(53)]
        HRESULT put_onplay(VARIANT v);

        [VtblIndex(54)]
        HRESULT get_onplay(VARIANT* p);

        [VtblIndex(55)]
        HRESULT put_onplaying(VARIANT v);

        [VtblIndex(56)]
        HRESULT get_onplaying(VARIANT* p);

        [VtblIndex(57)]
        HRESULT put_onprogress(VARIANT v);

        [VtblIndex(58)]
        HRESULT get_onprogress(VARIANT* p);

        [VtblIndex(59)]
        HRESULT put_onratechange(VARIANT v);

        [VtblIndex(60)]
        HRESULT get_onratechange(VARIANT* p);

        [VtblIndex(61)]
        HRESULT put_onreset(VARIANT v);

        [VtblIndex(62)]
        HRESULT get_onreset(VARIANT* p);

        [VtblIndex(63)]
        HRESULT put_onseeked(VARIANT v);

        [VtblIndex(64)]
        HRESULT get_onseeked(VARIANT* p);

        [VtblIndex(65)]
        HRESULT put_onseeking(VARIANT v);

        [VtblIndex(66)]
        HRESULT get_onseeking(VARIANT* p);

        [VtblIndex(67)]
        HRESULT put_onselect(VARIANT v);

        [VtblIndex(68)]
        HRESULT get_onselect(VARIANT* p);

        [VtblIndex(69)]
        HRESULT put_onstalled(VARIANT v);

        [VtblIndex(70)]
        HRESULT get_onstalled(VARIANT* p);

        [VtblIndex(71)]
        HRESULT put_onsubmit(VARIANT v);

        [VtblIndex(72)]
        HRESULT get_onsubmit(VARIANT* p);

        [VtblIndex(73)]
        HRESULT put_onsuspend(VARIANT v);

        [VtblIndex(74)]
        HRESULT get_onsuspend(VARIANT* p);

        [VtblIndex(75)]
        HRESULT put_ontimeupdate(VARIANT v);

        [VtblIndex(76)]
        HRESULT get_ontimeupdate(VARIANT* p);

        [VtblIndex(77)]
        HRESULT put_onvolumechange(VARIANT v);

        [VtblIndex(78)]
        HRESULT get_onvolumechange(VARIANT* p);

        [VtblIndex(79)]
        HRESULT put_onwaiting(VARIANT v);

        [VtblIndex(80)]
        HRESULT get_onwaiting(VARIANT* p);

        [VtblIndex(81)]
        HRESULT hasAttributes([NativeTypeName("VARIANT_BOOL *")] short* pfHasAttributes);
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

        [NativeTypeName("HRESULT (VARIANT *, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, ushort*, VARIANT*, int> getAttributeNS;

        [NativeTypeName("HRESULT (VARIANT *, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, ushort*, VARIANT*, int> setAttributeNS;

        [NativeTypeName("HRESULT (VARIANT *, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, ushort*, int> removeAttributeNS;

        [NativeTypeName("HRESULT (VARIANT *, BSTR, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, ushort*, IHTMLDOMAttribute2**, int> getAttributeNodeNS;

        [NativeTypeName("HRESULT (IHTMLDOMAttribute2 *, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int> setAttributeNodeNS;

        [NativeTypeName("HRESULT (VARIANT *, BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, ushort*, short*, int> hasAttributeNS;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> getAttribute;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> setAttribute;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> removeAttribute;

        [NativeTypeName("HRESULT (BSTR, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDOMAttribute2**, int> getAttributeNode;

        [NativeTypeName("HRESULT (IHTMLDOMAttribute2 *, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int> setAttributeNode;

        [NativeTypeName("HRESULT (IHTMLDOMAttribute2 *, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int> removeAttributeNode;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> hasAttribute;

        [NativeTypeName("HRESULT (VARIANT *, BSTR, IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, ushort*, IHTMLElementCollection**, int> getElementsByTagNameNS;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_tagName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_nodeName;

        [NativeTypeName("HRESULT (BSTR, IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLElementCollection**, int> getElementsByClassName;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> msMatchesSelector;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onabort;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onabort;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncanplay;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncanplay;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncanplaythrough;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncanplaythrough;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onchange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onchange;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondurationchange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondurationchange;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onemptied;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onemptied;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onended;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onended;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onerror;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onerror;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oninput;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oninput;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onload;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onload;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onloadeddata;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onloadeddata;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onloadedmetadata;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onloadedmetadata;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onloadstart;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onloadstart;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onpause;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onpause;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onplay;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onplay;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onplaying;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onplaying;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onprogress;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onprogress;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onratechange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onratechange;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreset;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreset;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onseeked;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onseeked;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onseeking;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onseeking;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onselect;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onselect;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onstalled;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onstalled;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onsubmit;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onsubmit;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onsuspend;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onsuspend;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ontimeupdate;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ontimeupdate;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onvolumechange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onvolumechange;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onwaiting;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onwaiting;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> hasAttributes;
    }
}
