// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F6E022BA-BFF3-42EC-9033-E073F33E83C3")]
[NativeTypeName("struct IUIAnimationManagerEventHandler2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationManagerEventHandler2
    : IUIAnimationManagerEventHandler2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationManagerEventHandler2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IUIAnimationManagerEventHandler2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationManagerEventHandler2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationManagerEventHandler2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnManagerStatusChanged(
        UI_ANIMATION_MANAGER_STATUS newStatus,
        UI_ANIMATION_MANAGER_STATUS previousStatus
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationManagerEventHandler2,
                UI_ANIMATION_MANAGER_STATUS,
                UI_ANIMATION_MANAGER_STATUS,
                int>)((*lpVtbl)[3])
        )(this, newStatus, previousStatus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnManagerStatusChanged(
            UI_ANIMATION_MANAGER_STATUS newStatus,
            UI_ANIMATION_MANAGER_STATUS previousStatus
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
            "HRESULT (UI_ANIMATION_MANAGER_STATUS, UI_ANIMATION_MANAGER_STATUS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            UI_ANIMATION_MANAGER_STATUS,
            UI_ANIMATION_MANAGER_STATUS,
            int> OnManagerStatusChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUIAnimationManagerEventHandler2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUIAnimationManagerEventHandler2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUIAnimationManagerEventHandler2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUIAnimationManagerEventHandler2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IUIAnimationManagerEventHandler2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUIAnimationManagerEventHandler2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUIAnimationManagerEventHandler2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IUIAnimationManagerEventHandler2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
