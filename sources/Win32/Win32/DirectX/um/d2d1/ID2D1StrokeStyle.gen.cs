// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("2CD9069D-12E2-11DC-9FED-001143A055F9")]
[NativeTypeName("struct ID2D1StrokeStyle : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1StrokeStyle : ID2D1StrokeStyle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1StrokeStyle));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1StrokeStyle, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1StrokeStyle, ID2D1Factory*, void>)((*lpVtbl)[3]))(this, factory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public D2D1_CAP_STYLE GetStartCap()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle, D2D1_CAP_STYLE>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public D2D1_CAP_STYLE GetEndCap()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle, D2D1_CAP_STYLE>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public D2D1_CAP_STYLE GetDashCap()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle, D2D1_CAP_STYLE>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public float GetMiterLimit()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle, float>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public D2D1_LINE_JOIN GetLineJoin()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle, D2D1_LINE_JOIN>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public float GetDashOffset()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle, float>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D2D1_DASH_STYLE GetDashStyle()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle, D2D1_DASH_STYLE>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("UINT32")]
    public uint GetDashesCount()
    {
        return ((delegate* unmanaged<ID2D1StrokeStyle, uint>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void GetDashes(float* dashes, [NativeTypeName("UINT32")] uint dashesCount)
    {
        ((delegate* unmanaged<ID2D1StrokeStyle, float*, uint, void>)((*lpVtbl)[12]))(
            this,
            dashes,
            dashesCount
        );
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        D2D1_CAP_STYLE GetStartCap();

        [VtblIndex(5)]
        D2D1_CAP_STYLE GetEndCap();

        [VtblIndex(6)]
        D2D1_CAP_STYLE GetDashCap();

        [VtblIndex(7)]
        float GetMiterLimit();

        [VtblIndex(8)]
        D2D1_LINE_JOIN GetLineJoin();

        [VtblIndex(9)]
        float GetDashOffset();

        [VtblIndex(10)]
        D2D1_DASH_STYLE GetDashStyle();

        [VtblIndex(11)]
        [return: NativeTypeName("UINT32")]
        uint GetDashesCount();

        [VtblIndex(12)]
        void GetDashes(float* dashes, [NativeTypeName("UINT32")] uint dashesCount);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1StrokeStyle"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1StrokeStyle(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1StrokeStyle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1StrokeStyle(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1StrokeStyle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1StrokeStyle"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1StrokeStyle"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1StrokeStyle value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1StrokeStyle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1StrokeStyle(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1StrokeStyle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1StrokeStyle"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1StrokeStyle"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1StrokeStyle value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
