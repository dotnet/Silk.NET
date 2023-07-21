// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1Bitmap1.xml' path='doc/member[@name="ID2D1Bitmap1"]/*' />
[Guid("A898A84C-3873-4588-B08B-EBBF978DF041")]
[NativeTypeName("struct ID2D1Bitmap1 : ID2D1Bitmap")]
[NativeInheritance("ID2D1Bitmap")]
public unsafe partial struct ID2D1Bitmap1 : ID2D1Bitmap1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Bitmap1));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1Bitmap1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1Bitmap1*, uint>)(lpVtbl[1]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1Bitmap1*, uint>)(lpVtbl[2]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1Resource.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1Bitmap1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), factory);
    }

    /// <inheritdoc cref="ID2D1Bitmap.GetSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("D2D1_SIZE_F")]
    public D2D_SIZE_F GetSize()
    {
        D2D_SIZE_F result;
        return *((delegate* unmanaged<ID2D1Bitmap1*, D2D_SIZE_F*, D2D_SIZE_F*>)(lpVtbl[4]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
    }

    /// <inheritdoc cref="ID2D1Bitmap.GetPixelSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("D2D1_SIZE_U")]
    public D2D_SIZE_U GetPixelSize()
    {
        D2D_SIZE_U result;
        return *((delegate* unmanaged<ID2D1Bitmap1*, D2D_SIZE_U*, D2D_SIZE_U*>)(lpVtbl[5]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
    }

    /// <inheritdoc cref="ID2D1Bitmap.GetPixelFormat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public D2D1_PIXEL_FORMAT GetPixelFormat()
    {
        D2D1_PIXEL_FORMAT result;
        return *((delegate* unmanaged<ID2D1Bitmap1*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*>)(lpVtbl[6]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
    }

    /// <inheritdoc cref="ID2D1Bitmap.GetDpi" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetDpi(float* dpiX, float* dpiY)
    {
        ((delegate* unmanaged<ID2D1Bitmap1*, float*, float*, void>)(lpVtbl[7]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dpiX, dpiY);
    }

    /// <inheritdoc cref="ID2D1Bitmap.CopyFromBitmap" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CopyFromBitmap([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect)
    {
        return ((delegate* unmanaged<ID2D1Bitmap1*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int>)(lpVtbl[8]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), destPoint, bitmap, srcRect);
    }

    /// <inheritdoc cref="ID2D1Bitmap.CopyFromRenderTarget" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CopyFromRenderTarget([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, ID2D1RenderTarget* renderTarget, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect)
    {
        return ((delegate* unmanaged<ID2D1Bitmap1*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int>)(lpVtbl[9]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), destPoint, renderTarget, srcRect);
    }

    /// <inheritdoc cref="ID2D1Bitmap.CopyFromMemory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CopyFromMemory([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* dstRect, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch)
    {
        return ((delegate* unmanaged<ID2D1Bitmap1*, D2D_RECT_U*, void*, uint, int>)(lpVtbl[10]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dstRect, srcData, pitch);
    }

    /// <include file='ID2D1Bitmap1.xml' path='doc/member[@name="ID2D1Bitmap1.GetColorContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void GetColorContext(ID2D1ColorContext** colorContext)
    {
        ((delegate* unmanaged<ID2D1Bitmap1*, ID2D1ColorContext**, void>)(lpVtbl[11]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), colorContext);
    }

    /// <include file='ID2D1Bitmap1.xml' path='doc/member[@name="ID2D1Bitmap1.GetOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public D2D1_BITMAP_OPTIONS GetOptions()
    {
        return ((delegate* unmanaged<ID2D1Bitmap1*, D2D1_BITMAP_OPTIONS>)(lpVtbl[12]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1Bitmap1.xml' path='doc/member[@name="ID2D1Bitmap1.GetSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetSurface(IDXGISurface** dxgiSurface)
    {
        return ((delegate* unmanaged<ID2D1Bitmap1*, IDXGISurface**, int>)(lpVtbl[13]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dxgiSurface);
    }

    /// <include file='ID2D1Bitmap1.xml' path='doc/member[@name="ID2D1Bitmap1.Map"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Map(D2D1_MAP_OPTIONS options, D2D1_MAPPED_RECT* mappedRect)
    {
        return ((delegate* unmanaged<ID2D1Bitmap1*, D2D1_MAP_OPTIONS, D2D1_MAPPED_RECT*, int>)(lpVtbl[14]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), options, mappedRect);
    }

    /// <include file='ID2D1Bitmap1.xml' path='doc/member[@name="ID2D1Bitmap1.Unmap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Unmap()
    {
        return ((delegate* unmanaged<ID2D1Bitmap1*, int>)(lpVtbl[15]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ID2D1Bitmap.Interface
    {
        [VtblIndex(11)]
        void GetColorContext(ID2D1ColorContext** colorContext);

        [VtblIndex(12)]
        D2D1_BITMAP_OPTIONS GetOptions();

        [VtblIndex(13)]
        HRESULT GetSurface(IDXGISurface** dxgiSurface);

        [VtblIndex(14)]
        HRESULT Map(D2D1_MAP_OPTIONS options, D2D1_MAPPED_RECT* mappedRect);

        [VtblIndex(15)]
        HRESULT Unmap();
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

        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Factory**, void> GetFactory;

        [NativeTypeName("D2D1_SIZE_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_SIZE_F*, D2D_SIZE_F*> GetSize;

        [NativeTypeName("D2D1_SIZE_U () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_SIZE_U*, D2D_SIZE_U*> GetPixelSize;

        [NativeTypeName("D2D1_PIXEL_FORMAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*> GetPixelFormat;

        [NativeTypeName("void (FLOAT *, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, float*, void> GetDpi;

        [NativeTypeName("HRESULT (const D2D1_POINT_2U *, ID2D1Bitmap *, const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int> CopyFromBitmap;

        [NativeTypeName("HRESULT (const D2D1_POINT_2U *, ID2D1RenderTarget *, const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int> CopyFromRenderTarget;

        [NativeTypeName("HRESULT (const D2D1_RECT_U *, const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_RECT_U*, void*, uint, int> CopyFromMemory;

        [NativeTypeName("void (ID2D1ColorContext **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1ColorContext**, void> GetColorContext;

        [NativeTypeName("D2D1_BITMAP_OPTIONS () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_BITMAP_OPTIONS> GetOptions;

        [NativeTypeName("HRESULT (IDXGISurface **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGISurface**, int> GetSurface;

        [NativeTypeName("HRESULT (D2D1_MAP_OPTIONS, D2D1_MAPPED_RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_MAP_OPTIONS, D2D1_MAPPED_RECT*, int> Map;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unmap;
    }
}
