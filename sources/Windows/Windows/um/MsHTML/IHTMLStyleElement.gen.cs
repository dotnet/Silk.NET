// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement"]/*'/>
[Guid("3050F375-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLStyleElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLStyleElement : IHTMLStyleElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLStyleElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, uint> )(lpVtbl[1]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, uint> )(lpVtbl[2]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, uint*, int> )(lpVtbl[3]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.put_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_type([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, ushort*, int> )(lpVtbl[7]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, ushort**, int> )(lpVtbl[8]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.get_readyState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, ushort**, int> )(lpVtbl[9]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.put_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_onreadystatechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, VARIANT, int> )(lpVtbl[10]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.get_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_onreadystatechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, VARIANT*, int> )(lpVtbl[11]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.put_onload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_onload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, VARIANT, int> )(lpVtbl[12]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.get_onload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_onload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, VARIANT*, int> )(lpVtbl[13]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.put_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_onerror(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, VARIANT, int> )(lpVtbl[14]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.get_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_onerror(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, VARIANT*, int> )(lpVtbl[15]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.get_styleSheet"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_styleSheet(IHTMLStyleSheet** p)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, IHTMLStyleSheet**, int> )(lpVtbl[16]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.put_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, short, int> )(lpVtbl[17]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.get_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, short*, int> )(lpVtbl[18]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.put_media"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_media([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, ushort*, int> )(lpVtbl[19]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyleElement.xml' path='doc/member[@name="IHTMLStyleElement.get_media"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_media([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyleElement*, ushort**, int> )(lpVtbl[20]))((IHTMLStyleElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_type([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(10)]
        HRESULT put_onreadystatechange(VARIANT v);
        [VtblIndex(11)]
        HRESULT get_onreadystatechange(VARIANT* p);
        [VtblIndex(12)]
        HRESULT put_onload(VARIANT v);
        [VtblIndex(13)]
        HRESULT get_onload(VARIANT* p);
        [VtblIndex(14)]
        HRESULT put_onerror(VARIANT v);
        [VtblIndex(15)]
        HRESULT get_onerror(VARIANT* p);
        [VtblIndex(16)]
        HRESULT get_styleSheet(IHTMLStyleSheet** p);
        [VtblIndex(17)]
        HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(18)]
        HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(19)]
        HRESULT put_media([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(20)]
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