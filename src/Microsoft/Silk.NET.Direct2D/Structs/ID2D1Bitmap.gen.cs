// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Guid("a2296057-ea42-4099-983b-539fb6505426")]
    [NativeName("Name", "ID2D1Bitmap")]
    public unsafe partial struct ID2D1Bitmap
    {
        public static readonly Guid Guid = new("a2296057-ea42-4099-983b-539fb6505426");

        public static implicit operator ID2D1Image(ID2D1Bitmap val)
            => Unsafe.As<ID2D1Bitmap, ID2D1Image>(ref val);

        public static implicit operator ID2D1Resource(ID2D1Bitmap val)
            => Unsafe.As<ID2D1Bitmap, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Bitmap val)
            => Unsafe.As<ID2D1Bitmap, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Bitmap
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, ID2D1Factory**, void>)LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, ID2D1Factory**, void>)LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly D2D_SIZE_F GetSize()
        {
            D2D_SIZE_F silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            D2D_SIZE_F* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_SIZE_F*, D2D_SIZE_F*>)LpVtbl[4])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly D2D_SIZE_U GetPixelSize()
        {
            D2D_SIZE_U silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            D2D_SIZE_U* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_SIZE_U*, D2D_SIZE_U*>)LpVtbl[5])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            D2D1_PIXEL_FORMAT silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            D2D1_PIXEL_FORMAT* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*>)LpVtbl[6])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(float* dpiX, float* dpiY)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, float*, float*, void>)LpVtbl[7])(@this, dpiX, dpiY);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(float* dpiX, ref float dpiY)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, float*, float*, void>)LpVtbl[7])(@this, dpiX, dpiYPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(ref float dpiX, float* dpiY)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, float*, float*, void>)LpVtbl[7])(@this, dpiXPtr, dpiY);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDpi(ref float dpiX, ref float dpiY)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                fixed (float* dpiYPtr = &dpiY)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, float*, float*, void>)LpVtbl[7])(@this, dpiXPtr, dpiYPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromBitmap(D2D_POINT_2U* destPoint, ID2D1Bitmap* bitmap, D2D_RECT_U* srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int>)LpVtbl[8])(@this, destPoint, bitmap, srcRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromBitmap(D2D_POINT_2U* destPoint, ID2D1Bitmap* bitmap, ref D2D_RECT_U srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_RECT_U* srcRectPtr = &srcRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int>)LpVtbl[8])(@this, destPoint, bitmap, srcRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromBitmap(D2D_POINT_2U* destPoint, ref ID2D1Bitmap bitmap, D2D_RECT_U* srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int>)LpVtbl[8])(@this, destPoint, bitmapPtr, srcRect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromBitmap(D2D_POINT_2U* destPoint, ref ID2D1Bitmap bitmap, ref D2D_RECT_U srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (D2D_RECT_U* srcRectPtr = &srcRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int>)LpVtbl[8])(@this, destPoint, bitmapPtr, srcRectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromBitmap(ref D2D_POINT_2U destPoint, ID2D1Bitmap* bitmap, D2D_RECT_U* srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2U* destPointPtr = &destPoint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int>)LpVtbl[8])(@this, destPointPtr, bitmap, srcRect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromBitmap(ref D2D_POINT_2U destPoint, ID2D1Bitmap* bitmap, ref D2D_RECT_U srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2U* destPointPtr = &destPoint)
            {
                fixed (D2D_RECT_U* srcRectPtr = &srcRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int>)LpVtbl[8])(@this, destPointPtr, bitmap, srcRectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromBitmap(ref D2D_POINT_2U destPoint, ref ID2D1Bitmap bitmap, D2D_RECT_U* srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2U* destPointPtr = &destPoint)
            {
                fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int>)LpVtbl[8])(@this, destPointPtr, bitmapPtr, srcRect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyFromBitmap(ref D2D_POINT_2U destPoint, ref ID2D1Bitmap bitmap, ref D2D_RECT_U srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2U* destPointPtr = &destPoint)
            {
                fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
                {
                    fixed (D2D_RECT_U* srcRectPtr = &srcRect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int>)LpVtbl[8])(@this, destPointPtr, bitmapPtr, srcRectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromRenderTarget(D2D_POINT_2U* destPoint, ID2D1RenderTarget* renderTarget, D2D_RECT_U* srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int>)LpVtbl[9])(@this, destPoint, renderTarget, srcRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromRenderTarget(D2D_POINT_2U* destPoint, ID2D1RenderTarget* renderTarget, ref D2D_RECT_U srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_RECT_U* srcRectPtr = &srcRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int>)LpVtbl[9])(@this, destPoint, renderTarget, srcRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromRenderTarget(D2D_POINT_2U* destPoint, ref ID2D1RenderTarget renderTarget, D2D_RECT_U* srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RenderTarget* renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int>)LpVtbl[9])(@this, destPoint, renderTargetPtr, srcRect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromRenderTarget(D2D_POINT_2U* destPoint, ref ID2D1RenderTarget renderTarget, ref D2D_RECT_U srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RenderTarget* renderTargetPtr = &renderTarget)
            {
                fixed (D2D_RECT_U* srcRectPtr = &srcRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int>)LpVtbl[9])(@this, destPoint, renderTargetPtr, srcRectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromRenderTarget(ref D2D_POINT_2U destPoint, ID2D1RenderTarget* renderTarget, D2D_RECT_U* srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2U* destPointPtr = &destPoint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int>)LpVtbl[9])(@this, destPointPtr, renderTarget, srcRect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromRenderTarget(ref D2D_POINT_2U destPoint, ID2D1RenderTarget* renderTarget, ref D2D_RECT_U srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2U* destPointPtr = &destPoint)
            {
                fixed (D2D_RECT_U* srcRectPtr = &srcRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int>)LpVtbl[9])(@this, destPointPtr, renderTarget, srcRectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromRenderTarget(ref D2D_POINT_2U destPoint, ref ID2D1RenderTarget renderTarget, D2D_RECT_U* srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2U* destPointPtr = &destPoint)
            {
                fixed (ID2D1RenderTarget* renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int>)LpVtbl[9])(@this, destPointPtr, renderTargetPtr, srcRect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyFromRenderTarget(ref D2D_POINT_2U destPoint, ref ID2D1RenderTarget renderTarget, ref D2D_RECT_U srcRect)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2U* destPointPtr = &destPoint)
            {
                fixed (ID2D1RenderTarget* renderTargetPtr = &renderTarget)
                {
                    fixed (D2D_RECT_U* srcRectPtr = &srcRect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int>)LpVtbl[9])(@this, destPointPtr, renderTargetPtr, srcRectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromMemory(D2D_RECT_U* dstRect, void* srcData, uint pitch)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_RECT_U*, void*, uint, int>)LpVtbl[10])(@this, dstRect, srcData, pitch);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromMemory<T0>(D2D_RECT_U* dstRect, ref T0 srcData, uint pitch) where T0 : unmanaged
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* srcDataPtr = &srcData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_RECT_U*, void*, uint, int>)LpVtbl[10])(@this, dstRect, srcDataPtr, pitch);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromMemory(ref D2D_RECT_U dstRect, void* srcData, uint pitch)
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_RECT_U* dstRectPtr = &dstRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_RECT_U*, void*, uint, int>)LpVtbl[10])(@this, dstRectPtr, srcData, pitch);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyFromMemory<T0>(ref D2D_RECT_U dstRect, ref T0 srcData, uint pitch) where T0 : unmanaged
        {
            var @this = (ID2D1Bitmap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_RECT_U* dstRectPtr = &dstRect)
            {
                fixed (void* srcDataPtr = &srcData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, D2D_RECT_U*, void*, uint, int>)LpVtbl[10])(@this, dstRectPtr, srcDataPtr, pitch);
                }
            }
            return ret;
        }

    }
}
