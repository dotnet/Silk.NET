// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("2CD906AC-12E2-11DC-9FED-001143A055F9")]
[NativeTypeName("struct ID2D1RadialGradientBrush : ID2D1Brush")]
[NativeInheritance("ID2D1Brush")]
public unsafe partial struct ID2D1RadialGradientBrush
    : ID2D1RadialGradientBrush.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1RadialGradientBrush));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1RadialGradientBrush, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1RadialGradientBrush, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1RadialGradientBrush, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1RadialGradientBrush, ID2D1Factory*, void>)((*lpVtbl)[3]))(
            this,
            factory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetOpacity(float opacity)
    {
        ((delegate* unmanaged<ID2D1RadialGradientBrush, float, void>)((*lpVtbl)[4]))(this, opacity);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetTransform(
        [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform
    )
    {
        ((delegate* unmanaged<ID2D1RadialGradientBrush, D2D_MATRIX_3X2_F*, void>)((*lpVtbl)[5]))(
            this,
            transform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public float GetOpacity()
    {
        return ((delegate* unmanaged<ID2D1RadialGradientBrush, float>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged<ID2D1RadialGradientBrush, D2D_MATRIX_3X2_F*, void>)((*lpVtbl)[7]))(
            this,
            transform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void SetCenter([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center)
    {
        ((delegate* unmanaged<ID2D1RadialGradientBrush, D2D_POINT_2F, void>)((*lpVtbl)[8]))(
            this,
            center
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void SetGradientOriginOffset(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F gradientOriginOffset
    )
    {
        ((delegate* unmanaged<ID2D1RadialGradientBrush, D2D_POINT_2F, void>)((*lpVtbl)[9]))(
            this,
            gradientOriginOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void SetRadiusX(float radiusX)
    {
        ((delegate* unmanaged<ID2D1RadialGradientBrush, float, void>)((*lpVtbl)[10]))(
            this,
            radiusX
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void SetRadiusY(float radiusY)
    {
        ((delegate* unmanaged<ID2D1RadialGradientBrush, float, void>)((*lpVtbl)[11]))(
            this,
            radiusY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F GetCenter()
    {
        D2D_POINT_2F result;
        return *(
            (delegate* unmanaged<ID2D1RadialGradientBrush, D2D_POINT_2F*, D2D_POINT_2F*>)(
                (*lpVtbl)[12]
            )
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F GetGradientOriginOffset()
    {
        D2D_POINT_2F result;
        return *(
            (delegate* unmanaged<ID2D1RadialGradientBrush, D2D_POINT_2F*, D2D_POINT_2F*>)(
                (*lpVtbl)[13]
            )
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public float GetRadiusX()
    {
        return ((delegate* unmanaged<ID2D1RadialGradientBrush, float>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public float GetRadiusY()
    {
        return ((delegate* unmanaged<ID2D1RadialGradientBrush, float>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void GetGradientStopCollection(ID2D1GradientStopCollection* gradientStopCollection)
    {
        (
            (delegate* unmanaged<ID2D1RadialGradientBrush, ID2D1GradientStopCollection*, void>)(
                (*lpVtbl)[16]
            )
        )(this, gradientStopCollection);
    }

    public interface Interface : ID2D1Brush.Interface
    {
        [VtblIndex(8)]
        void SetCenter([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center);

        [VtblIndex(9)]
        void SetGradientOriginOffset(
            [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F gradientOriginOffset
        );

        [VtblIndex(10)]
        void SetRadiusX(float radiusX);

        [VtblIndex(11)]
        void SetRadiusY(float radiusY);

        [VtblIndex(12)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        D2D_POINT_2F GetCenter();

        [VtblIndex(13)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        D2D_POINT_2F GetGradientOriginOffset();

        [VtblIndex(14)]
        float GetRadiusX();

        [VtblIndex(15)]
        float GetRadiusY();

        [VtblIndex(16)]
        void GetGradientStopCollection(ID2D1GradientStopCollection* gradientStopCollection);
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
            "void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Factory*, void> GetFactory;

        [NativeTypeName("void (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, void> SetOpacity;

        [NativeTypeName(
            "void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, void> SetTransform;

        [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetOpacity;

        [NativeTypeName(
            "void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, void> GetTransform;

        [NativeTypeName("void (D2D1_POINT_2F) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F, void> SetCenter;

        [NativeTypeName("void (D2D1_POINT_2F) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F, void> SetGradientOriginOffset;

        [NativeTypeName("void (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, void> SetRadiusX;

        [NativeTypeName("void (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, void> SetRadiusY;

        [NativeTypeName("D2D1_POINT_2F () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F*, D2D_POINT_2F*> GetCenter;

        [NativeTypeName("D2D1_POINT_2F () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F*, D2D_POINT_2F*> GetGradientOriginOffset;

        [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetRadiusX;

        [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetRadiusY;

        [NativeTypeName(
            "void (ID2D1GradientStopCollection **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1GradientStopCollection*,
            void> GetGradientStopCollection;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1RadialGradientBrush"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1RadialGradientBrush(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Brush"/> to <see cref = "ID2D1RadialGradientBrush"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Brush"/> instance to be converted </param>
    public static explicit operator ID2D1RadialGradientBrush(Silk.NET.DirectX.ID2D1Brush value)
    {
        return new ID2D1RadialGradientBrush(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1RadialGradientBrush"/> to <see cref = "Silk.NET.DirectX.ID2D1Brush"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1RadialGradientBrush"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Brush(ID2D1RadialGradientBrush value)
    {
        return new Silk.NET.DirectX.ID2D1Brush(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1RadialGradientBrush"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1RadialGradientBrush(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1RadialGradientBrush(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1RadialGradientBrush"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1RadialGradientBrush"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1RadialGradientBrush value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1RadialGradientBrush"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1RadialGradientBrush(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1RadialGradientBrush(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1RadialGradientBrush"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1RadialGradientBrush"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1RadialGradientBrush value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
