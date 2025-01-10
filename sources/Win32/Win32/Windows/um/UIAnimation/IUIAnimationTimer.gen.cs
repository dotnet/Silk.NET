// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6B0EFAD1-A053-41D6-9085-33A689144665")]
[NativeTypeName("struct IUIAnimationTimer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationTimer : IUIAnimationTimer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationTimer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationTimer, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationTimer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationTimer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetTimerUpdateHandler(
        IUIAnimationTimerUpdateHandler updateHandler,
        UI_ANIMATION_IDLE_BEHAVIOR idleBehavior
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationTimer,
                IUIAnimationTimerUpdateHandler,
                UI_ANIMATION_IDLE_BEHAVIOR,
                int>)((*lpVtbl)[3])
        )(this, updateHandler, idleBehavior);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTimerEventHandler(IUIAnimationTimerEventHandler handler)
    {
        return (
            (delegate* unmanaged<IUIAnimationTimer, IUIAnimationTimerEventHandler, int>)(
                (*lpVtbl)[4]
            )
        )(this, handler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Enable()
    {
        return ((delegate* unmanaged<IUIAnimationTimer, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Disable()
    {
        return ((delegate* unmanaged<IUIAnimationTimer, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsEnabled()
    {
        return ((delegate* unmanaged<IUIAnimationTimer, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* seconds)
    {
        return ((delegate* unmanaged<IUIAnimationTimer, double*, int>)((*lpVtbl)[8]))(
            this,
            seconds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetFrameRateThreshold([NativeTypeName("UINT32")] uint framesPerSecond)
    {
        return ((delegate* unmanaged<IUIAnimationTimer, uint, int>)((*lpVtbl)[9]))(
            this,
            framesPerSecond
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetTimerUpdateHandler(
            IUIAnimationTimerUpdateHandler updateHandler,
            UI_ANIMATION_IDLE_BEHAVIOR idleBehavior
        );

        [VtblIndex(4)]
        HRESULT SetTimerEventHandler(IUIAnimationTimerEventHandler handler);

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

        [NativeTypeName(
            "HRESULT (IUIAnimationTimerUpdateHandler *, UI_ANIMATION_IDLE_BEHAVIOR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationTimerUpdateHandler,
            UI_ANIMATION_IDLE_BEHAVIOR,
            int> SetTimerUpdateHandler;

        [NativeTypeName("HRESULT (IUIAnimationTimerEventHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationTimerEventHandler, int> SetTimerEventHandler;

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

    /// <summary>Initializes a new instance of the <see cref = "IUIAnimationTimer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUIAnimationTimer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUIAnimationTimer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUIAnimationTimer(Silk.NET.Windows.IUnknown value)
    {
        return new IUIAnimationTimer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUIAnimationTimer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUIAnimationTimer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUIAnimationTimer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
