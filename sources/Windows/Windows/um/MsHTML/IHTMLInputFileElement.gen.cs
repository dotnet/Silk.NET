// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement"]/*' />
[Guid("3050F2AD-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLInputFileElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLInputFileElement : IHTMLInputFileElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLInputFileElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, uint>)(lpVtbl[1]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, uint>)(lpVtbl[2]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, uint*, int>)(lpVtbl[3]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.get_type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, ushort**, int>)(lpVtbl[7]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.put_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, ushort*, int>)(lpVtbl[8]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.get_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, ushort**, int>)(lpVtbl[9]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.put_status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_status(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, VARIANT, int>)(lpVtbl[10]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.get_status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_status(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, VARIANT*, int>)(lpVtbl[11]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.put_disabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, short, int>)(lpVtbl[12]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.get_disabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, short*, int>)(lpVtbl[13]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.get_form"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_form(IHTMLFormElement** p)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, IHTMLFormElement**, int>)(lpVtbl[14]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.put_size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_size([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, int, int>)(lpVtbl[15]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.get_size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_size([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, int*, int>)(lpVtbl[16]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.put_maxLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_maxLength([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, int, int>)(lpVtbl[17]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.get_maxLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_maxLength([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, int*, int>)(lpVtbl[18]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.select"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT select()
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, int>)(lpVtbl[19]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.put_onchange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_onchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, VARIANT, int>)(lpVtbl[20]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.get_onchange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_onchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, VARIANT*, int>)(lpVtbl[21]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.put_onselect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_onselect(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, VARIANT, int>)(lpVtbl[22]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.get_onselect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_onselect(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, VARIANT*, int>)(lpVtbl[23]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.put_value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_value([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, ushort*, int>)(lpVtbl[24]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputFileElement.xml' path='doc/member[@name="IHTMLInputFileElement.get_value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_value([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputFileElement*, ushort**, int>)(lpVtbl[25]))((IHTMLInputFileElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(8)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(9)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(10)]
        HRESULT put_status(VARIANT v);

        [VtblIndex(11)]
        HRESULT get_status(VARIANT* p);

        [VtblIndex(12)]
        HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(13)]
        HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(14)]
        HRESULT get_form(IHTMLFormElement** p);

        [VtblIndex(15)]
        HRESULT put_size([NativeTypeName("long")] int v);

        [VtblIndex(16)]
        HRESULT get_size([NativeTypeName("long *")] int* p);

        [VtblIndex(17)]
        HRESULT put_maxLength([NativeTypeName("long")] int v);

        [VtblIndex(18)]
        HRESULT get_maxLength([NativeTypeName("long *")] int* p);

        [VtblIndex(19)]
        HRESULT select();

        [VtblIndex(20)]
        HRESULT put_onchange(VARIANT v);

        [VtblIndex(21)]
        HRESULT get_onchange(VARIANT* p);

        [VtblIndex(22)]
        HRESULT put_onselect(VARIANT v);

        [VtblIndex(23)]
        HRESULT get_onselect(VARIANT* p);

        [VtblIndex(24)]
        HRESULT put_value([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(25)]
        HRESULT get_value([NativeTypeName("BSTR *")] ushort** p);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_status;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_status;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_disabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_disabled;

        [NativeTypeName("HRESULT (IHTMLFormElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLFormElement**, int> get_form;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_size;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_size;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_maxLength;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_maxLength;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> select;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onchange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onchange;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onselect;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onselect;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_value;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_value;
    }
}
