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

}
