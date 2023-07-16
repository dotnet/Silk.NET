// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IUIAnimationTimerUpdateHandler.xml' path='doc/member[@name="IUIAnimationTimerUpdateHandler"]/*'/>
[Guid("195509B7-5D5E-4E3E-B278-EE3759B367AD")]
[NativeTypeName("struct IUIAnimationTimerUpdateHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationTimerUpdateHandler : IUIAnimationTimerUpdateHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationTimerUpdateHandler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationTimerUpdateHandler*, Guid*, void**, int> )(lpVtbl[0]))((IUIAnimationTimerUpdateHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationTimerUpdateHandler*, uint> )(lpVtbl[1]))((IUIAnimationTimerUpdateHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationTimerUpdateHandler*, uint> )(lpVtbl[2]))((IUIAnimationTimerUpdateHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTimerUpdateHandler.xml' path='doc/member[@name="IUIAnimationTimerUpdateHandler.OnUpdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnUpdate([NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow, UI_ANIMATION_UPDATE_RESULT* result)
    {
        return ((delegate* unmanaged<IUIAnimationTimerUpdateHandler*, double, UI_ANIMATION_UPDATE_RESULT*, int> )(lpVtbl[3]))((IUIAnimationTimerUpdateHandler*)Unsafe.AsPointer(ref this), timeNow, result);
    }

    /// <include file='IUIAnimationTimerUpdateHandler.xml' path='doc/member[@name="IUIAnimationTimerUpdateHandler.SetTimerClientEventHandler"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTimerClientEventHandler(IUIAnimationTimerClientEventHandler* handler)
    {
        return ((delegate* unmanaged<IUIAnimationTimerUpdateHandler*, IUIAnimationTimerClientEventHandler*, int> )(lpVtbl[4]))((IUIAnimationTimerUpdateHandler*)Unsafe.AsPointer(ref this), handler);
    }

    /// <include file='IUIAnimationTimerUpdateHandler.xml' path='doc/member[@name="IUIAnimationTimerUpdateHandler.ClearTimerClientEventHandler"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ClearTimerClientEventHandler()
    {
        return ((delegate* unmanaged<IUIAnimationTimerUpdateHandler*, int> )(lpVtbl[5]))((IUIAnimationTimerUpdateHandler*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnUpdate([NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow, UI_ANIMATION_UPDATE_RESULT* result);
        [VtblIndex(4)]
        HRESULT SetTimerClientEventHandler(IUIAnimationTimerClientEventHandler* handler);
        [VtblIndex(5)]
        HRESULT ClearTimerClientEventHandler();
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
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS, UI_ANIMATION_UPDATE_RESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, UI_ANIMATION_UPDATE_RESULT*, int> OnUpdate;
        [NativeTypeName("HRESULT (IUIAnimationTimerClientEventHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationTimerClientEventHandler*, int> SetTimerClientEventHandler;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearTimerClientEventHandler;
    }
}