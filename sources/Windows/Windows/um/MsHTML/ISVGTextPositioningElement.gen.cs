// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISVGTextPositioningElement.xml' path='doc/member[@name="ISVGTextPositioningElement"]/*'/>
[Guid("3051051B-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGTextPositioningElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGTextPositioningElement : ISVGTextPositioningElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGTextPositioningElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, Guid*, void**, int> )(lpVtbl[0]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, uint> )(lpVtbl[1]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, uint> )(lpVtbl[2]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, uint*, int> )(lpVtbl[3]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGTextPositioningElement.xml' path='doc/member[@name="ISVGTextPositioningElement.putref_x"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT putref_x(ISVGAnimatedLengthList* v)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList*, int> )(lpVtbl[7]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGTextPositioningElement.xml' path='doc/member[@name="ISVGTextPositioningElement.get_x"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_x(ISVGAnimatedLengthList** p)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList**, int> )(lpVtbl[8]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGTextPositioningElement.xml' path='doc/member[@name="ISVGTextPositioningElement.putref_y"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_y(ISVGAnimatedLengthList* v)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList*, int> )(lpVtbl[9]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGTextPositioningElement.xml' path='doc/member[@name="ISVGTextPositioningElement.get_y"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_y(ISVGAnimatedLengthList** p)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList**, int> )(lpVtbl[10]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGTextPositioningElement.xml' path='doc/member[@name="ISVGTextPositioningElement.putref_dx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_dx(ISVGAnimatedLengthList* v)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList*, int> )(lpVtbl[11]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGTextPositioningElement.xml' path='doc/member[@name="ISVGTextPositioningElement.get_dx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_dx(ISVGAnimatedLengthList** p)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList**, int> )(lpVtbl[12]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGTextPositioningElement.xml' path='doc/member[@name="ISVGTextPositioningElement.putref_dy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_dy(ISVGAnimatedLengthList* v)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList*, int> )(lpVtbl[13]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGTextPositioningElement.xml' path='doc/member[@name="ISVGTextPositioningElement.get_dy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_dy(ISVGAnimatedLengthList** p)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList**, int> )(lpVtbl[14]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGTextPositioningElement.xml' path='doc/member[@name="ISVGTextPositioningElement.putref_rotate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT putref_rotate(ISVGAnimatedNumberList* v)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedNumberList*, int> )(lpVtbl[15]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGTextPositioningElement.xml' path='doc/member[@name="ISVGTextPositioningElement.get_rotate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_rotate(ISVGAnimatedNumberList** p)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedNumberList**, int> )(lpVtbl[16]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_x(ISVGAnimatedLengthList* v);
        [VtblIndex(8)]
        HRESULT get_x(ISVGAnimatedLengthList** p);
        [VtblIndex(9)]
        HRESULT putref_y(ISVGAnimatedLengthList* v);
        [VtblIndex(10)]
        HRESULT get_y(ISVGAnimatedLengthList** p);
        [VtblIndex(11)]
        HRESULT putref_dx(ISVGAnimatedLengthList* v);
        [VtblIndex(12)]
        HRESULT get_dx(ISVGAnimatedLengthList** p);
        [VtblIndex(13)]
        HRESULT putref_dy(ISVGAnimatedLengthList* v);
        [VtblIndex(14)]
        HRESULT get_dy(ISVGAnimatedLengthList** p);
        [VtblIndex(15)]
        HRESULT putref_rotate(ISVGAnimatedNumberList* v);
        [VtblIndex(16)]
        HRESULT get_rotate(ISVGAnimatedNumberList** p);
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
        [NativeTypeName("HRESULT (ISVGAnimatedLengthList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList*, int> putref_x;
        [NativeTypeName("HRESULT (ISVGAnimatedLengthList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList**, int> get_x;
        [NativeTypeName("HRESULT (ISVGAnimatedLengthList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList*, int> putref_y;
        [NativeTypeName("HRESULT (ISVGAnimatedLengthList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList**, int> get_y;
        [NativeTypeName("HRESULT (ISVGAnimatedLengthList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList*, int> putref_dx;
        [NativeTypeName("HRESULT (ISVGAnimatedLengthList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList**, int> get_dx;
        [NativeTypeName("HRESULT (ISVGAnimatedLengthList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList*, int> putref_dy;
        [NativeTypeName("HRESULT (ISVGAnimatedLengthList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList**, int> get_dy;
        [NativeTypeName("HRESULT (ISVGAnimatedNumberList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedNumberList*, int> putref_rotate;
        [NativeTypeName("HRESULT (ISVGAnimatedNumberList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedNumberList**, int> get_rotate;
    }
}