// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4"]/*' />
[Guid("3050F80F-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLElement4 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLElement4 : IHTMLElement4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLElement4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLElement4*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElement4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLElement4*, uint>)(lpVtbl[1]))((IHTMLElement4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLElement4*, uint>)(lpVtbl[2]))((IHTMLElement4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLElement4*, uint*, int>)(lpVtbl[3]))((IHTMLElement4*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLElement4*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElement4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLElement4*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElement4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLElement4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElement4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4.put_onmousewheel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_onmousewheel(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement4*, VARIANT, int>)(lpVtbl[7]))((IHTMLElement4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4.get_onmousewheel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_onmousewheel(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement4*, VARIANT*, int>)(lpVtbl[8]))((IHTMLElement4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4.normalize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT normalize()
    {
        return ((delegate* unmanaged<IHTMLElement4*, int>)(lpVtbl[9]))((IHTMLElement4*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4.getAttributeNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT getAttributeNode([NativeTypeName("BSTR")] ushort* bstrname, IHTMLDOMAttribute** ppAttribute)
    {
        return ((delegate* unmanaged<IHTMLElement4*, ushort*, IHTMLDOMAttribute**, int>)(lpVtbl[10]))((IHTMLElement4*)Unsafe.AsPointer(ref this), bstrname, ppAttribute);
    }

    /// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4.setAttributeNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT setAttributeNode(IHTMLDOMAttribute* pattr, IHTMLDOMAttribute** ppretAttribute)
    {
        return ((delegate* unmanaged<IHTMLElement4*, IHTMLDOMAttribute*, IHTMLDOMAttribute**, int>)(lpVtbl[11]))((IHTMLElement4*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
    }

    /// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4.removeAttributeNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT removeAttributeNode(IHTMLDOMAttribute* pattr, IHTMLDOMAttribute** ppretAttribute)
    {
        return ((delegate* unmanaged<IHTMLElement4*, IHTMLDOMAttribute*, IHTMLDOMAttribute**, int>)(lpVtbl[12]))((IHTMLElement4*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
    }

    /// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4.put_onbeforeactivate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_onbeforeactivate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement4*, VARIANT, int>)(lpVtbl[13]))((IHTMLElement4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4.get_onbeforeactivate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_onbeforeactivate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement4*, VARIANT*, int>)(lpVtbl[14]))((IHTMLElement4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4.put_onfocusin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_onfocusin(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement4*, VARIANT, int>)(lpVtbl[15]))((IHTMLElement4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4.get_onfocusin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_onfocusin(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement4*, VARIANT*, int>)(lpVtbl[16]))((IHTMLElement4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4.put_onfocusout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_onfocusout(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLElement4*, VARIANT, int>)(lpVtbl[17]))((IHTMLElement4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElement4.xml' path='doc/member[@name="IHTMLElement4.get_onfocusout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_onfocusout(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLElement4*, VARIANT*, int>)(lpVtbl[18]))((IHTMLElement4*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_onmousewheel(VARIANT v);

        [VtblIndex(8)]
        HRESULT get_onmousewheel(VARIANT* p);

        [VtblIndex(9)]
        HRESULT normalize();

        [VtblIndex(10)]
        HRESULT getAttributeNode([NativeTypeName("BSTR")] ushort* bstrname, IHTMLDOMAttribute** ppAttribute);

        [VtblIndex(11)]
        HRESULT setAttributeNode(IHTMLDOMAttribute* pattr, IHTMLDOMAttribute** ppretAttribute);

        [VtblIndex(12)]
        HRESULT removeAttributeNode(IHTMLDOMAttribute* pattr, IHTMLDOMAttribute** ppretAttribute);

        [VtblIndex(13)]
        HRESULT put_onbeforeactivate(VARIANT v);

        [VtblIndex(14)]
        HRESULT get_onbeforeactivate(VARIANT* p);

        [VtblIndex(15)]
        HRESULT put_onfocusin(VARIANT v);

        [VtblIndex(16)]
        HRESULT get_onfocusin(VARIANT* p);

        [VtblIndex(17)]
        HRESULT put_onfocusout(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_onfocusout(VARIANT* p);
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

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmousewheel;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmousewheel;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> normalize;

        [NativeTypeName("HRESULT (BSTR, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDOMAttribute**, int> getAttributeNode;

        [NativeTypeName("HRESULT (IHTMLDOMAttribute *, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMAttribute*, IHTMLDOMAttribute**, int> setAttributeNode;

        [NativeTypeName("HRESULT (IHTMLDOMAttribute *, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMAttribute*, IHTMLDOMAttribute**, int> removeAttributeNode;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforeactivate;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforeactivate;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onfocusin;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onfocusin;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onfocusout;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onfocusout;
    }
}
