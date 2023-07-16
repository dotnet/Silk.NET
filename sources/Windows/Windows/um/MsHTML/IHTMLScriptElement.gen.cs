// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement"]/*'/>
[Guid("3050F28B-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLScriptElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLScriptElement : IHTMLScriptElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLScriptElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, uint> )(lpVtbl[1]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, uint> )(lpVtbl[2]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, uint*, int> )(lpVtbl[3]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.put_src"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_src([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, ushort*, int> )(lpVtbl[7]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.get_src"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_src([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, ushort**, int> )(lpVtbl[8]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.put_htmlFor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_htmlFor([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, ushort*, int> )(lpVtbl[9]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.get_htmlFor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_htmlFor([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, ushort**, int> )(lpVtbl[10]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.put_event"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_event([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, ushort*, int> )(lpVtbl[11]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.get_event"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_event([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, ushort**, int> )(lpVtbl[12]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.put_text"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_text([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, ushort*, int> )(lpVtbl[13]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.get_text"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_text([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, ushort**, int> )(lpVtbl[14]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.put_defer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_defer([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, short, int> )(lpVtbl[15]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.get_defer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_defer([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, short*, int> )(lpVtbl[16]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.get_readyState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, ushort**, int> )(lpVtbl[17]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.put_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_onerror(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, VARIANT, int> )(lpVtbl[18]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.get_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_onerror(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, VARIANT*, int> )(lpVtbl[19]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.put_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_type([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, ushort*, int> )(lpVtbl[20]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLScriptElement.xml' path='doc/member[@name="IHTMLScriptElement.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLScriptElement*, ushort**, int> )(lpVtbl[21]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_src([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_src([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_htmlFor([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_htmlFor([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_event([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_event([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT put_text([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_text([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT put_defer([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(16)]
        HRESULT get_defer([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(17)]
        HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(18)]
        HRESULT put_onerror(VARIANT v);
        [VtblIndex(19)]
        HRESULT get_onerror(VARIANT* p);
        [VtblIndex(20)]
        HRESULT put_type([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(21)]
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_src;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_src;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_htmlFor;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_htmlFor;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_event;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_event;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_text;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_text;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_defer;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_defer;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_readyState;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onerror;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onerror;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_type;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;
    }
}