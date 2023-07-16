// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISVGEllipseElement.xml' path='doc/member[@name="ISVGEllipseElement"]/*'/>
[Guid("30510515-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGEllipseElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGEllipseElement : ISVGEllipseElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGEllipseElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, Guid*, void**, int> )(lpVtbl[0]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, uint> )(lpVtbl[1]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, uint> )(lpVtbl[2]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, uint*, int> )(lpVtbl[3]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGEllipseElement.xml' path='doc/member[@name="ISVGEllipseElement.putref_cx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT putref_cx(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, ISVGAnimatedLength*, int> )(lpVtbl[7]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGEllipseElement.xml' path='doc/member[@name="ISVGEllipseElement.get_cx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_cx(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, ISVGAnimatedLength**, int> )(lpVtbl[8]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGEllipseElement.xml' path='doc/member[@name="ISVGEllipseElement.putref_cy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_cy(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, ISVGAnimatedLength*, int> )(lpVtbl[9]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGEllipseElement.xml' path='doc/member[@name="ISVGEllipseElement.get_cy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_cy(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, ISVGAnimatedLength**, int> )(lpVtbl[10]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGEllipseElement.xml' path='doc/member[@name="ISVGEllipseElement.putref_rx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_rx(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, ISVGAnimatedLength*, int> )(lpVtbl[11]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGEllipseElement.xml' path='doc/member[@name="ISVGEllipseElement.get_rx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_rx(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, ISVGAnimatedLength**, int> )(lpVtbl[12]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGEllipseElement.xml' path='doc/member[@name="ISVGEllipseElement.putref_ry"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_ry(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, ISVGAnimatedLength*, int> )(lpVtbl[13]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGEllipseElement.xml' path='doc/member[@name="ISVGEllipseElement.get_ry"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ry(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGEllipseElement*, ISVGAnimatedLength**, int> )(lpVtbl[14]))((ISVGEllipseElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_cx(ISVGAnimatedLength* v);
        [VtblIndex(8)]
        HRESULT get_cx(ISVGAnimatedLength** p);
        [VtblIndex(9)]
        HRESULT putref_cy(ISVGAnimatedLength* v);
        [VtblIndex(10)]
        HRESULT get_cy(ISVGAnimatedLength** p);
        [VtblIndex(11)]
        HRESULT putref_rx(ISVGAnimatedLength* v);
        [VtblIndex(12)]
        HRESULT get_rx(ISVGAnimatedLength** p);
        [VtblIndex(13)]
        HRESULT putref_ry(ISVGAnimatedLength* v);
        [VtblIndex(14)]
        HRESULT get_ry(ISVGAnimatedLength** p);
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
        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_cx;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_cx;
        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_cy;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_cy;
        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_rx;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_rx;
        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_ry;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_ry;
    }
}