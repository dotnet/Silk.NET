// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IUIAnimationTimerEventHandler.xml' path='doc/member[@name="IUIAnimationTimerEventHandler"]/*'/>
[Guid("274A7DEA-D771-4095-ABBD-8DF7ABD23CE3")]
[NativeTypeName("struct IUIAnimationTimerEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationTimerEventHandler : IUIAnimationTimerEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationTimerEventHandler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationTimerEventHandler*, Guid*, void**, int> )(lpVtbl[0]))((IUIAnimationTimerEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationTimerEventHandler*, uint> )(lpVtbl[1]))((IUIAnimationTimerEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationTimerEventHandler*, uint> )(lpVtbl[2]))((IUIAnimationTimerEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTimerEventHandler.xml' path='doc/member[@name="IUIAnimationTimerEventHandler.OnPreUpdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnPreUpdate()
    {
        return ((delegate* unmanaged<IUIAnimationTimerEventHandler*, int> )(lpVtbl[3]))((IUIAnimationTimerEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTimerEventHandler.xml' path='doc/member[@name="IUIAnimationTimerEventHandler.OnPostUpdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnPostUpdate()
    {
        return ((delegate* unmanaged<IUIAnimationTimerEventHandler*, int> )(lpVtbl[4]))((IUIAnimationTimerEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTimerEventHandler.xml' path='doc/member[@name="IUIAnimationTimerEventHandler.OnRenderingTooSlow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnRenderingTooSlow([NativeTypeName("UINT32")] uint framesPerSecond)
    {
        return ((delegate* unmanaged<IUIAnimationTimerEventHandler*, uint, int> )(lpVtbl[5]))((IUIAnimationTimerEventHandler*)Unsafe.AsPointer(ref this), framesPerSecond);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnPreUpdate();
        [VtblIndex(4)]
        HRESULT OnPostUpdate();
        [VtblIndex(5)]
        HRESULT OnRenderingTooSlow([NativeTypeName("UINT32")] uint framesPerSecond);
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnPreUpdate;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnPostUpdate;
        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnRenderingTooSlow;
    }
}