// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle"]/*'/>
[Guid("3050F6AE-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLRenderStyle : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLRenderStyle : IHTMLRenderStyle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLRenderStyle));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, uint> )(lpVtbl[1]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, uint> )(lpVtbl[2]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, uint*, int> )(lpVtbl[3]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.put_textLineThroughStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_textLineThroughStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, ushort*, int> )(lpVtbl[7]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.get_textLineThroughStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_textLineThroughStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, ushort**, int> )(lpVtbl[8]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.put_textUnderlineStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_textUnderlineStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, ushort*, int> )(lpVtbl[9]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.get_textUnderlineStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_textUnderlineStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, ushort**, int> )(lpVtbl[10]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.put_textEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_textEffect([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, ushort*, int> )(lpVtbl[11]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.get_textEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_textEffect([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, ushort**, int> )(lpVtbl[12]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.put_textColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_textColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, VARIANT, int> )(lpVtbl[13]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.get_textColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_textColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, VARIANT*, int> )(lpVtbl[14]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.put_textBackgroundColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_textBackgroundColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, VARIANT, int> )(lpVtbl[15]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.get_textBackgroundColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_textBackgroundColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, VARIANT*, int> )(lpVtbl[16]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.put_textDecorationColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_textDecorationColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, VARIANT, int> )(lpVtbl[17]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.get_textDecorationColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_textDecorationColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, VARIANT*, int> )(lpVtbl[18]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.put_renderingPriority"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_renderingPriority([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, int, int> )(lpVtbl[19]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.get_renderingPriority"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_renderingPriority([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, int*, int> )(lpVtbl[20]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.put_defaultTextSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_defaultTextSelection([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, ushort*, int> )(lpVtbl[21]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.get_defaultTextSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_defaultTextSelection([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, ushort**, int> )(lpVtbl[22]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.put_textDecoration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_textDecoration([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, ushort*, int> )(lpVtbl[23]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRenderStyle.xml' path='doc/member[@name="IHTMLRenderStyle.get_textDecoration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_textDecoration([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLRenderStyle*, ushort**, int> )(lpVtbl[24]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_textLineThroughStyle([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_textLineThroughStyle([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_textUnderlineStyle([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_textUnderlineStyle([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_textEffect([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_textEffect([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT put_textColor(VARIANT v);
        [VtblIndex(14)]
        HRESULT get_textColor(VARIANT* p);
        [VtblIndex(15)]
        HRESULT put_textBackgroundColor(VARIANT v);
        [VtblIndex(16)]
        HRESULT get_textBackgroundColor(VARIANT* p);
        [VtblIndex(17)]
        HRESULT put_textDecorationColor(VARIANT v);
        [VtblIndex(18)]
        HRESULT get_textDecorationColor(VARIANT* p);
        [VtblIndex(19)]
        HRESULT put_renderingPriority([NativeTypeName("long")] int v);
        [VtblIndex(20)]
        HRESULT get_renderingPriority([NativeTypeName("long *")] int* p);
        [VtblIndex(21)]
        HRESULT put_defaultTextSelection([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(22)]
        HRESULT get_defaultTextSelection([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(23)]
        HRESULT put_textDecoration([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(24)]
        HRESULT get_textDecoration([NativeTypeName("BSTR *")] ushort** p);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_textLineThroughStyle;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textLineThroughStyle;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textUnderlineStyle;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textUnderlineStyle;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textEffect;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textEffect;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_textColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_textColor;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_textBackgroundColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_textBackgroundColor;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_textDecorationColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_textDecorationColor;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_renderingPriority;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_renderingPriority;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_defaultTextSelection;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_defaultTextSelection;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textDecoration;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textDecoration;
    }
}