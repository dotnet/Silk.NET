// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("BAE8B344-23FC-4071-8CB5-D05D6F073848")]
[NativeTypeName("struct ID2D1InkStyle : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1InkStyle : ID2D1InkStyle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1InkStyle));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1InkStyle, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1InkStyle, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1InkStyle, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1InkStyle, ID2D1Factory*, void>)((*lpVtbl)[3]))(this, factory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetNibTransform(
        [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform
    )
    {
        ((delegate* unmanaged<ID2D1InkStyle, D2D_MATRIX_3X2_F*, void>)((*lpVtbl)[4]))(
            this,
            transform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void GetNibTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged<ID2D1InkStyle, D2D_MATRIX_3X2_F*, void>)((*lpVtbl)[5]))(
            this,
            transform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetNibShape(D2D1_INK_NIB_SHAPE nibShape)
    {
        ((delegate* unmanaged<ID2D1InkStyle, D2D1_INK_NIB_SHAPE, void>)((*lpVtbl)[6]))(
            this,
            nibShape
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public D2D1_INK_NIB_SHAPE GetNibShape()
    {
        return ((delegate* unmanaged<ID2D1InkStyle, D2D1_INK_NIB_SHAPE>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        void SetNibTransform(
            [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform
        );

        [VtblIndex(5)]
        void GetNibTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [VtblIndex(6)]
        void SetNibShape(D2D1_INK_NIB_SHAPE nibShape);

        [VtblIndex(7)]
        D2D1_INK_NIB_SHAPE GetNibShape();
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
            "void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, void> SetNibTransform;

        [NativeTypeName(
            "void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, void> GetNibTransform;

        [NativeTypeName(
            "void (D2D1_INK_NIB_SHAPE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_INK_NIB_SHAPE, void> SetNibShape;

        [NativeTypeName(
            "D2D1_INK_NIB_SHAPE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_INK_NIB_SHAPE> GetNibShape;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1InkStyle"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1InkStyle(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1InkStyle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1InkStyle(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1InkStyle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1InkStyle"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1InkStyle"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1InkStyle value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1InkStyle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1InkStyle(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1InkStyle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1InkStyle"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1InkStyle"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1InkStyle value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
