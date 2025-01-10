// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3D5C9008-EC7C-4364-9F8A-9AF3C58CBAE6")]
[NativeTypeName("struct IUIAnimationStoryboardEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationStoryboardEventHandler
    : IUIAnimationStoryboardEventHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationStoryboardEventHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IUIAnimationStoryboardEventHandler, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnStoryboardStatusChanged(
        IUIAnimationStoryboard storyboard,
        UI_ANIMATION_STORYBOARD_STATUS newStatus,
        UI_ANIMATION_STORYBOARD_STATUS previousStatus
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationStoryboardEventHandler,
                IUIAnimationStoryboard,
                UI_ANIMATION_STORYBOARD_STATUS,
                UI_ANIMATION_STORYBOARD_STATUS,
                int>)((*lpVtbl)[3])
        )(this, storyboard, newStatus, previousStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnStoryboardUpdated(IUIAnimationStoryboard storyboard)
    {
        return (
            (delegate* unmanaged<IUIAnimationStoryboardEventHandler, IUIAnimationStoryboard, int>)(
                (*lpVtbl)[4]
            )
        )(this, storyboard);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnStoryboardStatusChanged(
            IUIAnimationStoryboard storyboard,
            UI_ANIMATION_STORYBOARD_STATUS newStatus,
            UI_ANIMATION_STORYBOARD_STATUS previousStatus
        );

        [VtblIndex(4)]
        HRESULT OnStoryboardUpdated(IUIAnimationStoryboard storyboard);
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
            "HRESULT (IUIAnimationStoryboard *, UI_ANIMATION_STORYBOARD_STATUS, UI_ANIMATION_STORYBOARD_STATUS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationStoryboard,
            UI_ANIMATION_STORYBOARD_STATUS,
            UI_ANIMATION_STORYBOARD_STATUS,
            int> OnStoryboardStatusChanged;

        [NativeTypeName("HRESULT (IUIAnimationStoryboard *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationStoryboard, int> OnStoryboardUpdated;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUIAnimationStoryboardEventHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUIAnimationStoryboardEventHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUIAnimationStoryboardEventHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUIAnimationStoryboardEventHandler(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IUIAnimationStoryboardEventHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUIAnimationStoryboardEventHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUIAnimationStoryboardEventHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IUIAnimationStoryboardEventHandler value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
