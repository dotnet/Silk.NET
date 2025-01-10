// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("0B74B9E8-CDD6-492F-BBBC-5ED32157026D")]
[NativeTypeName("struct IDCompositionAffineTransform2DEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionAffineTransform2DEffect
    : IDCompositionAffineTransform2DEffect.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionAffineTransform2DEffect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionAffineTransform2DEffect, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown input, uint flags)
    {
        return (
            (delegate* unmanaged<IDCompositionAffineTransform2DEffect, uint, IUnknown, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, index, input, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetInterpolationMode(D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE interpolationMode)
    {
        return (
            (delegate* unmanaged<
                IDCompositionAffineTransform2DEffect,
                D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE,
                int>)((*lpVtbl)[4])
        )(this, interpolationMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetBorderMode(D2D1_BORDER_MODE borderMode)
    {
        return (
            (delegate* unmanaged<IDCompositionAffineTransform2DEffect, D2D1_BORDER_MODE, int>)(
                (*lpVtbl)[5]
            )
        )(this, borderMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTransformMatrix(
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* transformMatrix
    )
    {
        return (
            (delegate* unmanaged<IDCompositionAffineTransform2DEffect, D2D_MATRIX_3X2_F*, int>)(
                (*lpVtbl)[6]
            )
        )(this, transformMatrix);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetTransformMatrixElement(int row, int column, IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<
                IDCompositionAffineTransform2DEffect,
                int,
                int,
                IDCompositionAnimation,
                int>)((*lpVtbl)[7])
        )(this, row, column, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTransformMatrixElement(int row, int column, float value)
    {
        return (
            (delegate* unmanaged<IDCompositionAffineTransform2DEffect, int, int, float, int>)(
                (*lpVtbl)[8]
            )
        )(this, row, column, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetSharpness(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<
                IDCompositionAffineTransform2DEffect,
                IDCompositionAnimation,
                int>)((*lpVtbl)[9])
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetSharpness(float sharpness)
    {
        return (
            (delegate* unmanaged<IDCompositionAffineTransform2DEffect, float, int>)((*lpVtbl)[10])
        )(this, sharpness);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetInterpolationMode(D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE interpolationMode);

        [VtblIndex(5)]
        HRESULT SetBorderMode(D2D1_BORDER_MODE borderMode);

        [VtblIndex(6)]
        HRESULT SetTransformMatrix(
            [NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* transformMatrix
        );

        [VtblIndex(7)]
        HRESULT SetTransformMatrixElement(int row, int column, IDCompositionAnimation animation);

        [VtblIndex(8)]
        HRESULT SetTransformMatrixElement(int row, int column, float value);

        [VtblIndex(9)]
        HRESULT SetSharpness(IDCompositionAnimation animation);

        [VtblIndex(10)]
        HRESULT SetSharpness(float sharpness);
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
            "HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IUnknown, uint, int> SetInput;

        [NativeTypeName(
            "HRESULT (D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE,
            int> SetInterpolationMode;

        [NativeTypeName(
            "HRESULT (D2D1_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_BORDER_MODE, int> SetBorderMode;

        [NativeTypeName(
            "HRESULT (const D2D1_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, int> SetTransformMatrix;

        [NativeTypeName(
            "HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            int,
            IDCompositionAnimation,
            int> SetTransformMatrixElement;

        [NativeTypeName(
            "HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, int, float, int> SetTransformMatrixElement1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetSharpness;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetSharpness1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionAffineTransform2DEffect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionAffineTransform2DEffect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> to <see cref = "IDCompositionAffineTransform2DEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionAffineTransform2DEffect(
        Silk.NET.DirectX.IDCompositionFilterEffect value
    )
    {
        return new IDCompositionAffineTransform2DEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionAffineTransform2DEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionAffineTransform2DEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionFilterEffect(
        IDCompositionAffineTransform2DEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionFilterEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionAffineTransform2DEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionAffineTransform2DEffect(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionAffineTransform2DEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionAffineTransform2DEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionAffineTransform2DEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionAffineTransform2DEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionAffineTransform2DEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionAffineTransform2DEffect(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDCompositionAffineTransform2DEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionAffineTransform2DEffect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionAffineTransform2DEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDCompositionAffineTransform2DEffect value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
