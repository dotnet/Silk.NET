// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IUIAnimationManagerEventHandler.xml' path='doc/member[@name="IUIAnimationManagerEventHandler"]/*'/>
[Guid("783321ED-78A3-4366-B574-6AF607A64788")]
[NativeTypeName("struct IUIAnimationManagerEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationManagerEventHandler : IUIAnimationManagerEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationManagerEventHandler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationManagerEventHandler*, Guid*, void**, int> )(lpVtbl[0]))((IUIAnimationManagerEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationManagerEventHandler*, uint> )(lpVtbl[1]))((IUIAnimationManagerEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationManagerEventHandler*, uint> )(lpVtbl[2]))((IUIAnimationManagerEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationManagerEventHandler.xml' path='doc/member[@name="IUIAnimationManagerEventHandler.OnManagerStatusChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnManagerStatusChanged(UI_ANIMATION_MANAGER_STATUS newStatus, UI_ANIMATION_MANAGER_STATUS previousStatus)
    {
        return ((delegate* unmanaged<IUIAnimationManagerEventHandler*, UI_ANIMATION_MANAGER_STATUS, UI_ANIMATION_MANAGER_STATUS, int> )(lpVtbl[3]))((IUIAnimationManagerEventHandler*)Unsafe.AsPointer(ref this), newStatus, previousStatus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnManagerStatusChanged(UI_ANIMATION_MANAGER_STATUS newStatus, UI_ANIMATION_MANAGER_STATUS previousStatus);
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
        [NativeTypeName("HRESULT (UI_ANIMATION_MANAGER_STATUS, UI_ANIMATION_MANAGER_STATUS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_MANAGER_STATUS, UI_ANIMATION_MANAGER_STATUS, int> OnManagerStatusChanged;
    }
}