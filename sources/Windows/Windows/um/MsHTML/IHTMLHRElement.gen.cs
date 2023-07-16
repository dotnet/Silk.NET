// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLHRElement.xml' path='doc/member[@name="IHTMLHRElement"]/*'/>
[Guid("3050F1F4-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLHRElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLHRElement : IHTMLHRElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLHRElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLHRElement*, uint> )(lpVtbl[1]))((IHTMLHRElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLHRElement*, uint> )(lpVtbl[2]))((IHTMLHRElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, uint*, int> )(lpVtbl[3]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLHRElement.xml' path='doc/member[@name="IHTMLHRElement.put_align"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, ushort*, int> )(lpVtbl[7]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLHRElement.xml' path='doc/member[@name="IHTMLHRElement.get_align"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, ushort**, int> )(lpVtbl[8]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLHRElement.xml' path='doc/member[@name="IHTMLHRElement.put_color"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_color(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, VARIANT, int> )(lpVtbl[9]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLHRElement.xml' path='doc/member[@name="IHTMLHRElement.get_color"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_color(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, VARIANT*, int> )(lpVtbl[10]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLHRElement.xml' path='doc/member[@name="IHTMLHRElement.put_noShade"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_noShade([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, short, int> )(lpVtbl[11]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLHRElement.xml' path='doc/member[@name="IHTMLHRElement.get_noShade"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_noShade([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, short*, int> )(lpVtbl[12]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLHRElement.xml' path='doc/member[@name="IHTMLHRElement.put_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_width(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, VARIANT, int> )(lpVtbl[13]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLHRElement.xml' path='doc/member[@name="IHTMLHRElement.get_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_width(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, VARIANT*, int> )(lpVtbl[14]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLHRElement.xml' path='doc/member[@name="IHTMLHRElement.put_size"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_size(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, VARIANT, int> )(lpVtbl[15]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLHRElement.xml' path='doc/member[@name="IHTMLHRElement.get_size"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_size(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLHRElement*, VARIANT*, int> )(lpVtbl[16]))((IHTMLHRElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_align([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_align([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_color(VARIANT v);
        [VtblIndex(10)]
        HRESULT get_color(VARIANT* p);
        [VtblIndex(11)]
        HRESULT put_noShade([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(12)]
        HRESULT get_noShade([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(13)]
        HRESULT put_width(VARIANT v);
        [VtblIndex(14)]
        HRESULT get_width(VARIANT* p);
        [VtblIndex(15)]
        HRESULT put_size(VARIANT v);
        [VtblIndex(16)]
        HRESULT get_size(VARIANT* p);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_align;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_align;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_color;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_color;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_noShade;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_noShade;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_width;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_width;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_size;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_size;
    }
}