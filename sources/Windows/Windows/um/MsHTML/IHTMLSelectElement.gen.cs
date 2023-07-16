// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement"]/*'/>
[Guid("3050F244-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLSelectElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLSelectElement : IHTMLSelectElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLSelectElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, uint> )(lpVtbl[1]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, uint> )(lpVtbl[2]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, uint*, int> )(lpVtbl[3]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.put_size"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_size([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, int, int> )(lpVtbl[7]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.get_size"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_size([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, int*, int> )(lpVtbl[8]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.put_multiple"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_multiple([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, short, int> )(lpVtbl[9]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.get_multiple"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_multiple([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, short*, int> )(lpVtbl[10]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.put_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, ushort*, int> )(lpVtbl[11]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.get_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, ushort**, int> )(lpVtbl[12]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.get_options"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_options(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, IDispatch**, int> )(lpVtbl[13]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.put_onchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_onchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, VARIANT, int> )(lpVtbl[14]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.get_onchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_onchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, VARIANT*, int> )(lpVtbl[15]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.put_selectedIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_selectedIndex([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, int, int> )(lpVtbl[16]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.get_selectedIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_selectedIndex([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, int*, int> )(lpVtbl[17]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, ushort**, int> )(lpVtbl[18]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.put_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_value([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, ushort*, int> )(lpVtbl[19]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.get_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_value([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, ushort**, int> )(lpVtbl[20]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.put_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, short, int> )(lpVtbl[21]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.get_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, short*, int> )(lpVtbl[22]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.get_form"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_form(IHTMLFormElement** p)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, IHTMLFormElement**, int> )(lpVtbl[23]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.add"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT add(IHTMLElement* element, VARIANT before)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, IHTMLElement*, VARIANT, int> )(lpVtbl[24]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), element, before);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.remove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT remove([NativeTypeName("long")] int index = -1)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, int, int> )(lpVtbl[25]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), index);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.put_length"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_length([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, int, int> )(lpVtbl[26]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.get_length"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, int*, int> )(lpVtbl[27]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.get__newEnum"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get__newEnum(IUnknown** p)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, IUnknown**, int> )(lpVtbl[28]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.item"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT item(VARIANT name, VARIANT index, IDispatch** pdisp)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, VARIANT, VARIANT, IDispatch**, int> )(lpVtbl[29]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), name, index, pdisp);
    }

    /// <include file='IHTMLSelectElement.xml' path='doc/member[@name="IHTMLSelectElement.tags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT tags(VARIANT tagName, IDispatch** pdisp)
    {
        return ((delegate* unmanaged<IHTMLSelectElement*, VARIANT, IDispatch**, int> )(lpVtbl[30]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), tagName, pdisp);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_size([NativeTypeName("long")] int v);
        [VtblIndex(8)]
        HRESULT get_size([NativeTypeName("long *")] int* p);
        [VtblIndex(9)]
        HRESULT put_multiple([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(10)]
        HRESULT get_multiple([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(11)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT get_options(IDispatch** p);
        [VtblIndex(14)]
        HRESULT put_onchange(VARIANT v);
        [VtblIndex(15)]
        HRESULT get_onchange(VARIANT* p);
        [VtblIndex(16)]
        HRESULT put_selectedIndex([NativeTypeName("long")] int v);
        [VtblIndex(17)]
        HRESULT get_selectedIndex([NativeTypeName("long *")] int* p);
        [VtblIndex(18)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(19)]
        HRESULT put_value([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(20)]
        HRESULT get_value([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(21)]
        HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(22)]
        HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(23)]
        HRESULT get_form(IHTMLFormElement** p);
        [VtblIndex(24)]
        HRESULT add(IHTMLElement* element, VARIANT before);
        [VtblIndex(25)]
        HRESULT remove([NativeTypeName("long")] int index = -1);
        [VtblIndex(26)]
        HRESULT put_length([NativeTypeName("long")] int v);
        [VtblIndex(27)]
        HRESULT get_length([NativeTypeName("long *")] int* p);
        [VtblIndex(28)]
        HRESULT get__newEnum(IUnknown** p);
        [VtblIndex(29)]
        HRESULT item(VARIANT name, VARIANT index, IDispatch** pdisp);
        [VtblIndex(30)]
        HRESULT tags(VARIANT tagName, IDispatch** pdisp);
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
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_size;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_size;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_multiple;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_multiple;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_options;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onchange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onchange;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_selectedIndex;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_selectedIndex;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_value;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_value;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_disabled;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_disabled;
        [NativeTypeName("HRESULT (IHTMLFormElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLFormElement**, int> get_form;
        [NativeTypeName("HRESULT (IHTMLElement *, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, VARIANT, int> add;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> remove;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_length;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get__newEnum;
        [NativeTypeName("HRESULT (VARIANT, VARIANT, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, IDispatch**, int> item;
        [NativeTypeName("HRESULT (VARIANT, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, IDispatch**, int> tags;
    }
}