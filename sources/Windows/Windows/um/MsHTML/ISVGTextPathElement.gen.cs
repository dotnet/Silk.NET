// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISVGTextPathElement.xml' path='doc/member[@name="ISVGTextPathElement"]/*'/>
[Guid("3051051F-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGTextPathElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGTextPathElement : ISVGTextPathElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGTextPathElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, Guid*, void**, int> )(lpVtbl[0]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, uint> )(lpVtbl[1]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, uint> )(lpVtbl[2]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, uint*, int> )(lpVtbl[3]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGTextPathElement.xml' path='doc/member[@name="ISVGTextPathElement.putref_startOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT putref_startOffset(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, ISVGAnimatedLength*, int> )(lpVtbl[7]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGTextPathElement.xml' path='doc/member[@name="ISVGTextPathElement.get_startOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_startOffset(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, ISVGAnimatedLength**, int> )(lpVtbl[8]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGTextPathElement.xml' path='doc/member[@name="ISVGTextPathElement.putref_method"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_method(ISVGAnimatedEnumeration* v)
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, ISVGAnimatedEnumeration*, int> )(lpVtbl[9]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGTextPathElement.xml' path='doc/member[@name="ISVGTextPathElement.get_method"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_method(ISVGAnimatedEnumeration** p)
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, ISVGAnimatedEnumeration**, int> )(lpVtbl[10]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGTextPathElement.xml' path='doc/member[@name="ISVGTextPathElement.putref_spacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_spacing(ISVGAnimatedEnumeration* v)
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, ISVGAnimatedEnumeration*, int> )(lpVtbl[11]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGTextPathElement.xml' path='doc/member[@name="ISVGTextPathElement.get_spacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_spacing(ISVGAnimatedEnumeration** p)
    {
        return ((delegate* unmanaged<ISVGTextPathElement*, ISVGAnimatedEnumeration**, int> )(lpVtbl[12]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_startOffset(ISVGAnimatedLength* v);
        [VtblIndex(8)]
        HRESULT get_startOffset(ISVGAnimatedLength** p);
        [VtblIndex(9)]
        HRESULT putref_method(ISVGAnimatedEnumeration* v);
        [VtblIndex(10)]
        HRESULT get_method(ISVGAnimatedEnumeration** p);
        [VtblIndex(11)]
        HRESULT putref_spacing(ISVGAnimatedEnumeration* v);
        [VtblIndex(12)]
        HRESULT get_spacing(ISVGAnimatedEnumeration** p);
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
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_startOffset;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_startOffset;
        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration*, int> putref_method;
        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration**, int> get_method;
        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration*, int> putref_spacing;
        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration**, int> get_spacing;
    }
}