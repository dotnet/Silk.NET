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

[Guid("93ADB5E9-8E05-4593-84A3-DCA152781E56")]
[NativeTypeName("struct IColorKeyFrameAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IColorKeyFrameAnimation
    : IColorKeyFrameAnimation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IColorKeyFrameAnimation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IColorKeyFrameAnimation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IColorKeyFrameAnimation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IColorKeyFrameAnimation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IColorKeyFrameAnimation, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IColorKeyFrameAnimation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IColorKeyFrameAnimation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InterpolationColorSpace(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionColorSpace *")]
            CompositionColorSpace* value
    )
    {
        return (
            (delegate* unmanaged<IColorKeyFrameAnimation, CompositionColorSpace*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_InterpolationColorSpace(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionColorSpace")]
            CompositionColorSpace value
    )
    {
        return (
            (delegate* unmanaged<IColorKeyFrameAnimation, CompositionColorSpace, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InsertKeyFrame(
        float normalizedProgressKey,
        [NativeTypeName("ABI::Windows::UI::Color")] Color value
    )
    {
        return ((delegate* unmanaged<IColorKeyFrameAnimation, float, Color, int>)((*lpVtbl)[8]))(
            this,
            normalizedProgressKey,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InsertKeyFrameWithEasingFunction(
        float normalizedProgressKey,
        [NativeTypeName("ABI::Windows::UI::Color")] Color value,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEasingFunction *")]
            ICompositionEasingFunction easingFunction
    )
    {
        return (
            (delegate* unmanaged<
                IColorKeyFrameAnimation,
                float,
                Color,
                ICompositionEasingFunction,
                int>)((*lpVtbl)[9])
        )(this, normalizedProgressKey, value, easingFunction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InterpolationColorSpace(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionColorSpace *")]
                CompositionColorSpace* value
        );

        [VtblIndex(7)]
        HRESULT put_InterpolationColorSpace(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionColorSpace")]
                CompositionColorSpace value
        );

        [VtblIndex(8)]
        HRESULT InsertKeyFrame(
            float normalizedProgressKey,
            [NativeTypeName("ABI::Windows::UI::Color")] Color value
        );

        [VtblIndex(9)]
        HRESULT InsertKeyFrameWithEasingFunction(
            float normalizedProgressKey,
            [NativeTypeName("ABI::Windows::UI::Color")] Color value,
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionColorSpace *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionColorSpace*, int> get_InterpolationColorSpace;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionColorSpace) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionColorSpace, int> put_InterpolationColorSpace;

        [NativeTypeName("HRESULT (FLOAT, ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, Color, int> InsertKeyFrame;

        [NativeTypeName(
            "HRESULT (FLOAT, ABI::Windows::UI::Color, ABI::Windows::UI::Composition::ICompositionEasingFunction *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            Color,
            ICompositionEasingFunction,
            int> InsertKeyFrameWithEasingFunction;
    }

    /// <summary>Initializes a new instance of the <see cref = "IColorKeyFrameAnimation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IColorKeyFrameAnimation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IColorKeyFrameAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IColorKeyFrameAnimation(Silk.NET.WinRT.IInspectable value)
    {
        return new IColorKeyFrameAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IColorKeyFrameAnimation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IColorKeyFrameAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IColorKeyFrameAnimation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IColorKeyFrameAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IColorKeyFrameAnimation(Silk.NET.Windows.IUnknown value)
    {
        return new IColorKeyFrameAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IColorKeyFrameAnimation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IColorKeyFrameAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IColorKeyFrameAnimation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
