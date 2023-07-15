// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLStyleSheet4.xml' path='doc/member[@name="IHTMLStyleSheet4"]/*'/>
[Guid("305106F4-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLStyleSheet4 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLStyleSheet4 : IHTMLStyleSheet4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLStyleSheet4));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, uint> )(lpVtbl[1]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, uint> )(lpVtbl[2]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, uint*, int> )(lpVtbl[3]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLStyleSheet4.xml' path='doc/member[@name="IHTMLStyleSheet4.get_type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, ushort**, int> )(lpVtbl[7]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet4.xml' path='doc/member[@name="IHTMLStyleSheet4.get_href"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_href(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, VARIANT*, int> )(lpVtbl[8]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet4.xml' path='doc/member[@name="IHTMLStyleSheet4.get_title"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_title([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, ushort**, int> )(lpVtbl[9]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet4.xml' path='doc/member[@name="IHTMLStyleSheet4.get_ownerNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ownerNode(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, IHTMLElement**, int> )(lpVtbl[10]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet4.xml' path='doc/member[@name="IHTMLStyleSheet4.get_ownerRule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ownerRule(IHTMLCSSRule** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, IHTMLCSSRule**, int> )(lpVtbl[11]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet4.xml' path='doc/member[@name="IHTMLStyleSheet4.get_cssRules"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_cssRules(IHTMLStyleSheetRulesCollection** p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, IHTMLStyleSheetRulesCollection**, int> )(lpVtbl[12]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet4.xml' path='doc/member[@name="IHTMLStyleSheet4.get_media"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_media(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, VARIANT*, int> )(lpVtbl[13]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyleSheet4.xml' path='doc/member[@name="IHTMLStyleSheet4.insertRule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT insertRule([NativeTypeName("BSTR")] ushort* bstrRule, [NativeTypeName("long")] int lIndex, [NativeTypeName("long *")] int* plNewIndex)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, ushort*, int, int*, int> )(lpVtbl[14]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), bstrRule, lIndex, plNewIndex);
    }

    /// <include file='IHTMLStyleSheet4.xml' path='doc/member[@name="IHTMLStyleSheet4.deleteRule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT deleteRule([NativeTypeName("long")] int lIndex = -1)
    {
        return ((delegate* unmanaged<IHTMLStyleSheet4*, int, int> )(lpVtbl[15]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), lIndex);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(8)]
        HRESULT get_href(VARIANT* p);
        [VtblIndex(9)]
        HRESULT get_title([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(10)]
        HRESULT get_ownerNode(IHTMLElement** p);
        [VtblIndex(11)]
        HRESULT get_ownerRule(IHTMLCSSRule** p);
        [VtblIndex(12)]
        HRESULT get_cssRules(IHTMLStyleSheetRulesCollection** p);
        [VtblIndex(13)]
        HRESULT get_media(VARIANT* p);
        [VtblIndex(14)]
        HRESULT insertRule([NativeTypeName("BSTR")] ushort* bstrRule, [NativeTypeName("long")] int lIndex, [NativeTypeName("long *")] int* plNewIndex);
        [VtblIndex(15)]
        HRESULT deleteRule([NativeTypeName("long")] int lIndex = -1);
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
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_href;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_title;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_ownerNode;
        [NativeTypeName("HRESULT (IHTMLCSSRule **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLCSSRule**, int> get_ownerRule;
        [NativeTypeName("HRESULT (IHTMLStyleSheetRulesCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLStyleSheetRulesCollection**, int> get_cssRules;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_media;
        [NativeTypeName("HRESULT (BSTR, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, int> insertRule;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> deleteRule;
    }
}