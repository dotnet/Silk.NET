// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1D9709E0-FFC6-4C0E-A9AB-34144D4C9098")]
[NativeTypeName("struct ICompositionGradientBrush : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionGradientBrush
    : ICompositionGradientBrush.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionGradientBrush));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionGradientBrush, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AnchorPoint(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, Vector2*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AnchorPoint(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, Vector2, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CenterPoint(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, Vector2*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CenterPoint(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, Vector2, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ColorStops(
        [NativeTypeName(
            "ABI::Windows::UI::Composition::ICompositionColorGradientStopCollection **"
        )]
            ICompositionColorGradientStopCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionGradientBrush,
                ICompositionColorGradientStopCollection*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ExtendMode(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionGradientExtendMode *")]
            CompositionGradientExtendMode* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionGradientBrush, CompositionGradientExtendMode*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_ExtendMode(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionGradientExtendMode")]
            CompositionGradientExtendMode value
    )
    {
        return (
            (delegate* unmanaged<ICompositionGradientBrush, CompositionGradientExtendMode, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_InterpolationSpace(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionColorSpace *")]
            CompositionColorSpace* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionGradientBrush, CompositionColorSpace*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_InterpolationSpace(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionColorSpace")]
            CompositionColorSpace value
    )
    {
        return (
            (delegate* unmanaged<ICompositionGradientBrush, CompositionColorSpace, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Offset(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, Vector2*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_Offset(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, Vector2, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_RotationAngle(float* value)
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, float*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_RotationAngle(float value)
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, float, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_RotationAngleInDegrees(float* value)
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, float*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_RotationAngleInDegrees(float value)
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, float, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Scale(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, Vector2*, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_Scale(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, Vector2, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_TransformMatrix(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2 *")] Matrix3x2* value
    )
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, Matrix3x2*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_TransformMatrix(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2")] Matrix3x2 value
    )
    {
        return ((delegate* unmanaged<ICompositionGradientBrush, Matrix3x2, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AnchorPoint(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(7)]
        HRESULT put_AnchorPoint(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(8)]
        HRESULT get_CenterPoint(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(9)]
        HRESULT put_CenterPoint(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(10)]
        HRESULT get_ColorStops(
            [NativeTypeName(
                "ABI::Windows::UI::Composition::ICompositionColorGradientStopCollection **"
            )]
                ICompositionColorGradientStopCollection* value
        );

        [VtblIndex(11)]
        HRESULT get_ExtendMode(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionGradientExtendMode *")]
                CompositionGradientExtendMode* value
        );

        [VtblIndex(12)]
        HRESULT put_ExtendMode(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionGradientExtendMode")]
                CompositionGradientExtendMode value
        );

        [VtblIndex(13)]
        HRESULT get_InterpolationSpace(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionColorSpace *")]
                CompositionColorSpace* value
        );

        [VtblIndex(14)]
        HRESULT put_InterpolationSpace(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionColorSpace")]
                CompositionColorSpace value
        );

        [VtblIndex(15)]
        HRESULT get_Offset(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(16)]
        HRESULT put_Offset(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(17)]
        HRESULT get_RotationAngle(float* value);

        [VtblIndex(18)]
        HRESULT put_RotationAngle(float value);

        [VtblIndex(19)]
        HRESULT get_RotationAngleInDegrees(float* value);

        [VtblIndex(20)]
        HRESULT put_RotationAngleInDegrees(float value);

        [VtblIndex(21)]
        HRESULT get_Scale(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(22)]
        HRESULT put_Scale(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(23)]
        HRESULT get_TransformMatrix(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2 *")] Matrix3x2* value
        );

        [VtblIndex(24)]
        HRESULT put_TransformMatrix(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2")] Matrix3x2 value
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
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_AnchorPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2, int> put_AnchorPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_CenterPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2, int> put_CenterPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionColorGradientStopCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionColorGradientStopCollection*,
            int> get_ColorStops;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionGradientExtendMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionGradientExtendMode*, int> get_ExtendMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionGradientExtendMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionGradientExtendMode, int> put_ExtendMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionColorSpace *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionColorSpace*, int> get_InterpolationSpace;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionColorSpace) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionColorSpace, int> put_InterpolationSpace;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_Offset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2, int> put_Offset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_RotationAngle;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_RotationAngle;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_RotationAngleInDegrees;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_RotationAngleInDegrees;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_Scale;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2, int> put_Scale;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Matrix3x2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Matrix3x2*, int> get_TransformMatrix;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Matrix3x2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Matrix3x2, int> put_TransformMatrix;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionGradientBrush"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionGradientBrush(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionGradientBrush"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionGradientBrush(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionGradientBrush(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionGradientBrush"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionGradientBrush"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionGradientBrush value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionGradientBrush"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionGradientBrush(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionGradientBrush(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionGradientBrush"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionGradientBrush"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionGradientBrush value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
