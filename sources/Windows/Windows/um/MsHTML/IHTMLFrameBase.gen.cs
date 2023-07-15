// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase"]/*'/>
[Guid("3050F311-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLFrameBase : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLFrameBase : IHTMLFrameBase.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLFrameBase));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, uint> )(lpVtbl[1]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, uint> )(lpVtbl[2]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, uint*, int> )(lpVtbl[3]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.put_src"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_src([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, ushort*, int> )(lpVtbl[7]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.get_src"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_src([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, ushort**, int> )(lpVtbl[8]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.put_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, ushort*, int> )(lpVtbl[9]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.get_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, ushort**, int> )(lpVtbl[10]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.put_border"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_border(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, VARIANT, int> )(lpVtbl[11]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.get_border"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_border(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, VARIANT*, int> )(lpVtbl[12]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.put_frameBorder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_frameBorder([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, ushort*, int> )(lpVtbl[13]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.get_frameBorder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_frameBorder([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, ushort**, int> )(lpVtbl[14]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.put_frameSpacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_frameSpacing(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, VARIANT, int> )(lpVtbl[15]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.get_frameSpacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_frameSpacing(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, VARIANT*, int> )(lpVtbl[16]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.put_marginWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_marginWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, VARIANT, int> )(lpVtbl[17]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.get_marginWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_marginWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, VARIANT*, int> )(lpVtbl[18]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.put_marginHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_marginHeight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, VARIANT, int> )(lpVtbl[19]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.get_marginHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_marginHeight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, VARIANT*, int> )(lpVtbl[20]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.put_noResize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_noResize([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, short, int> )(lpVtbl[21]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.get_noResize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_noResize([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, short*, int> )(lpVtbl[22]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.put_scrolling"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_scrolling([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, ushort*, int> )(lpVtbl[23]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLFrameBase.xml' path='doc/member[@name="IHTMLFrameBase.get_scrolling"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_scrolling([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLFrameBase*, ushort**, int> )(lpVtbl[24]))((IHTMLFrameBase*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_src([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_src([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_border(VARIANT v);
        [VtblIndex(12)]
        HRESULT get_border(VARIANT* p);
        [VtblIndex(13)]
        HRESULT put_frameBorder([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_frameBorder([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT put_frameSpacing(VARIANT v);
        [VtblIndex(16)]
        HRESULT get_frameSpacing(VARIANT* p);
        [VtblIndex(17)]
        HRESULT put_marginWidth(VARIANT v);
        [VtblIndex(18)]
        HRESULT get_marginWidth(VARIANT* p);
        [VtblIndex(19)]
        HRESULT put_marginHeight(VARIANT v);
        [VtblIndex(20)]
        HRESULT get_marginHeight(VARIANT* p);
        [VtblIndex(21)]
        HRESULT put_noResize([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(22)]
        HRESULT get_noResize([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(23)]
        HRESULT put_scrolling([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(24)]
        HRESULT get_scrolling([NativeTypeName("BSTR *")] ushort** p);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_src;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_src;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_border;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_border;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_frameBorder;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_frameBorder;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_frameSpacing;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_frameSpacing;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_marginWidth;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_marginWidth;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_marginHeight;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_marginHeight;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_noResize;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_noResize;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_scrolling;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_scrolling;
    }
}