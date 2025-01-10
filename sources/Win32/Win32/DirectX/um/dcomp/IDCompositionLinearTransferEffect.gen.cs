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

[Guid("4305EE5B-C4A0-4C88-9385-67124E017683")]
[NativeTypeName("struct IDCompositionLinearTransferEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionLinearTransferEffect
    : IDCompositionLinearTransferEffect.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionLinearTransferEffect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown input, uint flags)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, uint, IUnknown, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, index, input, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetRedYIntercept(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[4]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetRedYIntercept(float redYIntercept)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect, float, int>)((*lpVtbl)[5]))(
            this,
            redYIntercept
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetRedSlope(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[6]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRedSlope(float redSlope)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect, float, int>)((*lpVtbl)[7]))(
            this,
            redSlope
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetRedDisable(BOOL redDisable)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect, BOOL, int>)((*lpVtbl)[8]))(
            this,
            redDisable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetGreenYIntercept(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[9]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetGreenYIntercept(float greenYIntercept)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, float, int>)((*lpVtbl)[10])
        )(this, greenYIntercept);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetGreenSlope(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[11]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetGreenSlope(float greenSlope)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, float, int>)((*lpVtbl)[12])
        )(this, greenSlope);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetGreenDisable(BOOL greenDisable)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect, BOOL, int>)((*lpVtbl)[13]))(
            this,
            greenDisable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetBlueYIntercept(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[14]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetBlueYIntercept(float blueYIntercept)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, float, int>)((*lpVtbl)[15])
        )(this, blueYIntercept);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetBlueSlope(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[16]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetBlueSlope(float blueSlope)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, float, int>)((*lpVtbl)[17])
        )(this, blueSlope);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetBlueDisable(BOOL blueDisable)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect, BOOL, int>)((*lpVtbl)[18]))(
            this,
            blueDisable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetAlphaYIntercept(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[19]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetAlphaYIntercept(float alphaYIntercept)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, float, int>)((*lpVtbl)[20])
        )(this, alphaYIntercept);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetAlphaSlope(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[21]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetAlphaSlope(float alphaSlope)
    {
        return (
            (delegate* unmanaged<IDCompositionLinearTransferEffect, float, int>)((*lpVtbl)[22])
        )(this, alphaSlope);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetAlphaDisable(BOOL alphaDisable)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect, BOOL, int>)((*lpVtbl)[23]))(
            this,
            alphaDisable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetClampOutput(BOOL clampOutput)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect, BOOL, int>)((*lpVtbl)[24]))(
            this,
            clampOutput
        );
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetRedYIntercept(IDCompositionAnimation animation);

        [VtblIndex(5)]
        HRESULT SetRedYIntercept(float redYIntercept);

        [VtblIndex(6)]
        HRESULT SetRedSlope(IDCompositionAnimation animation);

        [VtblIndex(7)]
        HRESULT SetRedSlope(float redSlope);

        [VtblIndex(8)]
        HRESULT SetRedDisable(BOOL redDisable);

        [VtblIndex(9)]
        HRESULT SetGreenYIntercept(IDCompositionAnimation animation);

        [VtblIndex(10)]
        HRESULT SetGreenYIntercept(float greenYIntercept);

        [VtblIndex(11)]
        HRESULT SetGreenSlope(IDCompositionAnimation animation);

        [VtblIndex(12)]
        HRESULT SetGreenSlope(float greenSlope);

        [VtblIndex(13)]
        HRESULT SetGreenDisable(BOOL greenDisable);

        [VtblIndex(14)]
        HRESULT SetBlueYIntercept(IDCompositionAnimation animation);

        [VtblIndex(15)]
        HRESULT SetBlueYIntercept(float blueYIntercept);

        [VtblIndex(16)]
        HRESULT SetBlueSlope(IDCompositionAnimation animation);

        [VtblIndex(17)]
        HRESULT SetBlueSlope(float blueSlope);

        [VtblIndex(18)]
        HRESULT SetBlueDisable(BOOL blueDisable);

        [VtblIndex(19)]
        HRESULT SetAlphaYIntercept(IDCompositionAnimation animation);

        [VtblIndex(20)]
        HRESULT SetAlphaYIntercept(float alphaYIntercept);

        [VtblIndex(21)]
        HRESULT SetAlphaSlope(IDCompositionAnimation animation);

        [VtblIndex(22)]
        HRESULT SetAlphaSlope(float alphaSlope);

        [VtblIndex(23)]
        HRESULT SetAlphaDisable(BOOL alphaDisable);

        [VtblIndex(24)]
        HRESULT SetClampOutput(BOOL clampOutput);
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
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetRedYIntercept;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetRedYIntercept1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetRedSlope;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetRedSlope1;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetRedDisable;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetGreenYIntercept;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetGreenYIntercept1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetGreenSlope;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetGreenSlope1;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetGreenDisable;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetBlueYIntercept;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBlueYIntercept1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetBlueSlope;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBlueSlope1;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetBlueDisable;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetAlphaYIntercept;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetAlphaYIntercept1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetAlphaSlope;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetAlphaSlope1;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetAlphaDisable;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetClampOutput;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionLinearTransferEffect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionLinearTransferEffect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> to <see cref = "IDCompositionLinearTransferEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionLinearTransferEffect(
        Silk.NET.DirectX.IDCompositionFilterEffect value
    )
    {
        return new IDCompositionLinearTransferEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionLinearTransferEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionLinearTransferEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionFilterEffect(
        IDCompositionLinearTransferEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionFilterEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionLinearTransferEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionLinearTransferEffect(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionLinearTransferEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionLinearTransferEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionLinearTransferEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionLinearTransferEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionLinearTransferEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionLinearTransferEffect(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDCompositionLinearTransferEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionLinearTransferEffect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionLinearTransferEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDCompositionLinearTransferEffect value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
