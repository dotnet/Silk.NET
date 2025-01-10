// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("9DBE4C0D-3572-4DD9-9825-5530813BB712")]
[NativeTypeName("struct ID2D1SvgPointCollection : ID2D1SvgAttribute")]
[NativeInheritance("ID2D1SvgAttribute")]
public unsafe partial struct ID2D1SvgPointCollection
    : ID2D1SvgPointCollection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgPointCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SvgPointCollection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1SvgPointCollection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SvgPointCollection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1SvgPointCollection, ID2D1Factory*, void>)((*lpVtbl)[3]))(
            this,
            factory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetElement(ID2D1SvgElement* element)
    {
        ((delegate* unmanaged<ID2D1SvgPointCollection, ID2D1SvgElement*, void>)((*lpVtbl)[4]))(
            this,
            element
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Clone(ID2D1SvgAttribute* attribute)
    {
        return (
            (delegate* unmanaged<ID2D1SvgPointCollection, ID2D1SvgAttribute*, int>)((*lpVtbl)[5])
        )(this, attribute);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemovePointsAtEnd([NativeTypeName("UINT32")] uint pointsCount)
    {
        return ((delegate* unmanaged<ID2D1SvgPointCollection, uint, int>)((*lpVtbl)[6]))(
            this,
            pointsCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UpdatePoints(
        [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points,
        [NativeTypeName("UINT32")] uint pointsCount,
        [NativeTypeName("UINT32")] uint startIndex = 0
    )
    {
        return (
            (delegate* unmanaged<ID2D1SvgPointCollection, D2D_POINT_2F*, uint, uint, int>)(
                (*lpVtbl)[7]
            )
        )(this, points, pointsCount, startIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPoints(
        [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* points,
        [NativeTypeName("UINT32")] uint pointsCount,
        [NativeTypeName("UINT32")] uint startIndex = 0
    )
    {
        return (
            (delegate* unmanaged<ID2D1SvgPointCollection, D2D_POINT_2F*, uint, uint, int>)(
                (*lpVtbl)[8]
            )
        )(this, points, pointsCount, startIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT32")]
    public uint GetPointsCount()
    {
        return ((delegate* unmanaged<ID2D1SvgPointCollection, uint>)((*lpVtbl)[9]))(this);
    }

    public interface Interface : ID2D1SvgAttribute.Interface
    {
        [VtblIndex(6)]
        HRESULT RemovePointsAtEnd([NativeTypeName("UINT32")] uint pointsCount);

        [VtblIndex(7)]
        HRESULT UpdatePoints(
            [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points,
            [NativeTypeName("UINT32")] uint pointsCount,
            [NativeTypeName("UINT32")] uint startIndex = 0
        );

        [VtblIndex(8)]
        HRESULT GetPoints(
            [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* points,
            [NativeTypeName("UINT32")] uint pointsCount,
            [NativeTypeName("UINT32")] uint startIndex = 0
        );

        [VtblIndex(9)]
        [return: NativeTypeName("UINT32")]
        uint GetPointsCount();
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

        [NativeTypeName(
            "void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement*, void> GetElement;

        [NativeTypeName(
            "HRESULT (ID2D1SvgAttribute **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1SvgAttribute*, int> Clone;

        [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemovePointsAtEnd;

        [NativeTypeName(
            "HRESULT (const D2D1_POINT_2F *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F*, uint, uint, int> UpdatePoints;

        [NativeTypeName(
            "HRESULT (D2D1_POINT_2F *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F*, uint, uint, int> GetPoints;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetPointsCount;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1SvgPointCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1SvgPointCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1SvgAttribute"/> to <see cref = "ID2D1SvgPointCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1SvgAttribute"/> instance to be converted </param>
    public static explicit operator ID2D1SvgPointCollection(
        Silk.NET.DirectX.ID2D1SvgAttribute value
    )
    {
        return new ID2D1SvgPointCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1SvgPointCollection"/> to <see cref = "Silk.NET.DirectX.ID2D1SvgAttribute"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1SvgPointCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1SvgAttribute(
        ID2D1SvgPointCollection value
    )
    {
        return new Silk.NET.DirectX.ID2D1SvgAttribute(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1SvgPointCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1SvgPointCollection(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1SvgPointCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1SvgPointCollection"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1SvgPointCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1SvgPointCollection value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1SvgPointCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1SvgPointCollection(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1SvgPointCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1SvgPointCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1SvgPointCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1SvgPointCollection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
