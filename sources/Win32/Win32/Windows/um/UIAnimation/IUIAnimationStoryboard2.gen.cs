// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AE289CD2-12D4-4945-9419-9E41BE034DF2")]
[NativeTypeName("struct IUIAnimationStoryboard2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationStoryboard2
    : IUIAnimationStoryboard2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationStoryboard2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUIAnimationStoryboard2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddTransition(IUIAnimationVariable2 variable, IUIAnimationTransition2 transition)
    {
        return (
            (delegate* unmanaged<
                IUIAnimationStoryboard2,
                IUIAnimationVariable2,
                IUIAnimationTransition2,
                int>)((*lpVtbl)[3])
        )(this, variable, transition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddKeyframeAtOffset(
        UI_ANIMATION_KEYFRAME existingKeyframe,
        [NativeTypeName("UI_ANIMATION_SECONDS")] double offset,
        UI_ANIMATION_KEYFRAME* keyframe
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationStoryboard2,
                UI_ANIMATION_KEYFRAME,
                double,
                UI_ANIMATION_KEYFRAME*,
                int>)((*lpVtbl)[4])
        )(this, existingKeyframe, offset, keyframe);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddKeyframeAfterTransition(
        IUIAnimationTransition2 transition,
        UI_ANIMATION_KEYFRAME* keyframe
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationStoryboard2,
                IUIAnimationTransition2,
                UI_ANIMATION_KEYFRAME*,
                int>)((*lpVtbl)[5])
        )(this, transition, keyframe);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddTransitionAtKeyframe(
        IUIAnimationVariable2 variable,
        IUIAnimationTransition2 transition,
        UI_ANIMATION_KEYFRAME startKeyframe
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationStoryboard2,
                IUIAnimationVariable2,
                IUIAnimationTransition2,
                UI_ANIMATION_KEYFRAME,
                int>)((*lpVtbl)[6])
        )(this, variable, transition, startKeyframe);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddTransitionBetweenKeyframes(
        IUIAnimationVariable2 variable,
        IUIAnimationTransition2 transition,
        UI_ANIMATION_KEYFRAME startKeyframe,
        UI_ANIMATION_KEYFRAME endKeyframe
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationStoryboard2,
                IUIAnimationVariable2,
                IUIAnimationTransition2,
                UI_ANIMATION_KEYFRAME,
                UI_ANIMATION_KEYFRAME,
                int>)((*lpVtbl)[7])
        )(this, variable, transition, startKeyframe, endKeyframe);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RepeatBetweenKeyframes(
        UI_ANIMATION_KEYFRAME startKeyframe,
        UI_ANIMATION_KEYFRAME endKeyframe,
        double cRepetition,
        UI_ANIMATION_REPEAT_MODE repeatMode,
        [Optional] IUIAnimationLoopIterationChangeHandler2 pIterationChangeHandler,
        [NativeTypeName("UINT_PTR")] [Optional] nuint id,
        [Optional] BOOL fRegisterForNextAnimationEvent
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationStoryboard2,
                UI_ANIMATION_KEYFRAME,
                UI_ANIMATION_KEYFRAME,
                double,
                UI_ANIMATION_REPEAT_MODE,
                IUIAnimationLoopIterationChangeHandler2,
                nuint,
                BOOL,
                int>)((*lpVtbl)[8])
        )(
            this,
            startKeyframe,
            endKeyframe,
            cRepetition,
            repeatMode,
            pIterationChangeHandler,
            id,
            fRegisterForNextAnimationEvent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT HoldVariable(IUIAnimationVariable2 variable)
    {
        return (
            (delegate* unmanaged<IUIAnimationStoryboard2, IUIAnimationVariable2, int>)((*lpVtbl)[9])
        )(this, variable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLongestAcceptableDelay([NativeTypeName("UI_ANIMATION_SECONDS")] double delay)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard2, double, int>)((*lpVtbl)[10]))(
            this,
            delay
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetSkipDuration([NativeTypeName("UI_ANIMATION_SECONDS")] double secondsDuration)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard2, double, int>)((*lpVtbl)[11]))(
            this,
            secondsDuration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Schedule(
        [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow,
        UI_ANIMATION_SCHEDULING_RESULT* schedulingResult = null
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationStoryboard2,
                double,
                UI_ANIMATION_SCHEDULING_RESULT*,
                int>)((*lpVtbl)[12])
        )(this, timeNow, schedulingResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Conclude()
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard2, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Finish([NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard2, double, int>)((*lpVtbl)[14]))(
            this,
            completionDeadline
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Abandon()
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard2, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetTag(IUnknown @object, [NativeTypeName("UINT32")] uint id)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard2, IUnknown, uint, int>)((*lpVtbl)[16]))(
            this,
            @object,
            id
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTag(IUnknown* @object, [NativeTypeName("UINT32 *")] uint* id)
    {
        return (
            (delegate* unmanaged<IUIAnimationStoryboard2, IUnknown*, uint*, int>)((*lpVtbl)[17])
        )(this, @object, id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetStatus(UI_ANIMATION_STORYBOARD_STATUS* status)
    {
        return (
            (delegate* unmanaged<IUIAnimationStoryboard2, UI_ANIMATION_STORYBOARD_STATUS*, int>)(
                (*lpVtbl)[18]
            )
        )(this, status);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetElapsedTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* elapsedTime)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard2, double*, int>)((*lpVtbl)[19]))(
            this,
            elapsedTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetStoryboardEventHandler(
        IUIAnimationStoryboardEventHandler2 handler,
        [Optional] BOOL fRegisterStatusChangeForNextAnimationEvent,
        [Optional] BOOL fRegisterUpdateForNextAnimationEvent
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationStoryboard2,
                IUIAnimationStoryboardEventHandler2,
                BOOL,
                BOOL,
                int>)((*lpVtbl)[20])
        )(
            this,
            handler,
            fRegisterStatusChangeForNextAnimationEvent,
            fRegisterUpdateForNextAnimationEvent
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddTransition(IUIAnimationVariable2 variable, IUIAnimationTransition2 transition);

        [VtblIndex(4)]
        HRESULT AddKeyframeAtOffset(
            UI_ANIMATION_KEYFRAME existingKeyframe,
            [NativeTypeName("UI_ANIMATION_SECONDS")] double offset,
            UI_ANIMATION_KEYFRAME* keyframe
        );

        [VtblIndex(5)]
        HRESULT AddKeyframeAfterTransition(
            IUIAnimationTransition2 transition,
            UI_ANIMATION_KEYFRAME* keyframe
        );

        [VtblIndex(6)]
        HRESULT AddTransitionAtKeyframe(
            IUIAnimationVariable2 variable,
            IUIAnimationTransition2 transition,
            UI_ANIMATION_KEYFRAME startKeyframe
        );

        [VtblIndex(7)]
        HRESULT AddTransitionBetweenKeyframes(
            IUIAnimationVariable2 variable,
            IUIAnimationTransition2 transition,
            UI_ANIMATION_KEYFRAME startKeyframe,
            UI_ANIMATION_KEYFRAME endKeyframe
        );

        [VtblIndex(8)]
        HRESULT RepeatBetweenKeyframes(
            UI_ANIMATION_KEYFRAME startKeyframe,
            UI_ANIMATION_KEYFRAME endKeyframe,
            double cRepetition,
            UI_ANIMATION_REPEAT_MODE repeatMode,
            [Optional] IUIAnimationLoopIterationChangeHandler2 pIterationChangeHandler,
            [NativeTypeName("UINT_PTR")] [Optional] nuint id,
            [Optional] BOOL fRegisterForNextAnimationEvent
        );

        [VtblIndex(9)]
        HRESULT HoldVariable(IUIAnimationVariable2 variable);

        [VtblIndex(10)]
        HRESULT SetLongestAcceptableDelay([NativeTypeName("UI_ANIMATION_SECONDS")] double delay);

        [VtblIndex(11)]
        HRESULT SetSkipDuration([NativeTypeName("UI_ANIMATION_SECONDS")] double secondsDuration);

        [VtblIndex(12)]
        HRESULT Schedule(
            [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow,
            UI_ANIMATION_SCHEDULING_RESULT* schedulingResult = null
        );

        [VtblIndex(13)]
        HRESULT Conclude();

        [VtblIndex(14)]
        HRESULT Finish([NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline);

        [VtblIndex(15)]
        HRESULT Abandon();

        [VtblIndex(16)]
        HRESULT SetTag(IUnknown @object, [NativeTypeName("UINT32")] uint id);

        [VtblIndex(17)]
        HRESULT GetTag(IUnknown* @object, [NativeTypeName("UINT32 *")] uint* id);

        [VtblIndex(18)]
        HRESULT GetStatus(UI_ANIMATION_STORYBOARD_STATUS* status);

        [VtblIndex(19)]
        HRESULT GetElapsedTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* elapsedTime);

        [VtblIndex(20)]
        HRESULT SetStoryboardEventHandler(
            IUIAnimationStoryboardEventHandler2 handler,
            [Optional] BOOL fRegisterStatusChangeForNextAnimationEvent,
            [Optional] BOOL fRegisterUpdateForNextAnimationEvent
        );
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
            "HRESULT (IUIAnimationVariable2 *, IUIAnimationTransition2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationVariable2,
            IUIAnimationTransition2,
            int> AddTransition;

        [NativeTypeName(
            "HRESULT (UI_ANIMATION_KEYFRAME, UI_ANIMATION_SECONDS, UI_ANIMATION_KEYFRAME *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            UI_ANIMATION_KEYFRAME,
            double,
            UI_ANIMATION_KEYFRAME*,
            int> AddKeyframeAtOffset;

        [NativeTypeName(
            "HRESULT (IUIAnimationTransition2 *, UI_ANIMATION_KEYFRAME *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationTransition2,
            UI_ANIMATION_KEYFRAME*,
            int> AddKeyframeAfterTransition;

        [NativeTypeName(
            "HRESULT (IUIAnimationVariable2 *, IUIAnimationTransition2 *, UI_ANIMATION_KEYFRAME) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationVariable2,
            IUIAnimationTransition2,
            UI_ANIMATION_KEYFRAME,
            int> AddTransitionAtKeyframe;

        [NativeTypeName(
            "HRESULT (IUIAnimationVariable2 *, IUIAnimationTransition2 *, UI_ANIMATION_KEYFRAME, UI_ANIMATION_KEYFRAME) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationVariable2,
            IUIAnimationTransition2,
            UI_ANIMATION_KEYFRAME,
            UI_ANIMATION_KEYFRAME,
            int> AddTransitionBetweenKeyframes;

        [NativeTypeName(
            "HRESULT (UI_ANIMATION_KEYFRAME, UI_ANIMATION_KEYFRAME, DOUBLE, UI_ANIMATION_REPEAT_MODE, IUIAnimationLoopIterationChangeHandler2 *, UINT_PTR, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            UI_ANIMATION_KEYFRAME,
            UI_ANIMATION_KEYFRAME,
            double,
            UI_ANIMATION_REPEAT_MODE,
            IUIAnimationLoopIterationChangeHandler2,
            nuint,
            BOOL,
            int> RepeatBetweenKeyframes;

        [NativeTypeName("HRESULT (IUIAnimationVariable2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationVariable2, int> HoldVariable;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetLongestAcceptableDelay;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetSkipDuration;

        [NativeTypeName(
            "HRESULT (UI_ANIMATION_SECONDS, UI_ANIMATION_SCHEDULING_RESULT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, double, UI_ANIMATION_SCHEDULING_RESULT*, int> Schedule;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Conclude;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> Finish;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Abandon;

        [NativeTypeName("HRESULT (IUnknown *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, uint, int> SetTag;

        [NativeTypeName("HRESULT (IUnknown **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint*, int> GetTag;

        [NativeTypeName("HRESULT (UI_ANIMATION_STORYBOARD_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_STORYBOARD_STATUS*, int> GetStatus;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetElapsedTime;

        [NativeTypeName(
            "HRESULT (IUIAnimationStoryboardEventHandler2 *, BOOL, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationStoryboardEventHandler2,
            BOOL,
            BOOL,
            int> SetStoryboardEventHandler;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUIAnimationStoryboard2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUIAnimationStoryboard2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUIAnimationStoryboard2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUIAnimationStoryboard2(Silk.NET.Windows.IUnknown value)
    {
        return new IUIAnimationStoryboard2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUIAnimationStoryboard2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUIAnimationStoryboard2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUIAnimationStoryboard2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
