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

[Guid("2CD906AA-12E2-11DC-9FED-001143A055F9")]
[NativeTypeName("struct ID2D1BitmapBrush : ID2D1Brush")]
[NativeInheritance("ID2D1Brush")]
public unsafe partial struct ID2D1BitmapBrush : ID2D1BitmapBrush.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1BitmapBrush));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1BitmapBrush, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1BitmapBrush, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1BitmapBrush, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1BitmapBrush, ID2D1Factory*, void>)((*lpVtbl)[3]))(this, factory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetOpacity(float opacity)
    {
        ((delegate* unmanaged<ID2D1BitmapBrush, float, void>)((*lpVtbl)[4]))(this, opacity);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetTransform(
        [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform
    )
    {
        ((delegate* unmanaged<ID2D1BitmapBrush, D2D_MATRIX_3X2_F*, void>)((*lpVtbl)[5]))(
            this,
            transform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public float GetOpacity()
    {
        return ((delegate* unmanaged<ID2D1BitmapBrush, float>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged<ID2D1BitmapBrush, D2D_MATRIX_3X2_F*, void>)((*lpVtbl)[7]))(
            this,
            transform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void SetExtendModeX(D2D1_EXTEND_MODE extendModeX)
    {
        ((delegate* unmanaged<ID2D1BitmapBrush, D2D1_EXTEND_MODE, void>)((*lpVtbl)[8]))(
            this,
            extendModeX
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void SetExtendModeY(D2D1_EXTEND_MODE extendModeY)
    {
        ((delegate* unmanaged<ID2D1BitmapBrush, D2D1_EXTEND_MODE, void>)((*lpVtbl)[9]))(
            this,
            extendModeY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE interpolationMode)
    {
        (
            (delegate* unmanaged<ID2D1BitmapBrush, D2D1_BITMAP_INTERPOLATION_MODE, void>)(
                (*lpVtbl)[10]
            )
        )(this, interpolationMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void SetBitmap(ID2D1Bitmap bitmap)
    {
        ((delegate* unmanaged<ID2D1BitmapBrush, ID2D1Bitmap, void>)((*lpVtbl)[11]))(this, bitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public D2D1_EXTEND_MODE GetExtendModeX()
    {
        return ((delegate* unmanaged<ID2D1BitmapBrush, D2D1_EXTEND_MODE>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public D2D1_EXTEND_MODE GetExtendModeY()
    {
        return ((delegate* unmanaged<ID2D1BitmapBrush, D2D1_EXTEND_MODE>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode()
    {
        return (
            (delegate* unmanaged<ID2D1BitmapBrush, D2D1_BITMAP_INTERPOLATION_MODE>)((*lpVtbl)[14])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void GetBitmap(ID2D1Bitmap* bitmap)
    {
        ((delegate* unmanaged<ID2D1BitmapBrush, ID2D1Bitmap*, void>)((*lpVtbl)[15]))(this, bitmap);
    }

    public interface Interface : ID2D1Brush.Interface
    {
        [VtblIndex(8)]
        void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);

        [VtblIndex(9)]
        void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);

        [VtblIndex(10)]
        void SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);

        [VtblIndex(11)]
        void SetBitmap(ID2D1Bitmap bitmap);

        [VtblIndex(12)]
        D2D1_EXTEND_MODE GetExtendModeX();

        [VtblIndex(13)]
        D2D1_EXTEND_MODE GetExtendModeY();

        [VtblIndex(14)]
        D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode();

        [VtblIndex(15)]
        void GetBitmap(ID2D1Bitmap* bitmap);
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

        [NativeTypeName("void (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, void> SetOpacity;

        [NativeTypeName(
            "void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, void> SetTransform;

        [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetOpacity;

        [NativeTypeName(
            "void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, void> GetTransform;

        [NativeTypeName(
            "void (D2D1_EXTEND_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE, void> SetExtendModeX;

        [NativeTypeName(
            "void (D2D1_EXTEND_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE, void> SetExtendModeY;

        [NativeTypeName(
            "void (D2D1_BITMAP_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_BITMAP_INTERPOLATION_MODE,
            void> SetInterpolationMode;

        [NativeTypeName("void (ID2D1Bitmap *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Bitmap, void> SetBitmap;

        [NativeTypeName(
            "D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE> GetExtendModeX;

        [NativeTypeName(
            "D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE> GetExtendModeY;

        [NativeTypeName(
            "D2D1_BITMAP_INTERPOLATION_MODE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_BITMAP_INTERPOLATION_MODE> GetInterpolationMode;

        [NativeTypeName(
            "void (ID2D1Bitmap **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Bitmap*, void> GetBitmap;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1BitmapBrush"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1BitmapBrush(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Brush"/> to <see cref = "ID2D1BitmapBrush"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Brush"/> instance to be converted </param>
    public static explicit operator ID2D1BitmapBrush(Silk.NET.DirectX.ID2D1Brush value)
    {
        return new ID2D1BitmapBrush(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1BitmapBrush"/> to <see cref = "Silk.NET.DirectX.ID2D1Brush"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1BitmapBrush"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Brush(ID2D1BitmapBrush value)
    {
        return new Silk.NET.DirectX.ID2D1Brush(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1BitmapBrush"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1BitmapBrush(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1BitmapBrush(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1BitmapBrush"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1BitmapBrush"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1BitmapBrush value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1BitmapBrush"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1BitmapBrush(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1BitmapBrush(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1BitmapBrush"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1BitmapBrush"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1BitmapBrush value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
