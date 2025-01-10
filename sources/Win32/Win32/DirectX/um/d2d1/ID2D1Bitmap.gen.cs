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

[Guid("A2296057-EA42-4099-983B-539FB6505426")]
[NativeTypeName("struct ID2D1Bitmap : ID2D1Image")]
[NativeInheritance("ID2D1Image")]
public unsafe partial struct ID2D1Bitmap : ID2D1Bitmap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Bitmap));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1Bitmap, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1Bitmap, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1Bitmap, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1Bitmap, ID2D1Factory*, void>)((*lpVtbl)[3]))(this, factory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("D2D1_SIZE_F")]
    public D2D_SIZE_F GetSize()
    {
        D2D_SIZE_F result;
        return *((delegate* unmanaged<ID2D1Bitmap, D2D_SIZE_F*, D2D_SIZE_F*>)((*lpVtbl)[4]))(
            this,
            &result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("D2D1_SIZE_U")]
    public D2D_SIZE_U GetPixelSize()
    {
        D2D_SIZE_U result;
        return *((delegate* unmanaged<ID2D1Bitmap, D2D_SIZE_U*, D2D_SIZE_U*>)((*lpVtbl)[5]))(
            this,
            &result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public D2D1_PIXEL_FORMAT GetPixelFormat()
    {
        D2D1_PIXEL_FORMAT result;
        return *(
            (delegate* unmanaged<ID2D1Bitmap, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*>)((*lpVtbl)[6])
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetDpi(float* dpiX, float* dpiY)
    {
        ((delegate* unmanaged<ID2D1Bitmap, float*, float*, void>)((*lpVtbl)[7]))(this, dpiX, dpiY);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CopyFromBitmap(
        [NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint,
        ID2D1Bitmap bitmap,
        [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect
    )
    {
        return (
            (delegate* unmanaged<ID2D1Bitmap, D2D_POINT_2U*, ID2D1Bitmap, D2D_RECT_U*, int>)(
                (*lpVtbl)[8]
            )
        )(this, destPoint, bitmap, srcRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CopyFromRenderTarget(
        [NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint,
        ID2D1RenderTarget renderTarget,
        [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect
    )
    {
        return (
            (delegate* unmanaged<ID2D1Bitmap, D2D_POINT_2U*, ID2D1RenderTarget, D2D_RECT_U*, int>)(
                (*lpVtbl)[9]
            )
        )(this, destPoint, renderTarget, srcRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CopyFromMemory(
        [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* dstRect,
        [NativeTypeName("const void *")] void* srcData,
        [NativeTypeName("UINT32")] uint pitch
    )
    {
        return ((delegate* unmanaged<ID2D1Bitmap, D2D_RECT_U*, void*, uint, int>)((*lpVtbl)[10]))(
            this,
            dstRect,
            srcData,
            pitch
        );
    }

    public interface Interface : ID2D1Image.Interface
    {
        [VtblIndex(4)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        D2D_SIZE_F GetSize();

        [VtblIndex(5)]
        [return: NativeTypeName("D2D1_SIZE_U")]
        D2D_SIZE_U GetPixelSize();

        [VtblIndex(6)]
        D2D1_PIXEL_FORMAT GetPixelFormat();

        [VtblIndex(7)]
        void GetDpi(float* dpiX, float* dpiY);

        [VtblIndex(8)]
        HRESULT CopyFromBitmap(
            [NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint,
            ID2D1Bitmap bitmap,
            [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect
        );

        [VtblIndex(9)]
        HRESULT CopyFromRenderTarget(
            [NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint,
            ID2D1RenderTarget renderTarget,
            [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect
        );

        [VtblIndex(10)]
        HRESULT CopyFromMemory(
            [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* dstRect,
            [NativeTypeName("const void *")] void* srcData,
            [NativeTypeName("UINT32")] uint pitch
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

        [NativeTypeName(
            "void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Factory*, void> GetFactory;

        [NativeTypeName("D2D1_SIZE_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_SIZE_F*, D2D_SIZE_F*> GetSize;

        [NativeTypeName("D2D1_SIZE_U () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_SIZE_U*, D2D_SIZE_U*> GetPixelSize;

        [NativeTypeName(
            "D2D1_PIXEL_FORMAT () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*> GetPixelFormat;

        [NativeTypeName(
            "void (FLOAT *, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float*, float*, void> GetDpi;

        [NativeTypeName(
            "HRESULT (const D2D1_POINT_2U *, ID2D1Bitmap *, const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2U*,
            ID2D1Bitmap,
            D2D_RECT_U*,
            int> CopyFromBitmap;

        [NativeTypeName(
            "HRESULT (const D2D1_POINT_2U *, ID2D1RenderTarget *, const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2U*,
            ID2D1RenderTarget,
            D2D_RECT_U*,
            int> CopyFromRenderTarget;

        [NativeTypeName(
            "HRESULT (const D2D1_RECT_U *, const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_RECT_U*, void*, uint, int> CopyFromMemory;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1Bitmap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1Bitmap(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Image"/> to <see cref = "ID2D1Bitmap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Image"/> instance to be converted </param>
    public static explicit operator ID2D1Bitmap(Silk.NET.DirectX.ID2D1Image value)
    {
        return new ID2D1Bitmap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1Bitmap"/> to <see cref = "Silk.NET.DirectX.ID2D1Image"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1Bitmap"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Image(ID2D1Bitmap value)
    {
        return new Silk.NET.DirectX.ID2D1Image(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1Bitmap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1Bitmap(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1Bitmap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1Bitmap"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1Bitmap"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1Bitmap value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1Bitmap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1Bitmap(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1Bitmap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1Bitmap"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1Bitmap"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1Bitmap value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
