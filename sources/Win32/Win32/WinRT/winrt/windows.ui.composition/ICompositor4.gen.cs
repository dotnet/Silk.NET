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

[Guid("AE47E78A-7910-4425-A482-A05B758ADCE9")]
[NativeTypeName("struct ICompositor4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositor4 : ICompositor4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositor4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositor4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositor4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositor4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositor4, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositor4, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositor4, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateColorGradientStop(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionColorGradientStop **")]
            ICompositionColorGradientStop* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor4, ICompositionColorGradientStop*, int>)((*lpVtbl)[6])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateColorGradientStopWithOffsetAndColor(
        float offset,
        [NativeTypeName("ABI::Windows::UI::Color")] Color color,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionColorGradientStop **")]
            ICompositionColorGradientStop* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor4, float, Color, ICompositionColorGradientStop*, int>)(
                (*lpVtbl)[7]
            )
        )(this, offset, color, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateLinearGradientBrush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionLinearGradientBrush **")]
            ICompositionLinearGradientBrush* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor4, ICompositionLinearGradientBrush*, int>)((*lpVtbl)[8])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateSpringScalarAnimation(
        [NativeTypeName("ABI::Windows::UI::Composition::ISpringScalarNaturalMotionAnimation **")]
            ISpringScalarNaturalMotionAnimation* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor4, ISpringScalarNaturalMotionAnimation*, int>)(
                (*lpVtbl)[9]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateSpringVector2Animation(
        [NativeTypeName("ABI::Windows::UI::Composition::ISpringVector2NaturalMotionAnimation **")]
            ISpringVector2NaturalMotionAnimation* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor4, ISpringVector2NaturalMotionAnimation*, int>)(
                (*lpVtbl)[10]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateSpringVector3Animation(
        [NativeTypeName("ABI::Windows::UI::Composition::ISpringVector3NaturalMotionAnimation **")]
            ISpringVector3NaturalMotionAnimation* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor4, ISpringVector3NaturalMotionAnimation*, int>)(
                (*lpVtbl)[11]
            )
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateColorGradientStop(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionColorGradientStop **")]
                ICompositionColorGradientStop* result
        );

        [VtblIndex(7)]
        HRESULT CreateColorGradientStopWithOffsetAndColor(
            float offset,
            [NativeTypeName("ABI::Windows::UI::Color")] Color color,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionColorGradientStop **")]
                ICompositionColorGradientStop* result
        );

        [VtblIndex(8)]
        HRESULT CreateLinearGradientBrush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionLinearGradientBrush **")]
                ICompositionLinearGradientBrush* result
        );

        [VtblIndex(9)]
        HRESULT CreateSpringScalarAnimation(
            [NativeTypeName(
                "ABI::Windows::UI::Composition::ISpringScalarNaturalMotionAnimation **"
            )]
                ISpringScalarNaturalMotionAnimation* result
        );

        [VtblIndex(10)]
        HRESULT CreateSpringVector2Animation(
            [NativeTypeName(
                "ABI::Windows::UI::Composition::ISpringVector2NaturalMotionAnimation **"
            )]
                ISpringVector2NaturalMotionAnimation* result
        );

        [VtblIndex(11)]
        HRESULT CreateSpringVector3Animation(
            [NativeTypeName(
                "ABI::Windows::UI::Composition::ISpringVector3NaturalMotionAnimation **"
            )]
                ISpringVector3NaturalMotionAnimation* result
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
            "HRESULT (ABI::Windows::UI::Composition::ICompositionColorGradientStop **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionColorGradientStop*,
            int> CreateColorGradientStop;

        [NativeTypeName(
            "HRESULT (FLOAT, ABI::Windows::UI::Color, ABI::Windows::UI::Composition::ICompositionColorGradientStop **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            Color,
            ICompositionColorGradientStop*,
            int> CreateColorGradientStopWithOffsetAndColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionLinearGradientBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionLinearGradientBrush*,
            int> CreateLinearGradientBrush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ISpringScalarNaturalMotionAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpringScalarNaturalMotionAnimation*,
            int> CreateSpringScalarAnimation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ISpringVector2NaturalMotionAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpringVector2NaturalMotionAnimation*,
            int> CreateSpringVector2Animation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ISpringVector3NaturalMotionAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpringVector3NaturalMotionAnimation*,
            int> CreateSpringVector3Animation;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositor4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositor4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositor4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositor4(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositor4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositor4"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositor4"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositor4 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositor4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositor4(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositor4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositor4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositor4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositor4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
