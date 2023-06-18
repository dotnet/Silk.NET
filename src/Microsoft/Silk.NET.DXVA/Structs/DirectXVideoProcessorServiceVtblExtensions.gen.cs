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

public unsafe static class DirectXVideoProcessorServiceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirectXVideoProcessorService> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirectXVideoProcessorService> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirectXVideoProcessorService> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDirectXVideoProcessorService> thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoProcessorSoftwareDevice(this ComPtr<IDirectXVideoProcessorService> thisVtbl, void* pCallbacks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, void*, int>)@this->LpVtbl[4])(@this, pCallbacks);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorDeviceGuids(this ComPtr<IDirectXVideoProcessorService> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, uint* pCount, Guid** pGuids)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, DXVA2VideoDesc*, uint*, Guid**, int>)@this->LpVtbl[5])(@this, pVideoDesc, pCount, pGuids);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets(this ComPtr<IDirectXVideoProcessorService> thisVtbl, Guid* VideoProcDeviceGuid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, uint* pCount, Silk.NET.Direct3D9.Format** pFormats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuid, pVideoDesc, pCount, pFormats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats(this ComPtr<IDirectXVideoProcessorService> thisVtbl, Guid* VideoProcDeviceGuid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint* pCount, Silk.NET.Direct3D9.Format** pFormats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, pCount, pFormats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps(this ComPtr<IDirectXVideoProcessorService> thisVtbl, Guid* VideoProcDeviceGuid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, DXVA2VideoProcessorCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[8])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProcAmpRange(this ComPtr<IDirectXVideoProcessorService> thisVtbl, Guid* VideoProcDeviceGuid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint ProcAmpCap, DXVA2ValueRange* pRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[9])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, ProcAmpCap, pRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilterPropertyRange(this ComPtr<IDirectXVideoProcessorService> thisVtbl, Guid* VideoProcDeviceGuid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint FilterSetting, DXVA2ValueRange* pRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[10])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, FilterSetting, pRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<IDirectXVideoProcessorService> thisVtbl, Guid* VideoProcDeviceGuid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint MaxNumSubStreams, IDirectXVideoProcessor** ppVidProcess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, IDirectXVideoProcessor**, int>)@this->LpVtbl[11])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, MaxNumSubStreams, ppVidProcess);
        return ret;
    }

}
