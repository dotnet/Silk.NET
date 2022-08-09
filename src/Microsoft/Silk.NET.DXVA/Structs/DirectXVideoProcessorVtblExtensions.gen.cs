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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorService<TThis>(this TThis thisVtbl, IDirectXVideoProcessorService** ppService) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, IDirectXVideoProcessorService**, int>)@this->LpVtbl[3])(@this, ppService);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorService<TThis>(this TThis thisVtbl, ref IDirectXVideoProcessorService* ppService) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirectXVideoProcessorService** ppServicePtr = &ppService)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, IDirectXVideoProcessorService**, int>)@this->LpVtbl[3])(@this, ppServicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pRenderTargetFormat, pMaxNumSubStreams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, ref uint pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pRenderTargetFormat, pMaxNumSubStreamsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pRenderTargetFormatPtr, pMaxNumSubStreams);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, ref uint pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
        {
            fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pRenderTargetFormatPtr, pMaxNumSubStreamsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pRenderTargetFormat, pMaxNumSubStreams);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, ref uint pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pRenderTargetFormat, pMaxNumSubStreamsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pRenderTargetFormatPtr, pMaxNumSubStreams);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, ref uint pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
            {
                fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pRenderTargetFormatPtr, pMaxNumSubStreamsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pRenderTargetFormat, pMaxNumSubStreams);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, ref uint pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pRenderTargetFormat, pMaxNumSubStreamsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pRenderTargetFormatPtr, pMaxNumSubStreams);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, ref uint pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
            {
                fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pRenderTargetFormatPtr, pMaxNumSubStreamsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pRenderTargetFormat, pMaxNumSubStreams);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, ref uint pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pRenderTargetFormat, pMaxNumSubStreamsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pRenderTargetFormatPtr, pMaxNumSubStreams);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref Silk.NET.Direct3D9.Format pRenderTargetFormat, ref uint pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.Format* pRenderTargetFormatPtr = &pRenderTargetFormat)
                {
                    fixed (uint* pMaxNumSubStreamsPtr = &pMaxNumSubStreams)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format*, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pRenderTargetFormatPtr, pMaxNumSubStreamsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, DXVA2VideoProcessorCaps* pCaps) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[5])(@this, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, ref DXVA2VideoProcessorCaps pCaps) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoProcessorCaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[5])(@this, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProcAmpRange<TThis>(this TThis thisVtbl, uint ProcAmpCap, DXVA2ValueRange* pRange) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, uint, DXVA2ValueRange*, int>)@this->LpVtbl[6])(@this, ProcAmpCap, pRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetProcAmpRange<TThis>(this TThis thisVtbl, uint ProcAmpCap, ref DXVA2ValueRange pRange) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ValueRange* pRangePtr = &pRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, uint, DXVA2ValueRange*, int>)@this->LpVtbl[6])(@this, ProcAmpCap, pRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilterPropertyRange<TThis>(this TThis thisVtbl, uint FilterSetting, DXVA2ValueRange* pRange) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, uint, DXVA2ValueRange*, int>)@this->LpVtbl[7])(@this, FilterSetting, pRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFilterPropertyRange<TThis>(this TThis thisVtbl, uint FilterSetting, ref DXVA2ValueRange pRange) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ValueRange* pRangePtr = &pRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, uint, DXVA2ValueRange*, int>)@this->LpVtbl[7])(@this, FilterSetting, pRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTarget, pBltParams, pSamples, NumSamples, pHandleComplete);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pHandleCompletePtr = &pHandleComplete)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTarget, pBltParams, pSamples, NumSamples, pHandleCompletePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTarget, pBltParams, pSamplesPtr, NumSamples, pHandleComplete);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
        {
            fixed (void** pHandleCompletePtr = &pHandleComplete)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTarget, pBltParams, pSamplesPtr, NumSamples, pHandleCompletePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTarget, pBltParamsPtr, pSamples, NumSamples, pHandleComplete);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
        {
            fixed (void** pHandleCompletePtr = &pHandleComplete)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTarget, pBltParamsPtr, pSamples, NumSamples, pHandleCompletePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
        {
            fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTarget, pBltParamsPtr, pSamplesPtr, NumSamples, pHandleComplete);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
        {
            fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
            {
                fixed (void** pHandleCompletePtr = &pHandleComplete)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTarget, pBltParamsPtr, pSamplesPtr, NumSamples, pHandleCompletePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTargetPtr, pBltParams, pSamples, NumSamples, pHandleComplete);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            fixed (void** pHandleCompletePtr = &pHandleComplete)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTargetPtr, pBltParams, pSamples, NumSamples, pHandleCompletePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTargetPtr, pBltParams, pSamplesPtr, NumSamples, pHandleComplete);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
            {
                fixed (void** pHandleCompletePtr = &pHandleComplete)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTargetPtr, pBltParams, pSamplesPtr, NumSamples, pHandleCompletePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTargetPtr, pBltParamsPtr, pSamples, NumSamples, pHandleComplete);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
            {
                fixed (void** pHandleCompletePtr = &pHandleComplete)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTargetPtr, pBltParamsPtr, pSamples, NumSamples, pHandleCompletePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
            {
                fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTargetPtr, pBltParamsPtr, pSamplesPtr, NumSamples, pHandleComplete);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, ref DXVA2VideoProcessBltParams pBltParams, ref DXVA2VideoSample pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            fixed (DXVA2VideoProcessBltParams* pBltParamsPtr = &pBltParams)
            {
                fixed (DXVA2VideoSample* pSamplesPtr = &pSamples)
                {
                    fixed (void** pHandleCompletePtr = &pHandleComplete)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, DXVA2VideoProcessBltParams*, DXVA2VideoSample*, uint, void**, int>)@this->LpVtbl[8])(@this, pRenderTargetPtr, pBltParamsPtr, pSamplesPtr, NumSamples, pHandleCompletePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorService<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppService) where TI0 : unmanaged, IComVtbl<IDirectXVideoProcessorService>, IComVtbl<TI0> where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetVideoProcessorService((IDirectXVideoProcessorService**) ppService.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, Span<uint> pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, pVideoDesc, pRenderTargetFormat, ref pMaxNumSubStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Span<Silk.NET.Direct3D9.Format> pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, pVideoDesc, ref pRenderTargetFormat.GetPinnableReference(), pMaxNumSubStreams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Span<Silk.NET.Direct3D9.Format> pRenderTargetFormat, Span<uint> pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, pVideoDesc, ref pRenderTargetFormat.GetPinnableReference(), ref pMaxNumSubStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, ref pVideoDesc.GetPinnableReference(), pRenderTargetFormat, pMaxNumSubStreams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, Span<uint> pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, ref pVideoDesc.GetPinnableReference(), pRenderTargetFormat, ref pMaxNumSubStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Span<Silk.NET.Direct3D9.Format> pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, ref pVideoDesc.GetPinnableReference(), ref pRenderTargetFormat.GetPinnableReference(), pMaxNumSubStreams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Span<Silk.NET.Direct3D9.Format> pRenderTargetFormat, Span<uint> pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, ref pVideoDesc.GetPinnableReference(), ref pRenderTargetFormat.GetPinnableReference(), ref pMaxNumSubStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), pVideoDesc, pRenderTargetFormat, pMaxNumSubStreams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, Span<uint> pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), pVideoDesc, pRenderTargetFormat, ref pMaxNumSubStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Span<Silk.NET.Direct3D9.Format> pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), pVideoDesc, ref pRenderTargetFormat.GetPinnableReference(), pMaxNumSubStreams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Span<Silk.NET.Direct3D9.Format> pRenderTargetFormat, Span<uint> pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), pVideoDesc, ref pRenderTargetFormat.GetPinnableReference(), ref pMaxNumSubStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pRenderTargetFormat, pMaxNumSubStreams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Silk.NET.Direct3D9.Format* pRenderTargetFormat, Span<uint> pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pRenderTargetFormat, ref pMaxNumSubStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Span<Silk.NET.Direct3D9.Format> pRenderTargetFormat, uint* pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pRenderTargetFormat.GetPinnableReference(), pMaxNumSubStreams);
    }

    /// <summary>To be documented.</summary>
    public static int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Span<Silk.NET.Direct3D9.Format> pRenderTargetFormat, Span<uint> pMaxNumSubStreams) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pRenderTargetFormat.GetPinnableReference(), ref pMaxNumSubStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, Span<DXVA2VideoProcessorCaps> pCaps) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoProcessorCaps(ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetProcAmpRange<TThis>(this TThis thisVtbl, uint ProcAmpCap, Span<DXVA2ValueRange> pRange) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetProcAmpRange(ProcAmpCap, ref pRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFilterPropertyRange<TThis>(this TThis thisVtbl, uint FilterSetting, Span<DXVA2ValueRange> pRange) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFilterPropertyRange(FilterSetting, ref pRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, Span<DXVA2VideoSample> pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(pRenderTarget, pBltParams, ref pSamples.GetPinnableReference(), NumSamples, pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, Span<DXVA2VideoSample> pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(pRenderTarget, pBltParams, ref pSamples.GetPinnableReference(), NumSamples, ref pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, Span<DXVA2VideoProcessBltParams> pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(pRenderTarget, ref pBltParams.GetPinnableReference(), pSamples, NumSamples, pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, Span<DXVA2VideoProcessBltParams> pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(pRenderTarget, ref pBltParams.GetPinnableReference(), pSamples, NumSamples, ref pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, Span<DXVA2VideoProcessBltParams> pBltParams, Span<DXVA2VideoSample> pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(pRenderTarget, ref pBltParams.GetPinnableReference(), ref pSamples.GetPinnableReference(), NumSamples, pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, Span<DXVA2VideoProcessBltParams> pBltParams, Span<DXVA2VideoSample> pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(pRenderTarget, ref pBltParams.GetPinnableReference(), ref pSamples.GetPinnableReference(), NumSamples, ref pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(ref pRenderTarget.GetPinnableReference(), pBltParams, pSamples, NumSamples, pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(ref pRenderTarget.GetPinnableReference(), pBltParams, pSamples, NumSamples, ref pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, Span<DXVA2VideoSample> pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(ref pRenderTarget.GetPinnableReference(), pBltParams, ref pSamples.GetPinnableReference(), NumSamples, pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pRenderTarget, DXVA2VideoProcessBltParams* pBltParams, Span<DXVA2VideoSample> pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(ref pRenderTarget.GetPinnableReference(), pBltParams, ref pSamples.GetPinnableReference(), NumSamples, ref pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pRenderTarget, Span<DXVA2VideoProcessBltParams> pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(ref pRenderTarget.GetPinnableReference(), ref pBltParams.GetPinnableReference(), pSamples, NumSamples, pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pRenderTarget, Span<DXVA2VideoProcessBltParams> pBltParams, DXVA2VideoSample* pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(ref pRenderTarget.GetPinnableReference(), ref pBltParams.GetPinnableReference(), pSamples, NumSamples, ref pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pRenderTarget, Span<DXVA2VideoProcessBltParams> pBltParams, Span<DXVA2VideoSample> pSamples, uint NumSamples, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(ref pRenderTarget.GetPinnableReference(), ref pBltParams.GetPinnableReference(), ref pSamples.GetPinnableReference(), NumSamples, pHandleComplete);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBlt<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pRenderTarget, Span<DXVA2VideoProcessBltParams> pBltParams, Span<DXVA2VideoSample> pSamples, uint NumSamples, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoProcessor>
    {
        var @this = (IDirectXVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBlt(ref pRenderTarget.GetPinnableReference(), ref pBltParams.GetPinnableReference(), ref pSamples.GetPinnableReference(), NumSamples, ref pHandleComplete);
    }

}
