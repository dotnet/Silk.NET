// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLBaseFontElement.xml' path='doc/member[@name="IHTMLBaseFontElement"]/*'/>
[Guid("3050F202-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLBaseFontElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLBaseFontElement : IHTMLBaseFontElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLBaseFontElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, uint> )(lpVtbl[1]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, uint> )(lpVtbl[2]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, uint*, int> )(lpVtbl[3]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLBaseFontElement.xml' path='doc/member[@name="IHTMLBaseFontElement.put_color"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_color(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, VARIANT, int> )(lpVtbl[7]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBaseFontElement.xml' path='doc/member[@name="IHTMLBaseFontElement.get_color"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_color(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, VARIANT*, int> )(lpVtbl[8]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBaseFontElement.xml' path='doc/member[@name="IHTMLBaseFontElement.put_face"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_face([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, ushort*, int> )(lpVtbl[9]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBaseFontElement.xml' path='doc/member[@name="IHTMLBaseFontElement.get_face"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_face([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, ushort**, int> )(lpVtbl[10]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBaseFontElement.xml' path='doc/member[@name="IHTMLBaseFontElement.put_size"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_size([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, int, int> )(lpVtbl[11]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBaseFontElement.xml' path='doc/member[@name="IHTMLBaseFontElement.get_size"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_size([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLBaseFontElement*, int*, int> )(lpVtbl[12]))((IHTMLBaseFontElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_color(VARIANT v);
        [VtblIndex(8)]
        HRESULT get_color(VARIANT* p);
        [VtblIndex(9)]
        HRESULT put_face([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_face([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_size([NativeTypeName("long")] int v);
        [VtblIndex(12)]
        HRESULT get_size([NativeTypeName("long *")] int* p);
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
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_color;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_color;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_face;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_face;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_size;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_size;
    }
}