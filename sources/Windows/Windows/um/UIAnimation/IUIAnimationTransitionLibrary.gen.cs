// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary"]/*'/>
[Guid("CA5A14B1-D24F-48B8-8FE4-C78169BA954E")]
[NativeTypeName("struct IUIAnimationTransitionLibrary : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationTransitionLibrary : IUIAnimationTransitionLibrary.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationTransitionLibrary));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, Guid*, void**, int> )(lpVtbl[0]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, uint> )(lpVtbl[1]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, uint> )(lpVtbl[2]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary.CreateInstantaneousTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstantaneousTransition(double finalValue, IUIAnimationTransition** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, double, IUIAnimationTransition**, int> )(lpVtbl[3]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), finalValue, transition);
    }

    /// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary.CreateConstantTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateConstantTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, IUIAnimationTransition** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, double, IUIAnimationTransition**, int> )(lpVtbl[4]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, transition);
    }

    /// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary.CreateDiscreteTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateDiscreteTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double delay, double finalValue, [NativeTypeName("UI_ANIMATION_SECONDS")] double hold, IUIAnimationTransition** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, double, double, double, IUIAnimationTransition**, int> )(lpVtbl[5]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), delay, finalValue, hold, transition);
    }

    /// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary.CreateLinearTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateLinearTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, IUIAnimationTransition** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, double, double, IUIAnimationTransition**, int> )(lpVtbl[6]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, finalValue, transition);
    }

    /// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary.CreateLinearTransitionFromSpeed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateLinearTransitionFromSpeed(double speed, double finalValue, IUIAnimationTransition** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, double, double, IUIAnimationTransition**, int> )(lpVtbl[7]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), speed, finalValue, transition);
    }

    /// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary.CreateSinusoidalTransitionFromVelocity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSinusoidalTransitionFromVelocity([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("UI_ANIMATION_SECONDS")] double period, IUIAnimationTransition** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, double, double, IUIAnimationTransition**, int> )(lpVtbl[8]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, period, transition);
    }

    /// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary.CreateSinusoidalTransitionFromRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateSinusoidalTransitionFromRange([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double minimumValue, double maximumValue, [NativeTypeName("UI_ANIMATION_SECONDS")] double period, UI_ANIMATION_SLOPE slope, IUIAnimationTransition** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, double, double, double, double, UI_ANIMATION_SLOPE, IUIAnimationTransition**, int> )(lpVtbl[9]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, minimumValue, maximumValue, period, slope, transition);
    }

    /// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary.CreateAccelerateDecelerateTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateAccelerateDecelerateTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, double accelerationRatio, double decelerationRatio, IUIAnimationTransition** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, double, double, double, double, IUIAnimationTransition**, int> )(lpVtbl[10]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, finalValue, accelerationRatio, decelerationRatio, transition);
    }

    /// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary.CreateReversalTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateReversalTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, IUIAnimationTransition** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, double, IUIAnimationTransition**, int> )(lpVtbl[11]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, transition);
    }

    /// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary.CreateCubicTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateCubicTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, double finalVelocity, IUIAnimationTransition** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, double, double, double, IUIAnimationTransition**, int> )(lpVtbl[12]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), duration, finalValue, finalVelocity, transition);
    }

    /// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary.CreateSmoothStopTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateSmoothStopTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double maximumDuration, double finalValue, IUIAnimationTransition** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, double, double, IUIAnimationTransition**, int> )(lpVtbl[13]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), maximumDuration, finalValue, transition);
    }

    /// <include file='IUIAnimationTransitionLibrary.xml' path='doc/member[@name="IUIAnimationTransitionLibrary.CreateParabolicTransitionFromAcceleration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateParabolicTransitionFromAcceleration(double finalValue, double finalVelocity, double acceleration, IUIAnimationTransition** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionLibrary*, double, double, double, IUIAnimationTransition**, int> )(lpVtbl[14]))((IUIAnimationTransitionLibrary*)Unsafe.AsPointer(ref this), finalValue, finalVelocity, acceleration, transition);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateInstantaneousTransition(double finalValue, IUIAnimationTransition** transition);
        [VtblIndex(4)]
        HRESULT CreateConstantTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, IUIAnimationTransition** transition);
        [VtblIndex(5)]
        HRESULT CreateDiscreteTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double delay, double finalValue, [NativeTypeName("UI_ANIMATION_SECONDS")] double hold, IUIAnimationTransition** transition);
        [VtblIndex(6)]
        HRESULT CreateLinearTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, IUIAnimationTransition** transition);
        [VtblIndex(7)]
        HRESULT CreateLinearTransitionFromSpeed(double speed, double finalValue, IUIAnimationTransition** transition);
        [VtblIndex(8)]
        HRESULT CreateSinusoidalTransitionFromVelocity([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, [NativeTypeName("UI_ANIMATION_SECONDS")] double period, IUIAnimationTransition** transition);
        [VtblIndex(9)]
        HRESULT CreateSinusoidalTransitionFromRange([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double minimumValue, double maximumValue, [NativeTypeName("UI_ANIMATION_SECONDS")] double period, UI_ANIMATION_SLOPE slope, IUIAnimationTransition** transition);
        [VtblIndex(10)]
        HRESULT CreateAccelerateDecelerateTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, double accelerationRatio, double decelerationRatio, IUIAnimationTransition** transition);
        [VtblIndex(11)]
        HRESULT CreateReversalTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, IUIAnimationTransition** transition);
        [VtblIndex(12)]
        HRESULT CreateCubicTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double duration, double finalValue, double finalVelocity, IUIAnimationTransition** transition);
        [VtblIndex(13)]
        HRESULT CreateSmoothStopTransition([NativeTypeName("UI_ANIMATION_SECONDS")] double maximumDuration, double finalValue, IUIAnimationTransition** transition);
        [VtblIndex(14)]
        HRESULT CreateParabolicTransitionFromAcceleration(double finalValue, double finalVelocity, double acceleration, IUIAnimationTransition** transition);
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
        [NativeTypeName("HRESULT (DOUBLE, IUIAnimationTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, IUIAnimationTransition**, int> CreateInstantaneousTransition;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, IUIAnimationTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, IUIAnimationTransition**, int> CreateConstantTransition;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, UI_ANIMATION_SECONDS, IUIAnimationTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, double, IUIAnimationTransition**, int> CreateDiscreteTransition;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, IUIAnimationTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, IUIAnimationTransition**, int> CreateLinearTransition;
        [NativeTypeName("HRESULT (DOUBLE, DOUBLE, IUIAnimationTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, IUIAnimationTransition**, int> CreateLinearTransitionFromSpeed;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, UI_ANIMATION_SECONDS, IUIAnimationTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, IUIAnimationTransition**, int> CreateSinusoidalTransitionFromVelocity;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, DOUBLE, UI_ANIMATION_SECONDS, UI_ANIMATION_SLOPE, IUIAnimationTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, double, double, UI_ANIMATION_SLOPE, IUIAnimationTransition**, int> CreateSinusoidalTransitionFromRange;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, DOUBLE, DOUBLE, IUIAnimationTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, double, double, IUIAnimationTransition**, int> CreateAccelerateDecelerateTransition;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, IUIAnimationTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, IUIAnimationTransition**, int> CreateReversalTransition;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, DOUBLE, IUIAnimationTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, double, IUIAnimationTransition**, int> CreateCubicTransition;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, DOUBLE, IUIAnimationTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, IUIAnimationTransition**, int> CreateSmoothStopTransition;
        [NativeTypeName("HRESULT (DOUBLE, DOUBLE, DOUBLE, IUIAnimationTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, double, IUIAnimationTransition**, int> CreateParabolicTransitionFromAcceleration;
    }
}