// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard"]/*'/>
[Guid("A8FF128F-9BF9-4AF1-9E67-E5E410DEFB84")]
[NativeTypeName("struct IUIAnimationStoryboard : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationStoryboard : IUIAnimationStoryboard.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationStoryboard));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, Guid*, void**, int> )(lpVtbl[0]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, uint> )(lpVtbl[1]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, uint> )(lpVtbl[2]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.AddTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddTransition(IUIAnimationVariable* variable, IUIAnimationTransition* transition)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, IUIAnimationVariable*, IUIAnimationTransition*, int> )(lpVtbl[3]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), variable, transition);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.AddKeyframeAtOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddKeyframeAtOffset(UI_ANIMATION_KEYFRAME existingKeyframe, [NativeTypeName("UI_ANIMATION_SECONDS")] double offset, UI_ANIMATION_KEYFRAME* keyframe)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, UI_ANIMATION_KEYFRAME, double, UI_ANIMATION_KEYFRAME*, int> )(lpVtbl[4]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), existingKeyframe, offset, keyframe);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.AddKeyframeAfterTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddKeyframeAfterTransition(IUIAnimationTransition* transition, UI_ANIMATION_KEYFRAME* keyframe)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, IUIAnimationTransition*, UI_ANIMATION_KEYFRAME*, int> )(lpVtbl[5]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), transition, keyframe);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.AddTransitionAtKeyframe"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddTransitionAtKeyframe(IUIAnimationVariable* variable, IUIAnimationTransition* transition, UI_ANIMATION_KEYFRAME startKeyframe)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, IUIAnimationVariable*, IUIAnimationTransition*, UI_ANIMATION_KEYFRAME, int> )(lpVtbl[6]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), variable, transition, startKeyframe);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.AddTransitionBetweenKeyframes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddTransitionBetweenKeyframes(IUIAnimationVariable* variable, IUIAnimationTransition* transition, UI_ANIMATION_KEYFRAME startKeyframe, UI_ANIMATION_KEYFRAME endKeyframe)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, IUIAnimationVariable*, IUIAnimationTransition*, UI_ANIMATION_KEYFRAME, UI_ANIMATION_KEYFRAME, int> )(lpVtbl[7]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), variable, transition, startKeyframe, endKeyframe);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.RepeatBetweenKeyframes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RepeatBetweenKeyframes(UI_ANIMATION_KEYFRAME startKeyframe, UI_ANIMATION_KEYFRAME endKeyframe, [NativeTypeName("INT32")] int repetitionCount)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, UI_ANIMATION_KEYFRAME, UI_ANIMATION_KEYFRAME, int, int> )(lpVtbl[8]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), startKeyframe, endKeyframe, repetitionCount);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.HoldVariable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT HoldVariable(IUIAnimationVariable* variable)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, IUIAnimationVariable*, int> )(lpVtbl[9]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), variable);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.SetLongestAcceptableDelay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLongestAcceptableDelay([NativeTypeName("UI_ANIMATION_SECONDS")] double delay)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, double, int> )(lpVtbl[10]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), delay);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.Schedule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Schedule([NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow, UI_ANIMATION_SCHEDULING_RESULT* schedulingResult = null)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, double, UI_ANIMATION_SCHEDULING_RESULT*, int> )(lpVtbl[11]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), timeNow, schedulingResult);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.Conclude"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Conclude()
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, int> )(lpVtbl[12]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.Finish"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Finish([NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, double, int> )(lpVtbl[13]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), completionDeadline);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.Abandon"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Abandon()
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, int> )(lpVtbl[14]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.SetTag"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, IUnknown*, uint, int> )(lpVtbl[15]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), @object, id);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.GetTag"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetTag(IUnknown** @object, [NativeTypeName("UINT32 *")] uint* id)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, IUnknown**, uint*, int> )(lpVtbl[16]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), @object, id);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.GetStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetStatus(UI_ANIMATION_STORYBOARD_STATUS* status)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, UI_ANIMATION_STORYBOARD_STATUS*, int> )(lpVtbl[17]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), status);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.GetElapsedTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetElapsedTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* elapsedTime)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, double*, int> )(lpVtbl[18]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), elapsedTime);
    }

    /// <include file='IUIAnimationStoryboard.xml' path='doc/member[@name="IUIAnimationStoryboard.SetStoryboardEventHandler"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetStoryboardEventHandler(IUIAnimationStoryboardEventHandler* handler)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboard*, IUIAnimationStoryboardEventHandler*, int> )(lpVtbl[19]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), handler);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddTransition(IUIAnimationVariable* variable, IUIAnimationTransition* transition);
        [VtblIndex(4)]
        HRESULT AddKeyframeAtOffset(UI_ANIMATION_KEYFRAME existingKeyframe, [NativeTypeName("UI_ANIMATION_SECONDS")] double offset, UI_ANIMATION_KEYFRAME* keyframe);
        [VtblIndex(5)]
        HRESULT AddKeyframeAfterTransition(IUIAnimationTransition* transition, UI_ANIMATION_KEYFRAME* keyframe);
        [VtblIndex(6)]
        HRESULT AddTransitionAtKeyframe(IUIAnimationVariable* variable, IUIAnimationTransition* transition, UI_ANIMATION_KEYFRAME startKeyframe);
        [VtblIndex(7)]
        HRESULT AddTransitionBetweenKeyframes(IUIAnimationVariable* variable, IUIAnimationTransition* transition, UI_ANIMATION_KEYFRAME startKeyframe, UI_ANIMATION_KEYFRAME endKeyframe);
        [VtblIndex(8)]
        HRESULT RepeatBetweenKeyframes(UI_ANIMATION_KEYFRAME startKeyframe, UI_ANIMATION_KEYFRAME endKeyframe, [NativeTypeName("INT32")] int repetitionCount);
        [VtblIndex(9)]
        HRESULT HoldVariable(IUIAnimationVariable* variable);
        [VtblIndex(10)]
        HRESULT SetLongestAcceptableDelay([NativeTypeName("UI_ANIMATION_SECONDS")] double delay);
        [VtblIndex(11)]
        HRESULT Schedule([NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow, UI_ANIMATION_SCHEDULING_RESULT* schedulingResult = null);
        [VtblIndex(12)]
        HRESULT Conclude();
        [VtblIndex(13)]
        HRESULT Finish([NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline);
        [VtblIndex(14)]
        HRESULT Abandon();
        [VtblIndex(15)]
        HRESULT SetTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id);
        [VtblIndex(16)]
        HRESULT GetTag(IUnknown** @object, [NativeTypeName("UINT32 *")] uint* id);
        [VtblIndex(17)]
        HRESULT GetStatus(UI_ANIMATION_STORYBOARD_STATUS* status);
        [VtblIndex(18)]
        HRESULT GetElapsedTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* elapsedTime);
        [VtblIndex(19)]
        HRESULT SetStoryboardEventHandler(IUIAnimationStoryboardEventHandler* handler);
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
        [NativeTypeName("HRESULT (IUIAnimationVariable *, IUIAnimationTransition *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationVariable*, IUIAnimationTransition*, int> AddTransition;
        [NativeTypeName("HRESULT (UI_ANIMATION_KEYFRAME, UI_ANIMATION_SECONDS, UI_ANIMATION_KEYFRAME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_KEYFRAME, double, UI_ANIMATION_KEYFRAME*, int> AddKeyframeAtOffset;
        [NativeTypeName("HRESULT (IUIAnimationTransition *, UI_ANIMATION_KEYFRAME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationTransition*, UI_ANIMATION_KEYFRAME*, int> AddKeyframeAfterTransition;
        [NativeTypeName("HRESULT (IUIAnimationVariable *, IUIAnimationTransition *, UI_ANIMATION_KEYFRAME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationVariable*, IUIAnimationTransition*, UI_ANIMATION_KEYFRAME, int> AddTransitionAtKeyframe;
        [NativeTypeName("HRESULT (IUIAnimationVariable *, IUIAnimationTransition *, UI_ANIMATION_KEYFRAME, UI_ANIMATION_KEYFRAME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationVariable*, IUIAnimationTransition*, UI_ANIMATION_KEYFRAME, UI_ANIMATION_KEYFRAME, int> AddTransitionBetweenKeyframes;
        [NativeTypeName("HRESULT (UI_ANIMATION_KEYFRAME, UI_ANIMATION_KEYFRAME, INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_KEYFRAME, UI_ANIMATION_KEYFRAME, int, int> RepeatBetweenKeyframes;
        [NativeTypeName("HRESULT (IUIAnimationVariable *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationVariable*, int> HoldVariable;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetLongestAcceptableDelay;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, UI_ANIMATION_SCHEDULING_RESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, UI_ANIMATION_SCHEDULING_RESULT*, int> Schedule;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Conclude;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> Finish;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Abandon;
        [NativeTypeName("HRESULT (IUnknown *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint, int> SetTag;
        [NativeTypeName("HRESULT (IUnknown **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, uint*, int> GetTag;
        [NativeTypeName("HRESULT (UI_ANIMATION_STORYBOARD_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_STORYBOARD_STATUS*, int> GetStatus;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetElapsedTime;
        [NativeTypeName("HRESULT (IUIAnimationStoryboardEventHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationStoryboardEventHandler*, int> SetStoryboardEventHandler;
    }
}