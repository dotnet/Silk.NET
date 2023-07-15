// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement"]/*'/>
[Guid("3050F2BC-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLOptionButtonElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLOptionButtonElement : IHTMLOptionButtonElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLOptionButtonElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, uint> )(lpVtbl[1]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, uint> )(lpVtbl[2]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, uint*, int> )(lpVtbl[3]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.put_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_value([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, ushort*, int> )(lpVtbl[7]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.get_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_value([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, ushort**, int> )(lpVtbl[8]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, ushort**, int> )(lpVtbl[9]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.put_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, ushort*, int> )(lpVtbl[10]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.get_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, ushort**, int> )(lpVtbl[11]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.put_checked"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_checked([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, short, int> )(lpVtbl[12]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.get_checked"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_checked([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, short*, int> )(lpVtbl[13]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.put_defaultChecked"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_defaultChecked([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, short, int> )(lpVtbl[14]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.get_defaultChecked"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_defaultChecked([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, short*, int> )(lpVtbl[15]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.put_onchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_onchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, VARIANT, int> )(lpVtbl[16]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.get_onchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_onchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, VARIANT*, int> )(lpVtbl[17]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.put_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, short, int> )(lpVtbl[18]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.get_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, short*, int> )(lpVtbl[19]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.put_status"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_status([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, short, int> )(lpVtbl[20]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.get_status"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_status([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, short*, int> )(lpVtbl[21]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.put_indeterminate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_indeterminate([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, short, int> )(lpVtbl[22]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.get_indeterminate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_indeterminate([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, short*, int> )(lpVtbl[23]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLOptionButtonElement.xml' path='doc/member[@name="IHTMLOptionButtonElement.get_form"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_form(IHTMLFormElement** p)
    {
        return ((delegate* unmanaged<IHTMLOptionButtonElement*, IHTMLFormElement**, int> )(lpVtbl[24]))((IHTMLOptionButtonElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_value([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_value([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(10)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(11)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(12)]
        HRESULT put_checked([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(13)]
        HRESULT get_checked([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(14)]
        HRESULT put_defaultChecked([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(15)]
        HRESULT get_defaultChecked([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(16)]
        HRESULT put_onchange(VARIANT v);
        [VtblIndex(17)]
        HRESULT get_onchange(VARIANT* p);
        [VtblIndex(18)]
        HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(19)]
        HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(20)]
        HRESULT put_status([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(21)]
        HRESULT get_status([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(22)]
        HRESULT put_indeterminate([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(23)]
        HRESULT get_indeterminate([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(24)]
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
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_value;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_value;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_checked;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_checked;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_defaultChecked;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_defaultChecked;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onchange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onchange;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_disabled;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_disabled;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_status;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_status;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_indeterminate;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_indeterminate;
        [NativeTypeName("HRESULT (IHTMLFormElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLFormElement**, int> get_form;
    }
}