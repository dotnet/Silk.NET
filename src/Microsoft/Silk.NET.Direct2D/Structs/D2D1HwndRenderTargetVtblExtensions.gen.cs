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

namespace Silk.NET.Direct2D;

public unsafe static class D2D1HwndRenderTargetVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcData, pitch, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcData, pitch, bitmapProperties, bitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcData, pitch, bitmapPropertiesPtr, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcData, pitch, bitmapPropertiesPtr, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* srcDataPtr = &srcData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapProperties, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* srcDataPtr = &srcData)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapProperties, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* srcDataPtr = &srcData)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapPropertiesPtr, bitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* srcDataPtr = &srcData)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapPropertiesPtr, bitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, IWICBitmapSource* wicBitmapSource, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSource, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, IWICBitmapSource* wicBitmapSource, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSource, bitmapProperties, bitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, IWICBitmapSource* wicBitmapSource, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSource, bitmapPropertiesPtr, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, IWICBitmapSource* wicBitmapSource, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSource, bitmapPropertiesPtr, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref IWICBitmapSource wicBitmapSource, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSourcePtr, bitmapProperties, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref IWICBitmapSource wicBitmapSource, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSourcePtr, bitmapProperties, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref IWICBitmapSource wicBitmapSource, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSourcePtr, bitmapPropertiesPtr, bitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref IWICBitmapSource wicBitmapSource, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSourcePtr, bitmapPropertiesPtr, bitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, void* data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, data, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, void* data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, data, bitmapProperties, bitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, void* data, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, data, bitmapPropertiesPtr, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, void* data, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, data, bitmapPropertiesPtr, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, ref T0 data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, dataPtr, bitmapProperties, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, ref T0 data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* dataPtr = &data)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, dataPtr, bitmapProperties, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, ref T0 data, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* dataPtr = &data)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, dataPtr, bitmapPropertiesPtr, bitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, ref T0 data, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* dataPtr = &data)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, dataPtr, bitmapPropertiesPtr, bitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, void* data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, data, bitmapProperties, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, void* data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, data, bitmapProperties, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, void* data, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, data, bitmapPropertiesPtr, bitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, void* data, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, data, bitmapPropertiesPtr, bitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, ref T0 data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, dataPtr, bitmapProperties, bitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, ref T0 data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* dataPtr = &data)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, dataPtr, bitmapProperties, bitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, ref T0 data, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* dataPtr = &data)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, dataPtr, bitmapPropertiesPtr, bitmap);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, ref T0 data, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* dataPtr = &data)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, dataPtr, bitmapPropertiesPtr, bitmapPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushProperties, bitmapBrushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushPropertiesPtr, bitmapBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushPropertiesPtr, bitmapBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushProperties, bitmapBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
        {
            fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushProperties, bitmapBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushProperties, bitmapBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushProperties, bitmapBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushPropertiesPtr, bitmapBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushPropertiesPtr, bitmapBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushProperties, bitmapBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushProperties, bitmapBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrush);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrushPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color, BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, color, brushProperties, solidColorBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color, BrushProperties* brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, color, brushProperties, solidColorBrushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color, ref BrushProperties brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, color, brushPropertiesPtr, solidColorBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color, ref BrushProperties brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, color, brushPropertiesPtr, solidColorBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.DXGI.D3Dcolorvalue color, BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, colorPtr, brushProperties, solidColorBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.DXGI.D3Dcolorvalue color, BrushProperties* brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, colorPtr, brushProperties, solidColorBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.DXGI.D3Dcolorvalue color, ref BrushProperties brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, colorPtr, brushPropertiesPtr, solidColorBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.DXGI.D3Dcolorvalue color, ref BrushProperties brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, colorPtr, brushPropertiesPtr, solidColorBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)@this->LpVtbl[9])(@this, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ID2D1GradientStopCollection* gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GradientStopCollection** gradientStopCollectionPtr = &gradientStopCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)@this->LpVtbl[9])(@this, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollectionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref GradientStop gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GradientStop* gradientStopsPtr = &gradientStops)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)@this->LpVtbl[9])(@this, gradientStopsPtr, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref GradientStop gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ID2D1GradientStopCollection* gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GradientStop* gradientStopsPtr = &gradientStops)
        {
            fixed (ID2D1GradientStopCollection** gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)@this->LpVtbl[9])(@this, gradientStopsPtr, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollectionPtr, linearGradientBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
        {
            fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollectionPtr, linearGradientBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, linearGradientBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, linearGradientBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, linearGradientBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, linearGradientBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, linearGradientBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, linearGradientBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, linearGradientBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, linearGradientBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrush);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrushPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollectionPtr, radialGradientBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
        {
            fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollectionPtr, radialGradientBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, radialGradientBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, radialGradientBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, radialGradientBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, radialGradientBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, radialGradientBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, radialGradientBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, radialGradientBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, radialGradientBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrush);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrushPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
        {
            fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
        {
            fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
        {
            fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
        {
            fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
            {
                fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormat, options, bitmapRenderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
            {
                fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTarget);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                {
                    fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTargetPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* size, ID2D1Layer** layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)@this->LpVtbl[13])(@this, size, layer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* size, ref ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Layer** layerPtr = &layer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)@this->LpVtbl[13])(@this, size, layerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> size, ID2D1Layer** layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* sizePtr = &size)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)@this->LpVtbl[13])(@this, sizePtr, layer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> size, ref ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* sizePtr = &size)
        {
            fixed (ID2D1Layer** layerPtr = &layer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)@this->LpVtbl[13])(@this, sizePtr, layerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMesh(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Mesh** mesh)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Mesh**, int>)@this->LpVtbl[14])(@this, mesh);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMesh(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Mesh* mesh)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Mesh** meshPtr = &mesh)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Mesh**, int>)@this->LpVtbl[14])(@this, meshPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawLine(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[15])(@this, point0, point1, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawLine(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[15])(@this, point0, point1, brush, strokeWidth, strokeStylePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawLine(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[15])(@this, point0, point1, brushPtr, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawLine(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[15])(@this, point0, point1, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStylePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rect, brushPtr, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rect, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rectPtr, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rectPtr, brush, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rectPtr, brushPtr, strokeWidth, strokeStyle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rectPtr, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)@this->LpVtbl[17])(@this, rect, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)@this->LpVtbl[17])(@this, rect, brushPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)@this->LpVtbl[17])(@this, rectPtr, brush);
        }
    }

    /// <summary>To be documented.</summary>
    public static void FillRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)@this->LpVtbl[17])(@this, rectPtr, brushPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRect, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRect, brush, strokeWidth, strokeStylePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRect, brushPtr, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRect, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RoundedRect roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (RoundedRect* roundedRectPtr = &roundedRect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRectPtr, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RoundedRect roundedRect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (RoundedRect* roundedRectPtr = &roundedRect)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRectPtr, brush, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RoundedRect roundedRect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (RoundedRect* roundedRectPtr = &roundedRect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRectPtr, brushPtr, strokeWidth, strokeStyle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RoundedRect roundedRect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (RoundedRect* roundedRectPtr = &roundedRect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRectPtr, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RoundedRect*, ID2D1Brush*, void>)@this->LpVtbl[19])(@this, roundedRect, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RoundedRect*, ID2D1Brush*, void>)@this->LpVtbl[19])(@this, roundedRect, brushPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RoundedRect roundedRect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        fixed (RoundedRect* roundedRectPtr = &roundedRect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RoundedRect*, ID2D1Brush*, void>)@this->LpVtbl[19])(@this, roundedRectPtr, brush);
        }
    }

    /// <summary>To be documented.</summary>
    public static void FillRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RoundedRect roundedRect, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (RoundedRect* roundedRectPtr = &roundedRect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RoundedRect*, ID2D1Brush*, void>)@this->LpVtbl[19])(@this, roundedRectPtr, brushPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipse, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipse, brush, strokeWidth, strokeStylePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipse, brushPtr, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipse, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Ellipse ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipsePtr, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Ellipse ellipse, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipsePtr, brush, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Ellipse ellipse, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipsePtr, brushPtr, strokeWidth, strokeStyle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Ellipse ellipse, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipsePtr, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Ellipse*, ID2D1Brush*, void>)@this->LpVtbl[21])(@this, ellipse, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Ellipse*, ID2D1Brush*, void>)@this->LpVtbl[21])(@this, ellipse, brushPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Ellipse ellipse, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Ellipse*, ID2D1Brush*, void>)@this->LpVtbl[21])(@this, ellipsePtr, brush);
        }
    }

    /// <summary>To be documented.</summary>
    public static void FillEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Ellipse ellipse, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Ellipse*, ID2D1Brush*, void>)@this->LpVtbl[21])(@this, ellipsePtr, brushPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometry, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometry, brush, strokeWidth, strokeStylePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometry, brushPtr, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometry, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometryPtr, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometryPtr, brush, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometryPtr, brushPtr, strokeWidth, strokeStyle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometryPtr, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometry, brush, opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, ref ID2D1Brush opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometry, brush, opacityBrushPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, ref ID2D1Brush brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometry, brushPtr, opacityBrush);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometry, brushPtr, opacityBrushPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometryPtr, brush, opacityBrush);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ID2D1Brush* brush, ref ID2D1Brush opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometryPtr, brush, opacityBrushPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometryPtr, brushPtr, opacityBrush);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometryPtr, brushPtr, opacityBrushPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillMesh(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Mesh* mesh, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Mesh*, ID2D1Brush*, void>)@this->LpVtbl[24])(@this, mesh, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillMesh(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Mesh* mesh, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Mesh*, ID2D1Brush*, void>)@this->LpVtbl[24])(@this, mesh, brushPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillMesh(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Mesh mesh, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Mesh* meshPtr = &mesh)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Mesh*, ID2D1Brush*, void>)@this->LpVtbl[24])(@this, meshPtr, brush);
        }
    }

    /// <summary>To be documented.</summary>
    public static void FillMesh(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Mesh mesh, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Mesh* meshPtr = &mesh)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Mesh*, ID2D1Brush*, void>)@this->LpVtbl[24])(@this, meshPtr, brushPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brush, content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brush, content, destinationRectangle, sourceRectanglePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brush, content, destinationRectanglePtr, sourceRectangle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brush, content, destinationRectanglePtr, sourceRectanglePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectangle, sourceRectangle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectangle, sourceRectanglePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectanglePtr, sourceRectangle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectanglePtr, sourceRectanglePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectangle, sourceRectangle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectangle, sourceRectanglePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectanglePtr, sourceRectangle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectanglePtr, sourceRectanglePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectangle, sourceRectangle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectangle, sourceRectanglePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectanglePtr, sourceRectangle);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectanglePtr, sourceRectanglePtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectangle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRect, defaultFillBrushPtr, options, measuringMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRectPtr, defaultFillBrush, options, measuringMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
        {
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormatPtr, layoutRect, defaultFillBrush, options, measuringMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormatPtr, layoutRect, defaultFillBrushPtr, options, measuringMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref char @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (char* @stringPtr = &@string)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref char @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (char* @stringPtr = &@string)
        {
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrushPtr, options, measuringMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref char @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (char* @stringPtr = &@string)
        {
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref char @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (char* @stringPtr = &@string)
        {
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (char* @stringPtr = &@string)
        {
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRect, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (char* @stringPtr = &@string)
        {
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRect, defaultFillBrushPtr, options, measuringMode);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (char* @stringPtr = &@string)
        {
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrush, options, measuringMode);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (char* @stringPtr = &@string)
        {
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
        SilkMarshal.Free((nint)@stringPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrushPtr, options, measuringMode);
        }
        SilkMarshal.Free((nint)@stringPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrush, options, measuringMode);
        }
        SilkMarshal.Free((nint)@stringPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
        {
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
            }
        }
        SilkMarshal.Free((nint)@stringPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRect, defaultFillBrush, options, measuringMode);
        }
        SilkMarshal.Free((nint)@stringPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRect, defaultFillBrushPtr, options, measuringMode);
            }
        }
        SilkMarshal.Free((nint)@stringPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrush, options, measuringMode);
            }
        }
        SilkMarshal.Free((nint)@stringPtr);
    }

    /// <summary>To be documented.</summary>
    public static void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                }
            }
        }
        SilkMarshal.Free((nint)@stringPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextLayout(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)@this->LpVtbl[28])(@this, origin, textLayout, defaultFillBrush, options);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextLayout(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, ref ID2D1Brush defaultFillBrush, DrawTextOptions options)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)@this->LpVtbl[28])(@this, origin, textLayout, defaultFillBrushPtr, options);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextLayout(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, ref IDWriteTextLayout textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options)
    {
        var @this = thisVtbl.Handle;
        fixed (IDWriteTextLayout* textLayoutPtr = &textLayout)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)@this->LpVtbl[28])(@this, origin, textLayoutPtr, defaultFillBrush, options);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawTextLayout(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, ref IDWriteTextLayout textLayout, ref ID2D1Brush defaultFillBrush, DrawTextOptions options)
    {
        var @this = thisVtbl.Handle;
        fixed (IDWriteTextLayout* textLayoutPtr = &textLayout)
        {
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)@this->LpVtbl[28])(@this, origin, textLayoutPtr, defaultFillBrushPtr, options);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGlyphRun(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)@this->LpVtbl[29])(@this, baselineOrigin, glyphRun, foregroundBrush, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGlyphRun(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, ref ID2D1Brush foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* foregroundBrushPtr = &foregroundBrush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)@this->LpVtbl[29])(@this, baselineOrigin, glyphRun, foregroundBrushPtr, measuringMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGlyphRun(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)@this->LpVtbl[29])(@this, baselineOrigin, glyphRunPtr, foregroundBrush, measuringMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawGlyphRun(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, ref ID2D1Brush foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (ID2D1Brush* foregroundBrushPtr = &foregroundBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)@this->LpVtbl[29])(@this, baselineOrigin, glyphRunPtr, foregroundBrushPtr, measuringMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTransform(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[30])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static void SetTransform(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Matrix3X2<float> transform)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[30])(@this, transformPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTransform(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[31])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static void GetTransform(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Matrix3X2<float> transform)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[31])(@this, transformPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetAntialiasMode(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, AntialiasMode, void>)@this->LpVtbl[32])(@this, antialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static AntialiasMode GetAntialiasMode(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        AntialiasMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, AntialiasMode>)@this->LpVtbl[33])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetTextAntialiasMode(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, TextAntialiasMode textAntialiasMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, TextAntialiasMode, void>)@this->LpVtbl[34])(@this, textAntialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static TextAntialiasMode GetTextAntialiasMode(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TextAntialiasMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, TextAntialiasMode>)@this->LpVtbl[35])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTextRenderingParams(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, IDWriteRenderingParams* textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IDWriteRenderingParams*, void>)@this->LpVtbl[36])(@this, textRenderingParams);
    }

    /// <summary>To be documented.</summary>
    public static void SetTextRenderingParams(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref IDWriteRenderingParams textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        fixed (IDWriteRenderingParams* textRenderingParamsPtr = &textRenderingParams)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IDWriteRenderingParams*, void>)@this->LpVtbl[36])(@this, textRenderingParamsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTextRenderingParams(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, IDWriteRenderingParams** textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IDWriteRenderingParams**, void>)@this->LpVtbl[37])(@this, textRenderingParams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTextRenderingParams(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref IDWriteRenderingParams* textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        fixed (IDWriteRenderingParams** textRenderingParamsPtr = &textRenderingParams)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IDWriteRenderingParams**, void>)@this->LpVtbl[37])(@this, textRenderingParamsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetTags(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ulong tag1, ulong tag2)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong, ulong, void>)@this->LpVtbl[38])(@this, tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTags(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, void>)@this->LpVtbl[39])(@this, tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTags(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ulong* tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        fixed (ulong* tag2Ptr = &tag2)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, void>)@this->LpVtbl[39])(@this, tag1, tag2Ptr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTags(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ulong tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        fixed (ulong* tag1Ptr = &tag1)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, void>)@this->LpVtbl[39])(@this, tag1Ptr, tag2);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetTags(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ulong tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        fixed (ulong* tag1Ptr = &tag1)
        {
            fixed (ulong* tag2Ptr = &tag2)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, void>)@this->LpVtbl[39])(@this, tag1Ptr, tag2Ptr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LayerParameters* layerParameters, ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LayerParameters*, ID2D1Layer*, void>)@this->LpVtbl[40])(@this, layerParameters, layer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LayerParameters* layerParameters, ref ID2D1Layer layer)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Layer* layerPtr = &layer)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LayerParameters*, ID2D1Layer*, void>)@this->LpVtbl[40])(@this, layerParameters, layerPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LayerParameters layerParameters, ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        fixed (LayerParameters* layerParametersPtr = &layerParameters)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LayerParameters*, ID2D1Layer*, void>)@this->LpVtbl[40])(@this, layerParametersPtr, layer);
        }
    }

    /// <summary>To be documented.</summary>
    public static void PushLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LayerParameters layerParameters, ref ID2D1Layer layer)
    {
        var @this = thisVtbl.Handle;
        fixed (LayerParameters* layerParametersPtr = &layerParameters)
        {
            fixed (ID2D1Layer* layerPtr = &layer)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, LayerParameters*, ID2D1Layer*, void>)@this->LpVtbl[40])(@this, layerParametersPtr, layerPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void PopLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, void>)@this->LpVtbl[41])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Flush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, int>)@this->LpVtbl[42])(@this, tag1, tag2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Flush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ulong* tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag2Ptr = &tag2)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, int>)@this->LpVtbl[42])(@this, tag1, tag2Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Flush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ulong tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag1Ptr = &tag1)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, int>)@this->LpVtbl[42])(@this, tag1Ptr, tag2);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Flush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ulong tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag1Ptr = &tag1)
        {
            fixed (ulong* tag2Ptr = &tag2)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, int>)@this->LpVtbl[42])(@this, tag1Ptr, tag2Ptr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SaveDrawingState(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1DrawingStateBlock*, void>)@this->LpVtbl[43])(@this, drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static void SaveDrawingState(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1DrawingStateBlock drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1DrawingStateBlock* drawingStateBlockPtr = &drawingStateBlock)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1DrawingStateBlock*, void>)@this->LpVtbl[43])(@this, drawingStateBlockPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RestoreDrawingState(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1DrawingStateBlock*, void>)@this->LpVtbl[44])(@this, drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static void RestoreDrawingState(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1DrawingStateBlock drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1DrawingStateBlock* drawingStateBlockPtr = &drawingStateBlock)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1DrawingStateBlock*, void>)@this->LpVtbl[44])(@this, drawingStateBlockPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushAxisAlignedClip(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* clipRect, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, void>)@this->LpVtbl[45])(@this, clipRect, antialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static void PushAxisAlignedClip(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Box2D<float> clipRect, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* clipRectPtr = &clipRect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, void>)@this->LpVtbl[45])(@this, clipRectPtr, antialiasMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static void PopAxisAlignedClip(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, void>)@this->LpVtbl[46])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Clear(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* clearColor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, void>)@this->LpVtbl[47])(@this, clearColor);
    }

    /// <summary>To be documented.</summary>
    public static void Clear(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.DXGI.D3Dcolorvalue clearColor)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* clearColorPtr = &clearColor)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, void>)@this->LpVtbl[47])(@this, clearColorPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void BeginDraw(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, void>)@this->LpVtbl[48])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndDraw(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, int>)@this->LpVtbl[49])(@this, tag1, tag2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndDraw(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ulong* tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag2Ptr = &tag2)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, int>)@this->LpVtbl[49])(@this, tag1, tag2Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndDraw(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ulong tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag1Ptr = &tag1)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, int>)@this->LpVtbl[49])(@this, tag1Ptr, tag2);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndDraw(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ulong tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag1Ptr = &tag1)
        {
            fixed (ulong* tag2Ptr = &tag2)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, int>)@this->LpVtbl[49])(@this, tag1Ptr, tag2Ptr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static PixelFormat GetPixelFormat(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        PixelFormat ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, PixelFormat>)@this->LpVtbl[50])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetDpi(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, float dpiX, float dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, float, float, void>)@this->LpVtbl[51])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, float*, float*, void>)@this->LpVtbl[52])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, float* dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiYPtr = &dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, float*, float*, void>)@this->LpVtbl[52])(@this, dpiX, dpiYPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref float dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, float*, float*, void>)@this->LpVtbl[52])(@this, dpiXPtr, dpiY);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetDpi(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref float dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, float*, float*, void>)@this->LpVtbl[52])(@this, dpiXPtr, dpiYPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<float> GetSize(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<float> ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<float>>)@this->LpVtbl[53])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<uint> GetPixelSize(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<uint> ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<uint>>)@this->LpVtbl[54])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetMaximumBitmapSize(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, uint>)@this->LpVtbl[55])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsSupported(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RenderTargetProperties* renderTargetProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RenderTargetProperties*, int>)@this->LpVtbl[56])(@this, renderTargetProperties);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsSupported(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RenderTargetProperties renderTargetProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, RenderTargetProperties*, int>)@this->LpVtbl[56])(@this, renderTargetPropertiesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static WindowState CheckWindowState(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        WindowState ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, WindowState>)@this->LpVtbl[57])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Resize(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint>* pixelSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<uint>*, int>)@this->LpVtbl[58])(@this, pixelSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Resize(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> pixelSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* pixelSizePtr = &pixelSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Silk.NET.Maths.Vector2D<uint>*, int>)@this->LpVtbl[58])(@this, pixelSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nint GetHwnd(this ComPtr<ID2D1HwndRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        nint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, nint>)@this->LpVtbl[59])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmap(size, srcData, pitch, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, Span<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(size, srcData, pitch, ref bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, ref BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmap(size, srcData, pitch, ref bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, Span<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(size, srcData, pitch, ref bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, Span<T0> srcData, uint pitch, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(size, ref srcData.GetPinnableReference(), pitch, bitmapProperties, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0, TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmap(size, ref srcData, pitch, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, Span<T0> srcData, uint pitch, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(size, ref srcData.GetPinnableReference(), pitch, bitmapProperties, ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, Span<T0> srcData, uint pitch, Span<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(size, ref srcData.GetPinnableReference(), pitch, ref bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmap<T0, TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, ref BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmap(size, ref srcData, pitch, ref bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, Span<T0> srcData, uint pitch, Span<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(size, ref srcData.GetPinnableReference(), pitch, ref bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, IWICBitmapSource* wicBitmapSource, BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, IWICBitmapSource* wicBitmapSource, Span<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromWicBitmap(wicBitmapSource, ref bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, IWICBitmapSource* wicBitmapSource, ref BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromWicBitmap(wicBitmapSource, ref bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, IWICBitmapSource* wicBitmapSource, Span<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromWicBitmap(wicBitmapSource, ref bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<IWICBitmapSource> wicBitmapSource, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromWicBitmap(ref wicBitmapSource.GetPinnableReference(), bitmapProperties, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref IWICBitmapSource wicBitmapSource, BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromWicBitmap(ref wicBitmapSource, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<IWICBitmapSource> wicBitmapSource, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromWicBitmap(ref wicBitmapSource.GetPinnableReference(), bitmapProperties, ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<IWICBitmapSource> wicBitmapSource, Span<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromWicBitmap(ref wicBitmapSource.GetPinnableReference(), ref bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapFromWicBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref IWICBitmapSource wicBitmapSource, ref BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromWicBitmap(ref wicBitmapSource, ref bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<IWICBitmapSource> wicBitmapSource, Span<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromWicBitmap(ref wicBitmapSource.GetPinnableReference(), ref bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, void* data, BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(riid, data, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, void* data, Span<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(riid, data, ref bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, void* data, ref BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(riid, data, ref bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, void* data, Span<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(riid, data, ref bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, Span<T0> data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(riid, ref data.GetPinnableReference(), bitmapProperties, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0, TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, ref T0 data, BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(riid, ref data, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, Span<T0> data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(riid, ref data.GetPinnableReference(), bitmapProperties, ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, Span<T0> data, Span<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(riid, ref data.GetPinnableReference(), ref bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0, TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, ref T0 data, ref BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(riid, ref data, ref bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Guid* riid, Span<T0> data, Span<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(riid, ref data.GetPinnableReference(), ref bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Guid> riid, void* data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), data, bitmapProperties, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, void* data, BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(ref riid, data, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Guid> riid, void* data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), data, bitmapProperties, ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Guid> riid, void* data, Span<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), data, ref bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, void* data, ref BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(ref riid, data, ref bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Guid> riid, void* data, Span<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), data, ref bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Guid> riid, Span<T0> data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), ref data.GetPinnableReference(), bitmapProperties, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0, TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, ref T0 data, BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(ref riid, ref data, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Guid> riid, Span<T0> data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), ref data.GetPinnableReference(), bitmapProperties, ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Guid> riid, Span<T0> data, Span<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), ref data.GetPinnableReference(), ref bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSharedBitmap<T0, TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Guid riid, ref T0 data, ref BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(ref riid, ref data, ref bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Guid> riid, Span<T0> data, Span<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), ref data.GetPinnableReference(), ref bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ref ComPtr<TI1> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, bitmapBrushProperties, brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, bitmapBrushProperties, brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, Span<BrushProperties> brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(bitmap, bitmapBrushProperties, ref brushProperties.GetPinnableReference(), bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ref ComPtr<TI1> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, bitmapBrushProperties, ref brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, Span<BrushProperties> brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(bitmap, bitmapBrushProperties, ref brushProperties.GetPinnableReference(), ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, bitmapBrushProperties, ref brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, Span<BitmapBrushProperties> bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(bitmap, ref bitmapBrushProperties.GetPinnableReference(), brushProperties, bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ref ComPtr<TI1> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, ref bitmapBrushProperties, brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, Span<BitmapBrushProperties> bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(bitmap, ref bitmapBrushProperties.GetPinnableReference(), brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, ref bitmapBrushProperties, brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, Span<BitmapBrushProperties> bitmapBrushProperties, Span<BrushProperties> brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(bitmap, ref bitmapBrushProperties.GetPinnableReference(), ref brushProperties.GetPinnableReference(), bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapBrush<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ref ComPtr<TI1> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, ref bitmapBrushProperties, ref brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, Span<BitmapBrushProperties> bitmapBrushProperties, Span<BrushProperties> brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(bitmap, ref bitmapBrushProperties.GetPinnableReference(), ref brushProperties.GetPinnableReference(), ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, ref bitmapBrushProperties, ref brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), bitmapBrushProperties, brushProperties, bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ref ComPtr<TI0> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush(ref bitmap, bitmapBrushProperties, brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), bitmapBrushProperties, brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> bitmap, BitmapBrushProperties* bitmapBrushProperties, Span<BrushProperties> brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), bitmapBrushProperties, ref brushProperties.GetPinnableReference(), bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ref ComPtr<TI0> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush(ref bitmap, bitmapBrushProperties, ref brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> bitmap, BitmapBrushProperties* bitmapBrushProperties, Span<BrushProperties> brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), bitmapBrushProperties, ref brushProperties.GetPinnableReference(), ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> bitmap, Span<BitmapBrushProperties> bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), ref bitmapBrushProperties.GetPinnableReference(), brushProperties, bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ref ComPtr<TI0> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush(ref bitmap, ref bitmapBrushProperties, brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> bitmap, Span<BitmapBrushProperties> bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), ref bitmapBrushProperties.GetPinnableReference(), brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> bitmap, Span<BitmapBrushProperties> bitmapBrushProperties, Span<BrushProperties> brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), ref bitmapBrushProperties.GetPinnableReference(), ref brushProperties.GetPinnableReference(), bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ref ComPtr<TI0> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush(ref bitmap, ref bitmapBrushProperties, ref brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> bitmap, Span<BitmapBrushProperties> bitmapBrushProperties, Span<BrushProperties> brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), ref bitmapBrushProperties.GetPinnableReference(), ref brushProperties.GetPinnableReference(), ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color, BrushProperties* brushProperties, ref ComPtr<TI0> solidColorBrush) where TI0 : unmanaged, IComVtbl<ID2D1SolidColorBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSolidColorBrush(color, brushProperties, (ID2D1SolidColorBrush**) solidColorBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color, Span<BrushProperties> brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSolidColorBrush(color, ref brushProperties.GetPinnableReference(), solidColorBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color, ref BrushProperties brushProperties, ref ComPtr<TI0> solidColorBrush) where TI0 : unmanaged, IComVtbl<ID2D1SolidColorBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSolidColorBrush(color, ref brushProperties, (ID2D1SolidColorBrush**) solidColorBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color, Span<BrushProperties> brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSolidColorBrush(color, ref brushProperties.GetPinnableReference(), ref solidColorBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.DXGI.D3Dcolorvalue> color, BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSolidColorBrush(ref color.GetPinnableReference(), brushProperties, solidColorBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.DXGI.D3Dcolorvalue color, BrushProperties* brushProperties, ref ComPtr<TI0> solidColorBrush) where TI0 : unmanaged, IComVtbl<ID2D1SolidColorBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSolidColorBrush(ref color, brushProperties, (ID2D1SolidColorBrush**) solidColorBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.DXGI.D3Dcolorvalue> color, BrushProperties* brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSolidColorBrush(ref color.GetPinnableReference(), brushProperties, ref solidColorBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.DXGI.D3Dcolorvalue> color, Span<BrushProperties> brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSolidColorBrush(ref color.GetPinnableReference(), ref brushProperties.GetPinnableReference(), solidColorBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSolidColorBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.DXGI.D3Dcolorvalue color, ref BrushProperties brushProperties, ref ComPtr<TI0> solidColorBrush) where TI0 : unmanaged, IComVtbl<ID2D1SolidColorBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSolidColorBrush(ref color, ref brushProperties, (ID2D1SolidColorBrush**) solidColorBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.DXGI.D3Dcolorvalue> color, Span<BrushProperties> brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSolidColorBrush(ref color.GetPinnableReference(), ref brushProperties.GetPinnableReference(), ref solidColorBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ComPtr<TI0> gradientStopCollection) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGradientStopCollection(gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, (ID2D1GradientStopCollection**) gradientStopCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<GradientStop> gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGradientStopCollection(ref gradientStops.GetPinnableReference(), gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGradientStopCollection<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref GradientStop gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ComPtr<TI0> gradientStopCollection) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGradientStopCollection(ref gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, (ID2D1GradientStopCollection**) gradientStopCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<GradientStop> gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ID2D1GradientStopCollection* gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGradientStopCollection(ref gradientStops.GetPinnableReference(), gradientStopsCount, colorInterpolationGamma, extendMode, ref gradientStopCollection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, brushProperties, ref gradientStopCollection.GetPinnableReference(), linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, brushProperties, ref gradientStopCollection, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, brushProperties, ref gradientStopCollection.GetPinnableReference(), ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, Span<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, ref brushProperties.GetPinnableReference(), gradientStopCollection, linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, ref brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, Span<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, ref brushProperties.GetPinnableReference(), gradientStopCollection, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, ref brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, Span<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, ref brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, ref brushProperties, ref gradientStopCollection, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LinearGradientBrushProperties* linearGradientBrushProperties, Span<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, ref brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<LinearGradientBrushProperties> linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties.GetPinnableReference(), brushProperties, gradientStopCollection, linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<LinearGradientBrushProperties> linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties.GetPinnableReference(), brushProperties, gradientStopCollection, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<LinearGradientBrushProperties> linearGradientBrushProperties, BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties.GetPinnableReference(), brushProperties, ref gradientStopCollection.GetPinnableReference(), linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties, brushProperties, ref gradientStopCollection, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<LinearGradientBrushProperties> linearGradientBrushProperties, BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties.GetPinnableReference(), brushProperties, ref gradientStopCollection.GetPinnableReference(), ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<LinearGradientBrushProperties> linearGradientBrushProperties, Span<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties.GetPinnableReference(), ref brushProperties.GetPinnableReference(), gradientStopCollection, linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateLinearGradientBrush<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties, ref brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<LinearGradientBrushProperties> linearGradientBrushProperties, Span<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties.GetPinnableReference(), ref brushProperties.GetPinnableReference(), gradientStopCollection, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties, ref brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<LinearGradientBrushProperties> linearGradientBrushProperties, Span<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties.GetPinnableReference(), ref brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties, ref brushProperties, ref gradientStopCollection, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<LinearGradientBrushProperties> linearGradientBrushProperties, Span<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(ref linearGradientBrushProperties.GetPinnableReference(), ref brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, brushProperties, ref gradientStopCollection.GetPinnableReference(), radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, brushProperties, ref gradientStopCollection, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, brushProperties, ref gradientStopCollection.GetPinnableReference(), ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, Span<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, ref brushProperties.GetPinnableReference(), gradientStopCollection, radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, ref brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, Span<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, ref brushProperties.GetPinnableReference(), gradientStopCollection, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, ref brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, Span<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, ref brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, ref brushProperties, ref gradientStopCollection, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RadialGradientBrushProperties* radialGradientBrushProperties, Span<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, ref brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RadialGradientBrushProperties> radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties.GetPinnableReference(), brushProperties, gradientStopCollection, radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RadialGradientBrushProperties> radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties.GetPinnableReference(), brushProperties, gradientStopCollection, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RadialGradientBrushProperties> radialGradientBrushProperties, BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties.GetPinnableReference(), brushProperties, ref gradientStopCollection.GetPinnableReference(), radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties, brushProperties, ref gradientStopCollection, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RadialGradientBrushProperties> radialGradientBrushProperties, BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties.GetPinnableReference(), brushProperties, ref gradientStopCollection.GetPinnableReference(), ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RadialGradientBrushProperties> radialGradientBrushProperties, Span<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties.GetPinnableReference(), ref brushProperties.GetPinnableReference(), gradientStopCollection, radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateRadialGradientBrush<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties, ref brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RadialGradientBrushProperties> radialGradientBrushProperties, Span<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties.GetPinnableReference(), ref brushProperties.GetPinnableReference(), gradientStopCollection, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties, ref brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RadialGradientBrushProperties> radialGradientBrushProperties, Span<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties.GetPinnableReference(), ref brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties, ref brushProperties, ref gradientStopCollection, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RadialGradientBrushProperties> radialGradientBrushProperties, Span<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(ref radialGradientBrushProperties.GetPinnableReference(), ref brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, desiredPixelSize, desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, Span<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, desiredPixelSize, ref desiredFormat.GetPinnableReference(), options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, desiredPixelSize, ref desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, Span<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, desiredPixelSize, ref desiredFormat.GetPinnableReference(), options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, Span<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, ref desiredPixelSize.GetPinnableReference(), desiredFormat, options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, ref desiredPixelSize, desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, Span<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, ref desiredPixelSize.GetPinnableReference(), desiredFormat, options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, Span<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, Span<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, ref desiredPixelSize.GetPinnableReference(), ref desiredFormat.GetPinnableReference(), options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, ref desiredPixelSize, ref desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* desiredSize, Span<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, Span<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, ref desiredPixelSize.GetPinnableReference(), ref desiredFormat.GetPinnableReference(), options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Vector2D<float>> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(ref desiredSize.GetPinnableReference(), desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(ref desiredSize, desiredPixelSize, desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Vector2D<float>> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(ref desiredSize.GetPinnableReference(), desiredPixelSize, desiredFormat, options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Vector2D<float>> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, Span<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(ref desiredSize.GetPinnableReference(), desiredPixelSize, ref desiredFormat.GetPinnableReference(), options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(ref desiredSize, desiredPixelSize, ref desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Vector2D<float>> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, Span<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(ref desiredSize.GetPinnableReference(), desiredPixelSize, ref desiredFormat.GetPinnableReference(), options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Vector2D<float>> desiredSize, Span<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(ref desiredSize.GetPinnableReference(), ref desiredPixelSize.GetPinnableReference(), desiredFormat, options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(ref desiredSize, ref desiredPixelSize, desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Vector2D<float>> desiredSize, Span<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(ref desiredSize.GetPinnableReference(), ref desiredPixelSize.GetPinnableReference(), desiredFormat, options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Vector2D<float>> desiredSize, Span<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, Span<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(ref desiredSize.GetPinnableReference(), ref desiredPixelSize.GetPinnableReference(), ref desiredFormat.GetPinnableReference(), options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(ref desiredSize, ref desiredPixelSize, ref desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Vector2D<float>> desiredSize, Span<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, Span<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(ref desiredSize.GetPinnableReference(), ref desiredPixelSize.GetPinnableReference(), ref desiredFormat.GetPinnableReference(), options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float>* size, ref ComPtr<TI0> layer) where TI0 : unmanaged, IComVtbl<ID2D1Layer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLayer(size, (ID2D1Layer**) layer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Vector2D<float>> size, ID2D1Layer** layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLayer(ref size.GetPinnableReference(), layer);
    }

    /// <summary>To be documented.</summary>
    public static int CreateLayer<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<float> size, ref ComPtr<TI0> layer) where TI0 : unmanaged, IComVtbl<ID2D1Layer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLayer(ref size, (ID2D1Layer**) layer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Vector2D<float>> size, ref ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLayer(ref size.GetPinnableReference(), ref layer);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMesh<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ComPtr<TI0> mesh) where TI0 : unmanaged, IComVtbl<ID2D1Mesh>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMesh((ID2D1Mesh**) mesh.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void DrawLine<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawLine(point0, point1, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawLine(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawLine(point0, point1, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawLine<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawLine(point0, point1, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawLine(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawLine(point0, point1, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawLine<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawLine(point0, point1, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawLine(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawLine(point0, point1, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRectangle(rect, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(rect, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRectangle(rect, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(rect, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRectangle(rect, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(rect, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Box2D<float>> rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(ref rect.GetPinnableReference(), brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawRectangle<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Box2D<float> rect, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRectangle(ref rect, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Box2D<float>> rect, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(ref rect.GetPinnableReference(), brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawRectangle<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Box2D<float> rect, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRectangle(ref rect, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Box2D<float>> rect, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(ref rect.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawRectangle<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRectangle(ref rect, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Box2D<float>> rect, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(ref rect.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillRectangle(rect, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Box2D<float>* rect, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillRectangle(rect, ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Box2D<float>> rect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillRectangle(ref rect.GetPinnableReference(), brush);
    }

    /// <summary>To be documented.</summary>
    public static void FillRectangle<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Silk.NET.Maths.Box2D<float> rect, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillRectangle(ref rect, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void FillRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Box2D<float>> rect, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillRectangle(ref rect.GetPinnableReference(), ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRoundedRectangle(roundedRect, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(roundedRect, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRoundedRectangle(roundedRect, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(roundedRect, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRoundedRectangle(roundedRect, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(roundedRect, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RoundedRect> roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(ref roundedRect.GetPinnableReference(), brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawRoundedRectangle<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RoundedRect roundedRect, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRoundedRectangle(ref roundedRect, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RoundedRect> roundedRect, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(ref roundedRect.GetPinnableReference(), brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawRoundedRectangle<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RoundedRect roundedRect, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRoundedRectangle(ref roundedRect, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RoundedRect> roundedRect, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(ref roundedRect.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawRoundedRectangle<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RoundedRect roundedRect, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRoundedRectangle(ref roundedRect, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RoundedRect> roundedRect, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(ref roundedRect.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillRoundedRectangle(roundedRect, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, RoundedRect* roundedRect, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillRoundedRectangle(roundedRect, ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RoundedRect> roundedRect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillRoundedRectangle(ref roundedRect.GetPinnableReference(), brush);
    }

    /// <summary>To be documented.</summary>
    public static void FillRoundedRectangle<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref RoundedRect roundedRect, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillRoundedRectangle(ref roundedRect, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void FillRoundedRectangle(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RoundedRect> roundedRect, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillRoundedRectangle(ref roundedRect.GetPinnableReference(), ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawEllipse(ellipse, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(ellipse, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawEllipse(ellipse, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(ellipse, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawEllipse(ellipse, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(ellipse, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Ellipse> ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(ref ellipse.GetPinnableReference(), brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawEllipse<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Ellipse ellipse, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawEllipse(ref ellipse, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Ellipse> ellipse, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(ref ellipse.GetPinnableReference(), brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawEllipse<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Ellipse ellipse, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawEllipse(ref ellipse, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Ellipse> ellipse, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(ref ellipse.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawEllipse<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Ellipse ellipse, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawEllipse(ref ellipse, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Ellipse> ellipse, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(ref ellipse.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillEllipse(ellipse, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Ellipse* ellipse, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillEllipse(ellipse, ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Ellipse> ellipse, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillEllipse(ref ellipse.GetPinnableReference(), brush);
    }

    /// <summary>To be documented.</summary>
    public static void FillEllipse<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref Ellipse ellipse, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillEllipse(ref ellipse, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void FillEllipse(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Ellipse> ellipse, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillEllipse(ref ellipse.GetPinnableReference(), ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0, TI1, TI2>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> geometry, ComPtr<TI1> brush, float strokeWidth, ComPtr<TI2> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(geometry, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> geometry, ComPtr<TI1> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(geometry, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> geometry, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(geometry, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, ref brush, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Geometry> geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(ref geometry.GetPinnableReference(), brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry(ref geometry, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Geometry> geometry, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(ref geometry.GetPinnableReference(), brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry(ref geometry, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Geometry> geometry, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(ref geometry.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry(ref geometry, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Geometry> geometry, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(ref geometry.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0, TI1, TI2>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> geometry, ComPtr<TI1> brush, ComPtr<TI2> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, (ID2D1Brush*) opacityBrush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, Span<ID2D1Brush> opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(geometry, brush, ref opacityBrush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> geometry, ComPtr<TI1> brush, ref ID2D1Brush opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, ref opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, Span<ID2D1Brush> brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(geometry, ref brush.GetPinnableReference(), opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> geometry, ref ID2D1Brush brush, ComPtr<TI1> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry((ID2D1Geometry*) geometry.Handle, ref brush, (ID2D1Brush*) opacityBrush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Geometry* geometry, Span<ID2D1Brush> brush, Span<ID2D1Brush> opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(geometry, ref brush.GetPinnableReference(), ref opacityBrush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry((ID2D1Geometry*) geometry.Handle, ref brush, ref opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Geometry> geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(ref geometry.GetPinnableReference(), brush, opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ComPtr<TI0> brush, ComPtr<TI1> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry(ref geometry, (ID2D1Brush*) brush.Handle, (ID2D1Brush*) opacityBrush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Geometry> geometry, ID2D1Brush* brush, Span<ID2D1Brush> opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(ref geometry.GetPinnableReference(), brush, ref opacityBrush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ComPtr<TI0> brush, ref ID2D1Brush opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry(ref geometry, (ID2D1Brush*) brush.Handle, ref opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Geometry> geometry, Span<ID2D1Brush> brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(ref geometry.GetPinnableReference(), ref brush.GetPinnableReference(), opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, ComPtr<TI0> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry(ref geometry, ref brush, (ID2D1Brush*) opacityBrush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Geometry> geometry, Span<ID2D1Brush> brush, Span<ID2D1Brush> opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(ref geometry.GetPinnableReference(), ref brush.GetPinnableReference(), ref opacityBrush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillMesh<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> mesh, ComPtr<TI1> brush) where TI0 : unmanaged, IComVtbl<ID2D1Mesh>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillMesh((ID2D1Mesh*) mesh.Handle, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillMesh(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Mesh* mesh, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillMesh(mesh, ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillMesh<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> mesh, ref ID2D1Brush brush) where TI0 : unmanaged, IComVtbl<ID2D1Mesh>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillMesh((ID2D1Mesh*) mesh.Handle, ref brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillMesh(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Mesh> mesh, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillMesh(ref mesh.GetPinnableReference(), brush);
    }

    /// <summary>To be documented.</summary>
    public static void FillMesh<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Mesh mesh, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillMesh(ref mesh, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void FillMesh(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Mesh> mesh, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillMesh(ref mesh.GetPinnableReference(), ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> opacityMask, ComPtr<TI1> brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, brush, content, destinationRectangle, ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> opacityMask, ComPtr<TI1> brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, content, destinationRectangle, ref sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Span<Silk.NET.Maths.Box2D<float>> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, brush, content, ref destinationRectangle.GetPinnableReference(), sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> opacityMask, ComPtr<TI1> brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, content, ref destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Span<Silk.NET.Maths.Box2D<float>> destinationRectangle, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, brush, content, ref destinationRectangle.GetPinnableReference(), ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillOpacityMask<TI0, TI1>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> opacityMask, ComPtr<TI1> brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, content, ref destinationRectangle, ref sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, ref brush.GetPinnableReference(), content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, ref brush.GetPinnableReference(), content, destinationRectangle, ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, content, destinationRectangle, ref sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, Span<Silk.NET.Maths.Box2D<float>> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, ref brush.GetPinnableReference(), content, ref destinationRectangle.GetPinnableReference(), sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, content, ref destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, Span<Silk.NET.Maths.Box2D<float>> destinationRectangle, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, ref brush.GetPinnableReference(), content, ref destinationRectangle.GetPinnableReference(), ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillOpacityMask<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, content, ref destinationRectangle, ref sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), brush, content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), brush, content, destinationRectangle, ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, content, destinationRectangle, ref sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Span<Silk.NET.Maths.Box2D<float>> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), brush, content, ref destinationRectangle.GetPinnableReference(), sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, content, ref destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Span<Silk.NET.Maths.Box2D<float>> destinationRectangle, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), brush, content, ref destinationRectangle.GetPinnableReference(), ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillOpacityMask<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, content, ref destinationRectangle, ref sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), ref brush.GetPinnableReference(), content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), ref brush.GetPinnableReference(), content, destinationRectangle, ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, Span<Silk.NET.Maths.Box2D<float>> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), ref brush.GetPinnableReference(), content, ref destinationRectangle.GetPinnableReference(), sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static void FillOpacityMask(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, Span<Silk.NET.Maths.Box2D<float>> destinationRectangle, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), ref brush.GetPinnableReference(), content, ref destinationRectangle.GetPinnableReference(), ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, destinationRectangle, opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(bitmap, destinationRectangle, opacity, interpolationMode, ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, destinationRectangle, opacity, interpolationMode, ref sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, Span<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(bitmap, ref destinationRectangle.GetPinnableReference(), opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, ref destinationRectangle, opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ID2D1Bitmap* bitmap, Span<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(bitmap, ref destinationRectangle.GetPinnableReference(), opacity, interpolationMode, ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawBitmap<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, ref destinationRectangle, opacity, interpolationMode, ref sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(ref bitmap.GetPinnableReference(), destinationRectangle, opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(ref bitmap.GetPinnableReference(), destinationRectangle, opacity, interpolationMode, ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> bitmap, Span<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(ref bitmap.GetPinnableReference(), ref destinationRectangle.GetPinnableReference(), opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawBitmap(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1Bitmap> bitmap, Span<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(ref bitmap.GetPinnableReference(), ref destinationRectangle.GetPinnableReference(), opacity, interpolationMode, ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(string, stringLength, textFormat, layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, textFormat, layoutRect, ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, IDWriteTextFormat* textFormat, Span<Silk.NET.Maths.Box2D<float>> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, textFormat, ref layoutRect.GetPinnableReference(), defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(string, stringLength, textFormat, ref layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, IDWriteTextFormat* textFormat, Span<Silk.NET.Maths.Box2D<float>> layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, textFormat, ref layoutRect.GetPinnableReference(), ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, Span<IDWriteTextFormat> textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, ref textFormat.GetPinnableReference(), layoutRect, defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(string, stringLength, ref textFormat, layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, Span<IDWriteTextFormat> textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, ref textFormat.GetPinnableReference(), layoutRect, ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, Span<IDWriteTextFormat> textFormat, Span<Silk.NET.Maths.Box2D<float>> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, ref textFormat.GetPinnableReference(), ref layoutRect.GetPinnableReference(), defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(string, stringLength, ref textFormat, ref layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, char* @string, uint stringLength, Span<IDWriteTextFormat> textFormat, Span<Silk.NET.Maths.Box2D<float>> layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, ref textFormat.GetPinnableReference(), ref layoutRect.GetPinnableReference(), ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<char> @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(ref @string.GetPinnableReference(), stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref char @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(ref @string, stringLength, textFormat, layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<char> @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(ref @string.GetPinnableReference(), stringLength, textFormat, layoutRect, ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<char> @string, uint stringLength, IDWriteTextFormat* textFormat, Span<Silk.NET.Maths.Box2D<float>> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(ref @string.GetPinnableReference(), stringLength, textFormat, ref layoutRect.GetPinnableReference(), defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref char @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(ref @string, stringLength, textFormat, ref layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<char> @string, uint stringLength, IDWriteTextFormat* textFormat, Span<Silk.NET.Maths.Box2D<float>> layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(ref @string.GetPinnableReference(), stringLength, textFormat, ref layoutRect.GetPinnableReference(), ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<char> @string, uint stringLength, Span<IDWriteTextFormat> textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(ref @string.GetPinnableReference(), stringLength, ref textFormat.GetPinnableReference(), layoutRect, defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(ref @string, stringLength, ref textFormat, layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<char> @string, uint stringLength, Span<IDWriteTextFormat> textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(ref @string.GetPinnableReference(), stringLength, ref textFormat.GetPinnableReference(), layoutRect, ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<char> @string, uint stringLength, Span<IDWriteTextFormat> textFormat, Span<Silk.NET.Maths.Box2D<float>> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(ref @string.GetPinnableReference(), stringLength, ref textFormat.GetPinnableReference(), ref layoutRect.GetPinnableReference(), defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static void DrawTextA<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(ref @string, stringLength, ref textFormat, ref layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<char> @string, uint stringLength, Span<IDWriteTextFormat> textFormat, Span<Silk.NET.Maths.Box2D<float>> layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(ref @string.GetPinnableReference(), stringLength, ref textFormat.GetPinnableReference(), ref layoutRect.GetPinnableReference(), ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(@string, stringLength, textFormat, layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, textFormat, layoutRect, ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, Span<Silk.NET.Maths.Box2D<float>> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, textFormat, ref layoutRect.GetPinnableReference(), defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(@string, stringLength, textFormat, ref layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, Span<Silk.NET.Maths.Box2D<float>> layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, textFormat, ref layoutRect.GetPinnableReference(), ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, Span<IDWriteTextFormat> textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, ref textFormat.GetPinnableReference(), layoutRect, defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(@string, stringLength, ref textFormat, layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, Span<IDWriteTextFormat> textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, ref textFormat.GetPinnableReference(), layoutRect, ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, Span<IDWriteTextFormat> textFormat, Span<Silk.NET.Maths.Box2D<float>> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, ref textFormat.GetPinnableReference(), ref layoutRect.GetPinnableReference(), defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static void DrawTextA<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(@string, stringLength, ref textFormat, ref layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static void DrawTextA(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, Span<IDWriteTextFormat> textFormat, Span<Silk.NET.Maths.Box2D<float>> layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, ref textFormat.GetPinnableReference(), ref layoutRect.GetPinnableReference(), ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextLayout<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, ComPtr<TI0> defaultFillBrush, DrawTextOptions options) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextLayout(origin, textLayout, (ID2D1Brush*) defaultFillBrush.Handle, options);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextLayout(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextLayout(origin, textLayout, ref defaultFillBrush.GetPinnableReference(), options);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextLayout(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, Span<IDWriteTextLayout> textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextLayout(origin, ref textLayout.GetPinnableReference(), defaultFillBrush, options);
    }

    /// <summary>To be documented.</summary>
    public static void DrawTextLayout<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, ref IDWriteTextLayout textLayout, ComPtr<TI0> defaultFillBrush, DrawTextOptions options) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextLayout(origin, ref textLayout, (ID2D1Brush*) defaultFillBrush.Handle, options);
    }

    /// <summary>To be documented.</summary>
    public static void DrawTextLayout(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, Span<IDWriteTextLayout> textLayout, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextLayout(origin, ref textLayout.GetPinnableReference(), ref defaultFillBrush.GetPinnableReference(), options);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGlyphRun<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, ComPtr<TI0> foregroundBrush, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGlyphRun(baselineOrigin, glyphRun, (ID2D1Brush*) foregroundBrush.Handle, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGlyphRun(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, Span<ID2D1Brush> foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGlyphRun(baselineOrigin, glyphRun, ref foregroundBrush.GetPinnableReference(), measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGlyphRun(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, Span<DwriteGlyphRun> glyphRun, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGlyphRun(baselineOrigin, ref glyphRun.GetPinnableReference(), foregroundBrush, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static void DrawGlyphRun<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, ComPtr<TI0> foregroundBrush, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGlyphRun(baselineOrigin, ref glyphRun, (ID2D1Brush*) foregroundBrush.Handle, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static void DrawGlyphRun(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, Span<DwriteGlyphRun> glyphRun, Span<ID2D1Brush> foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGlyphRun(baselineOrigin, ref glyphRun.GetPinnableReference(), ref foregroundBrush.GetPinnableReference(), measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static void SetTransform(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Matrix3X2<float>> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetTransform(ref transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetTransform(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Matrix3X2<float>> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTransform(ref transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetTextRenderingParams(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<IDWriteRenderingParams> textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetTextRenderingParams(ref textRenderingParams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTags(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ulong* tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTags(tag1, ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTags(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ulong> tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTags(ref tag1.GetPinnableReference(), tag2);
    }

    /// <summary>To be documented.</summary>
    public static void GetTags(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ulong> tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTags(ref tag1.GetPinnableReference(), ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LayerParameters* layerParameters, ComPtr<TI0> layer) where TI0 : unmanaged, IComVtbl<ID2D1Layer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PushLayer(layerParameters, (ID2D1Layer*) layer.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, LayerParameters* layerParameters, Span<ID2D1Layer> layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PushLayer(layerParameters, ref layer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<LayerParameters> layerParameters, ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PushLayer(ref layerParameters.GetPinnableReference(), layer);
    }

    /// <summary>To be documented.</summary>
    public static void PushLayer<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ref LayerParameters layerParameters, ComPtr<TI0> layer) where TI0 : unmanaged, IComVtbl<ID2D1Layer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PushLayer(ref layerParameters, (ID2D1Layer*) layer.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void PushLayer(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<LayerParameters> layerParameters, Span<ID2D1Layer> layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PushLayer(ref layerParameters.GetPinnableReference(), ref layer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Flush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ulong* tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Flush(tag1, ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Flush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ulong> tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Flush(ref tag1.GetPinnableReference(), tag2);
    }

    /// <summary>To be documented.</summary>
    public static int Flush(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ulong> tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Flush(ref tag1.GetPinnableReference(), ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SaveDrawingState<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SaveDrawingState((ID2D1DrawingStateBlock*) drawingStateBlock.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void SaveDrawingState(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1DrawingStateBlock> drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SaveDrawingState(ref drawingStateBlock.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void RestoreDrawingState<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->RestoreDrawingState((ID2D1DrawingStateBlock*) drawingStateBlock.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void RestoreDrawingState(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ID2D1DrawingStateBlock> drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RestoreDrawingState(ref drawingStateBlock.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void PushAxisAlignedClip(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Box2D<float>> clipRect, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PushAxisAlignedClip(ref clipRect.GetPinnableReference(), antialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static void Clear(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.DXGI.D3Dcolorvalue> clearColor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Clear(ref clearColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndDraw(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, ulong* tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EndDraw(tag1, ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndDraw(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ulong> tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EndDraw(ref tag1.GetPinnableReference(), tag2);
    }

    /// <summary>To be documented.</summary>
    public static int EndDraw(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<ulong> tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EndDraw(ref tag1.GetPinnableReference(), ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, float* dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(dpiX, ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<float> dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(ref dpiX.GetPinnableReference(), dpiY);
    }

    /// <summary>To be documented.</summary>
    public static void GetDpi(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<float> dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(ref dpiX.GetPinnableReference(), ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsSupported(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<RenderTargetProperties> renderTargetProperties)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsSupported(ref renderTargetProperties.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Resize(this ComPtr<ID2D1HwndRenderTarget> thisVtbl, Span<Silk.NET.Maths.Vector2D<uint>> pixelSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Resize(ref pixelSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1HwndRenderTarget> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
