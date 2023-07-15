// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISVGElement.xml' path='doc/member[@name="ISVGElement"]/*'/>
[Guid("305104C5-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGElement : ISVGElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGElement*, Guid*, void**, int> )(lpVtbl[0]))((ISVGElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGElement*, uint> )(lpVtbl[1]))((ISVGElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGElement*, uint> )(lpVtbl[2]))((ISVGElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGElement*, uint*, int> )(lpVtbl[3]))((ISVGElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISVGElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISVGElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISVGElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGElement.xml' path='doc/member[@name="ISVGElement.put_xmlbase"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_xmlbase([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ISVGElement*, ushort*, int> )(lpVtbl[7]))((ISVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGElement.xml' path='doc/member[@name="ISVGElement.get_xmlbase"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_xmlbase([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ISVGElement*, ushort**, int> )(lpVtbl[8]))((ISVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGElement.xml' path='doc/member[@name="ISVGElement.putref_ownerSVGElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_ownerSVGElement(ISVGSVGElement* v)
    {
        return ((delegate* unmanaged<ISVGElement*, ISVGSVGElement*, int> )(lpVtbl[9]))((ISVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGElement.xml' path='doc/member[@name="ISVGElement.get_ownerSVGElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ownerSVGElement(ISVGSVGElement** p)
    {
        return ((delegate* unmanaged<ISVGElement*, ISVGSVGElement**, int> )(lpVtbl[10]))((ISVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGElement.xml' path='doc/member[@name="ISVGElement.putref_viewportElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_viewportElement(ISVGElement* v)
    {
        return ((delegate* unmanaged<ISVGElement*, ISVGElement*, int> )(lpVtbl[11]))((ISVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGElement.xml' path='doc/member[@name="ISVGElement.get_viewportElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_viewportElement(ISVGElement** p)
    {
        return ((delegate* unmanaged<ISVGElement*, ISVGElement**, int> )(lpVtbl[12]))((ISVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGElement.xml' path='doc/member[@name="ISVGElement.putref_focusable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_focusable(ISVGAnimatedEnumeration* v)
    {
        return ((delegate* unmanaged<ISVGElement*, ISVGAnimatedEnumeration*, int> )(lpVtbl[13]))((ISVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGElement.xml' path='doc/member[@name="ISVGElement.get_focusable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_focusable(ISVGAnimatedEnumeration** p)
    {
        return ((delegate* unmanaged<ISVGElement*, ISVGAnimatedEnumeration**, int> )(lpVtbl[14]))((ISVGElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_xmlbase([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_xmlbase([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT putref_ownerSVGElement(ISVGSVGElement* v);
        [VtblIndex(10)]
        HRESULT get_ownerSVGElement(ISVGSVGElement** p);
        [VtblIndex(11)]
        HRESULT putref_viewportElement(ISVGElement* v);
        [VtblIndex(12)]
        HRESULT get_viewportElement(ISVGElement** p);
        [VtblIndex(13)]
        HRESULT putref_focusable(ISVGAnimatedEnumeration* v);
        [VtblIndex(14)]
        HRESULT get_focusable(ISVGAnimatedEnumeration** p);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_xmlbase;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_xmlbase;
        [NativeTypeName("HRESULT (ISVGSVGElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGSVGElement*, int> putref_ownerSVGElement;
        [NativeTypeName("HRESULT (ISVGSVGElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGSVGElement**, int> get_ownerSVGElement;
        [NativeTypeName("HRESULT (ISVGElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElement*, int> putref_viewportElement;
        [NativeTypeName("HRESULT (ISVGElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElement**, int> get_viewportElement;
        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration*, int> putref_focusable;
        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration**, int> get_focusable;
    }
}