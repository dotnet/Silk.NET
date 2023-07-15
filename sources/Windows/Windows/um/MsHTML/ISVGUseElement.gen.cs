// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement"]/*'/>
[Guid("305104ED-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGUseElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGUseElement : ISVGUseElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGUseElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGUseElement*, Guid*, void**, int> )(lpVtbl[0]))((ISVGUseElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGUseElement*, uint> )(lpVtbl[1]))((ISVGUseElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGUseElement*, uint> )(lpVtbl[2]))((ISVGUseElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGUseElement*, uint*, int> )(lpVtbl[3]))((ISVGUseElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGUseElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISVGUseElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGUseElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISVGUseElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGUseElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISVGUseElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement.putref_x"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT putref_x(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength*, int> )(lpVtbl[7]))((ISVGUseElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement.get_x"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_x(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength**, int> )(lpVtbl[8]))((ISVGUseElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement.putref_y"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_y(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength*, int> )(lpVtbl[9]))((ISVGUseElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement.get_y"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_y(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength**, int> )(lpVtbl[10]))((ISVGUseElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement.putref_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_width(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength*, int> )(lpVtbl[11]))((ISVGUseElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement.get_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_width(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength**, int> )(lpVtbl[12]))((ISVGUseElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement.putref_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_height(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength*, int> )(lpVtbl[13]))((ISVGUseElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement.get_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_height(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength**, int> )(lpVtbl[14]))((ISVGUseElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement.putref_instanceRoot"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT putref_instanceRoot(ISVGElementInstance* v)
    {
        return ((delegate* unmanaged<ISVGUseElement*, ISVGElementInstance*, int> )(lpVtbl[15]))((ISVGUseElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement.get_instanceRoot"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_instanceRoot(ISVGElementInstance** p)
    {
        return ((delegate* unmanaged<ISVGUseElement*, ISVGElementInstance**, int> )(lpVtbl[16]))((ISVGUseElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement.putref_animatedInstanceRoot"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT putref_animatedInstanceRoot(ISVGElementInstance* v)
    {
        return ((delegate* unmanaged<ISVGUseElement*, ISVGElementInstance*, int> )(lpVtbl[17]))((ISVGUseElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGUseElement.xml' path='doc/member[@name="ISVGUseElement.get_animatedInstanceRoot"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_animatedInstanceRoot(ISVGElementInstance** p)
    {
        return ((delegate* unmanaged<ISVGUseElement*, ISVGElementInstance**, int> )(lpVtbl[18]))((ISVGUseElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_x(ISVGAnimatedLength* v);
        [VtblIndex(8)]
        HRESULT get_x(ISVGAnimatedLength** p);
        [VtblIndex(9)]
        HRESULT putref_y(ISVGAnimatedLength* v);
        [VtblIndex(10)]
        HRESULT get_y(ISVGAnimatedLength** p);
        [VtblIndex(11)]
        HRESULT putref_width(ISVGAnimatedLength* v);
        [VtblIndex(12)]
        HRESULT get_width(ISVGAnimatedLength** p);
        [VtblIndex(13)]
        HRESULT putref_height(ISVGAnimatedLength* v);
        [VtblIndex(14)]
        HRESULT get_height(ISVGAnimatedLength** p);
        [VtblIndex(15)]
        HRESULT putref_instanceRoot(ISVGElementInstance* v);
        [VtblIndex(16)]
        HRESULT get_instanceRoot(ISVGElementInstance** p);
        [VtblIndex(17)]
        HRESULT putref_animatedInstanceRoot(ISVGElementInstance* v);
        [VtblIndex(18)]
        HRESULT get_animatedInstanceRoot(ISVGElementInstance** p);
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
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_x;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_x;
        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_y;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_y;
        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_width;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_width;
        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_height;
        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_height;
        [NativeTypeName("HRESULT (ISVGElementInstance *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElementInstance*, int> putref_instanceRoot;
        [NativeTypeName("HRESULT (ISVGElementInstance **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElementInstance**, int> get_instanceRoot;
        [NativeTypeName("HRESULT (ISVGElementInstance *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElementInstance*, int> putref_animatedInstanceRoot;
        [NativeTypeName("HRESULT (ISVGElementInstance **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElementInstance**, int> get_animatedInstanceRoot;
    }
}