// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("438DE12D-769B-4821-A949-284A6547E873")]
[NativeTypeName("struct INaturalMotionAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INaturalMotionAnimation
    : INaturalMotionAnimation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INaturalMotionAnimation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INaturalMotionAnimation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<INaturalMotionAnimation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INaturalMotionAnimation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<INaturalMotionAnimation, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<INaturalMotionAnimation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<INaturalMotionAnimation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DelayBehavior(
        [NativeTypeName("ABI::Windows::UI::Composition::AnimationDelayBehavior *")]
            AnimationDelayBehavior* value
    )
    {
        return (
            (delegate* unmanaged<INaturalMotionAnimation, AnimationDelayBehavior*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DelayBehavior(
        [NativeTypeName("ABI::Windows::UI::Composition::AnimationDelayBehavior")]
            AnimationDelayBehavior value
    )
    {
        return (
            (delegate* unmanaged<INaturalMotionAnimation, AnimationDelayBehavior, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DelayTime(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<INaturalMotionAnimation, TimeSpan*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DelayTime(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<INaturalMotionAnimation, TimeSpan, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_StopBehavior(
        [NativeTypeName("ABI::Windows::UI::Composition::AnimationStopBehavior *")]
            AnimationStopBehavior* value
    )
    {
        return (
            (delegate* unmanaged<INaturalMotionAnimation, AnimationStopBehavior*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_StopBehavior(
        [NativeTypeName("ABI::Windows::UI::Composition::AnimationStopBehavior")]
            AnimationStopBehavior value
    )
    {
        return (
            (delegate* unmanaged<INaturalMotionAnimation, AnimationStopBehavior, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DelayBehavior(
            [NativeTypeName("ABI::Windows::UI::Composition::AnimationDelayBehavior *")]
                AnimationDelayBehavior* value
        );

        [VtblIndex(7)]
        HRESULT put_DelayBehavior(
            [NativeTypeName("ABI::Windows::UI::Composition::AnimationDelayBehavior")]
                AnimationDelayBehavior value
        );

        [VtblIndex(8)]
        HRESULT get_DelayTime(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(9)]
        HRESULT put_DelayTime(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
        );

        [VtblIndex(10)]
        HRESULT get_StopBehavior(
            [NativeTypeName("ABI::Windows::UI::Composition::AnimationStopBehavior *")]
                AnimationStopBehavior* value
        );

        [VtblIndex(11)]
        HRESULT put_StopBehavior(
            [NativeTypeName("ABI::Windows::UI::Composition::AnimationStopBehavior")]
                AnimationStopBehavior value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::AnimationDelayBehavior *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AnimationDelayBehavior*, int> get_DelayBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::AnimationDelayBehavior) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AnimationDelayBehavior, int> put_DelayBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_DelayTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_DelayTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::AnimationStopBehavior *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AnimationStopBehavior*, int> get_StopBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::AnimationStopBehavior) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AnimationStopBehavior, int> put_StopBehavior;
    }

    /// <summary>Initializes a new instance of the <see cref = "INaturalMotionAnimation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INaturalMotionAnimation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "INaturalMotionAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator INaturalMotionAnimation(Silk.NET.WinRT.IInspectable value)
    {
        return new INaturalMotionAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INaturalMotionAnimation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "INaturalMotionAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(INaturalMotionAnimation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INaturalMotionAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INaturalMotionAnimation(Silk.NET.Windows.IUnknown value)
    {
        return new INaturalMotionAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INaturalMotionAnimation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INaturalMotionAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INaturalMotionAnimation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
