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

public unsafe static class D2D1DeviceContextVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcData, pitch, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcData, pitch, bitmapProperties, bitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcData, pitch, bitmapPropertiesPtr, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcData, pitch, bitmapPropertiesPtr, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* srcDataPtr = &srcData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapProperties, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* srcDataPtr = &srcData)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapProperties, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* srcDataPtr = &srcData)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapPropertiesPtr, bitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* srcDataPtr = &srcData)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapPropertiesPtr, bitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, IWICBitmapSource* wicBitmapSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSource, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, IWICBitmapSource* wicBitmapSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSource, bitmapProperties, bitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, IWICBitmapSource* wicBitmapSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSource, bitmapPropertiesPtr, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, IWICBitmapSource* wicBitmapSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSource, bitmapPropertiesPtr, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, data, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, data, bitmapProperties, bitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, data, bitmapPropertiesPtr, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, data, bitmapPropertiesPtr, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, ref T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, dataPtr, bitmapProperties, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, ref T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* dataPtr = &data)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, dataPtr, bitmapProperties, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, ref T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* dataPtr = &data)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, dataPtr, bitmapPropertiesPtr, bitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, ref T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* dataPtr = &data)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, dataPtr, bitmapPropertiesPtr, bitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, data, bitmapProperties, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, data, bitmapProperties, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, data, bitmapPropertiesPtr, bitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, data, bitmapPropertiesPtr, bitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, ref T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, dataPtr, bitmapProperties, bitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, ref T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* dataPtr = &data)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, dataPtr, bitmapProperties, bitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, ref T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* dataPtr = &data)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, dataPtr, bitmapPropertiesPtr, bitmap);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, ref T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
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
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riidPtr, dataPtr, bitmapPropertiesPtr, bitmapPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushProperties, bitmapBrushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushPropertiesPtr, bitmapBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushPropertiesPtr, bitmapBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushProperties, bitmapBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
        {
            fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushProperties, bitmapBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushProperties, bitmapBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushProperties, bitmapBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushPropertiesPtr, bitmapBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushPropertiesPtr, bitmapBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushProperties, bitmapBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushProperties, bitmapBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrush);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
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
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrushPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, color, brushProperties, solidColorBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, color, brushProperties, solidColorBrushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, color, brushPropertiesPtr, solidColorBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, color, brushPropertiesPtr, solidColorBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, colorPtr, brushProperties, solidColorBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, colorPtr, brushProperties, solidColorBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, colorPtr, brushPropertiesPtr, solidColorBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, colorPtr, brushPropertiesPtr, solidColorBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)@this->LpVtbl[9])(@this, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ID2D1GradientStopCollection* gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GradientStopCollection** gradientStopCollectionPtr = &gradientStopCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)@this->LpVtbl[9])(@this, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollectionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GradientStop gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GradientStop* gradientStopsPtr = &gradientStops)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)@this->LpVtbl[9])(@this, gradientStopsPtr, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GradientStop gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ID2D1GradientStopCollection* gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GradientStop* gradientStopsPtr = &gradientStops)
        {
            fixed (ID2D1GradientStopCollection** gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)@this->LpVtbl[9])(@this, gradientStopsPtr, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollectionPtr, linearGradientBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
        {
            fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollectionPtr, linearGradientBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, linearGradientBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, linearGradientBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, linearGradientBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, linearGradientBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, linearGradientBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, linearGradientBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, linearGradientBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, linearGradientBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrush);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
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
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrushPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollectionPtr, radialGradientBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
        {
            fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollectionPtr, radialGradientBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, radialGradientBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, radialGradientBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, radialGradientBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, radialGradientBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, radialGradientBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, radialGradientBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, radialGradientBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, radialGradientBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrush);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
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
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrushPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
        {
            fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<uint> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<uint> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
        {
            fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<uint> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
        {
            fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<uint> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
        {
            fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
            {
                fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormat, options, bitmapRenderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
            {
                fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<uint> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<uint> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<uint> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
        {
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTarget);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<uint> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
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
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTargetPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* size, ID2D1Layer** layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)@this->LpVtbl[13])(@this, size, layer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* size, ref ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Layer** layerPtr = &layer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)@this->LpVtbl[13])(@this, size, layerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> size, ID2D1Layer** layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* sizePtr = &size)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)@this->LpVtbl[13])(@this, sizePtr, layer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> size, ref ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* sizePtr = &size)
        {
            fixed (ID2D1Layer** layerPtr = &layer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)@this->LpVtbl[13])(@this, sizePtr, layerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMesh(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Mesh** mesh)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Mesh**, int>)@this->LpVtbl[14])(@this, mesh);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMesh(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Mesh* mesh)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Mesh** meshPtr = &mesh)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Mesh**, int>)@this->LpVtbl[14])(@this, meshPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawLine(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[15])(@this, point0, point1, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawLine(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[15])(@this, point0, point1, brush, strokeWidth, strokeStylePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawLine(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[15])(@this, point0, point1, brushPtr, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawLine(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[15])(@this, point0, point1, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStylePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rect, brushPtr, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rect, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rectPtr, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rectPtr, brush, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rectPtr, brushPtr, strokeWidth, strokeStyle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rectPtr, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)@this->LpVtbl[17])(@this, rect, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)@this->LpVtbl[17])(@this, rect, brushPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)@this->LpVtbl[17])(@this, rectPtr, brush);
        }
    }

    /// <summary>To be documented.</summary>
    public static void FillRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)@this->LpVtbl[17])(@this, rectPtr, brushPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRect, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRect, brush, strokeWidth, strokeStylePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRect, brushPtr, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRect, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RoundedRect roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (RoundedRect* roundedRectPtr = &roundedRect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRectPtr, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RoundedRect roundedRect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (RoundedRect* roundedRectPtr = &roundedRect)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRectPtr, brush, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RoundedRect roundedRect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (RoundedRect* roundedRectPtr = &roundedRect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRectPtr, brushPtr, strokeWidth, strokeStyle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RoundedRect roundedRect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (RoundedRect* roundedRectPtr = &roundedRect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRectPtr, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RoundedRect*, ID2D1Brush*, void>)@this->LpVtbl[19])(@this, roundedRect, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RoundedRect*, ID2D1Brush*, void>)@this->LpVtbl[19])(@this, roundedRect, brushPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RoundedRect roundedRect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        fixed (RoundedRect* roundedRectPtr = &roundedRect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RoundedRect*, ID2D1Brush*, void>)@this->LpVtbl[19])(@this, roundedRectPtr, brush);
        }
    }

    /// <summary>To be documented.</summary>
    public static void FillRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RoundedRect roundedRect, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (RoundedRect* roundedRectPtr = &roundedRect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RoundedRect*, ID2D1Brush*, void>)@this->LpVtbl[19])(@this, roundedRectPtr, brushPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipse, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipse, brush, strokeWidth, strokeStylePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipse, brushPtr, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipse, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Ellipse ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipsePtr, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Ellipse ellipse, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipsePtr, brush, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Ellipse ellipse, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipsePtr, brushPtr, strokeWidth, strokeStyle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Ellipse ellipse, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipsePtr, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Ellipse*, ID2D1Brush*, void>)@this->LpVtbl[21])(@this, ellipse, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Ellipse*, ID2D1Brush*, void>)@this->LpVtbl[21])(@this, ellipse, brushPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Ellipse ellipse, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Ellipse*, ID2D1Brush*, void>)@this->LpVtbl[21])(@this, ellipsePtr, brush);
        }
    }

    /// <summary>To be documented.</summary>
    public static void FillEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Ellipse ellipse, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Ellipse*, ID2D1Brush*, void>)@this->LpVtbl[21])(@this, ellipsePtr, brushPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometry, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometry, brush, strokeWidth, strokeStylePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometry, brushPtr, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometry, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometryPtr, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometryPtr, brush, strokeWidth, strokeStylePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometryPtr, brushPtr, strokeWidth, strokeStyle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometryPtr, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometry, brush, opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, ref ID2D1Brush opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometry, brush, opacityBrushPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, ref ID2D1Brush brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometry, brushPtr, opacityBrush);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometry, brushPtr, opacityBrushPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometryPtr, brush, opacityBrush);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ID2D1Brush* brush, ref ID2D1Brush opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometryPtr, brush, opacityBrushPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometryPtr, brushPtr, opacityBrush);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometryPtr, brushPtr, opacityBrushPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillMesh(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Mesh* mesh, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Mesh*, ID2D1Brush*, void>)@this->LpVtbl[24])(@this, mesh, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillMesh(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Mesh* mesh, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Mesh*, ID2D1Brush*, void>)@this->LpVtbl[24])(@this, mesh, brushPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillMesh(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Mesh mesh, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Mesh* meshPtr = &mesh)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Mesh*, ID2D1Brush*, void>)@this->LpVtbl[24])(@this, meshPtr, brush);
        }
    }

    /// <summary>To be documented.</summary>
    public static void FillMesh(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Mesh mesh, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Mesh* meshPtr = &mesh)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Mesh*, ID2D1Brush*, void>)@this->LpVtbl[24])(@this, meshPtr, brushPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brush, content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brush, content, destinationRectangle, sourceRectanglePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brush, content, destinationRectanglePtr, sourceRectangle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brush, content, destinationRectanglePtr, sourceRectanglePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectangle, sourceRectangle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectangle, sourceRectanglePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectanglePtr, sourceRectangle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectanglePtr, sourceRectanglePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectangle, sourceRectangle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectangle, sourceRectanglePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectanglePtr, sourceRectangle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectanglePtr, sourceRectanglePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectangle, sourceRectangle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectangle, sourceRectanglePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectanglePtr, sourceRectangle);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle)
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
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectanglePtr, sourceRectanglePtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectangle);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRect, defaultFillBrushPtr, options, measuringMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRectPtr, defaultFillBrush, options, measuringMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
        {
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (char* @stringPtr = &@string)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (char* @stringPtr = &@string)
        {
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrushPtr, options, measuringMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (char* @stringPtr = &@string)
        {
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (char* @stringPtr = &@string)
        {
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
        SilkMarshal.Free((nint)@stringPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrushPtr, options, measuringMode);
        }
        SilkMarshal.Free((nint)@stringPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrush, options, measuringMode);
        }
        SilkMarshal.Free((nint)@stringPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
        {
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
            }
        }
        SilkMarshal.Free((nint)@stringPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextLayout(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)@this->LpVtbl[28])(@this, origin, textLayout, defaultFillBrush, options);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextLayout(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, ref ID2D1Brush defaultFillBrush, DrawTextOptions options)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)@this->LpVtbl[28])(@this, origin, textLayout, defaultFillBrushPtr, options);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGlyphRun(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)@this->LpVtbl[29])(@this, baselineOrigin, glyphRun, foregroundBrush, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGlyphRun(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, ref ID2D1Brush foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush* foregroundBrushPtr = &foregroundBrush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)@this->LpVtbl[29])(@this, baselineOrigin, glyphRun, foregroundBrushPtr, measuringMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTransform(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[30])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static void SetTransform(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Matrix3X2<float> transform)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[30])(@this, transformPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTransform(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[31])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static void GetTransform(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Silk.NET.Maths.Matrix3X2<float> transform)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[31])(@this, transformPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetAntialiasMode(this ComPtr<ID2D1DeviceContext> thisVtbl, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, AntialiasMode, void>)@this->LpVtbl[32])(@this, antialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static AntialiasMode GetAntialiasMode(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        AntialiasMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, AntialiasMode>)@this->LpVtbl[33])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetTextAntialiasMode(this ComPtr<ID2D1DeviceContext> thisVtbl, TextAntialiasMode textAntialiasMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, TextAntialiasMode, void>)@this->LpVtbl[34])(@this, textAntialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static TextAntialiasMode GetTextAntialiasMode(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TextAntialiasMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, TextAntialiasMode>)@this->LpVtbl[35])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTextRenderingParams(this ComPtr<ID2D1DeviceContext> thisVtbl, IDWriteRenderingParams* textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IDWriteRenderingParams*, void>)@this->LpVtbl[36])(@this, textRenderingParams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTextRenderingParams(this ComPtr<ID2D1DeviceContext> thisVtbl, IDWriteRenderingParams** textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IDWriteRenderingParams**, void>)@this->LpVtbl[37])(@this, textRenderingParams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTextRenderingParams(this ComPtr<ID2D1DeviceContext> thisVtbl, ref IDWriteRenderingParams* textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        fixed (IDWriteRenderingParams** textRenderingParamsPtr = &textRenderingParams)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IDWriteRenderingParams**, void>)@this->LpVtbl[37])(@this, textRenderingParamsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetTags(this ComPtr<ID2D1DeviceContext> thisVtbl, ulong tag1, ulong tag2)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong, ulong, void>)@this->LpVtbl[38])(@this, tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTags(this ComPtr<ID2D1DeviceContext> thisVtbl, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, void>)@this->LpVtbl[39])(@this, tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTags(this ComPtr<ID2D1DeviceContext> thisVtbl, ulong* tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        fixed (ulong* tag2Ptr = &tag2)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, void>)@this->LpVtbl[39])(@this, tag1, tag2Ptr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTags(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ulong tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        fixed (ulong* tag1Ptr = &tag1)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, void>)@this->LpVtbl[39])(@this, tag1Ptr, tag2);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetTags(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ulong tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        fixed (ulong* tag1Ptr = &tag1)
        {
            fixed (ulong* tag2Ptr = &tag2)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, void>)@this->LpVtbl[39])(@this, tag1Ptr, tag2Ptr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters* layerParameters, ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LayerParameters*, ID2D1Layer*, void>)@this->LpVtbl[40])(@this, layerParameters, layer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters* layerParameters, ref ID2D1Layer layer)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Layer* layerPtr = &layer)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LayerParameters*, ID2D1Layer*, void>)@this->LpVtbl[40])(@this, layerParameters, layerPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LayerParameters layerParameters, ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        fixed (LayerParameters* layerParametersPtr = &layerParameters)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LayerParameters*, ID2D1Layer*, void>)@this->LpVtbl[40])(@this, layerParametersPtr, layer);
        }
    }

    /// <summary>To be documented.</summary>
    public static void PushLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LayerParameters layerParameters, ref ID2D1Layer layer)
    {
        var @this = thisVtbl.Handle;
        fixed (LayerParameters* layerParametersPtr = &layerParameters)
        {
            fixed (ID2D1Layer* layerPtr = &layer)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, LayerParameters*, ID2D1Layer*, void>)@this->LpVtbl[40])(@this, layerParametersPtr, layerPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void PopLayer(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, void>)@this->LpVtbl[41])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Flush(this ComPtr<ID2D1DeviceContext> thisVtbl, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, int>)@this->LpVtbl[42])(@this, tag1, tag2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Flush(this ComPtr<ID2D1DeviceContext> thisVtbl, ulong* tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag2Ptr = &tag2)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, int>)@this->LpVtbl[42])(@this, tag1, tag2Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Flush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ulong tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag1Ptr = &tag1)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, int>)@this->LpVtbl[42])(@this, tag1Ptr, tag2);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Flush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ulong tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag1Ptr = &tag1)
        {
            fixed (ulong* tag2Ptr = &tag2)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, int>)@this->LpVtbl[42])(@this, tag1Ptr, tag2Ptr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SaveDrawingState(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1DrawingStateBlock*, void>)@this->LpVtbl[43])(@this, drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static void SaveDrawingState(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1DrawingStateBlock drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1DrawingStateBlock* drawingStateBlockPtr = &drawingStateBlock)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1DrawingStateBlock*, void>)@this->LpVtbl[43])(@this, drawingStateBlockPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RestoreDrawingState(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1DrawingStateBlock*, void>)@this->LpVtbl[44])(@this, drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static void RestoreDrawingState(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1DrawingStateBlock drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1DrawingStateBlock* drawingStateBlockPtr = &drawingStateBlock)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1DrawingStateBlock*, void>)@this->LpVtbl[44])(@this, drawingStateBlockPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushAxisAlignedClip(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* clipRect, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, void>)@this->LpVtbl[45])(@this, clipRect, antialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static void PushAxisAlignedClip(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> clipRect, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* clipRectPtr = &clipRect)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, void>)@this->LpVtbl[45])(@this, clipRectPtr, antialiasMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static void PopAxisAlignedClip(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, void>)@this->LpVtbl[46])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Clear(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* clearColor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.D3Dcolorvalue*, void>)@this->LpVtbl[47])(@this, clearColor);
    }

    /// <summary>To be documented.</summary>
    public static void Clear(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.DXGI.D3Dcolorvalue clearColor)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* clearColorPtr = &clearColor)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.D3Dcolorvalue*, void>)@this->LpVtbl[47])(@this, clearColorPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void BeginDraw(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, void>)@this->LpVtbl[48])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndDraw(this ComPtr<ID2D1DeviceContext> thisVtbl, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, int>)@this->LpVtbl[49])(@this, tag1, tag2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndDraw(this ComPtr<ID2D1DeviceContext> thisVtbl, ulong* tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag2Ptr = &tag2)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, int>)@this->LpVtbl[49])(@this, tag1, tag2Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndDraw(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ulong tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag1Ptr = &tag1)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, int>)@this->LpVtbl[49])(@this, tag1Ptr, tag2);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndDraw(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ulong tag1, ref ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* tag1Ptr = &tag1)
        {
            fixed (ulong* tag2Ptr = &tag2)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, int>)@this->LpVtbl[49])(@this, tag1Ptr, tag2Ptr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static PixelFormat GetPixelFormat(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        PixelFormat silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        PixelFormat* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, PixelFormat*, PixelFormat*>)@this->LpVtbl[50])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetDpi(this ComPtr<ID2D1DeviceContext> thisVtbl, float dpiX, float dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, float, float, void>)@this->LpVtbl[51])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1DeviceContext> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, float*, float*, void>)@this->LpVtbl[52])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1DeviceContext> thisVtbl, float* dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiYPtr = &dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, float*, float*, void>)@this->LpVtbl[52])(@this, dpiX, dpiYPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1DeviceContext> thisVtbl, ref float dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, float*, float*, void>)@this->LpVtbl[52])(@this, dpiXPtr, dpiY);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetDpi(this ComPtr<ID2D1DeviceContext> thisVtbl, ref float dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, float*, float*, void>)@this->LpVtbl[52])(@this, dpiXPtr, dpiYPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<float> GetSize(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Silk.NET.Maths.Vector2D<float>* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)@this->LpVtbl[53])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<uint> GetPixelSize(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<uint> silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Silk.NET.Maths.Vector2D<uint>* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<uint>*, Silk.NET.Maths.Vector2D<uint>*>)@this->LpVtbl[54])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetMaximumBitmapSize(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, uint>)@this->LpVtbl[55])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsSupported(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RenderTargetProperties*, Silk.NET.Core.Bool32>)@this->LpVtbl[56])(@this, renderTargetProperties);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsSupported(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderTargetProperties renderTargetProperties)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RenderTargetProperties*, Silk.NET.Core.Bool32>)@this->LpVtbl[56])(@this, renderTargetPropertiesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1DeviceContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* profile, uint profileSize, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[59])(@this, space, profile, profileSize, colorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1DeviceContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* profile, uint profileSize, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[59])(@this, space, profile, profileSize, colorContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1DeviceContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte profile, uint profileSize, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* profilePtr = &profile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[59])(@this, space, profilePtr, profileSize, colorContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1DeviceContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte profile, uint profileSize, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* profilePtr = &profile)
        {
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[59])(@this, space, profilePtr, profileSize, colorContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1DeviceContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var profilePtr = (byte*) SilkMarshal.StringToPtr(profile, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[59])(@this, space, profilePtr, profileSize, colorContext);
        SilkMarshal.Free((nint)profilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1DeviceContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var profilePtr = (byte*) SilkMarshal.StringToPtr(profile, NativeStringEncoding.UTF8);
        fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[59])(@this, space, profilePtr, profileSize, colorContextPtr);
        }
        SilkMarshal.Free((nint)profilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filename, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[60])(@this, filename, colorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filename, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[60])(@this, filename, colorContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filename, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* filenamePtr = &filename)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[60])(@this, filenamePtr, colorContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filename, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* filenamePtr = &filename)
        {
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[60])(@this, filenamePtr, colorContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var filenamePtr = (byte*) SilkMarshal.StringToPtr(filename, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, byte*, ID2D1ColorContext**, int>)@this->LpVtbl[60])(@this, filenamePtr, colorContext);
        SilkMarshal.Free((nint)filenamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var filenamePtr = (byte*) SilkMarshal.StringToPtr(filename, NativeStringEncoding.UTF8);
        fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, byte*, ID2D1ColorContext**, int>)@this->LpVtbl[60])(@this, filenamePtr, colorContextPtr);
        }
        SilkMarshal.Free((nint)filenamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromWicColorContext(this ComPtr<ID2D1DeviceContext> thisVtbl, IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IWICColorContext*, ID2D1ColorContext**, int>)@this->LpVtbl[61])(@this, wicColorContext, colorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromWicColorContext(this ComPtr<ID2D1DeviceContext> thisVtbl, IWICColorContext* wicColorContext, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IWICColorContext*, ID2D1ColorContext**, int>)@this->LpVtbl[61])(@this, wicColorContext, colorContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.DXGI.IDXGISurface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties1* bitmapProperties, ID2D1Bitmap1** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)@this->LpVtbl[62])(@this, surface, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.DXGI.IDXGISurface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties1* bitmapProperties, ref ID2D1Bitmap1* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap1** bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)@this->LpVtbl[62])(@this, surface, bitmapProperties, bitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.DXGI.IDXGISurface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties1 bitmapProperties, ID2D1Bitmap1** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties1* bitmapPropertiesPtr = &bitmapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)@this->LpVtbl[62])(@this, surface, bitmapPropertiesPtr, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.DXGI.IDXGISurface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties1 bitmapProperties, ref ID2D1Bitmap1* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapProperties1* bitmapPropertiesPtr = &bitmapProperties)
        {
            fixed (ID2D1Bitmap1** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)@this->LpVtbl[62])(@this, surface, bitmapPropertiesPtr, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Silk.NET.DXGI.IDXGISurface surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties1* bitmapProperties, ID2D1Bitmap1** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* surfacePtr = &surface)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)@this->LpVtbl[62])(@this, surfacePtr, bitmapProperties, bitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Silk.NET.DXGI.IDXGISurface surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties1* bitmapProperties, ref ID2D1Bitmap1* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* surfacePtr = &surface)
        {
            fixed (ID2D1Bitmap1** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)@this->LpVtbl[62])(@this, surfacePtr, bitmapProperties, bitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Silk.NET.DXGI.IDXGISurface surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties1 bitmapProperties, ID2D1Bitmap1** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* surfacePtr = &surface)
        {
            fixed (BitmapProperties1* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)@this->LpVtbl[62])(@this, surfacePtr, bitmapPropertiesPtr, bitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Silk.NET.DXGI.IDXGISurface surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties1 bitmapProperties, ref ID2D1Bitmap1* bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* surfacePtr = &surface)
        {
            fixed (BitmapProperties1* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap1** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)@this->LpVtbl[62])(@this, surfacePtr, bitmapPropertiesPtr, bitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* effectId, ID2D1Effect** effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[63])(@this, effectId, effect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* effectId, ref ID2D1Effect* effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect** effectPtr = &effect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[63])(@this, effectId, effectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid effectId, ID2D1Effect** effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectIdPtr = &effectId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[63])(@this, effectIdPtr, effect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid effectId, ref ID2D1Effect* effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectIdPtr = &effectId)
        {
            fixed (ID2D1Effect** effectPtr = &effect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[63])(@this, effectIdPtr, effectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, image, imageBrushProperties, brushProperties, imageBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, image, imageBrushProperties, brushProperties, imageBrushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, image, imageBrushProperties, brushPropertiesPtr, imageBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
        {
            fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, image, imageBrushProperties, brushPropertiesPtr, imageBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, image, imageBrushPropertiesPtr, brushProperties, imageBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
        {
            fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, image, imageBrushPropertiesPtr, brushProperties, imageBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, image, imageBrushPropertiesPtr, brushPropertiesPtr, imageBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, image, imageBrushPropertiesPtr, brushPropertiesPtr, imageBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, imagePtr, imageBrushProperties, brushProperties, imageBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, imagePtr, imageBrushProperties, brushProperties, imageBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, imagePtr, imageBrushProperties, brushPropertiesPtr, imageBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, imagePtr, imageBrushProperties, brushPropertiesPtr, imageBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, imagePtr, imageBrushPropertiesPtr, brushProperties, imageBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
            {
                fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, imagePtr, imageBrushPropertiesPtr, brushProperties, imageBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, imagePtr, imageBrushPropertiesPtr, brushPropertiesPtr, imageBrush);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, imagePtr, imageBrushPropertiesPtr, brushPropertiesPtr, imageBrushPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1CommandList** commandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1CommandList**, int>)@this->LpVtbl[67])(@this, commandList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1CommandList* commandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1CommandList** commandListPtr = &commandList)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1CommandList**, int>)@this->LpVtbl[67])(@this, commandListPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsDxgiFormatSupported(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.DXGI.Format format)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.DXGI.Format, Silk.NET.Core.Bool32>)@this->LpVtbl[68])(@this, format);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsBufferPrecisionSupported(this ComPtr<ID2D1DeviceContext> thisVtbl, BufferPrecision bufferPrecision)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, BufferPrecision, Silk.NET.Core.Bool32>)@this->LpVtbl[69])(@this, bufferPrecision);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageLocalBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, Silk.NET.Maths.Box2D<float>* localBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[70])(@this, image, localBounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageLocalBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, ref Silk.NET.Maths.Box2D<float> localBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* localBoundsPtr = &localBounds)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[70])(@this, image, localBoundsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageLocalBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, Silk.NET.Maths.Box2D<float>* localBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[70])(@this, imagePtr, localBounds);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetImageLocalBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, ref Silk.NET.Maths.Box2D<float> localBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (Silk.NET.Maths.Box2D<float>* localBoundsPtr = &localBounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[70])(@this, imagePtr, localBoundsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageWorldBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, Silk.NET.Maths.Box2D<float>* worldBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[71])(@this, image, worldBounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageWorldBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, ref Silk.NET.Maths.Box2D<float> worldBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* worldBoundsPtr = &worldBounds)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[71])(@this, image, worldBoundsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageWorldBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, Silk.NET.Maths.Box2D<float>* worldBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[71])(@this, imagePtr, worldBounds);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetImageWorldBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, ref Silk.NET.Maths.Box2D<float> worldBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (Silk.NET.Maths.Box2D<float>* worldBoundsPtr = &worldBounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[71])(@this, imagePtr, worldBoundsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunWorldBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, DwriteMeasuringMode measuringMode, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteMeasuringMode, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[72])(@this, baselineOrigin, glyphRun, measuringMode, bounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunWorldBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, DwriteMeasuringMode measuringMode, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteMeasuringMode, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[72])(@this, baselineOrigin, glyphRun, measuringMode, boundsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Device** device)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Device**, void>)@this->LpVtbl[73])(@this, device);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Device* device)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Device** devicePtr = &device)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Device**, void>)@this->LpVtbl[73])(@this, devicePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, void>)@this->LpVtbl[74])(@this, image);
    }

    /// <summary>To be documented.</summary>
    public static void SetTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Image* imagePtr = &image)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, void>)@this->LpVtbl[74])(@this, imagePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image** image)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image**, void>)@this->LpVtbl[75])(@this, image);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image* image)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Image** imagePtr = &image)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image**, void>)@this->LpVtbl[75])(@this, imagePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetRenderingControls(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingControls* renderingControls)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RenderingControls*, void>)@this->LpVtbl[76])(@this, renderingControls);
    }

    /// <summary>To be documented.</summary>
    public static void SetRenderingControls(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderingControls renderingControls)
    {
        var @this = thisVtbl.Handle;
        fixed (RenderingControls* renderingControlsPtr = &renderingControls)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RenderingControls*, void>)@this->LpVtbl[76])(@this, renderingControlsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRenderingControls(this ComPtr<ID2D1DeviceContext> thisVtbl, RenderingControls* renderingControls)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RenderingControls*, void>)@this->LpVtbl[77])(@this, renderingControls);
    }

    /// <summary>To be documented.</summary>
    public static void GetRenderingControls(this ComPtr<ID2D1DeviceContext> thisVtbl, ref RenderingControls renderingControls)
    {
        var @this = thisVtbl.Handle;
        fixed (RenderingControls* renderingControlsPtr = &renderingControls)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, RenderingControls*, void>)@this->LpVtbl[77])(@this, renderingControlsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetPrimitiveBlend(this ComPtr<ID2D1DeviceContext> thisVtbl, PrimitiveBlend primitiveBlend)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, PrimitiveBlend, void>)@this->LpVtbl[78])(@this, primitiveBlend);
    }

    /// <summary>To be documented.</summary>
    public static PrimitiveBlend GetPrimitiveBlend(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        PrimitiveBlend ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, PrimitiveBlend>)@this->LpVtbl[79])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetUnitMode(this ComPtr<ID2D1DeviceContext> thisVtbl, UnitMode unitMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, UnitMode, void>)@this->LpVtbl[80])(@this, unitMode);
    }

    /// <summary>To be documented.</summary>
    public static UnitMode GetUnitMode(this ComPtr<ID2D1DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        UnitMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, UnitMode>)@this->LpVtbl[81])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)@this->LpVtbl[83])(@this, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)@this->LpVtbl[83])(@this, image, targetOffset, imageRectanglePtr, interpolationMode, compositeMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)@this->LpVtbl[83])(@this, image, targetOffsetPtr, imageRectangle, interpolationMode, compositeMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
        {
            fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)@this->LpVtbl[83])(@this, image, targetOffsetPtr, imageRectanglePtr, interpolationMode, compositeMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Image* imagePtr = &image)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)@this->LpVtbl[83])(@this, imagePtr, targetOffset, imageRectangle, interpolationMode, compositeMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)@this->LpVtbl[83])(@this, imagePtr, targetOffset, imageRectanglePtr, interpolationMode, compositeMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)@this->LpVtbl[83])(@this, imagePtr, targetOffsetPtr, imageRectangle, interpolationMode, compositeMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
            {
                fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)@this->LpVtbl[83])(@this, imagePtr, targetOffsetPtr, imageRectanglePtr, interpolationMode, compositeMode);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGdiMetafile(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1GdiMetafile* gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, void>)@this->LpVtbl[84])(@this, gdiMetafile, targetOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGdiMetafile(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1GdiMetafile* gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> targetOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, void>)@this->LpVtbl[84])(@this, gdiMetafile, targetOffsetPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGdiMetafile(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1GdiMetafile gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1GdiMetafile* gdiMetafilePtr = &gdiMetafile)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, void>)@this->LpVtbl[84])(@this, gdiMetafilePtr, targetOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawGdiMetafile(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1GdiMetafile gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> targetOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1GdiMetafile* gdiMetafilePtr = &gdiMetafile)
        {
            fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, void>)@this->LpVtbl[84])(@this, gdiMetafilePtr, targetOffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InvalidateEffectInputRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* effect, uint input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* inputRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, uint, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[87])(@this, effect, input, inputRectangle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InvalidateEffectInputRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* effect, uint input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> inputRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* inputRectanglePtr = &inputRectangle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, uint, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[87])(@this, effect, input, inputRectanglePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InvalidateEffectInputRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect effect, uint input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* inputRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* effectPtr = &effect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, uint, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[87])(@this, effectPtr, input, inputRectangle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InvalidateEffectInputRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect effect, uint input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> inputRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* effectPtr = &effect)
        {
            fixed (Silk.NET.Maths.Box2D<float>* inputRectanglePtr = &inputRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, uint, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[87])(@this, effectPtr, input, inputRectanglePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangleCount(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* effect, uint* rectangleCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, uint*, int>)@this->LpVtbl[88])(@this, effect, rectangleCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangleCount(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* effect, ref uint rectangleCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* rectangleCountPtr = &rectangleCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, uint*, int>)@this->LpVtbl[88])(@this, effect, rectangleCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangleCount(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect effect, uint* rectangleCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* effectPtr = &effect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, uint*, int>)@this->LpVtbl[88])(@this, effectPtr, rectangleCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectInvalidRectangleCount(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect effect, ref uint rectangleCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* effectPtr = &effect)
        {
            fixed (uint* rectangleCountPtr = &rectangleCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, uint*, int>)@this->LpVtbl[88])(@this, effectPtr, rectangleCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* effect, Silk.NET.Maths.Box2D<float>* rectangles, uint rectanglesCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[89])(@this, effect, rectangles, rectanglesCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* effect, ref Silk.NET.Maths.Box2D<float> rectangles, uint rectanglesCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* rectanglesPtr = &rectangles)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[89])(@this, effect, rectanglesPtr, rectanglesCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect effect, Silk.NET.Maths.Box2D<float>* rectangles, uint rectanglesCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* effectPtr = &effect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[89])(@this, effectPtr, rectangles, rectanglesCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectInvalidRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect effect, ref Silk.NET.Maths.Box2D<float> rectangles, uint rectanglesCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* effectPtr = &effect)
        {
            fixed (Silk.NET.Maths.Box2D<float>* rectanglesPtr = &rectangles)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[89])(@this, effectPtr, rectanglesPtr, rectanglesCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffect, renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffect, renderImageRectangle, inputDescriptions, requiredInputRectsPtr, inputCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EffectInputDescription inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffect, renderImageRectangle, inputDescriptionsPtr, requiredInputRects, inputCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EffectInputDescription inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
        {
            fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffect, renderImageRectangle, inputDescriptionsPtr, requiredInputRectsPtr, inputCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffect, renderImageRectanglePtr, inputDescriptions, requiredInputRects, inputCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
        {
            fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffect, renderImageRectanglePtr, inputDescriptions, requiredInputRectsPtr, inputCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EffectInputDescription inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
        {
            fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffect, renderImageRectanglePtr, inputDescriptionsPtr, requiredInputRects, inputCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EffectInputDescription inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
        {
            fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
            {
                fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffect, renderImageRectanglePtr, inputDescriptionsPtr, requiredInputRectsPtr, inputCount);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffectPtr, renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
        {
            fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffectPtr, renderImageRectangle, inputDescriptions, requiredInputRectsPtr, inputCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EffectInputDescription inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
        {
            fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffectPtr, renderImageRectangle, inputDescriptionsPtr, requiredInputRects, inputCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EffectInputDescription inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
        {
            fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
            {
                fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffectPtr, renderImageRectangle, inputDescriptionsPtr, requiredInputRectsPtr, inputCount);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
        {
            fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffectPtr, renderImageRectanglePtr, inputDescriptions, requiredInputRects, inputCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
        {
            fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffectPtr, renderImageRectanglePtr, inputDescriptions, requiredInputRectsPtr, inputCount);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EffectInputDescription inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
        {
            fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
            {
                fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffectPtr, renderImageRectanglePtr, inputDescriptionsPtr, requiredInputRects, inputCount);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Effect renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EffectInputDescription inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
        {
            fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
            {
                fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffectPtr, renderImageRectanglePtr, inputDescriptionsPtr, requiredInputRectsPtr, inputCount);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmap(size, srcData, pitch, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(size, srcData, pitch, in bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmap(size, srcData, pitch, in bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(size, srcData, pitch, in bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(size, in srcData.GetPinnableReference(), pitch, bitmapProperties, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0, TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmap(size, in srcData, pitch, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(size, in srcData.GetPinnableReference(), pitch, bitmapProperties, ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(size, in srcData.GetPinnableReference(), pitch, in bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmap<T0, TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmap(size, in srcData, pitch, in bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(size, in srcData.GetPinnableReference(), pitch, in bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, IWICBitmapSource* wicBitmapSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, IWICBitmapSource* wicBitmapSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromWicBitmap(wicBitmapSource, in bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, IWICBitmapSource* wicBitmapSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromWicBitmap(wicBitmapSource, in bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, IWICBitmapSource* wicBitmapSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromWicBitmap(wicBitmapSource, in bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(riid, data, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(riid, data, in bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(riid, data, in bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(riid, data, in bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, Span<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(riid, ref data.GetPinnableReference(), bitmapProperties, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0, TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, ref T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(riid, ref data, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, Span<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(riid, ref data.GetPinnableReference(), bitmapProperties, ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, Span<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(riid, ref data.GetPinnableReference(), in bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0, TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, ref T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(riid, ref data, in bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Guid* riid, Span<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(riid, ref data.GetPinnableReference(), in bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Guid> riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), data, bitmapProperties, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(ref riid, data, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Guid> riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), data, bitmapProperties, ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Guid> riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), data, in bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(ref riid, data, in bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Guid> riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), data, in bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Guid> riid, Span<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), ref data.GetPinnableReference(), bitmapProperties, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0, TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, ref T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ComPtr<TI0> bitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(ref riid, ref data, bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Guid> riid, Span<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), ref data.GetPinnableReference(), bitmapProperties, ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Guid> riid, Span<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), ref data.GetPinnableReference(), in bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSharedBitmap<T0, TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid riid, ref T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties bitmapProperties, ref ComPtr<TI0> bitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedBitmap(ref riid, ref data, in bitmapProperties, (ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap<T0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Guid> riid, Span<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties> bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedBitmap(ref riid.GetPinnableReference(), ref data.GetPinnableReference(), in bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ComPtr<TI1> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, bitmapBrushProperties, brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, bitmapBrushProperties, brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(bitmap, bitmapBrushProperties, in brushProperties.GetPinnableReference(), bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ComPtr<TI1> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, bitmapBrushProperties, in brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(bitmap, bitmapBrushProperties, in brushProperties.GetPinnableReference(), ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, bitmapBrushProperties, in brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapBrushProperties> bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(bitmap, in bitmapBrushProperties.GetPinnableReference(), brushProperties, bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ComPtr<TI1> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, in bitmapBrushProperties, brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapBrushProperties> bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(bitmap, in bitmapBrushProperties.GetPinnableReference(), brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, in bitmapBrushProperties, brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapBrushProperties> bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(bitmap, in bitmapBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ComPtr<TI1> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, in bitmapBrushProperties, in brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapBrushProperties> bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(bitmap, in bitmapBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush((ID2D1Bitmap*) bitmap.Handle, in bitmapBrushProperties, in brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), bitmapBrushProperties, brushProperties, bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ComPtr<TI0> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush(ref bitmap, bitmapBrushProperties, brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), bitmapBrushProperties, brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), bitmapBrushProperties, in brushProperties.GetPinnableReference(), bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ComPtr<TI0> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush(ref bitmap, bitmapBrushProperties, in brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), bitmapBrushProperties, in brushProperties.GetPinnableReference(), ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapBrushProperties> bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), in bitmapBrushProperties.GetPinnableReference(), brushProperties, bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ComPtr<TI0> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush(ref bitmap, in bitmapBrushProperties, brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapBrushProperties> bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), in bitmapBrushProperties.GetPinnableReference(), brushProperties, ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapBrushProperties> bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), in bitmapBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapBrushProperties bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ComPtr<TI0> bitmapBrush) where TI0 : unmanaged, IComVtbl<ID2D1BitmapBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapBrush(ref bitmap, in bitmapBrushProperties, in brushProperties, (ID2D1BitmapBrush**) bitmapBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapBrushProperties> bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapBrush(ref bitmap.GetPinnableReference(), in bitmapBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), ref bitmapBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ComPtr<TI0> solidColorBrush) where TI0 : unmanaged, IComVtbl<ID2D1SolidColorBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSolidColorBrush(color, brushProperties, (ID2D1SolidColorBrush**) solidColorBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSolidColorBrush(color, in brushProperties.GetPinnableReference(), solidColorBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ComPtr<TI0> solidColorBrush) where TI0 : unmanaged, IComVtbl<ID2D1SolidColorBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSolidColorBrush(color, in brushProperties, (ID2D1SolidColorBrush**) solidColorBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSolidColorBrush(color, in brushProperties.GetPinnableReference(), ref solidColorBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSolidColorBrush(in color.GetPinnableReference(), brushProperties, solidColorBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ComPtr<TI0> solidColorBrush) where TI0 : unmanaged, IComVtbl<ID2D1SolidColorBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSolidColorBrush(in color, brushProperties, (ID2D1SolidColorBrush**) solidColorBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSolidColorBrush(in color.GetPinnableReference(), brushProperties, ref solidColorBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSolidColorBrush(in color.GetPinnableReference(), in brushProperties.GetPinnableReference(), solidColorBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSolidColorBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ComPtr<TI0> solidColorBrush) where TI0 : unmanaged, IComVtbl<ID2D1SolidColorBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSolidColorBrush(in color, in brushProperties, (ID2D1SolidColorBrush**) solidColorBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSolidColorBrush(in color.GetPinnableReference(), in brushProperties.GetPinnableReference(), ref solidColorBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ComPtr<TI0> gradientStopCollection) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGradientStopCollection(gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, (ID2D1GradientStopCollection**) gradientStopCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GradientStop> gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGradientStopCollection(in gradientStops.GetPinnableReference(), gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGradientStopCollection<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GradientStop gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ComPtr<TI0> gradientStopCollection) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGradientStopCollection(in gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, (ID2D1GradientStopCollection**) gradientStopCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GradientStop> gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ID2D1GradientStopCollection* gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGradientStopCollection(in gradientStops.GetPinnableReference(), gradientStopsCount, colorInterpolationGamma, extendMode, ref gradientStopCollection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, brushProperties, ref gradientStopCollection.GetPinnableReference(), linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, brushProperties, ref gradientStopCollection, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, brushProperties, ref gradientStopCollection.GetPinnableReference(), ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, in brushProperties.GetPinnableReference(), gradientStopCollection, linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, in brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, in brushProperties.GetPinnableReference(), gradientStopCollection, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, in brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, in brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, in brushProperties, ref gradientStopCollection, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(linearGradientBrushProperties, in brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LinearGradientBrushProperties> linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties.GetPinnableReference(), brushProperties, gradientStopCollection, linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LinearGradientBrushProperties> linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties.GetPinnableReference(), brushProperties, gradientStopCollection, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LinearGradientBrushProperties> linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties.GetPinnableReference(), brushProperties, ref gradientStopCollection.GetPinnableReference(), linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties, brushProperties, ref gradientStopCollection, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LinearGradientBrushProperties> linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties.GetPinnableReference(), brushProperties, ref gradientStopCollection.GetPinnableReference(), ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LinearGradientBrushProperties> linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), gradientStopCollection, linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateLinearGradientBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties, in brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LinearGradientBrushProperties> linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), gradientStopCollection, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties, in brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LinearGradientBrushProperties> linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateLinearGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LinearGradientBrushProperties linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> linearGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1LinearGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties, in brushProperties, ref gradientStopCollection, (ID2D1LinearGradientBrush**) linearGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LinearGradientBrushProperties> linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLinearGradientBrush(in linearGradientBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), ref linearGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, brushProperties, ref gradientStopCollection.GetPinnableReference(), radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, brushProperties, ref gradientStopCollection, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, brushProperties, ref gradientStopCollection.GetPinnableReference(), ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, in brushProperties.GetPinnableReference(), gradientStopCollection, radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, in brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, in brushProperties.GetPinnableReference(), gradientStopCollection, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, in brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, in brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, in brushProperties, ref gradientStopCollection, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(radialGradientBrushProperties, in brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RadialGradientBrushProperties> radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties.GetPinnableReference(), brushProperties, gradientStopCollection, radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RadialGradientBrushProperties> radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties.GetPinnableReference(), brushProperties, gradientStopCollection, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties, brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RadialGradientBrushProperties> radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties.GetPinnableReference(), brushProperties, ref gradientStopCollection.GetPinnableReference(), radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties, brushProperties, ref gradientStopCollection, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RadialGradientBrushProperties> radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties.GetPinnableReference(), brushProperties, ref gradientStopCollection.GetPinnableReference(), ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RadialGradientBrushProperties> radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), gradientStopCollection, radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateRadialGradientBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ComPtr<TI1> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties, in brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RadialGradientBrushProperties> radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), gradientStopCollection, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ComPtr<TI0> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1GradientStopCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties, in brushProperties, (ID2D1GradientStopCollection*) gradientStopCollection.Handle, ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RadialGradientBrushProperties> radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateRadialGradientBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RadialGradientBrushProperties radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ComPtr<TI0> radialGradientBrush) where TI0 : unmanaged, IComVtbl<ID2D1RadialGradientBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties, in brushProperties, ref gradientStopCollection, (ID2D1RadialGradientBrush**) radialGradientBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RadialGradientBrushProperties> radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, Span<ID2D1GradientStopCollection> gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRadialGradientBrush(in radialGradientBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), ref gradientStopCollection.GetPinnableReference(), ref radialGradientBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, desiredPixelSize, desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, desiredPixelSize, in desiredFormat.GetPinnableReference(), options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, desiredPixelSize, in desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, desiredPixelSize, in desiredFormat.GetPinnableReference(), options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, in desiredPixelSize.GetPinnableReference(), desiredFormat, options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<uint> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, in desiredPixelSize, desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, in desiredPixelSize.GetPinnableReference(), desiredFormat, options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, in desiredPixelSize.GetPinnableReference(), in desiredFormat.GetPinnableReference(), options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<uint> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, in desiredPixelSize, in desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(desiredSize, in desiredPixelSize.GetPinnableReference(), in desiredFormat.GetPinnableReference(), options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(in desiredSize.GetPinnableReference(), desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(in desiredSize, desiredPixelSize, desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(in desiredSize.GetPinnableReference(), desiredPixelSize, desiredFormat, options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(in desiredSize.GetPinnableReference(), desiredPixelSize, in desiredFormat.GetPinnableReference(), options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(in desiredSize, desiredPixelSize, in desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(in desiredSize.GetPinnableReference(), desiredPixelSize, in desiredFormat.GetPinnableReference(), options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(in desiredSize.GetPinnableReference(), in desiredPixelSize.GetPinnableReference(), desiredFormat, options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<uint> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(in desiredSize, in desiredPixelSize, desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(in desiredSize.GetPinnableReference(), in desiredPixelSize.GetPinnableReference(), desiredFormat, options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(in desiredSize.GetPinnableReference(), in desiredPixelSize.GetPinnableReference(), in desiredFormat.GetPinnableReference(), options, bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCompatibleRenderTarget<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<uint> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ComPtr<TI0> bitmapRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1BitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompatibleRenderTarget(in desiredSize, in desiredPixelSize, in desiredFormat, options, (ID2D1BitmapRenderTarget**) bitmapRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCompatibleRenderTarget(in desiredSize.GetPinnableReference(), in desiredPixelSize.GetPinnableReference(), in desiredFormat.GetPinnableReference(), options, ref bitmapRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* size, ref ComPtr<TI0> layer) where TI0 : unmanaged, IComVtbl<ID2D1Layer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLayer(size, (ID2D1Layer**) layer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> size, ID2D1Layer** layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLayer(in size.GetPinnableReference(), layer);
    }

    /// <summary>To be documented.</summary>
    public static int CreateLayer<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> size, ref ComPtr<TI0> layer) where TI0 : unmanaged, IComVtbl<ID2D1Layer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateLayer(in size, (ID2D1Layer**) layer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> size, ref ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateLayer(in size.GetPinnableReference(), ref layer);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMesh<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ComPtr<TI0> mesh) where TI0 : unmanaged, IComVtbl<ID2D1Mesh>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMesh((ID2D1Mesh**) mesh.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void DrawLine<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawLine(point0, point1, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawLine(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawLine(point0, point1, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawLine<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawLine(point0, point1, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawLine(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawLine(point0, point1, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawLine<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawLine(point0, point1, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawLine(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawLine(point0, point1, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRectangle(rect, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(rect, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRectangle(rect, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(rect, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRectangle(rect, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(rect, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(in rect.GetPinnableReference(), brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawRectangle<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> rect, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRectangle(in rect, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rect, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(in rect.GetPinnableReference(), brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> rect, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRectangle(in rect, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rect, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(in rect.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRectangle(in rect, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rect, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRectangle(in rect.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillRectangle(rect, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillRectangle(rect, ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillRectangle(in rect.GetPinnableReference(), brush);
    }

    /// <summary>To be documented.</summary>
    public static void FillRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> rect, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillRectangle(in rect, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void FillRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rect, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillRectangle(in rect.GetPinnableReference(), ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRoundedRectangle(roundedRect, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(roundedRect, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRoundedRectangle(roundedRect, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(roundedRect, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRoundedRectangle(roundedRect, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(roundedRect, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RoundedRect> roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(in roundedRect.GetPinnableReference(), brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawRoundedRectangle<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RoundedRect roundedRect, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRoundedRectangle(in roundedRect, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RoundedRect> roundedRect, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(in roundedRect.GetPinnableReference(), brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawRoundedRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RoundedRect roundedRect, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRoundedRectangle(in roundedRect, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RoundedRect> roundedRect, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(in roundedRect.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawRoundedRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RoundedRect roundedRect, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawRoundedRectangle(in roundedRect, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RoundedRect> roundedRect, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawRoundedRectangle(in roundedRect.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillRoundedRectangle(roundedRect, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillRoundedRectangle(roundedRect, ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RoundedRect> roundedRect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillRoundedRectangle(in roundedRect.GetPinnableReference(), brush);
    }

    /// <summary>To be documented.</summary>
    public static void FillRoundedRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RoundedRect roundedRect, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillRoundedRectangle(in roundedRect, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void FillRoundedRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RoundedRect> roundedRect, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillRoundedRectangle(in roundedRect.GetPinnableReference(), ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawEllipse(ellipse, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(ellipse, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawEllipse(ellipse, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(ellipse, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawEllipse(ellipse, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(ellipse, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Ellipse> ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(in ellipse.GetPinnableReference(), brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawEllipse<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Ellipse ellipse, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawEllipse(in ellipse, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Ellipse> ellipse, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(in ellipse.GetPinnableReference(), brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawEllipse<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Ellipse ellipse, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawEllipse(in ellipse, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Ellipse> ellipse, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(in ellipse.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawEllipse<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Ellipse ellipse, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawEllipse(in ellipse, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Ellipse> ellipse, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawEllipse(in ellipse.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillEllipse(ellipse, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillEllipse(ellipse, ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Ellipse> ellipse, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillEllipse(in ellipse.GetPinnableReference(), brush);
    }

    /// <summary>To be documented.</summary>
    public static void FillEllipse<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Ellipse ellipse, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillEllipse(in ellipse, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void FillEllipse(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Ellipse> ellipse, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillEllipse(in ellipse.GetPinnableReference(), ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0, TI1, TI2>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> geometry, ComPtr<TI1> brush, float strokeWidth, ComPtr<TI2> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(geometry, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> geometry, ComPtr<TI1> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(geometry, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> geometry, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(geometry, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, ref brush, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Geometry> geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(ref geometry.GetPinnableReference(), brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry(ref geometry, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Geometry> geometry, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(ref geometry.GetPinnableReference(), brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry(ref geometry, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Geometry> geometry, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(ref geometry.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGeometry(ref geometry, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Geometry> geometry, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGeometry(ref geometry.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0, TI1, TI2>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> geometry, ComPtr<TI1> brush, ComPtr<TI2> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, (ID2D1Brush*) opacityBrush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, Span<ID2D1Brush> opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(geometry, brush, ref opacityBrush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> geometry, ComPtr<TI1> brush, ref ID2D1Brush opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, ref opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, Span<ID2D1Brush> brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(geometry, ref brush.GetPinnableReference(), opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> geometry, ref ID2D1Brush brush, ComPtr<TI1> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry((ID2D1Geometry*) geometry.Handle, ref brush, (ID2D1Brush*) opacityBrush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Geometry* geometry, Span<ID2D1Brush> brush, Span<ID2D1Brush> opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(geometry, ref brush.GetPinnableReference(), ref opacityBrush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry((ID2D1Geometry*) geometry.Handle, ref brush, ref opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Geometry> geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(ref geometry.GetPinnableReference(), brush, opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ComPtr<TI0> brush, ComPtr<TI1> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry(ref geometry, (ID2D1Brush*) brush.Handle, (ID2D1Brush*) opacityBrush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Geometry> geometry, ID2D1Brush* brush, Span<ID2D1Brush> opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(ref geometry.GetPinnableReference(), brush, ref opacityBrush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ComPtr<TI0> brush, ref ID2D1Brush opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry(ref geometry, (ID2D1Brush*) brush.Handle, ref opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Geometry> geometry, Span<ID2D1Brush> brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(ref geometry.GetPinnableReference(), ref brush.GetPinnableReference(), opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, ComPtr<TI0> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillGeometry(ref geometry, ref brush, (ID2D1Brush*) opacityBrush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void FillGeometry(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Geometry> geometry, Span<ID2D1Brush> brush, Span<ID2D1Brush> opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillGeometry(ref geometry.GetPinnableReference(), ref brush.GetPinnableReference(), ref opacityBrush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillMesh<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> mesh, ComPtr<TI1> brush) where TI0 : unmanaged, IComVtbl<ID2D1Mesh>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillMesh((ID2D1Mesh*) mesh.Handle, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillMesh(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Mesh* mesh, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillMesh(mesh, ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillMesh<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> mesh, ref ID2D1Brush brush) where TI0 : unmanaged, IComVtbl<ID2D1Mesh>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillMesh((ID2D1Mesh*) mesh.Handle, ref brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillMesh(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Mesh> mesh, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillMesh(ref mesh.GetPinnableReference(), brush);
    }

    /// <summary>To be documented.</summary>
    public static void FillMesh<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Mesh mesh, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillMesh(ref mesh, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void FillMesh(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Mesh> mesh, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillMesh(ref mesh.GetPinnableReference(), ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> opacityMask, ComPtr<TI1> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, brush, content, destinationRectangle, in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> opacityMask, ComPtr<TI1> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, content, destinationRectangle, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, brush, content, in destinationRectangle.GetPinnableReference(), sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> opacityMask, ComPtr<TI1> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, content, in destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, brush, content, in destinationRectangle.GetPinnableReference(), in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillOpacityMask<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> opacityMask, ComPtr<TI1> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, content, in destinationRectangle, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, ref brush.GetPinnableReference(), content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, ref brush.GetPinnableReference(), content, destinationRectangle, in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, content, destinationRectangle, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, ref brush.GetPinnableReference(), content, in destinationRectangle.GetPinnableReference(), sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, content, in destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(opacityMask, ref brush.GetPinnableReference(), content, in destinationRectangle.GetPinnableReference(), in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillOpacityMask<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, content, in destinationRectangle, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), brush, content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), brush, content, destinationRectangle, in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, content, destinationRectangle, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), brush, content, in destinationRectangle.GetPinnableReference(), sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, content, in destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), brush, content, in destinationRectangle.GetPinnableReference(), in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FillOpacityMask<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, content, in destinationRectangle, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), ref brush.GetPinnableReference(), content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), ref brush.GetPinnableReference(), content, destinationRectangle, in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), ref brush.GetPinnableReference(), content, in destinationRectangle.GetPinnableReference(), sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static void FillOpacityMask(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> opacityMask, Span<ID2D1Brush> brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), ref brush.GetPinnableReference(), content, in destinationRectangle.GetPinnableReference(), in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, destinationRectangle, opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(bitmap, destinationRectangle, opacity, interpolationMode, in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, destinationRectangle, opacity, interpolationMode, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(bitmap, in destinationRectangle.GetPinnableReference(), opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, in destinationRectangle, opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(bitmap, in destinationRectangle.GetPinnableReference(), opacity, interpolationMode, in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawBitmap<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, in destinationRectangle, opacity, interpolationMode, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(ref bitmap.GetPinnableReference(), destinationRectangle, opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(ref bitmap.GetPinnableReference(), destinationRectangle, opacity, interpolationMode, in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(ref bitmap.GetPinnableReference(), in destinationRectangle.GetPinnableReference(), opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static void DrawBitmap(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawBitmap(ref bitmap.GetPinnableReference(), in destinationRectangle.GetPinnableReference(), opacity, interpolationMode, in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(@string, stringLength, textFormat, layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, textFormat, layoutRect, ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, textFormat, in layoutRect.GetPinnableReference(), defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(@string, stringLength, textFormat, in layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, textFormat, in layoutRect.GetPinnableReference(), ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(in @string.GetPinnableReference(), stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(in @string, stringLength, textFormat, layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(in @string.GetPinnableReference(), stringLength, textFormat, layoutRect, ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(in @string.GetPinnableReference(), stringLength, textFormat, in layoutRect.GetPinnableReference(), defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(in @string, stringLength, textFormat, in layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(in @string.GetPinnableReference(), stringLength, textFormat, in layoutRect.GetPinnableReference(), ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(@string, stringLength, textFormat, layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, textFormat, layoutRect, ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, textFormat, in layoutRect.GetPinnableReference(), defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> layoutRect, ComPtr<TI0> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextA(@string, stringLength, textFormat, in layoutRect, (ID2D1Brush*) defaultFillBrush.Handle, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> layoutRect, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextA(@string, stringLength, textFormat, in layoutRect.GetPinnableReference(), ref defaultFillBrush.GetPinnableReference(), options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextLayout<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, ComPtr<TI0> defaultFillBrush, DrawTextOptions options) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawTextLayout(origin, textLayout, (ID2D1Brush*) defaultFillBrush.Handle, options);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextLayout(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, Span<ID2D1Brush> defaultFillBrush, DrawTextOptions options)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawTextLayout(origin, textLayout, ref defaultFillBrush.GetPinnableReference(), options);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGlyphRun<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, ComPtr<TI0> foregroundBrush, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGlyphRun(baselineOrigin, glyphRun, (ID2D1Brush*) foregroundBrush.Handle, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGlyphRun(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, Span<ID2D1Brush> foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGlyphRun(baselineOrigin, glyphRun, ref foregroundBrush.GetPinnableReference(), measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static void SetTransform(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetTransform(in transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetTransform(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Silk.NET.Maths.Matrix3X2<float>> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTransform(ref transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTags(this ComPtr<ID2D1DeviceContext> thisVtbl, ulong* tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTags(tag1, ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTags(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ulong> tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTags(ref tag1.GetPinnableReference(), tag2);
    }

    /// <summary>To be documented.</summary>
    public static void GetTags(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ulong> tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTags(ref tag1.GetPinnableReference(), ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters* layerParameters, ComPtr<TI0> layer) where TI0 : unmanaged, IComVtbl<ID2D1Layer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PushLayer(layerParameters, (ID2D1Layer*) layer.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters* layerParameters, Span<ID2D1Layer> layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PushLayer(layerParameters, ref layer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LayerParameters> layerParameters, ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PushLayer(in layerParameters.GetPinnableReference(), layer);
    }

    /// <summary>To be documented.</summary>
    public static void PushLayer<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly LayerParameters layerParameters, ComPtr<TI0> layer) where TI0 : unmanaged, IComVtbl<ID2D1Layer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PushLayer(in layerParameters, (ID2D1Layer*) layer.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void PushLayer(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LayerParameters> layerParameters, Span<ID2D1Layer> layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PushLayer(in layerParameters.GetPinnableReference(), ref layer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Flush(this ComPtr<ID2D1DeviceContext> thisVtbl, ulong* tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Flush(tag1, ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Flush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ulong> tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Flush(ref tag1.GetPinnableReference(), tag2);
    }

    /// <summary>To be documented.</summary>
    public static int Flush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ulong> tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Flush(ref tag1.GetPinnableReference(), ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SaveDrawingState<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SaveDrawingState((ID2D1DrawingStateBlock*) drawingStateBlock.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void SaveDrawingState(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1DrawingStateBlock> drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SaveDrawingState(ref drawingStateBlock.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void RestoreDrawingState<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->RestoreDrawingState((ID2D1DrawingStateBlock*) drawingStateBlock.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void RestoreDrawingState(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1DrawingStateBlock> drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RestoreDrawingState(ref drawingStateBlock.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void PushAxisAlignedClip(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> clipRect, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PushAxisAlignedClip(in clipRect.GetPinnableReference(), antialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static void Clear(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> clearColor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Clear(in clearColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndDraw(this ComPtr<ID2D1DeviceContext> thisVtbl, ulong* tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EndDraw(tag1, ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndDraw(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ulong> tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EndDraw(ref tag1.GetPinnableReference(), tag2);
    }

    /// <summary>To be documented.</summary>
    public static int EndDraw(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ulong> tag1, Span<ulong> tag2)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EndDraw(ref tag1.GetPinnableReference(), ref tag2.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1DeviceContext> thisVtbl, float* dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(dpiX, ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<float> dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(ref dpiX.GetPinnableReference(), dpiY);
    }

    /// <summary>To be documented.</summary>
    public static void GetDpi(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<float> dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(ref dpiX.GetPinnableReference(), ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsSupported(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsSupported(in renderTargetProperties.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* profile, uint profileSize, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContext(space, profile, profileSize, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1DeviceContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> profile, uint profileSize, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateColorContext(space, in profile.GetPinnableReference(), profileSize, colorContext);
    }

    /// <summary>To be documented.</summary>
    public static int CreateColorContext<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte profile, uint profileSize, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContext(space, in profile, profileSize, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1DeviceContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> profile, uint profileSize, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateColorContext(space, in profile.GetPinnableReference(), profileSize, ref colorContext);
    }

    /// <summary>To be documented.</summary>
    public static int CreateColorContext<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContext(space, profile, profileSize, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filename, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContextFromFilename(filename, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> filename, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateColorContextFromFilename(in filename.GetPinnableReference(), colorContext);
    }

    /// <summary>To be documented.</summary>
    public static int CreateColorContextFromFilename<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filename, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContextFromFilename(in filename, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> filename, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateColorContextFromFilename(in filename.GetPinnableReference(), ref colorContext);
    }

    /// <summary>To be documented.</summary>
    public static int CreateColorContextFromFilename<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContextFromFilename(filename, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromWicColorContext<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, IWICColorContext* wicColorContext, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContextFromWicColorContext(wicColorContext, (ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.DXGI.IDXGISurface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties1* bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromDxgiSurface(surface, bitmapProperties, (ID2D1Bitmap1**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.DXGI.IDXGISurface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties1> bitmapProperties, ID2D1Bitmap1** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromDxgiSurface(surface, in bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.DXGI.IDXGISurface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties1 bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromDxgiSurface(surface, in bitmapProperties, (ID2D1Bitmap1**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.DXGI.IDXGISurface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties1> bitmapProperties, ref ID2D1Bitmap1* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromDxgiSurface(surface, in bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties1* bitmapProperties, ID2D1Bitmap1** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromDxgiSurface(ref surface.GetPinnableReference(), bitmapProperties, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Silk.NET.DXGI.IDXGISurface surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties1* bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromDxgiSurface(ref surface, bitmapProperties, (ID2D1Bitmap1**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties1* bitmapProperties, ref ID2D1Bitmap1* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromDxgiSurface(ref surface.GetPinnableReference(), bitmapProperties, ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties1> bitmapProperties, ID2D1Bitmap1** bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromDxgiSurface(ref surface.GetPinnableReference(), in bitmapProperties.GetPinnableReference(), bitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapFromDxgiSurface<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Silk.NET.DXGI.IDXGISurface surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BitmapProperties1 bitmapProperties, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromDxgiSurface(ref surface, in bitmapProperties, (ID2D1Bitmap1**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapProperties1> bitmapProperties, ref ID2D1Bitmap1* bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromDxgiSurface(ref surface.GetPinnableReference(), in bitmapProperties.GetPinnableReference(), ref bitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateEffect<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, out ComPtr<TI0> effect) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        effect = default;
        return @this->CreateEffect(SilkMarshal.GuidPtrOf<TI0>(), (ID2D1Effect**) effect.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Guid> effectId, ID2D1Effect** effect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEffect(ref effectId.GetPinnableReference(), effect);
    }

    /// <summary>To be documented.</summary>
    public static int CreateEffect<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref Guid effectId, ref ComPtr<TI0> effect) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEffect(ref effectId, (ID2D1Effect**) effect.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<Guid> effectId, ref ID2D1Effect* effect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEffect(ref effectId.GetPinnableReference(), ref effect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ComPtr<TI1> imageBrush) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1ImageBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateImageBrush((ID2D1Image*) image.Handle, imageBrushProperties, brushProperties, (ID2D1ImageBrush**) imageBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateImageBrush((ID2D1Image*) image.Handle, imageBrushProperties, brushProperties, ref imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(image, imageBrushProperties, in brushProperties.GetPinnableReference(), imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ComPtr<TI1> imageBrush) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1ImageBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateImageBrush((ID2D1Image*) image.Handle, imageBrushProperties, in brushProperties, (ID2D1ImageBrush**) imageBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(image, imageBrushProperties, in brushProperties.GetPinnableReference(), ref imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1ImageBrush* imageBrush) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateImageBrush((ID2D1Image*) image.Handle, imageBrushProperties, in brushProperties, ref imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageBrushProperties> imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(image, in imageBrushProperties.GetPinnableReference(), brushProperties, imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ComPtr<TI1> imageBrush) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1ImageBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateImageBrush((ID2D1Image*) image.Handle, in imageBrushProperties, brushProperties, (ID2D1ImageBrush**) imageBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageBrushProperties> imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(image, in imageBrushProperties.GetPinnableReference(), brushProperties, ref imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateImageBrush((ID2D1Image*) image.Handle, in imageBrushProperties, brushProperties, ref imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageBrushProperties> imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(image, in imageBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateImageBrush<TI0, TI1>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ComPtr<TI1> imageBrush) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1ImageBrush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateImageBrush((ID2D1Image*) image.Handle, in imageBrushProperties, in brushProperties, (ID2D1ImageBrush**) imageBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageBrushProperties> imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(image, in imageBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), ref imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ID2D1ImageBrush* imageBrush) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateImageBrush((ID2D1Image*) image.Handle, in imageBrushProperties, in brushProperties, ref imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(ref image.GetPinnableReference(), imageBrushProperties, brushProperties, imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ComPtr<TI0> imageBrush) where TI0 : unmanaged, IComVtbl<ID2D1ImageBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateImageBrush(ref image, imageBrushProperties, brushProperties, (ID2D1ImageBrush**) imageBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(ref image.GetPinnableReference(), imageBrushProperties, brushProperties, ref imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(ref image.GetPinnableReference(), imageBrushProperties, in brushProperties.GetPinnableReference(), imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ComPtr<TI0> imageBrush) where TI0 : unmanaged, IComVtbl<ID2D1ImageBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateImageBrush(ref image, imageBrushProperties, in brushProperties, (ID2D1ImageBrush**) imageBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(ref image.GetPinnableReference(), imageBrushProperties, in brushProperties.GetPinnableReference(), ref imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageBrushProperties> imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(ref image.GetPinnableReference(), in imageBrushProperties.GetPinnableReference(), brushProperties, imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ComPtr<TI0> imageBrush) where TI0 : unmanaged, IComVtbl<ID2D1ImageBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateImageBrush(ref image, in imageBrushProperties, brushProperties, (ID2D1ImageBrush**) imageBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageBrushProperties> imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(ref image.GetPinnableReference(), in imageBrushProperties.GetPinnableReference(), brushProperties, ref imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageBrushProperties> imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(ref image.GetPinnableReference(), in imageBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateImageBrush<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageBrushProperties imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BrushProperties brushProperties, ref ComPtr<TI0> imageBrush) where TI0 : unmanaged, IComVtbl<ID2D1ImageBrush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateImageBrush(ref image, in imageBrushProperties, in brushProperties, (ID2D1ImageBrush**) imageBrush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageBrushProperties> imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BrushProperties> brushProperties, ref ID2D1ImageBrush* imageBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateImageBrush(ref image.GetPinnableReference(), in imageBrushProperties.GetPinnableReference(), in brushProperties.GetPinnableReference(), ref imageBrush);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandList<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ComPtr<TI0> commandList) where TI0 : unmanaged, IComVtbl<ID2D1CommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandList((ID2D1CommandList**) commandList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageLocalBounds<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, Silk.NET.Maths.Box2D<float>* localBounds) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetImageLocalBounds((ID2D1Image*) image.Handle, localBounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageLocalBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, Span<Silk.NET.Maths.Box2D<float>> localBounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetImageLocalBounds(image, ref localBounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetImageLocalBounds<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, ref Silk.NET.Maths.Box2D<float> localBounds) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetImageLocalBounds((ID2D1Image*) image.Handle, ref localBounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageLocalBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, Silk.NET.Maths.Box2D<float>* localBounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetImageLocalBounds(ref image.GetPinnableReference(), localBounds);
    }

    /// <summary>To be documented.</summary>
    public static int GetImageLocalBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, Span<Silk.NET.Maths.Box2D<float>> localBounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetImageLocalBounds(ref image.GetPinnableReference(), ref localBounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageWorldBounds<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, Silk.NET.Maths.Box2D<float>* worldBounds) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetImageWorldBounds((ID2D1Image*) image.Handle, worldBounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageWorldBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, Span<Silk.NET.Maths.Box2D<float>> worldBounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetImageWorldBounds(image, ref worldBounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetImageWorldBounds<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, ref Silk.NET.Maths.Box2D<float> worldBounds) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetImageWorldBounds((ID2D1Image*) image.Handle, ref worldBounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageWorldBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, Silk.NET.Maths.Box2D<float>* worldBounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetImageWorldBounds(ref image.GetPinnableReference(), worldBounds);
    }

    /// <summary>To be documented.</summary>
    public static int GetImageWorldBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, Span<Silk.NET.Maths.Box2D<float>> worldBounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetImageWorldBounds(ref image.GetPinnableReference(), ref worldBounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunWorldBounds(this ComPtr<ID2D1DeviceContext> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, DwriteMeasuringMode measuringMode, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunWorldBounds(baselineOrigin, glyphRun, measuringMode, ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetDevice<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ComPtr<TI0> device) where TI0 : unmanaged, IComVtbl<ID2D1Device>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetDevice((ID2D1Device**) device.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void SetTarget<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetTarget((ID2D1Image*) image.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void SetTarget(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetTarget(ref image.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetTarget<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ref ComPtr<TI0> image) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetTarget((ID2D1Image**) image.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void SetRenderingControls(this ComPtr<ID2D1DeviceContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderingControls> renderingControls)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetRenderingControls(in renderingControls.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetRenderingControls(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<RenderingControls> renderingControls)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetRenderingControls(ref renderingControls.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawImage((ID2D1Image*) image.Handle, targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawImage(image, targetOffset, in imageRectangle.GetPinnableReference(), interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawImage((ID2D1Image*) image.Handle, targetOffset, in imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawImage(image, in targetOffset.GetPinnableReference(), imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawImage((ID2D1Image*) image.Handle, in targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawImage(image, in targetOffset.GetPinnableReference(), in imageRectangle.GetPinnableReference(), interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static void DrawImage<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawImage((ID2D1Image*) image.Handle, in targetOffset, in imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawImage(ref image.GetPinnableReference(), targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawImage(ref image.GetPinnableReference(), targetOffset, in imageRectangle.GetPinnableReference(), interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawImage(ref image.GetPinnableReference(), in targetOffset.GetPinnableReference(), imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static void DrawImage(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawImage(ref image.GetPinnableReference(), in targetOffset.GetPinnableReference(), in imageRectangle.GetPinnableReference(), interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGdiMetafile<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGdiMetafile((ID2D1GdiMetafile*) gdiMetafile.Handle, targetOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGdiMetafile(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1GdiMetafile* gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> targetOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGdiMetafile(gdiMetafile, in targetOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawGdiMetafile<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Vector2D<float> targetOffset) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawGdiMetafile((ID2D1GdiMetafile*) gdiMetafile.Handle, in targetOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGdiMetafile(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1GdiMetafile> gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGdiMetafile(ref gdiMetafile.GetPinnableReference(), targetOffset);
    }

    /// <summary>To be documented.</summary>
    public static void DrawGdiMetafile(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1GdiMetafile> gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> targetOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawGdiMetafile(ref gdiMetafile.GetPinnableReference(), in targetOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InvalidateEffectInputRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> effect, uint input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* inputRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InvalidateEffectInputRectangle((ID2D1Effect*) effect.Handle, input, inputRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InvalidateEffectInputRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* effect, uint input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> inputRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InvalidateEffectInputRectangle(effect, input, in inputRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int InvalidateEffectInputRectangle<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> effect, uint input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> inputRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InvalidateEffectInputRectangle((ID2D1Effect*) effect.Handle, input, in inputRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InvalidateEffectInputRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> effect, uint input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* inputRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InvalidateEffectInputRectangle(ref effect.GetPinnableReference(), input, inputRectangle);
    }

    /// <summary>To be documented.</summary>
    public static int InvalidateEffectInputRectangle(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> effect, uint input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> inputRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InvalidateEffectInputRectangle(ref effect.GetPinnableReference(), input, in inputRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangleCount<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> effect, uint* rectangleCount) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectInvalidRectangleCount((ID2D1Effect*) effect.Handle, rectangleCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangleCount(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* effect, Span<uint> rectangleCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectInvalidRectangleCount(effect, ref rectangleCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectInvalidRectangleCount<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> effect, ref uint rectangleCount) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectInvalidRectangleCount((ID2D1Effect*) effect.Handle, ref rectangleCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangleCount(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> effect, uint* rectangleCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectInvalidRectangleCount(ref effect.GetPinnableReference(), rectangleCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectInvalidRectangleCount(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> effect, Span<uint> rectangleCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectInvalidRectangleCount(ref effect.GetPinnableReference(), ref rectangleCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangles<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> effect, Silk.NET.Maths.Box2D<float>* rectangles, uint rectanglesCount) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectInvalidRectangles((ID2D1Effect*) effect.Handle, rectangles, rectanglesCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* effect, Span<Silk.NET.Maths.Box2D<float>> rectangles, uint rectanglesCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectInvalidRectangles(effect, ref rectangles.GetPinnableReference(), rectanglesCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectInvalidRectangles<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> effect, ref Silk.NET.Maths.Box2D<float> rectangles, uint rectanglesCount) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectInvalidRectangles((ID2D1Effect*) effect.Handle, ref rectangles, rectanglesCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> effect, Silk.NET.Maths.Box2D<float>* rectangles, uint rectanglesCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectInvalidRectangles(ref effect.GetPinnableReference(), rectangles, rectanglesCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectInvalidRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> effect, Span<Silk.NET.Maths.Box2D<float>> rectangles, uint rectanglesCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectInvalidRectangles(ref effect.GetPinnableReference(), ref rectangles.GetPinnableReference(), rectanglesCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectRequiredInputRectangles((ID2D1Effect*) renderEffect.Handle, renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Span<Silk.NET.Maths.Box2D<float>> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(renderEffect, renderImageRectangle, inputDescriptions, ref requiredInputRects.GetPinnableReference(), inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectRequiredInputRectangles((ID2D1Effect*) renderEffect.Handle, renderImageRectangle, inputDescriptions, ref requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectInputDescription> inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(renderEffect, renderImageRectangle, in inputDescriptions.GetPinnableReference(), requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EffectInputDescription inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectRequiredInputRectangles((ID2D1Effect*) renderEffect.Handle, renderImageRectangle, in inputDescriptions, requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectInputDescription> inputDescriptions, Span<Silk.NET.Maths.Box2D<float>> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(renderEffect, renderImageRectangle, in inputDescriptions.GetPinnableReference(), ref requiredInputRects.GetPinnableReference(), inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EffectInputDescription inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectRequiredInputRectangles((ID2D1Effect*) renderEffect.Handle, renderImageRectangle, in inputDescriptions, ref requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(renderEffect, in renderImageRectangle.GetPinnableReference(), inputDescriptions, requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectRequiredInputRectangles((ID2D1Effect*) renderEffect.Handle, in renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Span<Silk.NET.Maths.Box2D<float>> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(renderEffect, in renderImageRectangle.GetPinnableReference(), inputDescriptions, ref requiredInputRects.GetPinnableReference(), inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectRequiredInputRectangles((ID2D1Effect*) renderEffect.Handle, in renderImageRectangle, inputDescriptions, ref requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectInputDescription> inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(renderEffect, in renderImageRectangle.GetPinnableReference(), in inputDescriptions.GetPinnableReference(), requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EffectInputDescription inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectRequiredInputRectangles((ID2D1Effect*) renderEffect.Handle, in renderImageRectangle, in inputDescriptions, requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectInputDescription> inputDescriptions, Span<Silk.NET.Maths.Box2D<float>> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(renderEffect, in renderImageRectangle.GetPinnableReference(), in inputDescriptions.GetPinnableReference(), ref requiredInputRects.GetPinnableReference(), inputCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectRequiredInputRectangles<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl, ComPtr<TI0> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<float> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EffectInputDescription inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectRequiredInputRectangles((ID2D1Effect*) renderEffect.Handle, in renderImageRectangle, in inputDescriptions, ref requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(ref renderEffect.GetPinnableReference(), renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Span<Silk.NET.Maths.Box2D<float>> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(ref renderEffect.GetPinnableReference(), renderImageRectangle, inputDescriptions, ref requiredInputRects.GetPinnableReference(), inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectInputDescription> inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(ref renderEffect.GetPinnableReference(), renderImageRectangle, in inputDescriptions.GetPinnableReference(), requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectInputDescription> inputDescriptions, Span<Silk.NET.Maths.Box2D<float>> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(ref renderEffect.GetPinnableReference(), renderImageRectangle, in inputDescriptions.GetPinnableReference(), ref requiredInputRects.GetPinnableReference(), inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(ref renderEffect.GetPinnableReference(), in renderImageRectangle.GetPinnableReference(), inputDescriptions, requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Span<Silk.NET.Maths.Box2D<float>> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(ref renderEffect.GetPinnableReference(), in renderImageRectangle.GetPinnableReference(), inputDescriptions, ref requiredInputRects.GetPinnableReference(), inputCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectInputDescription> inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(ref renderEffect.GetPinnableReference(), in renderImageRectangle.GetPinnableReference(), in inputDescriptions.GetPinnableReference(), requiredInputRects, inputCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext> thisVtbl, Span<ID2D1Effect> renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectInputDescription> inputDescriptions, Span<Silk.NET.Maths.Box2D<float>> requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectRequiredInputRectangles(ref renderEffect.GetPinnableReference(), in renderImageRectangle.GetPinnableReference(), in inputDescriptions.GetPinnableReference(), ref requiredInputRects.GetPinnableReference(), inputCount);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateEffect<TI0>(this ComPtr<ID2D1DeviceContext> thisVtbl) where TI0 : unmanaged, IComVtbl<ID2D1Effect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateEffect(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
