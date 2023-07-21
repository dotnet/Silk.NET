// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IUIAnimationTimer.xml' path='doc/member[@name="IUIAnimationTimer"]/*' />
[Guid("6B0EFAD1-A053-41D6-9085-33A689144665")]
[NativeTypeName("struct IUIAnimationTimer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationTimer : IUIAnimationTimer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationTimer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationTimer*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationTimer*, uint>)(lpVtbl[1]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationTimer*, uint>)(lpVtbl[2]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTimer.xml' path='doc/member[@name="IUIAnimationTimer.SetTimerUpdateHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetTimerUpdateHandler(IUIAnimationTimerUpdateHandler* updateHandler, UI_ANIMATION_IDLE_BEHAVIOR idleBehavior)
    {
        return ((delegate* unmanaged<IUIAnimationTimer*, IUIAnimationTimerUpdateHandler*, UI_ANIMATION_IDLE_BEHAVIOR, int>)(lpVtbl[3]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), updateHandler, idleBehavior);
    }

    /// <include file='IUIAnimationTimer.xml' path='doc/member[@name="IUIAnimationTimer.SetTimerEventHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTimerEventHandler(IUIAnimationTimerEventHandler* handler)
    {
        return ((delegate* unmanaged<IUIAnimationTimer*, IUIAnimationTimerEventHandler*, int>)(lpVtbl[4]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), handler);
    }

    /// <include file='IUIAnimationTimer.xml' path='doc/member[@name="IUIAnimationTimer.Enable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Enable()
    {
        return ((delegate* unmanaged<IUIAnimationTimer*, int>)(lpVtbl[5]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTimer.xml' path='doc/member[@name="IUIAnimationTimer.Disable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Disable()
    {
        return ((delegate* unmanaged<IUIAnimationTimer*, int>)(lpVtbl[6]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTimer.xml' path='doc/member[@name="IUIAnimationTimer.IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsEnabled()
    {
        return ((delegate* unmanaged<IUIAnimationTimer*, int>)(lpVtbl[7]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTimer.xml' path='doc/member[@name="IUIAnimationTimer.GetTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* seconds)
    {
        return ((delegate* unmanaged<IUIAnimationTimer*, double*, int>)(lpVtbl[8]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), seconds);
    }

    /// <include file='IUIAnimationTimer.xml' path='doc/member[@name="IUIAnimationTimer.SetFrameRateThreshold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetFrameRateThreshold([NativeTypeName("UINT32")] uint framesPerSecond)
    {
        return ((delegate* unmanaged<IUIAnimationTimer*, uint, int>)(lpVtbl[9]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), framesPerSecond);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetTimerUpdateHandler(IUIAnimationTimerUpdateHandler* updateHandler, UI_ANIMATION_IDLE_BEHAVIOR idleBehavior);

        [VtblIndex(4)]
        HRESULT SetTimerEventHandler(IUIAnimationTimerEventHandler* handler);

        [VtblIndex(5)]
        HRESULT Enable();

        [VtblIndex(6)]
        HRESULT Disable();

        [VtblIndex(7)]
        HRESULT IsEnabled();

        [VtblIndex(8)]
        HRESULT GetTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* seconds);

        [VtblIndex(9)]
        HRESULT SetFrameRateThreshold([NativeTypeName("UINT32")] uint framesPerSecond);
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

        [NativeTypeName("HRESULT (IUIAnimationTimerUpdateHandler *, UI_ANIMATION_IDLE_BEHAVIOR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationTimerUpdateHandler*, UI_ANIMATION_IDLE_BEHAVIOR, int> SetTimerUpdateHandler;

        [NativeTypeName("HRESULT (IUIAnimationTimerEventHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationTimerEventHandler*, int> SetTimerEventHandler;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Enable;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Disable;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsEnabled;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetTime;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetFrameRateThreshold;
    }
}
