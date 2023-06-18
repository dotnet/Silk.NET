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

namespace Silk.NET.DXVA;

public unsafe static class DirectXVideoProcessorVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirectXVideoProcessor> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirectXVideoProcessor> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirectXVideoProcessor> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorService(this ComPtr<IDirectXVideoProcessor> thisVtbl, IDirectXVideoProcessorService** ppService)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, IDirectXVideoProcessorService**, int>)@this->LpVtbl[3])(@this, ppService);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters(this ComPtr<IDirectXVideoProcessor> thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, uint* pMaxNumSubStreams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pRenderTargetFormat, pMaxNumSubStreams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps(this ComPtr<IDirectXVideoProcessor> thisVtbl, DXVA2VideoProcessorCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[5])(@this, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProcAmpRange(this ComPtr<IDirectXVideoProcessor> thisVtbl, uint ProcAmpCap, DXVA2ValueRange* pRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, uint, DXVA2ValueRange*, int>)@this->LpVtbl[6])(@this, ProcAmpCap, pRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilterPropertyRange(this ComPtr<IDirectXVideoProcessor> thisVtbl, uint FilterSetting, DXVA2ValueRange* pRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, uint, DXVA2ValueRange*, int>)@this->LpVtbl[7])(@this, FilterSetting, pRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt(this ComPtr<IDirectXVideoProcessor> thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoProcessBltParams* pBltParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoSample* pSamples, uint NumSamples, void** pHandleComplete)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTarget, pBltParams, pSamples, NumSamples, pHandleComplete);
        return ret;
    }

}
