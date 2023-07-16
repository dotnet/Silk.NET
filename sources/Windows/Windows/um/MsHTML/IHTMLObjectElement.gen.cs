// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement"]/*'/>
[Guid("3050F24F-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLObjectElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLObjectElement : IHTMLObjectElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLObjectElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, uint> )(lpVtbl[1]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, uint> )(lpVtbl[2]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, uint*, int> )(lpVtbl[3]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_object"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_object(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, IDispatch**, int> )(lpVtbl[7]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_classid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_classid([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int> )(lpVtbl[8]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_data"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_data([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int> )(lpVtbl[9]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.putref_recordset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT putref_recordset(IDispatch* v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, IDispatch*, int> )(lpVtbl[10]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_recordset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_recordset(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, IDispatch**, int> )(lpVtbl[11]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_align"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int> )(lpVtbl[12]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_align"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int> )(lpVtbl[13]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int> )(lpVtbl[14]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int> )(lpVtbl[15]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_codeBase"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_codeBase([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int> )(lpVtbl[16]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_codeBase"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_codeBase([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int> )(lpVtbl[17]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_codeType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_codeType([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int> )(lpVtbl[18]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_codeType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_codeType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int> )(lpVtbl[19]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_code"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_code([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int> )(lpVtbl[20]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_code"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_code([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int> )(lpVtbl[21]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_BaseHref"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_BaseHref([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int> )(lpVtbl[22]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_type([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int> )(lpVtbl[23]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int> )(lpVtbl[24]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_form"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_form(IHTMLFormElement** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, IHTMLFormElement**, int> )(lpVtbl[25]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_width(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT, int> )(lpVtbl[26]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_width(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT*, int> )(lpVtbl[27]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_height(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT, int> )(lpVtbl[28]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_height(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT*, int> )(lpVtbl[29]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_readyState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_readyState([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, int*, int> )(lpVtbl[30]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_onreadystatechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT, int> )(lpVtbl[31]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_onreadystatechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT*, int> )(lpVtbl[32]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_onerror(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT, int> )(lpVtbl[33]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_onerror(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT*, int> )(lpVtbl[34]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_altHtml"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_altHtml([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int> )(lpVtbl[35]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_altHtml"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_altHtml([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int> )(lpVtbl[36]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_vspace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_vspace([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, int, int> )(lpVtbl[37]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_vspace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_vspace([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, int*, int> )(lpVtbl[38]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.put_hspace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_hspace([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, int, int> )(lpVtbl[39]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLObjectElement.xml' path='doc/member[@name="IHTMLObjectElement.get_hspace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_hspace([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLObjectElement*, int*, int> )(lpVtbl[40]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_object(IDispatch** p);
        [VtblIndex(8)]
        HRESULT get_classid([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT get_data([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(10)]
        HRESULT putref_recordset(IDispatch* v);
        [VtblIndex(11)]
        HRESULT get_recordset(IDispatch** p);
        [VtblIndex(12)]
        HRESULT put_align([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(13)]
        HRESULT get_align([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(14)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(15)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(16)]
        HRESULT put_codeBase([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(17)]
        HRESULT get_codeBase([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(18)]
        HRESULT put_codeType([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(19)]
        HRESULT get_codeType([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(20)]
        HRESULT put_code([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(21)]
        HRESULT get_code([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(22)]
        HRESULT get_BaseHref([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(23)]
        HRESULT put_type([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(24)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(25)]
        HRESULT get_form(IHTMLFormElement** p);
        [VtblIndex(26)]
        HRESULT put_width(VARIANT v);
        [VtblIndex(27)]
        HRESULT get_width(VARIANT* p);
        [VtblIndex(28)]
        HRESULT put_height(VARIANT v);
        [VtblIndex(29)]
        HRESULT get_height(VARIANT* p);
        [VtblIndex(30)]
        HRESULT get_readyState([NativeTypeName("long *")] int* p);
        [VtblIndex(31)]
        HRESULT put_onreadystatechange(VARIANT v);
        [VtblIndex(32)]
        HRESULT get_onreadystatechange(VARIANT* p);
        [VtblIndex(33)]
        HRESULT put_onerror(VARIANT v);
        [VtblIndex(34)]
        HRESULT get_onerror(VARIANT* p);
        [VtblIndex(35)]
        HRESULT put_altHtml([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(36)]
        HRESULT get_altHtml([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(37)]
        HRESULT put_vspace([NativeTypeName("long")] int v);
        [VtblIndex(38)]
        HRESULT get_vspace([NativeTypeName("long *")] int* p);
        [VtblIndex(39)]
        HRESULT put_hspace([NativeTypeName("long")] int v);
        [VtblIndex(40)]
        HRESULT get_hspace([NativeTypeName("long *")] int* p);
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
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_object;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_classid;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_data;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> putref_recordset;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_recordset;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_align;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_align;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_codeBase;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_codeBase;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_codeType;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_codeType;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_code;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_code;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_BaseHref;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_type;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;
        [NativeTypeName("HRESULT (IHTMLFormElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLFormElement**, int> get_form;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_width;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_width;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_height;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_height;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_readyState;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreadystatechange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreadystatechange;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onerror;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onerror;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_altHtml;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_altHtml;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_vspace;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_vspace;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_hspace;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_hspace;
    }
}