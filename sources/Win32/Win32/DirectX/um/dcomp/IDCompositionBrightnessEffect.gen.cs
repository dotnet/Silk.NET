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

[Guid("6027496E-CB3A-49AB-934F-D798DA4F7DA6")]
[NativeTypeName("struct IDCompositionBrightnessEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionBrightnessEffect
    : IDCompositionBrightnessEffect.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionBrightnessEffect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionBrightnessEffect, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown input, uint flags)
    {
        return (
            (delegate* unmanaged<IDCompositionBrightnessEffect, uint, IUnknown, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, index, input, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetWhitePoint(
        [NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* whitePoint
    )
    {
        return (
            (delegate* unmanaged<IDCompositionBrightnessEffect, D2D_VECTOR_2F*, int>)((*lpVtbl)[4])
        )(this, whitePoint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetBlackPoint(
        [NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* blackPoint
    )
    {
        return (
            (delegate* unmanaged<IDCompositionBrightnessEffect, D2D_VECTOR_2F*, int>)((*lpVtbl)[5])
        )(this, blackPoint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetWhitePointX(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionBrightnessEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[6]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetWhitePointX(float whitePointX)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect, float, int>)((*lpVtbl)[7]))(
            this,
            whitePointX
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetWhitePointY(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionBrightnessEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[8]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetWhitePointY(float whitePointY)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect, float, int>)((*lpVtbl)[9]))(
            this,
            whitePointY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetBlackPointX(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionBrightnessEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[10]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetBlackPointX(float blackPointX)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect, float, int>)((*lpVtbl)[11]))(
            this,
            blackPointX
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetBlackPointY(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionBrightnessEffect, IDCompositionAnimation, int>)(
                (*lpVtbl)[12]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetBlackPointY(float blackPointY)
    {
        return ((delegate* unmanaged<IDCompositionBrightnessEffect, float, int>)((*lpVtbl)[13]))(
            this,
            blackPointY
        );
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetWhitePoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* whitePoint);

        [VtblIndex(5)]
        HRESULT SetBlackPoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* blackPoint);

        [VtblIndex(6)]
        HRESULT SetWhitePointX(IDCompositionAnimation animation);

        [VtblIndex(7)]
        HRESULT SetWhitePointX(float whitePointX);

        [VtblIndex(8)]
        HRESULT SetWhitePointY(IDCompositionAnimation animation);

        [VtblIndex(9)]
        HRESULT SetWhitePointY(float whitePointY);

        [VtblIndex(10)]
        HRESULT SetBlackPointX(IDCompositionAnimation animation);

        [VtblIndex(11)]
        HRESULT SetBlackPointX(float blackPointX);

        [VtblIndex(12)]
        HRESULT SetBlackPointY(IDCompositionAnimation animation);

        [VtblIndex(13)]
        HRESULT SetBlackPointY(float blackPointY);
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
        public delegate* unmanaged<TSelf*, D2D_VECTOR_2F*, int> SetWhitePoint;

        [NativeTypeName(
            "HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_VECTOR_2F*, int> SetBlackPoint;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetWhitePointX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetWhitePointX1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetWhitePointY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetWhitePointY1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetBlackPointX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBlackPointX1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetBlackPointY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBlackPointY1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionBrightnessEffect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionBrightnessEffect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> to <see cref = "IDCompositionBrightnessEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionBrightnessEffect(
        Silk.NET.DirectX.IDCompositionFilterEffect value
    )
    {
        return new IDCompositionBrightnessEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionBrightnessEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionBrightnessEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionFilterEffect(
        IDCompositionBrightnessEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionFilterEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionBrightnessEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionBrightnessEffect(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionBrightnessEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionBrightnessEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionBrightnessEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionBrightnessEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionBrightnessEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionBrightnessEffect(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionBrightnessEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionBrightnessEffect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionBrightnessEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionBrightnessEffect value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
