// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("AE1572F4-5DD0-4777-998B-9279472AE63B")]
[NativeTypeName("struct ID2D1GradientStopCollection1 : ID2D1GradientStopCollection")]
[NativeInheritance("ID2D1GradientStopCollection")]
public unsafe partial struct ID2D1GradientStopCollection1
    : ID2D1GradientStopCollection1.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GradientStopCollection1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID2D1GradientStopCollection1, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1GradientStopCollection1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1GradientStopCollection1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1GradientStopCollection1, ID2D1Factory*, void>)((*lpVtbl)[3]))(
            this,
            factory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetGradientStopCount()
    {
        return ((delegate* unmanaged<ID2D1GradientStopCollection1, uint>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void GetGradientStops(
        D2D1_GRADIENT_STOP* gradientStops,
        [NativeTypeName("UINT32")] uint gradientStopsCount
    )
    {
        (
            (delegate* unmanaged<ID2D1GradientStopCollection1, D2D1_GRADIENT_STOP*, uint, void>)(
                (*lpVtbl)[5]
            )
        )(this, gradientStops, gradientStopsCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public D2D1_GAMMA GetColorInterpolationGamma()
    {
        return ((delegate* unmanaged<ID2D1GradientStopCollection1, D2D1_GAMMA>)((*lpVtbl)[6]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public D2D1_EXTEND_MODE GetExtendMode()
    {
        return (
            (delegate* unmanaged<ID2D1GradientStopCollection1, D2D1_EXTEND_MODE>)((*lpVtbl)[7])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetGradientStops1(
        D2D1_GRADIENT_STOP* gradientStops,
        [NativeTypeName("UINT32")] uint gradientStopsCount
    )
    {
        (
            (delegate* unmanaged<ID2D1GradientStopCollection1, D2D1_GRADIENT_STOP*, uint, void>)(
                (*lpVtbl)[8]
            )
        )(this, gradientStops, gradientStopsCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public D2D1_COLOR_SPACE GetPreInterpolationSpace()
    {
        return (
            (delegate* unmanaged<ID2D1GradientStopCollection1, D2D1_COLOR_SPACE>)((*lpVtbl)[9])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D2D1_COLOR_SPACE GetPostInterpolationSpace()
    {
        return (
            (delegate* unmanaged<ID2D1GradientStopCollection1, D2D1_COLOR_SPACE>)((*lpVtbl)[10])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public D2D1_BUFFER_PRECISION GetBufferPrecision()
    {
        return (
            (delegate* unmanaged<ID2D1GradientStopCollection1, D2D1_BUFFER_PRECISION>)(
                (*lpVtbl)[11]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public D2D1_COLOR_INTERPOLATION_MODE GetColorInterpolationMode()
    {
        return (
            (delegate* unmanaged<ID2D1GradientStopCollection1, D2D1_COLOR_INTERPOLATION_MODE>)(
                (*lpVtbl)[12]
            )
        )(this);
    }

    public interface Interface : ID2D1GradientStopCollection.Interface
    {
        [VtblIndex(8)]
        void GetGradientStops1(
            D2D1_GRADIENT_STOP* gradientStops,
            [NativeTypeName("UINT32")] uint gradientStopsCount
        );

        [VtblIndex(9)]
        D2D1_COLOR_SPACE GetPreInterpolationSpace();

        [VtblIndex(10)]
        D2D1_COLOR_SPACE GetPostInterpolationSpace();

        [VtblIndex(11)]
        D2D1_BUFFER_PRECISION GetBufferPrecision();

        [VtblIndex(12)]
        D2D1_COLOR_INTERPOLATION_MODE GetColorInterpolationMode();
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

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetGradientStopCount;

        [NativeTypeName(
            "void (D2D1_GRADIENT_STOP *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_GRADIENT_STOP*, uint, void> GetGradientStops;

        [NativeTypeName("D2D1_GAMMA () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_GAMMA> GetColorInterpolationGamma;

        [NativeTypeName(
            "D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE> GetExtendMode;

        [NativeTypeName(
            "void (D2D1_GRADIENT_STOP *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_GRADIENT_STOP*, uint, void> GetGradientStops1;

        [NativeTypeName(
            "D2D1_COLOR_SPACE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_COLOR_SPACE> GetPreInterpolationSpace;

        [NativeTypeName(
            "D2D1_COLOR_SPACE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_COLOR_SPACE> GetPostInterpolationSpace;

        [NativeTypeName(
            "D2D1_BUFFER_PRECISION () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_BUFFER_PRECISION> GetBufferPrecision;

        [NativeTypeName(
            "D2D1_COLOR_INTERPOLATION_MODE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_COLOR_INTERPOLATION_MODE> GetColorInterpolationMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1GradientStopCollection1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1GradientStopCollection1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1GradientStopCollection"/> to <see cref = "ID2D1GradientStopCollection1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1GradientStopCollection"/> instance to be converted </param>
    public static explicit operator ID2D1GradientStopCollection1(
        Silk.NET.DirectX.ID2D1GradientStopCollection value
    )
    {
        return new ID2D1GradientStopCollection1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1GradientStopCollection1"/> to <see cref = "Silk.NET.DirectX.ID2D1GradientStopCollection"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1GradientStopCollection1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1GradientStopCollection(
        ID2D1GradientStopCollection1 value
    )
    {
        return new Silk.NET.DirectX.ID2D1GradientStopCollection(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1GradientStopCollection1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1GradientStopCollection1(
        Silk.NET.DirectX.ID2D1Resource value
    )
    {
        return new ID2D1GradientStopCollection1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1GradientStopCollection1"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1GradientStopCollection1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(
        ID2D1GradientStopCollection1 value
    )
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1GradientStopCollection1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1GradientStopCollection1(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1GradientStopCollection1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1GradientStopCollection1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1GradientStopCollection1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1GradientStopCollection1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
