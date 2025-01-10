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

[Guid("A6A55BDA-C09C-49F3-9193-A41922C89715")]
[NativeTypeName("struct IDCompositionTurbulenceEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionTurbulenceEffect
    : IDCompositionTurbulenceEffect.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionTurbulenceEffect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionTurbulenceEffect, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionTurbulenceEffect, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionTurbulenceEffect, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown input, uint flags)
    {
        return (
            (delegate* unmanaged<IDCompositionTurbulenceEffect, uint, IUnknown, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, index, input, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOffset([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* offset)
    {
        return (
            (delegate* unmanaged<IDCompositionTurbulenceEffect, D2D_VECTOR_2F*, int>)((*lpVtbl)[4])
        )(this, offset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetBaseFrequency(
        [NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* frequency
    )
    {
        return (
            (delegate* unmanaged<IDCompositionTurbulenceEffect, D2D_VECTOR_2F*, int>)((*lpVtbl)[5])
        )(this, frequency);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* size)
    {
        return (
            (delegate* unmanaged<IDCompositionTurbulenceEffect, D2D_VECTOR_2F*, int>)((*lpVtbl)[6])
        )(this, size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetNumOctaves(uint numOctaves)
    {
        return ((delegate* unmanaged<IDCompositionTurbulenceEffect, uint, int>)((*lpVtbl)[7]))(
            this,
            numOctaves
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSeed(uint seed)
    {
        return ((delegate* unmanaged<IDCompositionTurbulenceEffect, uint, int>)((*lpVtbl)[8]))(
            this,
            seed
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetNoise(D2D1_TURBULENCE_NOISE noise)
    {
        return (
            (delegate* unmanaged<IDCompositionTurbulenceEffect, D2D1_TURBULENCE_NOISE, int>)(
                (*lpVtbl)[9]
            )
        )(this, noise);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetStitchable(BOOL stitchable)
    {
        return ((delegate* unmanaged<IDCompositionTurbulenceEffect, BOOL, int>)((*lpVtbl)[10]))(
            this,
            stitchable
        );
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetOffset([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* offset);

        [VtblIndex(5)]
        HRESULT SetBaseFrequency(
            [NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* frequency
        );

        [VtblIndex(6)]
        HRESULT SetSize([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* size);

        [VtblIndex(7)]
        HRESULT SetNumOctaves(uint numOctaves);

        [VtblIndex(8)]
        HRESULT SetSeed(uint seed);

        [VtblIndex(9)]
        HRESULT SetNoise(D2D1_TURBULENCE_NOISE noise);

        [VtblIndex(10)]
        HRESULT SetStitchable(BOOL stitchable);
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
            "HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_VECTOR_2F*, int> SetOffset;

        [NativeTypeName(
            "HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_VECTOR_2F*, int> SetBaseFrequency;

        [NativeTypeName(
            "HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_VECTOR_2F*, int> SetSize;

        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetNumOctaves;

        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetSeed;

        [NativeTypeName(
            "HRESULT (D2D1_TURBULENCE_NOISE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_TURBULENCE_NOISE, int> SetNoise;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetStitchable;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionTurbulenceEffect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionTurbulenceEffect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> to <see cref = "IDCompositionTurbulenceEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionTurbulenceEffect(
        Silk.NET.DirectX.IDCompositionFilterEffect value
    )
    {
        return new IDCompositionTurbulenceEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionTurbulenceEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionTurbulenceEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionFilterEffect(
        IDCompositionTurbulenceEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionFilterEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionTurbulenceEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionTurbulenceEffect(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionTurbulenceEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionTurbulenceEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionTurbulenceEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionTurbulenceEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionTurbulenceEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionTurbulenceEffect(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionTurbulenceEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionTurbulenceEffect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionTurbulenceEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionTurbulenceEffect value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
