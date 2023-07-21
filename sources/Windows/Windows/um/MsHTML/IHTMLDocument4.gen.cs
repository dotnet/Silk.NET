// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4"]/*' />
[Guid("3050F69A-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDocument4 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDocument4 : IHTMLDocument4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDocument4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDocument4*, uint>)(lpVtbl[1]))((IHTMLDocument4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDocument4*, uint>)(lpVtbl[2]))((IHTMLDocument4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, uint*, int>)(lpVtbl[3]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.focus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT focus()
    {
        return ((delegate* unmanaged<IHTMLDocument4*, int>)(lpVtbl[7]))((IHTMLDocument4*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.hasFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT hasFocus([NativeTypeName("VARIANT_BOOL *")] short* pfFocus)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, short*, int>)(lpVtbl[8]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), pfFocus);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.put_onselectionchange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_onselectionchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, VARIANT, int>)(lpVtbl[9]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.get_onselectionchange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_onselectionchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, VARIANT*, int>)(lpVtbl[10]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.get_namespaces"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_namespaces(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, IDispatch**, int>)(lpVtbl[11]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.createDocumentFromUrl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT createDocumentFromUrl([NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("BSTR")] ushort* bstrOptions, IHTMLDocument2** newDoc)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, ushort*, ushort*, IHTMLDocument2**, int>)(lpVtbl[12]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), bstrUrl, bstrOptions, newDoc);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.put_media"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_media([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, ushort*, int>)(lpVtbl[13]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.get_media"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_media([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, ushort**, int>)(lpVtbl[14]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.createEventObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT createEventObject(VARIANT* pvarEventObject, IHTMLEventObj** ppEventObj)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, VARIANT*, IHTMLEventObj**, int>)(lpVtbl[15]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), pvarEventObject, ppEventObj);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.fireEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT fireEvent([NativeTypeName("BSTR")] ushort* bstrEventName, VARIANT* pvarEventObject, [NativeTypeName("VARIANT_BOOL *")] short* pfCancelled)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, ushort*, VARIANT*, short*, int>)(lpVtbl[16]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), bstrEventName, pvarEventObject, pfCancelled);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.createRenderStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT createRenderStyle([NativeTypeName("BSTR")] ushort* v, IHTMLRenderStyle** ppIHTMLRenderStyle)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, ushort*, IHTMLRenderStyle**, int>)(lpVtbl[17]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), v, ppIHTMLRenderStyle);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.put_oncontrolselect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_oncontrolselect(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, VARIANT, int>)(lpVtbl[18]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.get_oncontrolselect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_oncontrolselect(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, VARIANT*, int>)(lpVtbl[19]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument4.xml' path='doc/member[@name="IHTMLDocument4.get_URLUnencoded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_URLUnencoded([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument4*, ushort**, int>)(lpVtbl[20]))((IHTMLDocument4*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT focus();

        [VtblIndex(8)]
        HRESULT hasFocus([NativeTypeName("VARIANT_BOOL *")] short* pfFocus);

        [VtblIndex(9)]
        HRESULT put_onselectionchange(VARIANT v);

        [VtblIndex(10)]
        HRESULT get_onselectionchange(VARIANT* p);

        [VtblIndex(11)]
        HRESULT get_namespaces(IDispatch** p);

        [VtblIndex(12)]
        HRESULT createDocumentFromUrl([NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("BSTR")] ushort* bstrOptions, IHTMLDocument2** newDoc);

        [VtblIndex(13)]
        HRESULT put_media([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(14)]
        HRESULT get_media([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(15)]
        HRESULT createEventObject(VARIANT* pvarEventObject, IHTMLEventObj** ppEventObj);

        [VtblIndex(16)]
        HRESULT fireEvent([NativeTypeName("BSTR")] ushort* bstrEventName, VARIANT* pvarEventObject, [NativeTypeName("VARIANT_BOOL *")] short* pfCancelled);

        [VtblIndex(17)]
        HRESULT createRenderStyle([NativeTypeName("BSTR")] ushort* v, IHTMLRenderStyle** ppIHTMLRenderStyle);

        [VtblIndex(18)]
        HRESULT put_oncontrolselect(VARIANT v);

        [VtblIndex(19)]
        HRESULT get_oncontrolselect(VARIANT* p);

        [VtblIndex(20)]
        HRESULT get_URLUnencoded([NativeTypeName("BSTR *")] ushort** p);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> focus;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> hasFocus;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onselectionchange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onselectionchange;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_namespaces;

        [NativeTypeName("HRESULT (BSTR, BSTR, IHTMLDocument2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IHTMLDocument2**, int> createDocumentFromUrl;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_media;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_media;

        [NativeTypeName("HRESULT (VARIANT *, IHTMLEventObj **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, IHTMLEventObj**, int> createEventObject;

        [NativeTypeName("HRESULT (BSTR, VARIANT *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, short*, int> fireEvent;

        [NativeTypeName("HRESULT (BSTR, IHTMLRenderStyle **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLRenderStyle**, int> createRenderStyle;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncontrolselect;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncontrolselect;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_URLUnencoded;
    }
}
