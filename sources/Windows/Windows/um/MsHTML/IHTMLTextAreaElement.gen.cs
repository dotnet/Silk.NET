// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement"]/*'/>
[Guid("3050F2AA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLTextAreaElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLTextAreaElement : IHTMLTextAreaElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLTextAreaElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, uint> )(lpVtbl[1]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, uint> )(lpVtbl[2]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, uint*, int> )(lpVtbl[3]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, ushort**, int> )(lpVtbl[7]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.put_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_value([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, ushort*, int> )(lpVtbl[8]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_value([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, ushort**, int> )(lpVtbl[9]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.put_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, ushort*, int> )(lpVtbl[10]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, ushort**, int> )(lpVtbl[11]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.put_status"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_status(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, VARIANT, int> )(lpVtbl[12]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_status"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_status(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, VARIANT*, int> )(lpVtbl[13]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.put_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, short, int> )(lpVtbl[14]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, short*, int> )(lpVtbl[15]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_form"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_form(IHTMLFormElement** p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, IHTMLFormElement**, int> )(lpVtbl[16]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.put_defaultValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_defaultValue([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, ushort*, int> )(lpVtbl[17]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_defaultValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_defaultValue([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, ushort**, int> )(lpVtbl[18]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.select"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT select()
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, int> )(lpVtbl[19]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.put_onchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_onchange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, VARIANT, int> )(lpVtbl[20]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_onchange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_onchange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, VARIANT*, int> )(lpVtbl[21]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.put_onselect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_onselect(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, VARIANT, int> )(lpVtbl[22]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_onselect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_onselect(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, VARIANT*, int> )(lpVtbl[23]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.put_readOnly"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_readOnly([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, short, int> )(lpVtbl[24]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_readOnly"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_readOnly([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, short*, int> )(lpVtbl[25]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.put_rows"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_rows([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, int, int> )(lpVtbl[26]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_rows"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_rows([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, int*, int> )(lpVtbl[27]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.put_cols"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_cols([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, int, int> )(lpVtbl[28]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_cols"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_cols([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, int*, int> )(lpVtbl[29]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.put_wrap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_wrap([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, ushort*, int> )(lpVtbl[30]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.get_wrap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_wrap([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, ushort**, int> )(lpVtbl[31]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement.xml' path='doc/member[@name="IHTMLTextAreaElement.createTextRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT createTextRange(IHTMLTxtRange** range)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement*, IHTMLTxtRange**, int> )(lpVtbl[32]))((IHTMLTextAreaElement*)Unsafe.AsPointer(ref this), range);
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
        HRESULT put_readOnly([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(25)]
        HRESULT get_readOnly([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(26)]
        HRESULT put_rows([NativeTypeName("long")] int v);
        [VtblIndex(27)]
        HRESULT get_rows([NativeTypeName("long *")] int* p);
        [VtblIndex(28)]
        HRESULT put_cols([NativeTypeName("long")] int v);
        [VtblIndex(29)]
        HRESULT get_cols([NativeTypeName("long *")] int* p);
        [VtblIndex(30)]
        HRESULT put_wrap([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(31)]
        HRESULT get_wrap([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(32)]
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
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_rows;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_rows;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_cols;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_cols;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_wrap;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_wrap;
        [NativeTypeName("HRESULT (IHTMLTxtRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTxtRange**, int> createTextRange;
    }
}