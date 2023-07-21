// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6"]/*' />
[Guid("30510480-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLStyle6 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLStyle6 : IHTMLStyle6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLStyle6));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLStyle6*, uint>)(lpVtbl[1]))((IHTMLStyle6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLStyle6*, uint>)(lpVtbl[2]))((IHTMLStyle6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, uint*, int>)(lpVtbl[3]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_content([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort*, int>)(lpVtbl[7]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_content([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort**, int>)(lpVtbl[8]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_captionSide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_captionSide([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort*, int>)(lpVtbl[9]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_captionSide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_captionSide([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort**, int>)(lpVtbl[10]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_counterIncrement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_counterIncrement([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort*, int>)(lpVtbl[11]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_counterIncrement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_counterIncrement([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort**, int>)(lpVtbl[12]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_counterReset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_counterReset([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort*, int>)(lpVtbl[13]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_counterReset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_counterReset([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort**, int>)(lpVtbl[14]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_outline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_outline([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort*, int>)(lpVtbl[15]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_outline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_outline([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort**, int>)(lpVtbl[16]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_outlineWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_outlineWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, VARIANT, int>)(lpVtbl[17]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_outlineWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_outlineWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, VARIANT*, int>)(lpVtbl[18]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_outlineStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_outlineStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort*, int>)(lpVtbl[19]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_outlineStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_outlineStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort**, int>)(lpVtbl[20]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_outlineColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_outlineColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, VARIANT, int>)(lpVtbl[21]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_outlineColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_outlineColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, VARIANT*, int>)(lpVtbl[22]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_boxSizing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_boxSizing([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort*, int>)(lpVtbl[23]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_boxSizing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_boxSizing([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort**, int>)(lpVtbl[24]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_borderSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_borderSpacing([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort*, int>)(lpVtbl[25]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_borderSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_borderSpacing([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort**, int>)(lpVtbl[26]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_orphans"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_orphans(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, VARIANT, int>)(lpVtbl[27]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_orphans"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_orphans(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, VARIANT*, int>)(lpVtbl[28]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_widows"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_widows(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, VARIANT, int>)(lpVtbl[29]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_widows"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_widows(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, VARIANT*, int>)(lpVtbl[30]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_pageBreakInside"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_pageBreakInside([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort*, int>)(lpVtbl[31]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_pageBreakInside"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_pageBreakInside([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort**, int>)(lpVtbl[32]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_emptyCells"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_emptyCells([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort*, int>)(lpVtbl[33]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_emptyCells"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_emptyCells([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort**, int>)(lpVtbl[34]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_msBlockProgression"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_msBlockProgression([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort*, int>)(lpVtbl[35]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_msBlockProgression"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_msBlockProgression([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort**, int>)(lpVtbl[36]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.put_quotes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_quotes([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort*, int>)(lpVtbl[37]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle6.xml' path='doc/member[@name="IHTMLStyle6.get_quotes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_quotes([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle6*, ushort**, int>)(lpVtbl[38]))((IHTMLStyle6*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_content([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_content([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT put_captionSide([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(10)]
        HRESULT get_captionSide([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT put_counterIncrement([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(12)]
        HRESULT get_counterIncrement([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(13)]
        HRESULT put_counterReset([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(14)]
        HRESULT get_counterReset([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(15)]
        HRESULT put_outline([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(16)]
        HRESULT get_outline([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(17)]
        HRESULT put_outlineWidth(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_outlineWidth(VARIANT* p);

        [VtblIndex(19)]
        HRESULT put_outlineStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(20)]
        HRESULT get_outlineStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT put_outlineColor(VARIANT v);

        [VtblIndex(22)]
        HRESULT get_outlineColor(VARIANT* p);

        [VtblIndex(23)]
        HRESULT put_boxSizing([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(24)]
        HRESULT get_boxSizing([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(25)]
        HRESULT put_borderSpacing([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(26)]
        HRESULT get_borderSpacing([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(27)]
        HRESULT put_orphans(VARIANT v);

        [VtblIndex(28)]
        HRESULT get_orphans(VARIANT* p);

        [VtblIndex(29)]
        HRESULT put_widows(VARIANT v);

        [VtblIndex(30)]
        HRESULT get_widows(VARIANT* p);

        [VtblIndex(31)]
        HRESULT put_pageBreakInside([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(32)]
        HRESULT get_pageBreakInside([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(33)]
        HRESULT put_emptyCells([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(34)]
        HRESULT get_emptyCells([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(35)]
        HRESULT put_msBlockProgression([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(36)]
        HRESULT get_msBlockProgression([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(37)]
        HRESULT put_quotes([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(38)]
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

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_content;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_content;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_captionSide;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_captionSide;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_counterIncrement;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_counterIncrement;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_counterReset;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_counterReset;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_outline;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_outline;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_outlineWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_outlineWidth;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_outlineStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_outlineStyle;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_outlineColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_outlineColor;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_boxSizing;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_boxSizing;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderSpacing;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderSpacing;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_orphans;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_orphans;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_widows;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_widows;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_pageBreakInside;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_pageBreakInside;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_emptyCells;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_emptyCells;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msBlockProgression;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msBlockProgression;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_quotes;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_quotes;
    }
}
