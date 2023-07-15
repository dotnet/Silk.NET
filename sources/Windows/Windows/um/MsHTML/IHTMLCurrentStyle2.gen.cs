// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2"]/*'/>
[Guid("3050F658-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLCurrentStyle2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLCurrentStyle2 : IHTMLCurrentStyle2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLCurrentStyle2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, uint> )(lpVtbl[1]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, uint> )(lpVtbl[2]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, uint*, int> )(lpVtbl[3]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_layoutFlow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_layoutFlow([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, ushort**, int> )(lpVtbl[7]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_wordWrap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_wordWrap([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, ushort**, int> )(lpVtbl[8]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_textUnderlinePosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_textUnderlinePosition([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, ushort**, int> )(lpVtbl[9]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_hasLayout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_hasLayout([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, short*, int> )(lpVtbl[10]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_scrollbarBaseColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_scrollbarBaseColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int> )(lpVtbl[11]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_scrollbarFaceColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_scrollbarFaceColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int> )(lpVtbl[12]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_scrollbar3dLightColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_scrollbar3dLightColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int> )(lpVtbl[13]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_scrollbarShadowColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_scrollbarShadowColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int> )(lpVtbl[14]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_scrollbarHighlightColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_scrollbarHighlightColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int> )(lpVtbl[15]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_scrollbarDarkShadowColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_scrollbarDarkShadowColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int> )(lpVtbl[16]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_scrollbarArrowColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_scrollbarArrowColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int> )(lpVtbl[17]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_scrollbarTrackColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_scrollbarTrackColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int> )(lpVtbl[18]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_writingMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_writingMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, ushort**, int> )(lpVtbl[19]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_zoom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_zoom(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int> )(lpVtbl[20]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_filter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_filter([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, ushort**, int> )(lpVtbl[21]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_textAlignLast"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_textAlignLast([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, ushort**, int> )(lpVtbl[22]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_textKashidaSpace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_textKashidaSpace(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int> )(lpVtbl[23]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle2.xml' path='doc/member[@name="IHTMLCurrentStyle2.get_isBlock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_isBlock([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle2*, short*, int> )(lpVtbl[24]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_layoutFlow([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(8)]
        HRESULT get_wordWrap([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT get_textUnderlinePosition([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(10)]
        HRESULT get_hasLayout([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(11)]
        HRESULT get_scrollbarBaseColor(VARIANT* p);
        [VtblIndex(12)]
        HRESULT get_scrollbarFaceColor(VARIANT* p);
        [VtblIndex(13)]
        HRESULT get_scrollbar3dLightColor(VARIANT* p);
        [VtblIndex(14)]
        HRESULT get_scrollbarShadowColor(VARIANT* p);
        [VtblIndex(15)]
        HRESULT get_scrollbarHighlightColor(VARIANT* p);
        [VtblIndex(16)]
        HRESULT get_scrollbarDarkShadowColor(VARIANT* p);
        [VtblIndex(17)]
        HRESULT get_scrollbarArrowColor(VARIANT* p);
        [VtblIndex(18)]
        HRESULT get_scrollbarTrackColor(VARIANT* p);
        [VtblIndex(19)]
        HRESULT get_writingMode([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(20)]
        HRESULT get_zoom(VARIANT* p);
        [VtblIndex(21)]
        HRESULT get_filter([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(22)]
        HRESULT get_textAlignLast([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(23)]
        HRESULT get_textKashidaSpace(VARIANT* p);
        [VtblIndex(24)]
        HRESULT get_isBlock([NativeTypeName("VARIANT_BOOL *")] short* p);
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
        public delegate* unmanaged<TSelf*, ushort**, int> get_layoutFlow;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_wordWrap;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textUnderlinePosition;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_hasLayout;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarBaseColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarFaceColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbar3dLightColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarShadowColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarHighlightColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarDarkShadowColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarArrowColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarTrackColor;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_writingMode;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_zoom;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_filter;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textAlignLast;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_textKashidaSpace;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_isBlock;
    }
}