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

[Guid("3B67DFA8-E3DD-4E61-B640-46C2F3D739DC")]
[NativeTypeName("struct IDCompositionArithmeticCompositeEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionArithmeticCompositeEffect
    : IDCompositionArithmeticCompositeEffect.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionArithmeticCompositeEffect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionArithmeticCompositeEffect, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown input, uint flags)
    {
        return (
            (delegate* unmanaged<
                IDCompositionArithmeticCompositeEffect,
                uint,
                IUnknown,
                uint,
                int>)((*lpVtbl)[3])
        )(this, index, input, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetCoefficients(
        [NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* coefficients
    )
    {
        return (
            (delegate* unmanaged<IDCompositionArithmeticCompositeEffect, D2D_VECTOR_4F*, int>)(
                (*lpVtbl)[4]
            )
        )(this, coefficients);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetClampOutput(BOOL clampoutput)
    {
        return (
            (delegate* unmanaged<IDCompositionArithmeticCompositeEffect, BOOL, int>)((*lpVtbl)[5])
        )(this, clampoutput);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCoefficient1(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<
                IDCompositionArithmeticCompositeEffect,
                IDCompositionAnimation,
                int>)((*lpVtbl)[6])
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetCoefficient1(float Coeffcient1)
    {
        return (
            (delegate* unmanaged<IDCompositionArithmeticCompositeEffect, float, int>)((*lpVtbl)[7])
        )(this, Coeffcient1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetCoefficient2(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<
                IDCompositionArithmeticCompositeEffect,
                IDCompositionAnimation,
                int>)((*lpVtbl)[8])
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetCoefficient2(float Coefficient2)
    {
        return (
            (delegate* unmanaged<IDCompositionArithmeticCompositeEffect, float, int>)((*lpVtbl)[9])
        )(this, Coefficient2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetCoefficient3(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<
                IDCompositionArithmeticCompositeEffect,
                IDCompositionAnimation,
                int>)((*lpVtbl)[10])
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetCoefficient3(float Coefficient3)
    {
        return (
            (delegate* unmanaged<IDCompositionArithmeticCompositeEffect, float, int>)((*lpVtbl)[11])
        )(this, Coefficient3);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetCoefficient4(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<
                IDCompositionArithmeticCompositeEffect,
                IDCompositionAnimation,
                int>)((*lpVtbl)[12])
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetCoefficient4(float Coefficient4)
    {
        return (
            (delegate* unmanaged<IDCompositionArithmeticCompositeEffect, float, int>)((*lpVtbl)[13])
        )(this, Coefficient4);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetCoefficients(
            [NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* coefficients
        );

        [VtblIndex(5)]
        HRESULT SetClampOutput(BOOL clampoutput);

        [VtblIndex(6)]
        HRESULT SetCoefficient1(IDCompositionAnimation animation);

        [VtblIndex(7)]
        HRESULT SetCoefficient1(float Coeffcient1);

        [VtblIndex(8)]
        HRESULT SetCoefficient2(IDCompositionAnimation animation);

        [VtblIndex(9)]
        HRESULT SetCoefficient2(float Coefficient2);

        [VtblIndex(10)]
        HRESULT SetCoefficient3(IDCompositionAnimation animation);

        [VtblIndex(11)]
        HRESULT SetCoefficient3(float Coefficient3);

        [VtblIndex(12)]
        HRESULT SetCoefficient4(IDCompositionAnimation animation);

        [VtblIndex(13)]
        HRESULT SetCoefficient4(float Coefficient4);
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
            "HRESULT (const D2D1_VECTOR_4F &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_VECTOR_4F*, int> SetCoefficients;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetClampOutput;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetCoefficient1;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCoefficient11;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetCoefficient2;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCoefficient21;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetCoefficient3;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCoefficient31;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetCoefficient4;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCoefficient41;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionArithmeticCompositeEffect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionArithmeticCompositeEffect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> to <see cref = "IDCompositionArithmeticCompositeEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionArithmeticCompositeEffect(
        Silk.NET.DirectX.IDCompositionFilterEffect value
    )
    {
        return new IDCompositionArithmeticCompositeEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionArithmeticCompositeEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionArithmeticCompositeEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionFilterEffect(
        IDCompositionArithmeticCompositeEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionFilterEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionArithmeticCompositeEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionArithmeticCompositeEffect(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionArithmeticCompositeEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionArithmeticCompositeEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionArithmeticCompositeEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionArithmeticCompositeEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionArithmeticCompositeEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionArithmeticCompositeEffect(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDCompositionArithmeticCompositeEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionArithmeticCompositeEffect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionArithmeticCompositeEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDCompositionArithmeticCompositeEffect value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
