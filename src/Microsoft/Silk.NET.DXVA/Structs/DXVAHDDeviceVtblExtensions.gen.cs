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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfaces, void** pSharedHandle) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfaces, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfaces, ref void* pSharedHandle) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfaces, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurfaces, void** pSharedHandle) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacesPtr = &ppSurfaces)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfacesPtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurfaces, ref void* pSharedHandle) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacesPtr = &ppSurfaces)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfacesPtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorDeviceCaps<TThis>(this TThis thisVtbl, HDVpdevcaps* pCaps) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDVpdevcaps*, int>)@this->LpVtbl[4])(@this, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorDeviceCaps<TThis>(this TThis thisVtbl, ref HDVpdevcaps pCaps) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HDVpdevcaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDVpdevcaps*, int>)@this->LpVtbl[4])(@this, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorOutputFormats<TThis>(this TThis thisVtbl, uint Count, Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)@this->LpVtbl[5])(@this, Count, pFormats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorOutputFormats<TThis>(this TThis thisVtbl, uint Count, ref Silk.NET.Direct3D9.Format pFormats) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.Format* pFormatsPtr = &pFormats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)@this->LpVtbl[5])(@this, Count, pFormatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorInputFormats<TThis>(this TThis thisVtbl, uint Count, Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)@this->LpVtbl[6])(@this, Count, pFormats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorInputFormats<TThis>(this TThis thisVtbl, uint Count, ref Silk.NET.Direct3D9.Format pFormats) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.Format* pFormatsPtr = &pFormats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)@this->LpVtbl[6])(@this, Count, pFormatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, uint Count, HDVpcaps* pCaps) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, HDVpcaps*, int>)@this->LpVtbl[7])(@this, Count, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, uint Count, ref HDVpcaps pCaps) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HDVpcaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, HDVpcaps*, int>)@this->LpVtbl[7])(@this, Count, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCustomRates<TThis>(this TThis thisVtbl, Guid* pVPGuid, uint Count, HDCustomRateData* pRates) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)@this->LpVtbl[8])(@this, pVPGuid, Count, pRates);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCustomRates<TThis>(this TThis thisVtbl, Guid* pVPGuid, uint Count, ref HDCustomRateData pRates) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HDCustomRateData* pRatesPtr = &pRates)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)@this->LpVtbl[8])(@this, pVPGuid, Count, pRatesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCustomRates<TThis>(this TThis thisVtbl, ref Guid pVPGuid, uint Count, HDCustomRateData* pRates) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pVPGuidPtr = &pVPGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)@this->LpVtbl[8])(@this, pVPGuidPtr, Count, pRates);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorCustomRates<TThis>(this TThis thisVtbl, ref Guid pVPGuid, uint Count, ref HDCustomRateData pRates) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pVPGuidPtr = &pVPGuid)
        {
            fixed (HDCustomRateData* pRatesPtr = &pRates)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)@this->LpVtbl[8])(@this, pVPGuidPtr, Count, pRatesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorFilterRange<TThis>(this TThis thisVtbl, HDFilter Filter, HDFilterRangeData* pRange) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDFilter, HDFilterRangeData*, int>)@this->LpVtbl[9])(@this, Filter, pRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorFilterRange<TThis>(this TThis thisVtbl, HDFilter Filter, ref HDFilterRangeData pRange) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HDFilterRangeData* pRangePtr = &pRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDFilter, HDFilterRangeData*, int>)@this->LpVtbl[9])(@this, Filter, pRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, Guid* pVPGuid, IDXVAHDVideoProcessor** ppVideoProcessor) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)@this->LpVtbl[10])(@this, pVPGuid, ppVideoProcessor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, Guid* pVPGuid, ref IDXVAHDVideoProcessor* ppVideoProcessor) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXVAHDVideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)@this->LpVtbl[10])(@this, pVPGuid, ppVideoProcessorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, ref Guid pVPGuid, IDXVAHDVideoProcessor** ppVideoProcessor) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pVPGuidPtr = &pVPGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)@this->LpVtbl[10])(@this, pVPGuidPtr, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, ref Guid pVPGuid, ref IDXVAHDVideoProcessor* ppVideoProcessor) where TThis : IComVtbl<IDXVAHDDevice>
    {
        var @this = (IDXVAHDDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pVPGuidPtr = &pVPGuid)
        {
            fixed (IDXVAHDVideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)@this->LpVtbl[10])(@this, pVPGuidPtr, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

}
