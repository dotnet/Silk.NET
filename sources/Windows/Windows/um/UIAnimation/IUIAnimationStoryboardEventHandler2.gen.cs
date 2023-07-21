// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IUIAnimationStoryboardEventHandler2.xml' path='doc/member[@name="IUIAnimationStoryboardEventHandler2"]/*' />
[Guid("BAC5F55A-BA7C-414C-B599-FBF850F553C6")]
[NativeTypeName("struct IUIAnimationStoryboardEventHandler2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationStoryboardEventHandler2 : IUIAnimationStoryboardEventHandler2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationStoryboardEventHandler2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationStoryboardEventHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler2*, uint>)(lpVtbl[1]))((IUIAnimationStoryboardEventHandler2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler2*, uint>)(lpVtbl[2]))((IUIAnimationStoryboardEventHandler2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationStoryboardEventHandler2.xml' path='doc/member[@name="IUIAnimationStoryboardEventHandler2.OnStoryboardStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnStoryboardStatusChanged(IUIAnimationStoryboard2* storyboard, UI_ANIMATION_STORYBOARD_STATUS newStatus, UI_ANIMATION_STORYBOARD_STATUS previousStatus)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler2*, IUIAnimationStoryboard2*, UI_ANIMATION_STORYBOARD_STATUS, UI_ANIMATION_STORYBOARD_STATUS, int>)(lpVtbl[3]))((IUIAnimationStoryboardEventHandler2*)Unsafe.AsPointer(ref this), storyboard, newStatus, previousStatus);
    }

    /// <include file='IUIAnimationStoryboardEventHandler2.xml' path='doc/member[@name="IUIAnimationStoryboardEventHandler2.OnStoryboardUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnStoryboardUpdated(IUIAnimationStoryboard2* storyboard)
    {
        return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler2*, IUIAnimationStoryboard2*, int>)(lpVtbl[4]))((IUIAnimationStoryboardEventHandler2*)Unsafe.AsPointer(ref this), storyboard);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnStoryboardStatusChanged(IUIAnimationStoryboard2* storyboard, UI_ANIMATION_STORYBOARD_STATUS newStatus, UI_ANIMATION_STORYBOARD_STATUS previousStatus);

        [VtblIndex(4)]
        HRESULT OnStoryboardUpdated(IUIAnimationStoryboard2* storyboard);
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

        [NativeTypeName("HRESULT (IUIAnimationStoryboard2 *, UI_ANIMATION_STORYBOARD_STATUS, UI_ANIMATION_STORYBOARD_STATUS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationStoryboard2*, UI_ANIMATION_STORYBOARD_STATUS, UI_ANIMATION_STORYBOARD_STATUS, int> OnStoryboardStatusChanged;

        [NativeTypeName("HRESULT (IUIAnimationStoryboard2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationStoryboard2*, int> OnStoryboardUpdated;
    }
}
