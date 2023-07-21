// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLOptionElement.xml' path='doc/member[@name="IHTMLOptionElement"]/*' />
[Guid("3050F211-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLOptionElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLOptionElement : IHTMLOptionElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLOptionElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, uint>)(lpVtbl[1]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, uint>)(lpVtbl[2]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, uint*, int>)(lpVtbl[3]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLOptionElement.xml' path='doc/member[@name="IHTMLOptionElement.put_selected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_selected([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, short, int>)(lpVtbl[7]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionElement.xml' path='doc/member[@name="IHTMLOptionElement.get_selected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_selected([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, short*, int>)(lpVtbl[8]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionElement.xml' path='doc/member[@name="IHTMLOptionElement.put_value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_value([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, ushort*, int>)(lpVtbl[9]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionElement.xml' path='doc/member[@name="IHTMLOptionElement.get_value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_value([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, ushort**, int>)(lpVtbl[10]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionElement.xml' path='doc/member[@name="IHTMLOptionElement.put_defaultSelected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_defaultSelected([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, short, int>)(lpVtbl[11]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionElement.xml' path='doc/member[@name="IHTMLOptionElement.get_defaultSelected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_defaultSelected([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, short*, int>)(lpVtbl[12]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionElement.xml' path='doc/member[@name="IHTMLOptionElement.put_index"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_index([NativeTypeName("LONG")] int v)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, int, int>)(lpVtbl[13]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionElement.xml' path='doc/member[@name="IHTMLOptionElement.get_index"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_index([NativeTypeName("LONG *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, int*, int>)(lpVtbl[14]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionElement.xml' path='doc/member[@name="IHTMLOptionElement.put_text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_text([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, ushort*, int>)(lpVtbl[15]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionElement.xml' path='doc/member[@name="IHTMLOptionElement.get_text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_text([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, ushort**, int>)(lpVtbl[16]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionElement.xml' path='doc/member[@name="IHTMLOptionElement.get_form"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_form(IHTMLFormElement** p)
    {
        return ((delegate* unmanaged<IHTMLOptionElement*, IHTMLFormElement**, int>)(lpVtbl[17]))((IHTMLOptionElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_selected([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(8)]
        HRESULT get_selected([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(9)]
        HRESULT put_value([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(10)]
        HRESULT get_value([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT put_defaultSelected([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(12)]
        HRESULT get_defaultSelected([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(13)]
        HRESULT put_index([NativeTypeName("LONG")] int v);

        [VtblIndex(14)]
        HRESULT get_index([NativeTypeName("LONG *")] int* p);

        [VtblIndex(15)]
        HRESULT put_text([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(16)]
        HRESULT get_text([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(17)]
        HRESULT get_form(IHTMLFormElement** p);
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

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_selected;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_selected;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_value;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_value;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_defaultSelected;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_defaultSelected;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_index;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_index;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_text;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_text;

        [NativeTypeName("HRESULT (IHTMLFormElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLFormElement**, int> get_form;
    }
}
