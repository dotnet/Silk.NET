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

[Guid("C1170A22-3CE2-4966-90D4-55408BFC84C4")]
[NativeTypeName("struct IDCompositionColorMatrixEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionColorMatrixEffect
    : IDCompositionColorMatrixEffect.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionColorMatrixEffect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionColorMatrixEffect, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionColorMatrixEffect, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionColorMatrixEffect, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown input, uint flags)
    {
        return (
            (delegate* unmanaged<IDCompositionColorMatrixEffect, uint, IUnknown, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, index, input, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetMatrix([NativeTypeName("const D2D1_MATRIX_5X4_F &")] D2D_MATRIX_5X4_F* matrix)
    {
        return (
            (delegate* unmanaged<IDCompositionColorMatrixEffect, D2D_MATRIX_5X4_F*, int>)(
                (*lpVtbl)[4]
            )
        )(this, matrix);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<
                IDCompositionColorMatrixEffect,
                int,
                int,
                IDCompositionAnimation,
                int>)((*lpVtbl)[5])
        )(this, row, column, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetMatrixElement(int row, int column, float value)
    {
        return (
            (delegate* unmanaged<IDCompositionColorMatrixEffect, int, int, float, int>)(
                (*lpVtbl)[6]
            )
        )(this, row, column, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetAlphaMode(D2D1_COLORMATRIX_ALPHA_MODE mode)
    {
        return (
            (delegate* unmanaged<IDCompositionColorMatrixEffect, D2D1_COLORMATRIX_ALPHA_MODE, int>)(
                (*lpVtbl)[7]
            )
        )(this, mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetClampOutput(BOOL clamp)
    {
        return ((delegate* unmanaged<IDCompositionColorMatrixEffect, BOOL, int>)((*lpVtbl)[8]))(
            this,
            clamp
        );
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetMatrix([NativeTypeName("const D2D1_MATRIX_5X4_F &")] D2D_MATRIX_5X4_F* matrix);

        [VtblIndex(5)]
        HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation animation);

        [VtblIndex(6)]
        HRESULT SetMatrixElement(int row, int column, float value);

        [VtblIndex(7)]
        HRESULT SetAlphaMode(D2D1_COLORMATRIX_ALPHA_MODE mode);

        [VtblIndex(8)]
        HRESULT SetClampOutput(BOOL clamp);
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
            "HRESULT (const D2D1_MATRIX_5X4_F &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_5X4_F*, int> SetMatrix;

        [NativeTypeName(
            "HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, int, IDCompositionAnimation, int> SetMatrixElement;

        [NativeTypeName(
            "HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, int, float, int> SetMatrixElement1;

        [NativeTypeName(
            "HRESULT (D2D1_COLORMATRIX_ALPHA_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_COLORMATRIX_ALPHA_MODE, int> SetAlphaMode;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetClampOutput;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionColorMatrixEffect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionColorMatrixEffect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> to <see cref = "IDCompositionColorMatrixEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionColorMatrixEffect(
        Silk.NET.DirectX.IDCompositionFilterEffect value
    )
    {
        return new IDCompositionColorMatrixEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionColorMatrixEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionColorMatrixEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionFilterEffect(
        IDCompositionColorMatrixEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionFilterEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionColorMatrixEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionColorMatrixEffect(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionColorMatrixEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionColorMatrixEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionColorMatrixEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionColorMatrixEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionColorMatrixEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionColorMatrixEffect(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionColorMatrixEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionColorMatrixEffect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionColorMatrixEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionColorMatrixEffect value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
