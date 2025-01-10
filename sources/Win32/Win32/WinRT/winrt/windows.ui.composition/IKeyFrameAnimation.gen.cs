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

[Guid("126E7F22-3AE9-4540-9A8A-DEAE8A4A4A84")]
[NativeTypeName("struct IKeyFrameAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyFrameAnimation : IKeyFrameAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKeyFrameAnimation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IKeyFrameAnimation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DelayTime(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, TimeSpan*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DelayTime(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, TimeSpan, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Duration(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, TimeSpan*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Duration(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, TimeSpan, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IterationBehavior(
        [NativeTypeName("ABI::Windows::UI::Composition::AnimationIterationBehavior *")]
            AnimationIterationBehavior* value
    )
    {
        return (
            (delegate* unmanaged<IKeyFrameAnimation, AnimationIterationBehavior*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IterationBehavior(
        [NativeTypeName("ABI::Windows::UI::Composition::AnimationIterationBehavior")]
            AnimationIterationBehavior value
    )
    {
        return (
            (delegate* unmanaged<IKeyFrameAnimation, AnimationIterationBehavior, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IterationCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, int*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IterationCount([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, int, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_KeyFrameCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, int*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_StopBehavior(
        [NativeTypeName("ABI::Windows::UI::Composition::AnimationStopBehavior *")]
            AnimationStopBehavior* value
    )
    {
        return (
            (delegate* unmanaged<IKeyFrameAnimation, AnimationStopBehavior*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_StopBehavior(
        [NativeTypeName("ABI::Windows::UI::Composition::AnimationStopBehavior")]
            AnimationStopBehavior value
    )
    {
        return (
            (delegate* unmanaged<IKeyFrameAnimation, AnimationStopBehavior, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT InsertExpressionKeyFrame(float normalizedProgressKey, HSTRING value)
    {
        return ((delegate* unmanaged<IKeyFrameAnimation, float, HSTRING, int>)((*lpVtbl)[17]))(
            this,
            normalizedProgressKey,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT InsertExpressionKeyFrameWithEasingFunction(
        float normalizedProgressKey,
        HSTRING value,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEasingFunction *")]
            ICompositionEasingFunction easingFunction
    )
    {
        return (
            (delegate* unmanaged<
                IKeyFrameAnimation,
                float,
                HSTRING,
                ICompositionEasingFunction,
                int>)((*lpVtbl)[18])
        )(this, normalizedProgressKey, value, easingFunction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DelayTime(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(7)]
        HRESULT put_DelayTime(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
        );

        [VtblIndex(8)]
        HRESULT get_Duration(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(9)]
        HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(10)]
        HRESULT get_IterationBehavior(
            [NativeTypeName("ABI::Windows::UI::Composition::AnimationIterationBehavior *")]
                AnimationIterationBehavior* value
        );

        [VtblIndex(11)]
        HRESULT put_IterationBehavior(
            [NativeTypeName("ABI::Windows::UI::Composition::AnimationIterationBehavior")]
                AnimationIterationBehavior value
        );

        [VtblIndex(12)]
        HRESULT get_IterationCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT put_IterationCount([NativeTypeName("INT32")] int value);

        [VtblIndex(14)]
        HRESULT get_KeyFrameCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(15)]
        HRESULT get_StopBehavior(
            [NativeTypeName("ABI::Windows::UI::Composition::AnimationStopBehavior *")]
                AnimationStopBehavior* value
        );

        [VtblIndex(16)]
        HRESULT put_StopBehavior(
            [NativeTypeName("ABI::Windows::UI::Composition::AnimationStopBehavior")]
                AnimationStopBehavior value
        );

        [VtblIndex(17)]
        HRESULT InsertExpressionKeyFrame(float normalizedProgressKey, HSTRING value);

        [VtblIndex(18)]
        HRESULT InsertExpressionKeyFrameWithEasingFunction(
            float normalizedProgressKey,
            HSTRING value,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEasingFunction *")]
                ICompositionEasingFunction easingFunction
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_DelayTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_DelayTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_Duration;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::AnimationIterationBehavior *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AnimationIterationBehavior*, int> get_IterationBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::AnimationIterationBehavior) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AnimationIterationBehavior, int> put_IterationBehavior;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_IterationCount;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_IterationCount;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_KeyFrameCount;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::AnimationStopBehavior *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AnimationStopBehavior*, int> get_StopBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::AnimationStopBehavior) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AnimationStopBehavior, int> put_StopBehavior;

        [NativeTypeName("HRESULT (FLOAT, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, HSTRING, int> InsertExpressionKeyFrame;

        [NativeTypeName(
            "HRESULT (FLOAT, HSTRING, ABI::Windows::UI::Composition::ICompositionEasingFunction *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            HSTRING,
            ICompositionEasingFunction,
            int> InsertExpressionKeyFrameWithEasingFunction;
    }

    /// <summary>Initializes a new instance of the <see cref = "IKeyFrameAnimation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IKeyFrameAnimation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IKeyFrameAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IKeyFrameAnimation(Silk.NET.WinRT.IInspectable value)
    {
        return new IKeyFrameAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKeyFrameAnimation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IKeyFrameAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IKeyFrameAnimation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IKeyFrameAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IKeyFrameAnimation(Silk.NET.Windows.IUnknown value)
    {
        return new IKeyFrameAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKeyFrameAnimation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IKeyFrameAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IKeyFrameAnimation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
