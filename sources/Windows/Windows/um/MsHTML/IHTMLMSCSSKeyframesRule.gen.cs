// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLMSCSSKeyframesRule.xml' path='doc/member[@name="IHTMLMSCSSKeyframesRule"]/*'/>
[Guid("3051080D-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLMSCSSKeyframesRule : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLMSCSSKeyframesRule : IHTMLMSCSSKeyframesRule.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLMSCSSKeyframesRule));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, uint> )(lpVtbl[1]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, uint> )(lpVtbl[2]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, uint*, int> )(lpVtbl[3]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLMSCSSKeyframesRule.xml' path='doc/member[@name="IHTMLMSCSSKeyframesRule.put_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, ushort*, int> )(lpVtbl[7]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMSCSSKeyframesRule.xml' path='doc/member[@name="IHTMLMSCSSKeyframesRule.get_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, ushort**, int> )(lpVtbl[8]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMSCSSKeyframesRule.xml' path='doc/member[@name="IHTMLMSCSSKeyframesRule.get_cssRules"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_cssRules(IHTMLStyleSheetRulesCollection** p)
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, IHTMLStyleSheetRulesCollection**, int> )(lpVtbl[9]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMSCSSKeyframesRule.xml' path='doc/member[@name="IHTMLMSCSSKeyframesRule.appendRule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT appendRule([NativeTypeName("BSTR")] ushort* bstrRule)
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, ushort*, int> )(lpVtbl[10]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), bstrRule);
    }

    /// <include file='IHTMLMSCSSKeyframesRule.xml' path='doc/member[@name="IHTMLMSCSSKeyframesRule.deleteRule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT deleteRule([NativeTypeName("BSTR")] ushort* bstrKey)
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, ushort*, int> )(lpVtbl[11]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), bstrKey);
    }

    /// <include file='IHTMLMSCSSKeyframesRule.xml' path='doc/member[@name="IHTMLMSCSSKeyframesRule.findRule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT findRule([NativeTypeName("BSTR")] ushort* bstrKey, IHTMLMSCSSKeyframeRule** ppMSKeyframeRule)
    {
        return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, ushort*, IHTMLMSCSSKeyframeRule**, int> )(lpVtbl[12]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), bstrKey, ppMSKeyframeRule);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT get_cssRules(IHTMLStyleSheetRulesCollection** p);
        [VtblIndex(10)]
        HRESULT appendRule([NativeTypeName("BSTR")] ushort* bstrRule);
        [VtblIndex(11)]
        HRESULT deleteRule([NativeTypeName("BSTR")] ushort* bstrKey);
        [VtblIndex(12)]
        HRESULT findRule([NativeTypeName("BSTR")] ushort* bstrKey, IHTMLMSCSSKeyframeRule** ppMSKeyframeRule);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;
        [NativeTypeName("HRESULT (IHTMLStyleSheetRulesCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLStyleSheetRulesCollection**, int> get_cssRules;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> appendRule;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> deleteRule;
        [NativeTypeName("HRESULT (BSTR, IHTMLMSCSSKeyframeRule **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLMSCSSKeyframeRule**, int> findRule;
    }
}