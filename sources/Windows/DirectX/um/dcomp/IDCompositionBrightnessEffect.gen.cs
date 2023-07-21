// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDCompositionBrightnessEffect.xml' path='doc/member[@name="IDCompositionBrightnessEffect"]/*' />
[Guid("6027496E-CB3A-49AB-934F-D798DA4F7DA6")]
[NativeTypeName("struct IDCompositionBrightnessEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionBrightnessEffect : IDCompositionBrightnessEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionBrightnessEffect));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, uint>)(lpVtbl[1]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, uint>)(lpVtbl[2]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDCompositionFilterEffect.SetInput" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown* input, uint flags)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), index, input, flags);
    }

    /// <include file='IDCompositionBrightnessEffect.xml' path='doc/member[@name="IDCompositionBrightnessEffect.SetWhitePoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetWhitePoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* whitePoint)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[4]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePoint);
    }

    /// <include file='IDCompositionBrightnessEffect.xml' path='doc/member[@name="IDCompositionBrightnessEffect.SetBlackPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetBlackPoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* blackPoint)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[5]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPoint);
    }

    /// <include file='IDCompositionBrightnessEffect.xml' path='doc/member[@name="IDCompositionBrightnessEffect.SetWhitePointX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetWhitePointX(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionBrightnessEffect.xml' path='doc/member[@name="IDCompositionBrightnessEffect.SetWhitePointX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetWhitePointX(float whitePointX)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[7]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePointX);
    }

    /// <include file='IDCompositionBrightnessEffect.xml' path='doc/member[@name="IDCompositionBrightnessEffect.SetWhitePointY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetWhitePointY(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[8]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionBrightnessEffect.xml' path='doc/member[@name="IDCompositionBrightnessEffect.SetWhitePointY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetWhitePointY(float whitePointY)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[9]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePointY);
    }

    /// <include file='IDCompositionBrightnessEffect.xml' path='doc/member[@name="IDCompositionBrightnessEffect.SetBlackPointX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetBlackPointX(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[10]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionBrightnessEffect.xml' path='doc/member[@name="IDCompositionBrightnessEffect.SetBlackPointX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetBlackPointX(float blackPointX)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[11]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPointX);
    }

    /// <include file='IDCompositionBrightnessEffect.xml' path='doc/member[@name="IDCompositionBrightnessEffect.SetBlackPointY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetBlackPointY(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[12]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionBrightnessEffect.xml' path='doc/member[@name="IDCompositionBrightnessEffect.SetBlackPointY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetBlackPointY(float blackPointY)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[13]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPointY);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetWhitePoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* whitePoint);

        [VtblIndex(5)]
        HRESULT SetBlackPoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* blackPoint);

        [VtblIndex(6)]
        HRESULT SetWhitePointX(IDCompositionAnimation* animation);

        [VtblIndex(7)]
        HRESULT SetWhitePointX(float whitePointX);

        [VtblIndex(8)]
        HRESULT SetWhitePointY(IDCompositionAnimation* animation);

        [VtblIndex(9)]
        HRESULT SetWhitePointY(float whitePointY);

        [VtblIndex(10)]
        HRESULT SetBlackPointX(IDCompositionAnimation* animation);

        [VtblIndex(11)]
        HRESULT SetBlackPointX(float blackPointX);

        [VtblIndex(12)]
        HRESULT SetBlackPointY(IDCompositionAnimation* animation);

        [VtblIndex(13)]
        HRESULT SetBlackPointY(float blackPointY);
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

        [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown*, uint, int> SetInput;

        [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_VECTOR_2F*, int> SetWhitePoint;

        [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_VECTOR_2F*, int> SetBlackPoint;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetWhitePointX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetWhitePointX1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetWhitePointY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetWhitePointY1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetBlackPointX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBlackPointX1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetBlackPointY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBlackPointY1;
    }
}
