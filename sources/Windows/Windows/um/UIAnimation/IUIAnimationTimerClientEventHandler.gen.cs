// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IUIAnimationTimerClientEventHandler.xml' path='doc/member[@name="IUIAnimationTimerClientEventHandler"]/*'/>
[Guid("BEDB4DB6-94FA-4BFB-A47F-EF2D9E408C25")]
[NativeTypeName("struct IUIAnimationTimerClientEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationTimerClientEventHandler : IUIAnimationTimerClientEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationTimerClientEventHandler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationTimerClientEventHandler*, Guid*, void**, int> )(lpVtbl[0]))((IUIAnimationTimerClientEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationTimerClientEventHandler*, uint> )(lpVtbl[1]))((IUIAnimationTimerClientEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationTimerClientEventHandler*, uint> )(lpVtbl[2]))((IUIAnimationTimerClientEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTimerClientEventHandler.xml' path='doc/member[@name="IUIAnimationTimerClientEventHandler.OnTimerClientStatusChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnTimerClientStatusChanged(UI_ANIMATION_TIMER_CLIENT_STATUS newStatus, UI_ANIMATION_TIMER_CLIENT_STATUS previousStatus)
    {
        return ((delegate* unmanaged<IUIAnimationTimerClientEventHandler*, UI_ANIMATION_TIMER_CLIENT_STATUS, UI_ANIMATION_TIMER_CLIENT_STATUS, int> )(lpVtbl[3]))((IUIAnimationTimerClientEventHandler*)Unsafe.AsPointer(ref this), newStatus, previousStatus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnTimerClientStatusChanged(UI_ANIMATION_TIMER_CLIENT_STATUS newStatus, UI_ANIMATION_TIMER_CLIENT_STATUS previousStatus);
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
        [NativeTypeName("HRESULT (UI_ANIMATION_TIMER_CLIENT_STATUS, UI_ANIMATION_TIMER_CLIENT_STATUS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_TIMER_CLIENT_STATUS, UI_ANIMATION_TIMER_CLIENT_STATUS, int> OnTimerClientStatusChanged;
    }
}