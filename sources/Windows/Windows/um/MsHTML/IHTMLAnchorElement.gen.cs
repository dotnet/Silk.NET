// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement"]/*' />
[Guid("3050F1DA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLAnchorElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLAnchorElement : IHTMLAnchorElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLAnchorElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, uint>)(lpVtbl[1]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, uint>)(lpVtbl[2]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, uint*, int>)(lpVtbl[3]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_href"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_href([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[7]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_href"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_href([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[8]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_target"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_target([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[9]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_target"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_target([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[10]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_rel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_rel([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[11]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_rel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_rel([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[12]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_rev"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_rev([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[13]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_rev"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_rev([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[14]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_urn"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_urn([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[15]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_urn"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_urn([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[16]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_Methods"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Methods([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[17]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_Methods"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Methods([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[18]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[19]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[20]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_host"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_host([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[21]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_host"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_host([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[22]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_hostname"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_hostname([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[23]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_hostname"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_hostname([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[24]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_pathname"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_pathname([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[25]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_pathname"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_pathname([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[26]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_port"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_port([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[27]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_port"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_port([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[28]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_protocol"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_protocol([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[29]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_protocol"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_protocol([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[30]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_search"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_search([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[31]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_search"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_search([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[32]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_hash"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_hash([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[33]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_hash"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_hash([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[34]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_onblur"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_onblur(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, VARIANT, int>)(lpVtbl[35]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_onblur"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_onblur(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, VARIANT*, int>)(lpVtbl[36]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_onfocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_onfocus(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, VARIANT, int>)(lpVtbl[37]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_onfocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_onfocus(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, VARIANT*, int>)(lpVtbl[38]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_accessKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_accessKey([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[39]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_accessKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_accessKey([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[40]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_protocolLong"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_protocolLong([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[41]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_mimeType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_mimeType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[42]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_nameProp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_nameProp([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[43]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.put_tabIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_tabIndex(short v)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, short, int>)(lpVtbl[44]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.get_tabIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_tabIndex(short* p)
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, short*, int>)(lpVtbl[45]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.focus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT focus()
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, int>)(lpVtbl[46]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLAnchorElement.xml' path='doc/member[@name="IHTMLAnchorElement.blur"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT blur()
    {
        return ((delegate* unmanaged<IHTMLAnchorElement*, int>)(lpVtbl[47]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_href([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_href([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT put_target([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(10)]
        HRESULT get_target([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT put_rel([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(12)]
        HRESULT get_rel([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(13)]
        HRESULT put_rev([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(14)]
        HRESULT get_rev([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(15)]
        HRESULT put_urn([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(16)]
        HRESULT get_urn([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(17)]
        HRESULT put_Methods([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(18)]
        HRESULT get_Methods([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(19)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(20)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT put_host([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(22)]
        HRESULT get_host([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(23)]
        HRESULT put_hostname([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(24)]
        HRESULT get_hostname([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(25)]
        HRESULT put_pathname([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(26)]
        HRESULT get_pathname([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(27)]
        HRESULT put_port([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(28)]
        HRESULT get_port([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(29)]
        HRESULT put_protocol([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(30)]
        HRESULT get_protocol([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(31)]
        HRESULT put_search([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(32)]
        HRESULT get_search([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(33)]
        HRESULT put_hash([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(34)]
        HRESULT get_hash([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(35)]
        HRESULT put_onblur(VARIANT v);

        [VtblIndex(36)]
        HRESULT get_onblur(VARIANT* p);

        [VtblIndex(37)]
        HRESULT put_onfocus(VARIANT v);

        [VtblIndex(38)]
        HRESULT get_onfocus(VARIANT* p);

        [VtblIndex(39)]
        HRESULT put_accessKey([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(40)]
        HRESULT get_accessKey([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(41)]
        HRESULT get_protocolLong([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(42)]
        HRESULT get_mimeType([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(43)]
        HRESULT get_nameProp([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(44)]
        HRESULT put_tabIndex(short v);

        [VtblIndex(45)]
        HRESULT get_tabIndex(short* p);

        [VtblIndex(46)]
        HRESULT focus();

        [VtblIndex(47)]
        HRESULT blur();
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_target;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_target;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_rel;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rel;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_rev;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rev;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_urn;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_urn;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Methods;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Methods;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_host;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_host;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_hostname;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_hostname;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_pathname;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_pathname;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_port;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_port;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_protocol;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_protocol;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_search;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_search;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_hash;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_hash;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onblur;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onblur;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onfocus;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onfocus;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_accessKey;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_accessKey;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_protocolLong;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_mimeType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_nameProp;

        [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_tabIndex;

        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_tabIndex;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> focus;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> blur;
    }
}
