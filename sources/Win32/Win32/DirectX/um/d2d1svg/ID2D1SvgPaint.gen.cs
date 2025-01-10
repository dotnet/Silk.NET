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

[Guid("D59BAB0A-68A2-455B-A5DC-9EB2854E2490")]
[NativeTypeName("struct ID2D1SvgPaint : ID2D1SvgAttribute")]
[NativeInheritance("ID2D1SvgAttribute")]
public unsafe partial struct ID2D1SvgPaint : ID2D1SvgPaint.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgPaint));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SvgPaint, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1SvgPaint, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SvgPaint, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1SvgPaint, ID2D1Factory*, void>)((*lpVtbl)[3]))(this, factory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetElement(ID2D1SvgElement* element)
    {
        ((delegate* unmanaged<ID2D1SvgPaint, ID2D1SvgElement*, void>)((*lpVtbl)[4]))(this, element);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Clone(ID2D1SvgAttribute* attribute)
    {
        return ((delegate* unmanaged<ID2D1SvgPaint, ID2D1SvgAttribute*, int>)((*lpVtbl)[5]))(
            this,
            attribute
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPaintType(D2D1_SVG_PAINT_TYPE paintType)
    {
        return ((delegate* unmanaged<ID2D1SvgPaint, D2D1_SVG_PAINT_TYPE, int>)((*lpVtbl)[6]))(
            this,
            paintType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public D2D1_SVG_PAINT_TYPE GetPaintType()
    {
        return ((delegate* unmanaged<ID2D1SvgPaint, D2D1_SVG_PAINT_TYPE>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetColor([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
    {
        return ((delegate* unmanaged<ID2D1SvgPaint, DXGI_RGBA*, int>)((*lpVtbl)[8]))(this, color);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void GetColor([NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* color)
    {
        ((delegate* unmanaged<ID2D1SvgPaint, DXGI_RGBA*, void>)((*lpVtbl)[9]))(this, color);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetId([NativeTypeName("PCWSTR")] ushort* id)
    {
        return ((delegate* unmanaged<ID2D1SvgPaint, ushort*, int>)((*lpVtbl)[10]))(this, id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetId(
        [NativeTypeName("PWSTR")] ushort* id,
        [NativeTypeName("UINT32")] uint idCount
    )
    {
        return ((delegate* unmanaged<ID2D1SvgPaint, ushort*, uint, int>)((*lpVtbl)[11]))(
            this,
            id,
            idCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("UINT32")]
    public uint GetIdLength()
    {
        return ((delegate* unmanaged<ID2D1SvgPaint, uint>)((*lpVtbl)[12]))(this);
    }

    public interface Interface : ID2D1SvgAttribute.Interface
    {
        [VtblIndex(6)]
        HRESULT SetPaintType(D2D1_SVG_PAINT_TYPE paintType);

        [VtblIndex(7)]
        D2D1_SVG_PAINT_TYPE GetPaintType();

        [VtblIndex(8)]
        HRESULT SetColor([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color);

        [VtblIndex(9)]
        void GetColor([NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* color);

        [VtblIndex(10)]
        HRESULT SetId([NativeTypeName("PCWSTR")] ushort* id);

        [VtblIndex(11)]
        HRESULT GetId(
            [NativeTypeName("PWSTR")] ushort* id,
            [NativeTypeName("UINT32")] uint idCount
        );

        [VtblIndex(12)]
        [return: NativeTypeName("UINT32")]
        uint GetIdLength();
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

        [NativeTypeName(
            "HRESULT (D2D1_SVG_PAINT_TYPE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_SVG_PAINT_TYPE, int> SetPaintType;

        [NativeTypeName("D2D1_SVG_PAINT_TYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_SVG_PAINT_TYPE> GetPaintType;

        [NativeTypeName(
            "HRESULT (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DXGI_RGBA*, int> SetColor;

        [NativeTypeName("void (D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_RGBA*, void> GetColor;

        [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetId;

        [NativeTypeName(
            "HRESULT (PWSTR, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> GetId;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetIdLength;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1SvgPaint"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1SvgPaint(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1SvgAttribute"/> to <see cref = "ID2D1SvgPaint"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1SvgAttribute"/> instance to be converted </param>
    public static explicit operator ID2D1SvgPaint(Silk.NET.DirectX.ID2D1SvgAttribute value)
    {
        return new ID2D1SvgPaint(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1SvgPaint"/> to <see cref = "Silk.NET.DirectX.ID2D1SvgAttribute"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1SvgPaint"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1SvgAttribute(ID2D1SvgPaint value)
    {
        return new Silk.NET.DirectX.ID2D1SvgAttribute(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1SvgPaint"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1SvgPaint(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1SvgPaint(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1SvgPaint"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1SvgPaint"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1SvgPaint value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1SvgPaint"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1SvgPaint(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1SvgPaint(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1SvgPaint"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1SvgPaint"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1SvgPaint value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
