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

[Guid("10A72A66-E91C-43F4-993F-DDF4B82B0B4A")]
[NativeTypeName("struct ID2D1StrokeStyle1 : ID2D1StrokeStyle")]
[NativeInheritance("ID2D1StrokeStyle")]
public unsafe partial struct ID2D1StrokeStyle1 : ID2D1StrokeStyle1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1StrokeStyle1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1StrokeStyle1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1StrokeStyle1, ID2D1Factory*, void>)((*lpVtbl)[3]))(
            this,
            factory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public D2D1_CAP_STYLE GetStartCap()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle1, D2D1_CAP_STYLE>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public D2D1_CAP_STYLE GetEndCap()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle1, D2D1_CAP_STYLE>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public D2D1_CAP_STYLE GetDashCap()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle1, D2D1_CAP_STYLE>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public float GetMiterLimit()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle1, float>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public D2D1_LINE_JOIN GetLineJoin()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle1, D2D1_LINE_JOIN>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public float GetDashOffset()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle1, float>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D2D1_DASH_STYLE GetDashStyle()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle1, D2D1_DASH_STYLE>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("UINT32")]
    public uint GetDashesCount()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle1, uint>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void GetDashes(float* dashes, [NativeTypeName("UINT32")] uint dashesCount)
    {
        ((delegate* unmanaged<ID2D1StrokeStyle1, float*, uint, void>)((*lpVtbl)[12]))(
            this,
            dashes,
            dashesCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformType()
    {
        return (
            (delegate* unmanaged<ID2D1StrokeStyle1, D2D1_STROKE_TRANSFORM_TYPE>)((*lpVtbl)[13])
        )(this);
    }

    public interface Interface : ID2D1StrokeStyle.Interface
    {
        [VtblIndex(13)]
        D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformType();
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
            "D2D1_CAP_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_CAP_STYLE> GetStartCap;

        [NativeTypeName(
            "D2D1_CAP_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_CAP_STYLE> GetEndCap;

        [NativeTypeName(
            "D2D1_CAP_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_CAP_STYLE> GetDashCap;

        [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetMiterLimit;

        [NativeTypeName(
            "D2D1_LINE_JOIN () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_LINE_JOIN> GetLineJoin;

        [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetDashOffset;

        [NativeTypeName(
            "D2D1_DASH_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_DASH_STYLE> GetDashStyle;

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetDashesCount;

        [NativeTypeName(
            "void (FLOAT *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float*, uint, void> GetDashes;

        [NativeTypeName(
            "D2D1_STROKE_TRANSFORM_TYPE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_STROKE_TRANSFORM_TYPE> GetStrokeTransformType;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1StrokeStyle1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1StrokeStyle1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1StrokeStyle"/> to <see cref = "ID2D1StrokeStyle1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1StrokeStyle"/> instance to be converted </param>
    public static explicit operator ID2D1StrokeStyle1(Silk.NET.DirectX.ID2D1StrokeStyle value)
    {
        return new ID2D1StrokeStyle1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1StrokeStyle1"/> to <see cref = "Silk.NET.DirectX.ID2D1StrokeStyle"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1StrokeStyle1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1StrokeStyle(ID2D1StrokeStyle1 value)
    {
        return new Silk.NET.DirectX.ID2D1StrokeStyle(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1StrokeStyle1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1StrokeStyle1(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1StrokeStyle1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1StrokeStyle1"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1StrokeStyle1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1StrokeStyle1 value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1StrokeStyle1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1StrokeStyle1(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1StrokeStyle1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1StrokeStyle1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1StrokeStyle1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1StrokeStyle1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
