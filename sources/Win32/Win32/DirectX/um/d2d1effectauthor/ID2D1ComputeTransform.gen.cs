// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("0D85573C-01E3-4F7D-BFD9-0D60608BF3C3")]
[NativeTypeName("struct ID2D1ComputeTransform : ID2D1Transform")]
[NativeInheritance("ID2D1Transform")]
public unsafe partial struct ID2D1ComputeTransform : ID2D1ComputeTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ComputeTransform));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1ComputeTransform, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT MapOutputRectToInputRects(
        [NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect,
        [NativeTypeName("D2D1_RECT_L *")] RECT* inputRects,
        [NativeTypeName("UINT32")] uint inputRectsCount
    )
    {
        return (
            (delegate* unmanaged<ID2D1ComputeTransform, RECT*, RECT*, uint, int>)((*lpVtbl)[4])
        )(this, outputRect, inputRects, inputRectsCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MapInputRectsToOutputRect(
        [NativeTypeName("const D2D1_RECT_L *")] RECT* inputRects,
        [NativeTypeName("const D2D1_RECT_L *")] RECT* inputOpaqueSubRects,
        [NativeTypeName("UINT32")] uint inputRectCount,
        [NativeTypeName("D2D1_RECT_L *")] RECT* outputRect,
        [NativeTypeName("D2D1_RECT_L *")] RECT* outputOpaqueSubRect
    )
    {
        return (
            (delegate* unmanaged<ID2D1ComputeTransform, RECT*, RECT*, uint, RECT*, RECT*, int>)(
                (*lpVtbl)[5]
            )
        )(this, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT MapInvalidRect(
        [NativeTypeName("UINT32")] uint inputIndex,
        [NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect,
        [NativeTypeName("D2D1_RECT_L *")] RECT* invalidOutputRect
    )
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform, uint, RECT, RECT*, int>)((*lpVtbl)[6]))(
            this,
            inputIndex,
            invalidInputRect,
            invalidOutputRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetComputeInfo(ID2D1ComputeInfo computeInfo)
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform, ID2D1ComputeInfo, int>)((*lpVtbl)[7]))(
            this,
            computeInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CalculateThreadgroups(
        [NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect,
        [NativeTypeName("UINT32 *")] uint* dimensionX,
        [NativeTypeName("UINT32 *")] uint* dimensionY,
        [NativeTypeName("UINT32 *")] uint* dimensionZ
    )
    {
        return (
            (delegate* unmanaged<ID2D1ComputeTransform, RECT*, uint*, uint*, uint*, int>)(
                (*lpVtbl)[8]
            )
        )(this, outputRect, dimensionX, dimensionY, dimensionZ);
    }

    public interface Interface : ID2D1Transform.Interface
    {
        [VtblIndex(7)]
        HRESULT SetComputeInfo(ID2D1ComputeInfo computeInfo);

        [VtblIndex(8)]
        HRESULT CalculateThreadgroups(
            [NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect,
            [NativeTypeName("UINT32 *")] uint* dimensionX,
            [NativeTypeName("UINT32 *")] uint* dimensionY,
            [NativeTypeName("UINT32 *")] uint* dimensionZ
        );
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

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetInputCount;

        [NativeTypeName(
            "HRESULT (const D2D1_RECT_L *, D2D1_RECT_L *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, uint, int> MapOutputRectToInputRects;

        [NativeTypeName(
            "HRESULT (const D2D1_RECT_L *, const D2D1_RECT_L *, UINT32, D2D1_RECT_L *, D2D1_RECT_L *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            RECT*,
            RECT*,
            uint,
            RECT*,
            RECT*,
            int> MapInputRectsToOutputRect;

        [NativeTypeName(
            "HRESULT (UINT32, D2D1_RECT_L, D2D1_RECT_L *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, RECT, RECT*, int> MapInvalidRect;

        [NativeTypeName(
            "HRESULT (ID2D1ComputeInfo *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1ComputeInfo, int> SetComputeInfo;

        [NativeTypeName(
            "HRESULT (const D2D1_RECT_L *, UINT32 *, UINT32 *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, uint*, uint*, uint*, int> CalculateThreadgroups;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1ComputeTransform"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1ComputeTransform(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Transform"/> to <see cref = "ID2D1ComputeTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Transform"/> instance to be converted </param>
    public static explicit operator ID2D1ComputeTransform(Silk.NET.DirectX.ID2D1Transform value)
    {
        return new ID2D1ComputeTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1ComputeTransform"/> to <see cref = "Silk.NET.DirectX.ID2D1Transform"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1ComputeTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Transform(ID2D1ComputeTransform value)
    {
        return new Silk.NET.DirectX.ID2D1Transform(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1TransformNode"/> to <see cref = "ID2D1ComputeTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1TransformNode"/> instance to be converted </param>
    public static explicit operator ID2D1ComputeTransform(Silk.NET.DirectX.ID2D1TransformNode value)
    {
        return new ID2D1ComputeTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1ComputeTransform"/> to <see cref = "Silk.NET.DirectX.ID2D1TransformNode"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1ComputeTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1TransformNode(ID2D1ComputeTransform value)
    {
        return new Silk.NET.DirectX.ID2D1TransformNode(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1ComputeTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1ComputeTransform(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1ComputeTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1ComputeTransform"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1ComputeTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1ComputeTransform value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
