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

[Guid("9B7E82E2-69C5-4EB4-A5F5-A7033F5132CD")]
[NativeTypeName("struct IDCompositionTableTransferEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionTableTransferEffect
    : IDCompositionTableTransferEffect.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionTableTransferEffect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionTableTransferEffect, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionTableTransferEffect, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionTableTransferEffect, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown input, uint flags)
    {
        return (
            (delegate* unmanaged<IDCompositionTableTransferEffect, uint, IUnknown, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, index, input, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetRedTable([NativeTypeName("const float *")] float* tableValues, uint count)
    {
        return (
            (delegate* unmanaged<IDCompositionTableTransferEffect, float*, uint, int>)((*lpVtbl)[4])
        )(this, tableValues, count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetGreenTable([NativeTypeName("const float *")] float* tableValues, uint count)
    {
        return (
            (delegate* unmanaged<IDCompositionTableTransferEffect, float*, uint, int>)((*lpVtbl)[5])
        )(this, tableValues, count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetBlueTable([NativeTypeName("const float *")] float* tableValues, uint count)
    {
        return (
            (delegate* unmanaged<IDCompositionTableTransferEffect, float*, uint, int>)((*lpVtbl)[6])
        )(this, tableValues, count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetAlphaTable([NativeTypeName("const float *")] float* tableValues, uint count)
    {
        return (
            (delegate* unmanaged<IDCompositionTableTransferEffect, float*, uint, int>)((*lpVtbl)[7])
        )(this, tableValues, count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetRedDisable(BOOL redDisable)
    {
        return ((delegate* unmanaged<IDCompositionTableTransferEffect, BOOL, int>)((*lpVtbl)[8]))(
            this,
            redDisable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetGreenDisable(BOOL greenDisable)
    {
        return ((delegate* unmanaged<IDCompositionTableTransferEffect, BOOL, int>)((*lpVtbl)[9]))(
            this,
            greenDisable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetBlueDisable(BOOL blueDisable)
    {
        return ((delegate* unmanaged<IDCompositionTableTransferEffect, BOOL, int>)((*lpVtbl)[10]))(
            this,
            blueDisable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetAlphaDisable(BOOL alphaDisable)
    {
        return ((delegate* unmanaged<IDCompositionTableTransferEffect, BOOL, int>)((*lpVtbl)[11]))(
            this,
            alphaDisable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetClampOutput(BOOL clampOutput)
    {
        return ((delegate* unmanaged<IDCompositionTableTransferEffect, BOOL, int>)((*lpVtbl)[12]))(
            this,
            clampOutput
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetRedTableValue(uint index, IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<
                IDCompositionTableTransferEffect,
                uint,
                IDCompositionAnimation,
                int>)((*lpVtbl)[13])
        )(this, index, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetRedTableValue(uint index, float value)
    {
        return (
            (delegate* unmanaged<IDCompositionTableTransferEffect, uint, float, int>)((*lpVtbl)[14])
        )(this, index, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetGreenTableValue(uint index, IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<
                IDCompositionTableTransferEffect,
                uint,
                IDCompositionAnimation,
                int>)((*lpVtbl)[15])
        )(this, index, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetGreenTableValue(uint index, float value)
    {
        return (
            (delegate* unmanaged<IDCompositionTableTransferEffect, uint, float, int>)((*lpVtbl)[16])
        )(this, index, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetBlueTableValue(uint index, IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<
                IDCompositionTableTransferEffect,
                uint,
                IDCompositionAnimation,
                int>)((*lpVtbl)[17])
        )(this, index, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetBlueTableValue(uint index, float value)
    {
        return (
            (delegate* unmanaged<IDCompositionTableTransferEffect, uint, float, int>)((*lpVtbl)[18])
        )(this, index, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetAlphaTableValue(uint index, IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<
                IDCompositionTableTransferEffect,
                uint,
                IDCompositionAnimation,
                int>)((*lpVtbl)[19])
        )(this, index, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetAlphaTableValue(uint index, float value)
    {
        return (
            (delegate* unmanaged<IDCompositionTableTransferEffect, uint, float, int>)((*lpVtbl)[20])
        )(this, index, value);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetRedTable([NativeTypeName("const float *")] float* tableValues, uint count);

        [VtblIndex(5)]
        HRESULT SetGreenTable([NativeTypeName("const float *")] float* tableValues, uint count);

        [VtblIndex(6)]
        HRESULT SetBlueTable([NativeTypeName("const float *")] float* tableValues, uint count);

        [VtblIndex(7)]
        HRESULT SetAlphaTable([NativeTypeName("const float *")] float* tableValues, uint count);

        [VtblIndex(8)]
        HRESULT SetRedDisable(BOOL redDisable);

        [VtblIndex(9)]
        HRESULT SetGreenDisable(BOOL greenDisable);

        [VtblIndex(10)]
        HRESULT SetBlueDisable(BOOL blueDisable);

        [VtblIndex(11)]
        HRESULT SetAlphaDisable(BOOL alphaDisable);

        [VtblIndex(12)]
        HRESULT SetClampOutput(BOOL clampOutput);

        [VtblIndex(13)]
        HRESULT SetRedTableValue(uint index, IDCompositionAnimation animation);

        [VtblIndex(14)]
        HRESULT SetRedTableValue(uint index, float value);

        [VtblIndex(15)]
        HRESULT SetGreenTableValue(uint index, IDCompositionAnimation animation);

        [VtblIndex(16)]
        HRESULT SetGreenTableValue(uint index, float value);

        [VtblIndex(17)]
        HRESULT SetBlueTableValue(uint index, IDCompositionAnimation animation);

        [VtblIndex(18)]
        HRESULT SetBlueTableValue(uint index, float value);

        [VtblIndex(19)]
        HRESULT SetAlphaTableValue(uint index, IDCompositionAnimation animation);

        [VtblIndex(20)]
        HRESULT SetAlphaTableValue(uint index, float value);
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
            "HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float*, uint, int> SetRedTable;

        [NativeTypeName(
            "HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float*, uint, int> SetGreenTable;

        [NativeTypeName(
            "HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float*, uint, int> SetBlueTable;

        [NativeTypeName(
            "HRESULT (const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float*, uint, int> SetAlphaTable;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetRedDisable;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetGreenDisable;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetBlueDisable;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetAlphaDisable;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetClampOutput;

        [NativeTypeName(
            "HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDCompositionAnimation, int> SetRedTableValue;

        [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, int> SetRedTableValue1;

        [NativeTypeName(
            "HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDCompositionAnimation, int> SetGreenTableValue;

        [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, int> SetGreenTableValue1;

        [NativeTypeName(
            "HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDCompositionAnimation, int> SetBlueTableValue;

        [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, int> SetBlueTableValue1;

        [NativeTypeName(
            "HRESULT (UINT, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDCompositionAnimation, int> SetAlphaTableValue;

        [NativeTypeName("HRESULT (UINT, float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, int> SetAlphaTableValue1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionTableTransferEffect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionTableTransferEffect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> to <see cref = "IDCompositionTableTransferEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionTableTransferEffect(
        Silk.NET.DirectX.IDCompositionFilterEffect value
    )
    {
        return new IDCompositionTableTransferEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionTableTransferEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionTableTransferEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionFilterEffect(
        IDCompositionTableTransferEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionFilterEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionTableTransferEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionTableTransferEffect(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionTableTransferEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionTableTransferEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionTableTransferEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionTableTransferEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionTableTransferEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionTableTransferEffect(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDCompositionTableTransferEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionTableTransferEffect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionTableTransferEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDCompositionTableTransferEffect value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
