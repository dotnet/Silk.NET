// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5"]/*' />
[Guid("30510481-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLCurrentStyle5 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLCurrentStyle5 : IHTMLCurrentStyle5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLCurrentStyle5));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, uint>)(lpVtbl[1]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, uint>)(lpVtbl[2]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, uint*, int>)(lpVtbl[3]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_captionSide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_captionSide([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, ushort**, int>)(lpVtbl[7]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_outline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_outline([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, ushort**, int>)(lpVtbl[8]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_outlineWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_outlineWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, VARIANT*, int>)(lpVtbl[9]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_outlineStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_outlineStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, ushort**, int>)(lpVtbl[10]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_outlineColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_outlineColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, VARIANT*, int>)(lpVtbl[11]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_boxSizing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_boxSizing([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, ushort**, int>)(lpVtbl[12]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_borderSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_borderSpacing([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, ushort**, int>)(lpVtbl[13]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_orphans"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_orphans(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, VARIANT*, int>)(lpVtbl[14]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_widows"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_widows(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, VARIANT*, int>)(lpVtbl[15]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_pageBreakInside"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_pageBreakInside([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, ushort**, int>)(lpVtbl[16]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_emptyCells"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_emptyCells([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, ushort**, int>)(lpVtbl[17]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_msBlockProgression"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_msBlockProgression([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, ushort**, int>)(lpVtbl[18]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCurrentStyle5.xml' path='doc/member[@name="IHTMLCurrentStyle5.get_quotes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_quotes([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCurrentStyle5*, ushort**, int>)(lpVtbl[19]))((IHTMLCurrentStyle5*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_captionSide([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(8)]
        HRESULT get_outline([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT get_outlineWidth(VARIANT* p);

        [VtblIndex(10)]
        HRESULT get_outlineStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT get_outlineColor(VARIANT* p);

        [VtblIndex(12)]
        HRESULT get_boxSizing([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(13)]
        HRESULT get_borderSpacing([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(14)]
        HRESULT get_orphans(VARIANT* p);

        [VtblIndex(15)]
        HRESULT get_widows(VARIANT* p);

        [VtblIndex(16)]
        HRESULT get_pageBreakInside([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(17)]
        HRESULT get_emptyCells([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(18)]
        HRESULT get_msBlockProgression([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(19)]
        HRESULT get_quotes([NativeTypeName("BSTR *")] ushort** p);
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
        public delegate* unmanaged<TSelf*, ushort**, int> get_captionSide;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_outline;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_outlineWidth;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_outlineStyle;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_outlineColor;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_boxSizing;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderSpacing;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_orphans;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_widows;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_pageBreakInside;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_emptyCells;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msBlockProgression;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_quotes;
    }
}
