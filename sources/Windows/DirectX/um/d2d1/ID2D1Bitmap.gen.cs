// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID2D1Bitmap.xml' path='doc/member[@name="ID2D1Bitmap"]/*'/>
[Guid("A2296057-EA42-4099-983B-539FB6505426")]
[NativeTypeName("struct ID2D1Bitmap : ID2D1Image")]
[NativeInheritance("ID2D1Image")]
public unsafe partial struct ID2D1Bitmap : ID2D1Bitmap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Bitmap));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1Bitmap*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1Bitmap*, uint> )(lpVtbl[1]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1Bitmap*, uint> )(lpVtbl[2]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Resource.GetFactory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1Bitmap*, ID2D1Factory**, void> )(lpVtbl[3]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), factory);
    }

    /// <include file='ID2D1Bitmap.xml' path='doc/member[@name="ID2D1Bitmap.GetSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("D2D1_SIZE_F")]
    public D2D_SIZE_F GetSize()
    {
        D2D_SIZE_F result;
        return *((delegate* unmanaged<ID2D1Bitmap*, D2D_SIZE_F*, D2D_SIZE_F*> )(lpVtbl[4]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='ID2D1Bitmap.xml' path='doc/member[@name="ID2D1Bitmap.GetPixelSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("D2D1_SIZE_U")]
    public D2D_SIZE_U GetPixelSize()
    {
        D2D_SIZE_U result;
        return *((delegate* unmanaged<ID2D1Bitmap*, D2D_SIZE_U*, D2D_SIZE_U*> )(lpVtbl[5]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='ID2D1Bitmap.xml' path='doc/member[@name="ID2D1Bitmap.GetPixelFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public D2D1_PIXEL_FORMAT GetPixelFormat()
    {
        D2D1_PIXEL_FORMAT result;
        return *((delegate* unmanaged<ID2D1Bitmap*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*> )(lpVtbl[6]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='ID2D1Bitmap.xml' path='doc/member[@name="ID2D1Bitmap.GetDpi"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetDpi(float* dpiX, float* dpiY)
    {
        ((delegate* unmanaged<ID2D1Bitmap*, float*, float*, void> )(lpVtbl[7]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), dpiX, dpiY);
    }

    /// <include file='ID2D1Bitmap.xml' path='doc/member[@name="ID2D1Bitmap.CopyFromBitmap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CopyFromBitmap([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect)
    {
        return ((delegate* unmanaged<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int> )(lpVtbl[8]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), destPoint, bitmap, srcRect);
    }

    /// <include file='ID2D1Bitmap.xml' path='doc/member[@name="ID2D1Bitmap.CopyFromRenderTarget"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CopyFromRenderTarget([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, ID2D1RenderTarget* renderTarget, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect)
    {
        return ((delegate* unmanaged<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int> )(lpVtbl[9]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), destPoint, renderTarget, srcRect);
    }

    /// <include file='ID2D1Bitmap.xml' path='doc/member[@name="ID2D1Bitmap.CopyFromMemory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CopyFromMemory([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* dstRect, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch)
    {
        return ((delegate* unmanaged<ID2D1Bitmap*, D2D_RECT_U*, void*, uint, int> )(lpVtbl[10]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), dstRect, srcData, pitch);
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
        HRESULT CopyFromBitmap([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect);
        [VtblIndex(9)]
        HRESULT CopyFromRenderTarget([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, ID2D1RenderTarget* renderTarget, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect);
        [VtblIndex(10)]
        HRESULT CopyFromMemory([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* dstRect, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch);
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
    }
}