// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement"]/*'/>
[Guid("3050F265-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLAreaElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLAreaElement : IHTMLAreaElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLAreaElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, uint> )(lpVtbl[1]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, uint> )(lpVtbl[2]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, uint*, int> )(lpVtbl[3]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_shape"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_shape([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort*, int> )(lpVtbl[7]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_shape"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_shape([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort**, int> )(lpVtbl[8]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_coords"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_coords([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort*, int> )(lpVtbl[9]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_coords"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_coords([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort**, int> )(lpVtbl[10]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_href"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_href([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort*, int> )(lpVtbl[11]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_href"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_href([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort**, int> )(lpVtbl[12]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_target"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_target([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort*, int> )(lpVtbl[13]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_target"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_target([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort**, int> )(lpVtbl[14]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_alt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_alt([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort*, int> )(lpVtbl[15]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_alt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_alt([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort**, int> )(lpVtbl[16]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_noHref"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_noHref([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, short, int> )(lpVtbl[17]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_noHref"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_noHref([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, short*, int> )(lpVtbl[18]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_host"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_host([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort*, int> )(lpVtbl[19]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_host"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_host([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort**, int> )(lpVtbl[20]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_hostname"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_hostname([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort*, int> )(lpVtbl[21]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_hostname"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_hostname([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort**, int> )(lpVtbl[22]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_pathname"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_pathname([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort*, int> )(lpVtbl[23]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_pathname"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_pathname([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort**, int> )(lpVtbl[24]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_port"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_port([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort*, int> )(lpVtbl[25]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_port"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_port([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort**, int> )(lpVtbl[26]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_protocol"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_protocol([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort*, int> )(lpVtbl[27]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_protocol"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_protocol([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort**, int> )(lpVtbl[28]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_search"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_search([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort*, int> )(lpVtbl[29]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_search"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_search([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort**, int> )(lpVtbl[30]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_hash"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_hash([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort*, int> )(lpVtbl[31]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_hash"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_hash([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, ushort**, int> )(lpVtbl[32]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_onblur"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_onblur(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, VARIANT, int> )(lpVtbl[33]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_onblur"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_onblur(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, VARIANT*, int> )(lpVtbl[34]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_onfocus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_onfocus(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, VARIANT, int> )(lpVtbl[35]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_onfocus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_onfocus(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, VARIANT*, int> )(lpVtbl[36]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.put_tabIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_tabIndex(short v)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, short, int> )(lpVtbl[37]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.get_tabIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_tabIndex(short* p)
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, short*, int> )(lpVtbl[38]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.focus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT focus()
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, int> )(lpVtbl[39]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLAreaElement.xml' path='doc/member[@name="IHTMLAreaElement.blur"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT blur()
    {
        return ((delegate* unmanaged<IHTMLAreaElement*, int> )(lpVtbl[40]))((IHTMLAreaElement*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_shape([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_shape([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_coords([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_coords([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_href([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_href([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT put_target([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_target([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT put_alt([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(16)]
        HRESULT get_alt([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(17)]
        HRESULT put_noHref([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(18)]
        HRESULT get_noHref([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(19)]
        HRESULT put_host([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(20)]
        HRESULT get_host([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(21)]
        HRESULT put_hostname([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(22)]
        HRESULT get_hostname([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(23)]
        HRESULT put_pathname([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(24)]
        HRESULT get_pathname([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(25)]
        HRESULT put_port([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(26)]
        HRESULT get_port([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(27)]
        HRESULT put_protocol([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(28)]
        HRESULT get_protocol([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(29)]
        HRESULT put_search([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(30)]
        HRESULT get_search([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(31)]
        HRESULT put_hash([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(32)]
        HRESULT get_hash([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(33)]
        HRESULT put_onblur(VARIANT v);
        [VtblIndex(34)]
        HRESULT get_onblur(VARIANT* p);
        [VtblIndex(35)]
        HRESULT put_onfocus(VARIANT v);
        [VtblIndex(36)]
        HRESULT get_onfocus(VARIANT* p);
        [VtblIndex(37)]
        HRESULT put_tabIndex(short v);
        [VtblIndex(38)]
        HRESULT get_tabIndex(short* p);
        [VtblIndex(39)]
        HRESULT focus();
        [VtblIndex(40)]
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_shape;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_shape;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_coords;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_coords;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_href;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_href;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_target;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_target;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_alt;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_alt;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_noHref;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_noHref;
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