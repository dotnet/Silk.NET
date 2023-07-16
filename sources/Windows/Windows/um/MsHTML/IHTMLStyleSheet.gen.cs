// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet"]/*'/>
[Guid("3050F2E3-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLStyleSheet : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLStyleSheet : IHTMLStyleSheet.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLStyleSheet));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, uint> )(lpVtbl[1]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, uint> )(lpVtbl[2]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, uint*, int> )(lpVtbl[3]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.put_title"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_title([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, ushort*, int> )(lpVtbl[7]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.get_title"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_title([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, ushort**, int> )(lpVtbl[8]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.get_parentStyleSheet"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_parentStyleSheet(IHTMLStyleSheet** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, IHTMLStyleSheet**, int> )(lpVtbl[9]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.get_owningElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_owningElement(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, IHTMLElement**, int> )(lpVtbl[10]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.put_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, short, int> )(lpVtbl[11]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.get_disabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, short*, int> )(lpVtbl[12]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.get_readOnly"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_readOnly([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, short*, int> )(lpVtbl[13]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.get_imports"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_imports(IHTMLStyleSheetsCollection** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, IHTMLStyleSheetsCollection**, int> )(lpVtbl[14]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.put_href"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_href([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, ushort*, int> )(lpVtbl[15]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.get_href"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_href([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, ushort**, int> )(lpVtbl[16]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, ushort**, int> )(lpVtbl[17]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.get_id"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_id([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, ushort**, int> )(lpVtbl[18]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.addImport"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT addImport([NativeTypeName("BSTR")] ushort* bstrURL, [NativeTypeName("long")] int lIndex, [NativeTypeName("long *")] int* plIndex)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, ushort*, int, int*, int> )(lpVtbl[19]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), bstrURL, lIndex, plIndex);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.addRule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT addRule([NativeTypeName("BSTR")] ushort* bstrSelector, [NativeTypeName("BSTR")] ushort* bstrStyle, [NativeTypeName("long")] int lIndex, [NativeTypeName("long *")] int* plNewIndex)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, ushort*, ushort*, int, int*, int> )(lpVtbl[20]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), bstrSelector, bstrStyle, lIndex, plNewIndex);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.removeImport"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT removeImport([NativeTypeName("long")] int lIndex)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, int, int> )(lpVtbl[21]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), lIndex);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.removeRule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT removeRule([NativeTypeName("long")] int lIndex)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, int, int> )(lpVtbl[22]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), lIndex);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.put_media"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_media([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, ushort*, int> )(lpVtbl[23]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.get_media"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_media([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, ushort**, int> )(lpVtbl[24]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.put_cssText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_cssText([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, ushort*, int> )(lpVtbl[25]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.get_cssText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_cssText([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, ushort**, int> )(lpVtbl[26]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet.xml' path='doc/member[@name="IHTMLStyleSheet.get_rules"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_rules(IHTMLStyleSheetRulesCollection** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet*, IHTMLStyleSheetRulesCollection**, int> )(lpVtbl[27]))((IHTMLStyleSheet*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_title([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_title([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT get_parentStyleSheet(IHTMLStyleSheet** p);
        [VtblIndex(10)]
        HRESULT get_owningElement(IHTMLElement** p);
        [VtblIndex(11)]
        HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(12)]
        HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(13)]
        HRESULT get_readOnly([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(14)]
        HRESULT get_imports(IHTMLStyleSheetsCollection** p);
        [VtblIndex(15)]
        HRESULT put_href([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(16)]
        HRESULT get_href([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(17)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(18)]
        HRESULT get_id([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(19)]
        HRESULT addImport([NativeTypeName("BSTR")] ushort* bstrURL, [NativeTypeName("long")] int lIndex, [NativeTypeName("long *")] int* plIndex);
        [VtblIndex(20)]
        HRESULT addRule([NativeTypeName("BSTR")] ushort* bstrSelector, [NativeTypeName("BSTR")] ushort* bstrStyle, [NativeTypeName("long")] int lIndex, [NativeTypeName("long *")] int* plNewIndex);
        [VtblIndex(21)]
        HRESULT removeImport([NativeTypeName("long")] int lIndex);
        [VtblIndex(22)]
        HRESULT removeRule([NativeTypeName("long")] int lIndex);
        [VtblIndex(23)]
        HRESULT put_media([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(24)]
        HRESULT get_media([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(25)]
        HRESULT put_cssText([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(26)]
        HRESULT get_cssText([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(27)]
        HRESULT get_rules(IHTMLStyleSheetRulesCollection** p);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_title;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_title;
        [NativeTypeName("HRESULT (IHTMLStyleSheet **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLStyleSheet**, int> get_parentStyleSheet;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_owningElement;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_disabled;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_disabled;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_readOnly;
        [NativeTypeName("HRESULT (IHTMLStyleSheetsCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLStyleSheetsCollection**, int> get_imports;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_href;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_href;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_id;
        [NativeTypeName("HRESULT (BSTR, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, int> addImport;
        [NativeTypeName("HRESULT (BSTR, BSTR, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int, int*, int> addRule;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> removeImport;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> removeRule;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_media;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_media;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_cssText;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_cssText;
        [NativeTypeName("HRESULT (IHTMLStyleSheetRulesCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLStyleSheetRulesCollection**, int> get_rules;
    }
}