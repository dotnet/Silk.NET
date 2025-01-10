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

[Guid("401B61BB-0007-4363-B1F3-6BCC003FB83E")]
[NativeTypeName("struct ICompositionSpriteShape : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionSpriteShape
    : ICompositionSpriteShape.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionSpriteShape));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionSpriteShape, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FillBrush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")]
            ICompositionBrush* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, ICompositionBrush*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_FillBrush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")]
            ICompositionBrush value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, ICompositionBrush, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Geometry(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry **")]
            ICompositionGeometry* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, ICompositionGeometry*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Geometry(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry *")]
            ICompositionGeometry value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, ICompositionGeometry, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsStrokeNonScaling([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, byte*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsStrokeNonScaling([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, byte, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_StrokeBrush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")]
            ICompositionBrush* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, ICompositionBrush*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_StrokeBrush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")]
            ICompositionBrush value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, ICompositionBrush, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_StrokeDashArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_float_t **")]
            IVector<float>** value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, IVector<float>**, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_StrokeDashCap(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeCap *")]
            CompositionStrokeCap* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, CompositionStrokeCap*, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_StrokeDashCap(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeCap")]
            CompositionStrokeCap value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, CompositionStrokeCap, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_StrokeDashOffset(float* value)
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, float*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_StrokeDashOffset(float value)
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, float, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_StrokeEndCap(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeCap *")]
            CompositionStrokeCap* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, CompositionStrokeCap*, int>)(
                (*lpVtbl)[19]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_StrokeEndCap(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeCap")]
            CompositionStrokeCap value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, CompositionStrokeCap, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_StrokeLineJoin(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeLineJoin *")]
            CompositionStrokeLineJoin* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, CompositionStrokeLineJoin*, int>)(
                (*lpVtbl)[21]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_StrokeLineJoin(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeLineJoin")]
            CompositionStrokeLineJoin value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, CompositionStrokeLineJoin, int>)(
                (*lpVtbl)[22]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_StrokeMiterLimit(float* value)
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, float*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_StrokeMiterLimit(float value)
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, float, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_StrokeStartCap(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeCap *")]
            CompositionStrokeCap* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, CompositionStrokeCap*, int>)(
                (*lpVtbl)[25]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_StrokeStartCap(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeCap")]
            CompositionStrokeCap value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSpriteShape, CompositionStrokeCap, int>)((*lpVtbl)[26])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_StrokeThickness(float* value)
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, float*, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_StrokeThickness(float value)
    {
        return ((delegate* unmanaged<ICompositionSpriteShape, float, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FillBrush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")]
                ICompositionBrush* value
        );

        [VtblIndex(7)]
        HRESULT put_FillBrush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")]
                ICompositionBrush value
        );

        [VtblIndex(8)]
        HRESULT get_Geometry(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry **")]
                ICompositionGeometry* value
        );

        [VtblIndex(9)]
        HRESULT put_Geometry(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry *")]
                ICompositionGeometry value
        );

        [VtblIndex(10)]
        HRESULT get_IsStrokeNonScaling([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsStrokeNonScaling([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_StrokeBrush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")]
                ICompositionBrush* value
        );

        [VtblIndex(13)]
        HRESULT put_StrokeBrush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")]
                ICompositionBrush value
        );

        [VtblIndex(14)]
        HRESULT get_StrokeDashArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_float_t **")]
                IVector<float>** value
        );

        [VtblIndex(15)]
        HRESULT get_StrokeDashCap(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeCap *")]
                CompositionStrokeCap* value
        );

        [VtblIndex(16)]
        HRESULT put_StrokeDashCap(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeCap")]
                CompositionStrokeCap value
        );

        [VtblIndex(17)]
        HRESULT get_StrokeDashOffset(float* value);

        [VtblIndex(18)]
        HRESULT put_StrokeDashOffset(float value);

        [VtblIndex(19)]
        HRESULT get_StrokeEndCap(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeCap *")]
                CompositionStrokeCap* value
        );

        [VtblIndex(20)]
        HRESULT put_StrokeEndCap(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeCap")]
                CompositionStrokeCap value
        );

        [VtblIndex(21)]
        HRESULT get_StrokeLineJoin(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeLineJoin *")]
                CompositionStrokeLineJoin* value
        );

        [VtblIndex(22)]
        HRESULT put_StrokeLineJoin(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeLineJoin")]
                CompositionStrokeLineJoin value
        );

        [VtblIndex(23)]
        HRESULT get_StrokeMiterLimit(float* value);

        [VtblIndex(24)]
        HRESULT put_StrokeMiterLimit(float value);

        [VtblIndex(25)]
        HRESULT get_StrokeStartCap(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeCap *")]
                CompositionStrokeCap* value
        );

        [VtblIndex(26)]
        HRESULT put_StrokeStartCap(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionStrokeCap")]
                CompositionStrokeCap value
        );

        [VtblIndex(27)]
        HRESULT get_StrokeThickness(float* value);

        [VtblIndex(28)]
        HRESULT put_StrokeThickness(float value);
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
            "HRESULT (ABI::Windows::UI::Composition::ICompositionBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionBrush*, int> get_FillBrush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionBrush *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionBrush, int> put_FillBrush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionGeometry **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionGeometry*, int> get_Geometry;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionGeometry *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionGeometry, int> put_Geometry;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsStrokeNonScaling;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsStrokeNonScaling;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionBrush*, int> get_StrokeBrush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionBrush *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionBrush, int> put_StrokeBrush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_float_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<float>**, int> get_StrokeDashArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionStrokeCap *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionStrokeCap*, int> get_StrokeDashCap;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionStrokeCap) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionStrokeCap, int> put_StrokeDashCap;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_StrokeDashOffset;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_StrokeDashOffset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionStrokeCap *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionStrokeCap*, int> get_StrokeEndCap;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionStrokeCap) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionStrokeCap, int> put_StrokeEndCap;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionStrokeLineJoin *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionStrokeLineJoin*, int> get_StrokeLineJoin;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionStrokeLineJoin) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionStrokeLineJoin, int> put_StrokeLineJoin;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_StrokeMiterLimit;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_StrokeMiterLimit;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionStrokeCap *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionStrokeCap*, int> get_StrokeStartCap;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionStrokeCap) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionStrokeCap, int> put_StrokeStartCap;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_StrokeThickness;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_StrokeThickness;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionSpriteShape"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionSpriteShape(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionSpriteShape"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionSpriteShape(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionSpriteShape(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionSpriteShape"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionSpriteShape"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionSpriteShape value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionSpriteShape"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionSpriteShape(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionSpriteShape(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionSpriteShape"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionSpriteShape"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionSpriteShape value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
