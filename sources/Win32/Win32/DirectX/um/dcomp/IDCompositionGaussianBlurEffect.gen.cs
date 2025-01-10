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

[Guid("45D4D0B7-1BD4-454E-8894-2BFA68443033")]
[NativeTypeName("struct IDCompositionGaussianBlurEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionGaussianBlurEffect
    : IDCompositionGaussianBlurEffect.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionGaussianBlurEffect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionGaussianBlurEffect, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionGaussianBlurEffect, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionGaussianBlurEffect, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown input, uint flags)
    {
        return (
            (delegate* unmanaged<IDCompositionGaussianBlurEffect, uint, IUnknown, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, index, input, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetStandardDeviation(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionGaussianBlurEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[4]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStandardDeviation(float amount)
    {
        return ((delegate* unmanaged<IDCompositionGaussianBlurEffect, float, int>)((*lpVtbl)[5]))(
            this,
            amount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetBorderMode(D2D1_BORDER_MODE mode)
    {
        return (
            (delegate* unmanaged<IDCompositionGaussianBlurEffect, D2D1_BORDER_MODE, int>)(
                (*lpVtbl)[6]
            )
        )(this, mode);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetStandardDeviation(IDCompositionAnimation animation);

        [VtblIndex(5)]
        HRESULT SetStandardDeviation(float amount);

        [VtblIndex(6)]
        HRESULT SetBorderMode(D2D1_BORDER_MODE mode);
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
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetStandardDeviation;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetStandardDeviation1;

        [NativeTypeName(
            "HRESULT (D2D1_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_BORDER_MODE, int> SetBorderMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionGaussianBlurEffect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionGaussianBlurEffect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> to <see cref = "IDCompositionGaussianBlurEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionGaussianBlurEffect(
        Silk.NET.DirectX.IDCompositionFilterEffect value
    )
    {
        return new IDCompositionGaussianBlurEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionGaussianBlurEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionGaussianBlurEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionFilterEffect(
        IDCompositionGaussianBlurEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionFilterEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionGaussianBlurEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionGaussianBlurEffect(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionGaussianBlurEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionGaussianBlurEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionGaussianBlurEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionGaussianBlurEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionGaussianBlurEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionGaussianBlurEffect(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionGaussianBlurEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionGaussianBlurEffect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionGaussianBlurEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionGaussianBlurEffect value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
