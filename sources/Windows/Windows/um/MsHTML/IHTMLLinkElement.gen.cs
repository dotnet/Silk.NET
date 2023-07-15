// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement"]/*'/>
[Guid("3050F205-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLLinkElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLLinkElement : IHTMLLinkElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLLinkElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, uint> )(lpVtbl[1]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, uint> )(lpVtbl[2]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, uint*, int> )(lpVtbl[3]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.put_href"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_href([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, ushort*, int> )(lpVtbl[7]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.get_href"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_href([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, ushort**, int> )(lpVtbl[8]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.put_rel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_rel([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, ushort*, int> )(lpVtbl[9]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.get_rel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_rel([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, ushort**, int> )(lpVtbl[10]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.put_rev"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_rev([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, ushort*, int> )(lpVtbl[11]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.get_rev"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_rev([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, ushort**, int> )(lpVtbl[12]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.put_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_type([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, ushort*, int> )(lpVtbl[13]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, ushort**, int> )(lpVtbl[14]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.get_readyState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, ushort**, int> )(lpVtbl[15]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.put_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_onreadystatechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, VARIANT, int> )(lpVtbl[16]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.get_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_onreadystatechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, VARIANT*, int> )(lpVtbl[17]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.put_onload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_onload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, VARIANT, int> )(lpVtbl[18]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.get_onload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_onload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, VARIANT*, int> )(lpVtbl[19]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.put_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_onerror(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, VARIANT, int> )(lpVtbl[20]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.get_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_onerror(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, VARIANT*, int> )(lpVtbl[21]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.get_styleSheet"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_styleSheet(IHTMLStyleSheet** p)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, IHTMLStyleSheet**, int> )(lpVtbl[22]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.put_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, short, int> )(lpVtbl[23]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.get_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, short*, int> )(lpVtbl[24]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.put_media"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_media([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, ushort*, int> )(lpVtbl[25]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLLinkElement.xml' path='doc/member[@name="IHTMLLinkElement.get_media"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_media([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLLinkElement*, ushort**, int> )(lpVtbl[26]))((IHTMLLinkElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_href([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_href([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_rel([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_rel([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_rev([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_rev([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT put_type([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(16)]
        HRESULT put_onreadystatechange(VARIANT v);
        [VtblIndex(17)]
        HRESULT get_onreadystatechange(VARIANT* p);
        [VtblIndex(18)]
        HRESULT put_onload(VARIANT v);
        [VtblIndex(19)]
        HRESULT get_onload(VARIANT* p);
        [VtblIndex(20)]
        HRESULT put_onerror(VARIANT v);
        [VtblIndex(21)]
        HRESULT get_onerror(VARIANT* p);
        [VtblIndex(22)]
        HRESULT get_styleSheet(IHTMLStyleSheet** p);
        [VtblIndex(23)]
        HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(24)]
        HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(25)]
        HRESULT put_media([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(26)]
        HRESULT get_media([NativeTypeName("BSTR *")] ushort** p);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_rel;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rel;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_rev;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rev;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_type;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_readyState;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreadystatechange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreadystatechange;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onload;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onload;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onerror;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onerror;
        [NativeTypeName("HRESULT (IHTMLStyleSheet **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLStyleSheet**, int> get_styleSheet;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_disabled;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_disabled;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_media;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_media;
    }
}