// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IUIAnimationPrimitiveInterpolation.xml' path='doc/member[@name="IUIAnimationPrimitiveInterpolation"]/*' />
[Guid("BAB20D63-4361-45DA-A24F-AB8508846B5B")]
[NativeTypeName("struct IUIAnimationPrimitiveInterpolation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationPrimitiveInterpolation : IUIAnimationPrimitiveInterpolation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationPrimitiveInterpolation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationPrimitiveInterpolation*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationPrimitiveInterpolation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationPrimitiveInterpolation*, uint>)(lpVtbl[1]))((IUIAnimationPrimitiveInterpolation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationPrimitiveInterpolation*, uint>)(lpVtbl[2]))((IUIAnimationPrimitiveInterpolation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationPrimitiveInterpolation.xml' path='doc/member[@name="IUIAnimationPrimitiveInterpolation.AddCubic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddCubic(uint dimension, [NativeTypeName("UI_ANIMATION_SECONDS")] double beginOffset, float constantCoefficient, float linearCoefficient, float quadraticCoefficient, float cubicCoefficient)
    {
        return ((delegate* unmanaged<IUIAnimationPrimitiveInterpolation*, uint, double, float, float, float, float, int>)(lpVtbl[3]))((IUIAnimationPrimitiveInterpolation*)Unsafe.AsPointer(ref this), dimension, beginOffset, constantCoefficient, linearCoefficient, quadraticCoefficient, cubicCoefficient);
    }

    /// <include file='IUIAnimationPrimitiveInterpolation.xml' path='doc/member[@name="IUIAnimationPrimitiveInterpolation.AddSinusoidal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddSinusoidal(uint dimension, [NativeTypeName("UI_ANIMATION_SECONDS")] double beginOffset, float bias, float amplitude, float frequency, float phase)
    {
        return ((delegate* unmanaged<IUIAnimationPrimitiveInterpolation*, uint, double, float, float, float, float, int>)(lpVtbl[4]))((IUIAnimationPrimitiveInterpolation*)Unsafe.AsPointer(ref this), dimension, beginOffset, bias, amplitude, frequency, phase);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddCubic(uint dimension, [NativeTypeName("UI_ANIMATION_SECONDS")] double beginOffset, float constantCoefficient, float linearCoefficient, float quadraticCoefficient, float cubicCoefficient);

        [VtblIndex(4)]
        HRESULT AddSinusoidal(uint dimension, [NativeTypeName("UI_ANIMATION_SECONDS")] double beginOffset, float bias, float amplitude, float frequency, float phase);
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

        [NativeTypeName("HRESULT (UINT, UI_ANIMATION_SECONDS, FLOAT, FLOAT, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, double, float, float, float, float, int> AddCubic;

        [NativeTypeName("HRESULT (UINT, UI_ANIMATION_SECONDS, FLOAT, FLOAT, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, double, float, float, float, float, int> AddSinusoidal;
    }
}
