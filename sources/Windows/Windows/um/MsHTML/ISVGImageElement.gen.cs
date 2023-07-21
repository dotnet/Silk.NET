// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISVGImageElement.xml' path='doc/member[@name="ISVGImageElement"]/*' />
[Guid("305104F0-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGImageElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGImageElement : ISVGImageElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGImageElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGImageElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGImageElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGImageElement*, uint>)(lpVtbl[1]))((ISVGImageElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGImageElement*, uint>)(lpVtbl[2]))((ISVGImageElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGImageElement*, uint*, int>)(lpVtbl[3]))((ISVGImageElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGImageElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGImageElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGImageElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGImageElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGImageElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGImageElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGImageElement.xml' path='doc/member[@name="ISVGImageElement.putref_x"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT putref_x(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGImageElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGImageElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGImageElement.xml' path='doc/member[@name="ISVGImageElement.get_x"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_x(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGImageElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGImageElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGImageElement.xml' path='doc/member[@name="ISVGImageElement.putref_y"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_y(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGImageElement*, ISVGAnimatedLength*, int>)(lpVtbl[9]))((ISVGImageElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGImageElement.xml' path='doc/member[@name="ISVGImageElement.get_y"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_y(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGImageElement*, ISVGAnimatedLength**, int>)(lpVtbl[10]))((ISVGImageElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGImageElement.xml' path='doc/member[@name="ISVGImageElement.putref_width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_width(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGImageElement*, ISVGAnimatedLength*, int>)(lpVtbl[11]))((ISVGImageElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGImageElement.xml' path='doc/member[@name="ISVGImageElement.get_width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_width(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGImageElement*, ISVGAnimatedLength**, int>)(lpVtbl[12]))((ISVGImageElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGImageElement.xml' path='doc/member[@name="ISVGImageElement.putref_height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_height(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGImageElement*, ISVGAnimatedLength*, int>)(lpVtbl[13]))((ISVGImageElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGImageElement.xml' path='doc/member[@name="ISVGImageElement.get_height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_height(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGImageElement*, ISVGAnimatedLength**, int>)(lpVtbl[14]))((ISVGImageElement*)Unsafe.AsPointer(ref this), p);
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
    }
}
