// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISVGLinearGradientElement.xml' path='doc/member[@name="ISVGLinearGradientElement"]/*'/>
[Guid("30510529-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGLinearGradientElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGLinearGradientElement : ISVGLinearGradientElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGLinearGradientElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, Guid*, void**, int> )(lpVtbl[0]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, uint> )(lpVtbl[1]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, uint> )(lpVtbl[2]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, uint*, int> )(lpVtbl[3]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGLinearGradientElement.xml' path='doc/member[@name="ISVGLinearGradientElement.putref_x1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT putref_x1(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength*, int> )(lpVtbl[7]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGLinearGradientElement.xml' path='doc/member[@name="ISVGLinearGradientElement.get_x1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_x1(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength**, int> )(lpVtbl[8]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGLinearGradientElement.xml' path='doc/member[@name="ISVGLinearGradientElement.putref_y1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_y1(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength*, int> )(lpVtbl[9]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGLinearGradientElement.xml' path='doc/member[@name="ISVGLinearGradientElement.get_y1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_y1(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength**, int> )(lpVtbl[10]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGLinearGradientElement.xml' path='doc/member[@name="ISVGLinearGradientElement.putref_x2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_x2(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength*, int> )(lpVtbl[11]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGLinearGradientElement.xml' path='doc/member[@name="ISVGLinearGradientElement.get_x2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_x2(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength**, int> )(lpVtbl[12]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGLinearGradientElement.xml' path='doc/member[@name="ISVGLinearGradientElement.putref_y2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_y2(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength*, int> )(lpVtbl[13]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGLinearGradientElement.xml' path='doc/member[@name="ISVGLinearGradientElement.get_y2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_y2(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength**, int> )(lpVtbl[14]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_x1(ISVGAnimatedLength* v);
        [VtblIndex(8)]
        HRESULT get_x1(ISVGAnimatedLength** p);
        [VtblIndex(9)]
        HRESULT putref_y1(ISVGAnimatedLength* v);
        [VtblIndex(10)]
        HRESULT get_y1(ISVGAnimatedLength** p);
        [VtblIndex(11)]
        HRESULT putref_x2(ISVGAnimatedLength* v);
        [VtblIndex(12)]
        HRESULT get_x2(ISVGAnimatedLength** p);
        [VtblIndex(13)]
        HRESULT putref_y2(ISVGAnimatedLength* v);
        [VtblIndex(14)]
        HRESULT get_y2(ISVGAnimatedLength** p);
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
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_x1;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_x1;
        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_y1;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_y1;
        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_x2;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_x2;
        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_y2;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_y2;
    }
}