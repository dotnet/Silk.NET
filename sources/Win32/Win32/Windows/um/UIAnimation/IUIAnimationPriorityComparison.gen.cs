// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("83FA9B74-5F86-4618-BC6A-A2FAC19B3F44")]
[NativeTypeName("struct IUIAnimationPriorityComparison : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationPriorityComparison
    : IUIAnimationPriorityComparison.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationPriorityComparison));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IUIAnimationPriorityComparison, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationPriorityComparison, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationPriorityComparison, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT HasPriority(
        IUIAnimationStoryboard scheduledStoryboard,
        IUIAnimationStoryboard newStoryboard,
        UI_ANIMATION_PRIORITY_EFFECT priorityEffect
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationPriorityComparison,
                IUIAnimationStoryboard,
                IUIAnimationStoryboard,
                UI_ANIMATION_PRIORITY_EFFECT,
                int>)((*lpVtbl)[3])
        )(this, scheduledStoryboard, newStoryboard, priorityEffect);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT HasPriority(
            IUIAnimationStoryboard scheduledStoryboard,
            IUIAnimationStoryboard newStoryboard,
            UI_ANIMATION_PRIORITY_EFFECT priorityEffect
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
            "HRESULT (IUIAnimationStoryboard *, IUIAnimationStoryboard *, UI_ANIMATION_PRIORITY_EFFECT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationStoryboard,
            IUIAnimationStoryboard,
            UI_ANIMATION_PRIORITY_EFFECT,
            int> HasPriority;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUIAnimationPriorityComparison"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUIAnimationPriorityComparison(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUIAnimationPriorityComparison"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUIAnimationPriorityComparison(Silk.NET.Windows.IUnknown value)
    {
        return new IUIAnimationPriorityComparison(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUIAnimationPriorityComparison"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUIAnimationPriorityComparison"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUIAnimationPriorityComparison value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
