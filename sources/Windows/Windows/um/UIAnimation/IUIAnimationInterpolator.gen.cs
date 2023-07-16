// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IUIAnimationInterpolator.xml' path='doc/member[@name="IUIAnimationInterpolator"]/*'/>
[Guid("7815CBBA-DDF7-478C-A46C-7B6C738B7978")]
[NativeTypeName("struct IUIAnimationInterpolator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationInterpolator : IUIAnimationInterpolator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationInterpolator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator*, Guid*, void**, int> )(lpVtbl[0]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator*, uint> )(lpVtbl[1]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator*, uint> )(lpVtbl[2]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationInterpolator.xml' path='doc/member[@name="IUIAnimationInterpolator.SetInitialValueAndVelocity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInitialValueAndVelocity(double initialValue, double initialVelocity)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator*, double, double, int> )(lpVtbl[3]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), initialValue, initialVelocity);
    }

    /// <include file='IUIAnimationInterpolator.xml' path='doc/member[@name="IUIAnimationInterpolator.SetDuration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetDuration([NativeTypeName("UI_ANIMATION_SECONDS")] double duration)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator*, double, int> )(lpVtbl[4]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), duration);
    }

    /// <include file='IUIAnimationInterpolator.xml' path='doc/member[@name="IUIAnimationInterpolator.GetDuration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator*, double*, int> )(lpVtbl[5]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), duration);
    }

    /// <include file='IUIAnimationInterpolator.xml' path='doc/member[@name="IUIAnimationInterpolator.GetFinalValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFinalValue(double* value)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator*, double*, int> )(lpVtbl[6]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUIAnimationInterpolator.xml' path='doc/member[@name="IUIAnimationInterpolator.InterpolateValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InterpolateValue([NativeTypeName("UI_ANIMATION_SECONDS")] double offset, double* value)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator*, double, double*, int> )(lpVtbl[7]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), offset, value);
    }

    /// <include file='IUIAnimationInterpolator.xml' path='doc/member[@name="IUIAnimationInterpolator.InterpolateVelocity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InterpolateVelocity([NativeTypeName("UI_ANIMATION_SECONDS")] double offset, double* velocity)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator*, double, double*, int> )(lpVtbl[8]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), offset, velocity);
    }

    /// <include file='IUIAnimationInterpolator.xml' path='doc/member[@name="IUIAnimationInterpolator.GetDependencies"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDependencies(UI_ANIMATION_DEPENDENCIES* initialValueDependencies, UI_ANIMATION_DEPENDENCIES* initialVelocityDependencies, UI_ANIMATION_DEPENDENCIES* durationDependencies)
    {
        return ((delegate* unmanaged<IUIAnimationInterpolator*, UI_ANIMATION_DEPENDENCIES*, UI_ANIMATION_DEPENDENCIES*, UI_ANIMATION_DEPENDENCIES*, int> )(lpVtbl[9]))((IUIAnimationInterpolator*)Unsafe.AsPointer(ref this), initialValueDependencies, initialVelocityDependencies, durationDependencies);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetInitialValueAndVelocity(double initialValue, double initialVelocity);
        [VtblIndex(4)]
        HRESULT SetDuration([NativeTypeName("UI_ANIMATION_SECONDS")] double duration);
        [VtblIndex(5)]
        HRESULT GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration);
        [VtblIndex(6)]
        HRESULT GetFinalValue(double* value);
        [VtblIndex(7)]
        HRESULT InterpolateValue([NativeTypeName("UI_ANIMATION_SECONDS")] double offset, double* value);
        [VtblIndex(8)]
        HRESULT InterpolateVelocity([NativeTypeName("UI_ANIMATION_SECONDS")] double offset, double* velocity);
        [VtblIndex(9)]
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
        [NativeTypeName("HRESULT (DOUBLE, DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, int> SetInitialValueAndVelocity;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetDuration;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetDuration;
        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetFinalValue;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double*, int> InterpolateValue;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double*, int> InterpolateVelocity;
        [NativeTypeName("HRESULT (UI_ANIMATION_DEPENDENCIES *, UI_ANIMATION_DEPENDENCIES *, UI_ANIMATION_DEPENDENCIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_DEPENDENCIES*, UI_ANIMATION_DEPENDENCIES*, UI_ANIMATION_DEPENDENCIES*, int> GetDependencies;
    }
}