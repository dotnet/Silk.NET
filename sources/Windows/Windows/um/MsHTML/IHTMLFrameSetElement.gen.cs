// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement"]/*' />
[Guid("3050F319-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLFrameSetElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLFrameSetElement : IHTMLFrameSetElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLFrameSetElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, uint>)(lpVtbl[1]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, uint>)(lpVtbl[2]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, uint*, int>)(lpVtbl[3]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.put_rows"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_rows([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort*, int>)(lpVtbl[7]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.get_rows"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_rows([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort**, int>)(lpVtbl[8]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.put_cols"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_cols([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort*, int>)(lpVtbl[9]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.get_cols"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_cols([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort**, int>)(lpVtbl[10]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.put_border"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_border(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT, int>)(lpVtbl[11]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.get_border"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_border(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT*, int>)(lpVtbl[12]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.put_borderColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_borderColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT, int>)(lpVtbl[13]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.get_borderColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_borderColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT*, int>)(lpVtbl[14]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.put_frameBorder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_frameBorder([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort*, int>)(lpVtbl[15]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.get_frameBorder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_frameBorder([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort**, int>)(lpVtbl[16]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.put_frameSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_frameSpacing(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT, int>)(lpVtbl[17]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.get_frameSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_frameSpacing(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT*, int>)(lpVtbl[18]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.put_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort*, int>)(lpVtbl[19]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.get_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort**, int>)(lpVtbl[20]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.put_onload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_onload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT, int>)(lpVtbl[21]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.get_onload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_onload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT*, int>)(lpVtbl[22]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.put_onunload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_onunload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT, int>)(lpVtbl[23]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.get_onunload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_onunload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT*, int>)(lpVtbl[24]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.put_onbeforeunload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_onbeforeunload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT, int>)(lpVtbl[25]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameSetElement.xml' path='doc/member[@name="IHTMLFrameSetElement.get_onbeforeunload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_onbeforeunload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT*, int>)(lpVtbl[26]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_rows([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_rows([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT put_cols([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(10)]
        HRESULT get_cols([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT put_border(VARIANT v);

        [VtblIndex(12)]
        HRESULT get_border(VARIANT* p);

        [VtblIndex(13)]
        HRESULT put_borderColor(VARIANT v);

        [VtblIndex(14)]
        HRESULT get_borderColor(VARIANT* p);

        [VtblIndex(15)]
        HRESULT put_frameBorder([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(16)]
        HRESULT get_frameBorder([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(17)]
        HRESULT put_frameSpacing(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_frameSpacing(VARIANT* p);

        [VtblIndex(19)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(20)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT put_onload(VARIANT v);

        [VtblIndex(22)]
        HRESULT get_onload(VARIANT* p);

        [VtblIndex(23)]
        HRESULT put_onunload(VARIANT v);

        [VtblIndex(24)]
        HRESULT get_onunload(VARIANT* p);

        [VtblIndex(25)]
        HRESULT put_onbeforeunload(VARIANT v);

        [VtblIndex(26)]
        HRESULT get_onbeforeunload(VARIANT* p);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_rows;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rows;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_cols;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_cols;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_border;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_border;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColor;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_frameBorder;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_frameBorder;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_frameSpacing;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_frameSpacing;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onload;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onload;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onunload;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onunload;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforeunload;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforeunload;
    }
}
