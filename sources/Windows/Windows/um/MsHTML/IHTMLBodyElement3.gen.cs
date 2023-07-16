// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLBodyElement3.xml' path='doc/member[@name="IHTMLBodyElement3"]/*'/>
[Guid("30510422-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLBodyElement3 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLBodyElement3 : IHTMLBodyElement3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLBodyElement3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, uint> )(lpVtbl[1]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, uint> )(lpVtbl[2]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, uint*, int> )(lpVtbl[3]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLBodyElement3.xml' path='doc/member[@name="IHTMLBodyElement3.put_background"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_background([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, ushort*, int> )(lpVtbl[7]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement3.xml' path='doc/member[@name="IHTMLBodyElement3.get_background"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_background([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, ushort**, int> )(lpVtbl[8]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement3.xml' path='doc/member[@name="IHTMLBodyElement3.put_ononline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ononline(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, VARIANT, int> )(lpVtbl[9]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement3.xml' path='doc/member[@name="IHTMLBodyElement3.get_ononline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ononline(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, VARIANT*, int> )(lpVtbl[10]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement3.xml' path='doc/member[@name="IHTMLBodyElement3.put_onoffline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_onoffline(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, VARIANT, int> )(lpVtbl[11]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement3.xml' path='doc/member[@name="IHTMLBodyElement3.get_onoffline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_onoffline(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, VARIANT*, int> )(lpVtbl[12]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement3.xml' path='doc/member[@name="IHTMLBodyElement3.put_onhashchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_onhashchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, VARIANT, int> )(lpVtbl[13]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement3.xml' path='doc/member[@name="IHTMLBodyElement3.get_onhashchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_onhashchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement3*, VARIANT*, int> )(lpVtbl[14]))((IHTMLBodyElement3*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_background([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_background([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_ononline(VARIANT v);
        [VtblIndex(10)]
        HRESULT get_ononline(VARIANT* p);
        [VtblIndex(11)]
        HRESULT put_onoffline(VARIANT v);
        [VtblIndex(12)]
        HRESULT get_onoffline(VARIANT* p);
        [VtblIndex(13)]
        HRESULT put_onhashchange(VARIANT v);
        [VtblIndex(14)]
        HRESULT get_onhashchange(VARIANT* p);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_background;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_background;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ononline;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ononline;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onoffline;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onoffline;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onhashchange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onhashchange;
    }
}