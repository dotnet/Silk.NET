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

public unsafe static class D2D1ImageSourceFromWicVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int OfferResources(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryReclaimResources(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, int* resourcesDiscarded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, int*, int>)@this->LpVtbl[5])(@this, resourcesDiscarded);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int TryReclaimResources(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, ref int resourcesDiscarded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* resourcesDiscardedPtr = &resourcesDiscarded)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, int*, int>)@this->LpVtbl[5])(@this, resourcesDiscardedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnsureCached(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* rectangleToFill)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[6])(@this, rectangleToFill);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnsureCached(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> rectangleToFill)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* rectangleToFillPtr = &rectangleToFill)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[6])(@this, rectangleToFillPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TrimCache(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* rectangleToPreserve)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[7])(@this, rectangleToPreserve);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int TrimCache(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> rectangleToPreserve)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* rectangleToPreservePtr = &rectangleToPreserve)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[7])(@this, rectangleToPreservePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetSource(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, IWICBitmapSource** wicBitmapSource)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, IWICBitmapSource**, void>)@this->LpVtbl[8])(@this, wicBitmapSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetSource(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, ref IWICBitmapSource* wicBitmapSource)
    {
        var @this = thisVtbl.Handle;
        fixed (IWICBitmapSource** wicBitmapSourcePtr = &wicBitmapSource)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, IWICBitmapSource**, void>)@this->LpVtbl[8])(@this, wicBitmapSourcePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int TryReclaimResources(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, Span<int> resourcesDiscarded)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryReclaimResources(ref resourcesDiscarded.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnsureCached(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> rectangleToFill)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnsureCached(in rectangleToFill.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int TrimCache(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> rectangleToPreserve)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TrimCache(in rectangleToPreserve.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
