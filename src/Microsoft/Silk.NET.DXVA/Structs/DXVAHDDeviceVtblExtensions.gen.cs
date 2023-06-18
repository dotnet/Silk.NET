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

public unsafe static class DXVAHDDeviceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXVAHDDevice> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXVAHDDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXVAHDDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoSurface(this ComPtr<IDXVAHDDevice> thisVtbl, uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfaces, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfaces, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorDeviceCaps(this ComPtr<IDXVAHDDevice> thisVtbl, HDVpdevcaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDVpdevcaps*, int>)@this->LpVtbl[4])(@this, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorOutputFormats(this ComPtr<IDXVAHDDevice> thisVtbl, uint Count, Silk.NET.Direct3D9.Format* pFormats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)@this->LpVtbl[5])(@this, Count, pFormats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorInputFormats(this ComPtr<IDXVAHDDevice> thisVtbl, uint Count, Silk.NET.Direct3D9.Format* pFormats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)@this->LpVtbl[6])(@this, Count, pFormats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps(this ComPtr<IDXVAHDDevice> thisVtbl, uint Count, HDVpcaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, HDVpcaps*, int>)@this->LpVtbl[7])(@this, Count, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCustomRates(this ComPtr<IDXVAHDDevice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pVPGuid, uint Count, HDCustomRateData* pRates)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)@this->LpVtbl[8])(@this, pVPGuid, Count, pRates);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorFilterRange(this ComPtr<IDXVAHDDevice> thisVtbl, HDFilter Filter, HDFilterRangeData* pRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDFilter, HDFilterRangeData*, int>)@this->LpVtbl[9])(@this, Filter, pRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<IDXVAHDDevice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pVPGuid, IDXVAHDVideoProcessor** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)@this->LpVtbl[10])(@this, pVPGuid, ppVideoProcessor);
        return ret;
    }

}
