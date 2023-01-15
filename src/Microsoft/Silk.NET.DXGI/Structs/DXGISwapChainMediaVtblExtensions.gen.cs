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

namespace Silk.NET.DXGI;

public unsafe static class DXGISwapChainMediaVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChainMedia> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChainMedia> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChainMedia> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChainMedia> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGISwapChainMedia> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGISwapChainMedia> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameStatisticsMedia(this ComPtr<IDXGISwapChainMedia> thisVtbl, FrameStatisticsMedia* pStats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, FrameStatisticsMedia*, int>)@this->LpVtbl[3])(@this, pStats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameStatisticsMedia(this ComPtr<IDXGISwapChainMedia> thisVtbl, ref FrameStatisticsMedia pStats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FrameStatisticsMedia* pStatsPtr = &pStats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, FrameStatisticsMedia*, int>)@this->LpVtbl[3])(@this, pStatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPresentDuration(this ComPtr<IDXGISwapChainMedia> thisVtbl, uint Duration)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint, int>)@this->LpVtbl[4])(@this, Duration);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckPresentDurationSupport(this ComPtr<IDXGISwapChainMedia> thisVtbl, uint DesiredPresentDuration, uint* pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint, uint*, uint*, int>)@this->LpVtbl[5])(@this, DesiredPresentDuration, pClosestSmallerPresentDuration, pClosestLargerPresentDuration);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckPresentDurationSupport(this ComPtr<IDXGISwapChainMedia> thisVtbl, uint DesiredPresentDuration, uint* pClosestSmallerPresentDuration, ref uint pClosestLargerPresentDuration)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pClosestLargerPresentDurationPtr = &pClosestLargerPresentDuration)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint, uint*, uint*, int>)@this->LpVtbl[5])(@this, DesiredPresentDuration, pClosestSmallerPresentDuration, pClosestLargerPresentDurationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckPresentDurationSupport(this ComPtr<IDXGISwapChainMedia> thisVtbl, uint DesiredPresentDuration, ref uint pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pClosestSmallerPresentDurationPtr = &pClosestSmallerPresentDuration)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint, uint*, uint*, int>)@this->LpVtbl[5])(@this, DesiredPresentDuration, pClosestSmallerPresentDurationPtr, pClosestLargerPresentDuration);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckPresentDurationSupport(this ComPtr<IDXGISwapChainMedia> thisVtbl, uint DesiredPresentDuration, ref uint pClosestSmallerPresentDuration, ref uint pClosestLargerPresentDuration)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pClosestSmallerPresentDurationPtr = &pClosestSmallerPresentDuration)
        {
            fixed (uint* pClosestLargerPresentDurationPtr = &pClosestLargerPresentDuration)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint, uint*, uint*, int>)@this->LpVtbl[5])(@this, DesiredPresentDuration, pClosestSmallerPresentDurationPtr, pClosestLargerPresentDurationPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDXGISwapChainMedia> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChainMedia> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChainMedia> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameStatisticsMedia(this ComPtr<IDXGISwapChainMedia> thisVtbl, Span<FrameStatisticsMedia> pStats)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrameStatisticsMedia(ref pStats.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckPresentDurationSupport(this ComPtr<IDXGISwapChainMedia> thisVtbl, uint DesiredPresentDuration, uint* pClosestSmallerPresentDuration, Span<uint> pClosestLargerPresentDuration)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckPresentDurationSupport(DesiredPresentDuration, pClosestSmallerPresentDuration, ref pClosestLargerPresentDuration.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckPresentDurationSupport(this ComPtr<IDXGISwapChainMedia> thisVtbl, uint DesiredPresentDuration, Span<uint> pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckPresentDurationSupport(DesiredPresentDuration, ref pClosestSmallerPresentDuration.GetPinnableReference(), pClosestLargerPresentDuration);
    }

    /// <summary>To be documented.</summary>
    public static int CheckPresentDurationSupport(this ComPtr<IDXGISwapChainMedia> thisVtbl, uint DesiredPresentDuration, Span<uint> pClosestSmallerPresentDuration, Span<uint> pClosestLargerPresentDuration)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckPresentDurationSupport(DesiredPresentDuration, ref pClosestSmallerPresentDuration.GetPinnableReference(), ref pClosestLargerPresentDuration.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDXGISwapChainMedia> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
