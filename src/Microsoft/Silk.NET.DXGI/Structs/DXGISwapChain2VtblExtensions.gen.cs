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

public unsafe static class DXGISwapChain2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChain2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGISwapChain2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGISwapChain2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGISwapChain2> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGISwapChain2> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGISwapChain2> thisVtbl, Guid* Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGISwapChain2> thisVtbl, Guid* riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDXGISwapChain2> thisVtbl, Guid* riid, void** ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Present(this ComPtr<IDXGISwapChain2> thisVtbl, uint SyncInterval, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, int>)@this->LpVtbl[8])(@this, SyncInterval, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IDXGISwapChain2> thisVtbl, uint Buffer, Guid* riid, void** ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riid, ppSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFullscreenState(this ComPtr<IDXGISwapChain2> thisVtbl, Silk.NET.Core.Bool32 Fullscreen, IDXGIOutput* pTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Silk.NET.Core.Bool32, IDXGIOutput*, int>)@this->LpVtbl[10])(@this, Fullscreen, pTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState(this ComPtr<IDXGISwapChain2> thisVtbl, int* pFullscreen, IDXGIOutput** ppTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreen, ppTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<IDXGISwapChain2> thisVtbl, SwapChainDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainDesc*, int>)@this->LpVtbl[12])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResizeBuffers(this ComPtr<IDXGISwapChain2> thisVtbl, uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format NewFormat, uint SwapChainFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, uint, Silk.NET.DXGI.Format, uint, int>)@this->LpVtbl[13])(@this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResizeTarget(this ComPtr<IDXGISwapChain2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pNewTargetParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeDesc*, int>)@this->LpVtbl[14])(@this, pNewTargetParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingOutput(this ComPtr<IDXGISwapChain2> thisVtbl, IDXGIOutput** ppOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, IDXGIOutput**, int>)@this->LpVtbl[15])(@this, ppOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameStatistics(this ComPtr<IDXGISwapChain2> thisVtbl, FrameStatistics* pStats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, FrameStatistics*, int>)@this->LpVtbl[16])(@this, pStats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastPresentCount(this ComPtr<IDXGISwapChain2> thisVtbl, uint* pLastPresentCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, int>)@this->LpVtbl[17])(@this, pLastPresentCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc1(this ComPtr<IDXGISwapChain2> thisVtbl, SwapChainDesc1* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainDesc1*, int>)@this->LpVtbl[18])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenDesc(this ComPtr<IDXGISwapChain2> thisVtbl, SwapChainFullscreenDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainFullscreenDesc*, int>)@this->LpVtbl[19])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHwnd(this ComPtr<IDXGISwapChain2> thisVtbl, nint* pHwnd)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, nint*, int>)@this->LpVtbl[20])(@this, pHwnd);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow(this ComPtr<IDXGISwapChain2> thisVtbl, Guid* refiid, void** ppUnk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiid, ppUnk);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present1(this ComPtr<IDXGISwapChain2> thisVtbl, uint SyncInterval, uint PresentFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PresentParameters* pPresentParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, PresentParameters*, int>)@this->LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsTemporaryMonoSupported(this ComPtr<IDXGISwapChain2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Silk.NET.Core.Bool32>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRestrictToOutput(this ComPtr<IDXGISwapChain2> thisVtbl, IDXGIOutput** ppRestrictToOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, IDXGIOutput**, int>)@this->LpVtbl[24])(@this, ppRestrictToOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundColor(this ComPtr<IDXGISwapChain2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3Dcolorvalue* pColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, D3Dcolorvalue*, int>)@this->LpVtbl[25])(@this, pColor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackgroundColor(this ComPtr<IDXGISwapChain2> thisVtbl, D3Dcolorvalue* pColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, D3Dcolorvalue*, int>)@this->LpVtbl[26])(@this, pColor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRotation(this ComPtr<IDXGISwapChain2> thisVtbl, ModeRotation Rotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeRotation, int>)@this->LpVtbl[27])(@this, Rotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRotation(this ComPtr<IDXGISwapChain2> thisVtbl, ModeRotation* pRotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeRotation*, int>)@this->LpVtbl[28])(@this, pRotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceSize(this ComPtr<IDXGISwapChain2> thisVtbl, uint Width, uint Height)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, int>)@this->LpVtbl[29])(@this, Width, Height);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceSize(this ComPtr<IDXGISwapChain2> thisVtbl, uint* pWidth, uint* pHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, uint*, int>)@this->LpVtbl[30])(@this, pWidth, pHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaximumFrameLatency(this ComPtr<IDXGISwapChain2> thisVtbl, uint MaxLatency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, int>)@this->LpVtbl[31])(@this, MaxLatency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaximumFrameLatency(this ComPtr<IDXGISwapChain2> thisVtbl, uint* pMaxLatency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, int>)@this->LpVtbl[32])(@this, pMaxLatency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetFrameLatencyWaitableObject(this ComPtr<IDXGISwapChain2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, void*>)@this->LpVtbl[33])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetMatrixTransform(this ComPtr<IDXGISwapChain2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix3X2F* pMatrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Matrix3X2F*, int>)@this->LpVtbl[34])(@this, pMatrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatrixTransform(this ComPtr<IDXGISwapChain2> thisVtbl, Matrix3X2F* pMatrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Matrix3X2F*, int>)@this->LpVtbl[35])(@this, pMatrix);
        return ret;
    }

}
