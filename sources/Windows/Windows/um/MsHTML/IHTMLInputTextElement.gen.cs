// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement"]/*'/>
[Guid("3050F2A6-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLInputTextElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLInputTextElement : IHTMLInputTextElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLInputTextElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, uint> )(lpVtbl[1]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, uint> )(lpVtbl[2]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, uint*, int> )(lpVtbl[3]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, ushort**, int> )(lpVtbl[7]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.put_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_value([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, ushort*, int> )(lpVtbl[8]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.get_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_value([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, ushort**, int> )(lpVtbl[9]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.put_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, ushort*, int> )(lpVtbl[10]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.get_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, ushort**, int> )(lpVtbl[11]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.put_status"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_status(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, VARIANT, int> )(lpVtbl[12]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.get_status"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_status(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, VARIANT*, int> )(lpVtbl[13]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.put_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, short, int> )(lpVtbl[14]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.get_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, short*, int> )(lpVtbl[15]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.get_form"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_form(IHTMLFormElement** p)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, IHTMLFormElement**, int> )(lpVtbl[16]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.put_defaultValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_defaultValue([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, ushort*, int> )(lpVtbl[17]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.get_defaultValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_defaultValue([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, ushort**, int> )(lpVtbl[18]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.put_size"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_size([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, int, int> )(lpVtbl[19]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.get_size"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_size([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, int*, int> )(lpVtbl[20]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.put_maxLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_maxLength([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, int, int> )(lpVtbl[21]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.get_maxLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_maxLength([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, int*, int> )(lpVtbl[22]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.select"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT select()
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, int> )(lpVtbl[23]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.put_onchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_onchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, VARIANT, int> )(lpVtbl[24]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.get_onchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_onchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, VARIANT*, int> )(lpVtbl[25]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.put_onselect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_onselect(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, VARIANT, int> )(lpVtbl[26]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.get_onselect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_onselect(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, VARIANT*, int> )(lpVtbl[27]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.put_readOnly"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_readOnly([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, short, int> )(lpVtbl[28]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.get_readOnly"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_readOnly([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, short*, int> )(lpVtbl[29]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputTextElement.xml' path='doc/member[@name="IHTMLInputTextElement.createTextRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT createTextRange(IHTMLTxtRange** range)
    {
        return ((delegate* unmanaged<IHTMLInputTextElement*, IHTMLTxtRange**, int> )(lpVtbl[30]))((IHTMLInputTextElement*)Unsafe.AsPointer(ref this), range);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(8)]
        HRESULT put_value([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(9)]
        HRESULT get_value([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(10)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(11)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(12)]
        HRESULT put_status(VARIANT v);
        [VtblIndex(13)]
        HRESULT get_status(VARIANT* p);
        [VtblIndex(14)]
        HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(15)]
        HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(16)]
        HRESULT get_form(IHTMLFormElement** p);
        [VtblIndex(17)]
        HRESULT put_defaultValue([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(18)]
        HRESULT get_defaultValue([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(19)]
        HRESULT put_size([NativeTypeName("long")] int v);
        [VtblIndex(20)]
        HRESULT get_size([NativeTypeName("long *")] int* p);
        [VtblIndex(21)]
        HRESULT put_maxLength([NativeTypeName("long")] int v);
        [VtblIndex(22)]
        HRESULT get_maxLength([NativeTypeName("long *")] int* p);
        [VtblIndex(23)]
        HRESULT select();
        [VtblIndex(24)]
        HRESULT put_onchange(VARIANT v);
        [VtblIndex(25)]
        HRESULT get_onchange(VARIANT* p);
        [VtblIndex(26)]
        HRESULT put_onselect(VARIANT v);
        [VtblIndex(27)]
        HRESULT get_onselect(VARIANT* p);
        [VtblIndex(28)]
        HRESULT put_readOnly([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(29)]
        HRESULT get_readOnly([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(30)]
        HRESULT createTextRange(IHTMLTxtRange** range);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_value;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_value;
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
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_defaultValue;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_defaultValue;
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
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_readOnly;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_readOnly;
        [NativeTypeName("HRESULT (IHTMLTxtRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTxtRange**, int> createTextRange;
    }
}