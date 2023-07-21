// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IUIAnimationInterpolator2.xml' path='doc/member[@name="IUIAnimationInterpolator2"]/*' />
[Guid("EA76AFF8-EA22-4A23-A0EF-A6A966703518")]
[NativeTypeName("struct IUIAnimationInterpolator2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationInterpolator2 : IUIAnimationInterpolator2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationInterpolator2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator2*, uint>)(lpVtbl[1]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator2*, uint>)(lpVtbl[2]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationInterpolator2.xml' path='doc/member[@name="IUIAnimationInterpolator2.GetDimension"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDimension(uint* dimension)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator2*, uint*, int>)(lpVtbl[3]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), dimension);
    }

    /// <include file='IUIAnimationInterpolator2.xml' path='doc/member[@name="IUIAnimationInterpolator2.SetInitialValueAndVelocity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetInitialValueAndVelocity(double* initialValue, double* initialVelocity, uint cDimension)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator2*, double*, double*, uint, int>)(lpVtbl[4]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), initialValue, initialVelocity, cDimension);
    }

    /// <include file='IUIAnimationInterpolator2.xml' path='doc/member[@name="IUIAnimationInterpolator2.SetDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDuration([NativeTypeName("UI_ANIMATION_SECONDS")] double duration)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator2*, double, int>)(lpVtbl[5]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), duration);
    }

    /// <include file='IUIAnimationInterpolator2.xml' path='doc/member[@name="IUIAnimationInterpolator2.GetDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator2*, double*, int>)(lpVtbl[6]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), duration);
    }

    /// <include file='IUIAnimationInterpolator2.xml' path='doc/member[@name="IUIAnimationInterpolator2.GetFinalValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFinalValue(double* value, uint cDimension)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator2*, double*, uint, int>)(lpVtbl[7]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), value, cDimension);
    }

    /// <include file='IUIAnimationInterpolator2.xml' path='doc/member[@name="IUIAnimationInterpolator2.InterpolateValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InterpolateValue([NativeTypeName("UI_ANIMATION_SECONDS")] double offset, double* value, uint cDimension)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator2*, double, double*, uint, int>)(lpVtbl[8]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), offset, value, cDimension);
    }

    /// <include file='IUIAnimationInterpolator2.xml' path='doc/member[@name="IUIAnimationInterpolator2.InterpolateVelocity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InterpolateVelocity([NativeTypeName("UI_ANIMATION_SECONDS")] double offset, double* velocity, uint cDimension)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator2*, double, double*, uint, int>)(lpVtbl[9]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), offset, velocity, cDimension);
    }

    /// <include file='IUIAnimationInterpolator2.xml' path='doc/member[@name="IUIAnimationInterpolator2.GetPrimitiveInterpolation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPrimitiveInterpolation(IUIAnimationPrimitiveInterpolation* interpolation, uint cDimension)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator2*, IUIAnimationPrimitiveInterpolation*, uint, int>)(lpVtbl[10]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), interpolation, cDimension);
    }

    /// <include file='IUIAnimationInterpolator2.xml' path='doc/member[@name="IUIAnimationInterpolator2.GetDependencies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDependencies(UI_ANIMATION_DEPENDENCIES* initialValueDependencies, UI_ANIMATION_DEPENDENCIES* initialVelocityDependencies, UI_ANIMATION_DEPENDENCIES* durationDependencies)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator2*, UI_ANIMATION_DEPENDENCIES*, UI_ANIMATION_DEPENDENCIES*, UI_ANIMATION_DEPENDENCIES*, int>)(lpVtbl[11]))((IUIAnimationInterpolator2*)Unsafe.AsPointer(ref this), initialValueDependencies, initialVelocityDependencies, durationDependencies);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDimension(uint* dimension);

        [VtblIndex(4)]
        HRESULT SetInitialValueAndVelocity(double* initialValue, double* initialVelocity, uint cDimension);

        [VtblIndex(5)]
        HRESULT SetDuration([NativeTypeName("UI_ANIMATION_SECONDS")] double duration);

        [VtblIndex(6)]
        HRESULT GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration);

        [VtblIndex(7)]
        HRESULT GetFinalValue(double* value, uint cDimension);

        [VtblIndex(8)]
        HRESULT InterpolateValue([NativeTypeName("UI_ANIMATION_SECONDS")] double offset, double* value, uint cDimension);

        [VtblIndex(9)]
        HRESULT InterpolateVelocity([NativeTypeName("UI_ANIMATION_SECONDS")] double offset, double* velocity, uint cDimension);

        [VtblIndex(10)]
        HRESULT GetPrimitiveInterpolation(IUIAnimationPrimitiveInterpolation* interpolation, uint cDimension);

        [VtblIndex(11)]
        HRESULT GetDependencies(UI_ANIMATION_DEPENDENCIES* initialValueDependencies, UI_ANIMATION_DEPENDENCIES* initialVelocityDependencies, UI_ANIMATION_DEPENDENCIES* durationDependencies);
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
        public delegate* unmanaged<TSelf*, uint*, int> GetDimension;

        [NativeTypeName("HRESULT (DOUBLE *, DOUBLE *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, double*, uint, int> SetInitialValueAndVelocity;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetDuration;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetDuration;

        [NativeTypeName("HRESULT (DOUBLE *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, uint, int> GetFinalValue;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double*, uint, int> InterpolateValue;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double*, uint, int> InterpolateVelocity;

        [NativeTypeName("HRESULT (IUIAnimationPrimitiveInterpolation *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationPrimitiveInterpolation*, uint, int> GetPrimitiveInterpolation;

        [NativeTypeName("HRESULT (UI_ANIMATION_DEPENDENCIES *, UI_ANIMATION_DEPENDENCIES *, UI_ANIMATION_DEPENDENCIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_DEPENDENCIES*, UI_ANIMATION_DEPENDENCIES*, UI_ANIMATION_DEPENDENCIES*, int> GetDependencies;
    }
}
