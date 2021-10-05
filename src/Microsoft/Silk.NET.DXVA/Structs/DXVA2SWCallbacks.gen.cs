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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA2SW_CALLBACKS")]
    public unsafe partial struct DXVA2SWCallbacks
    {
        public DXVA2SWCallbacks
        (
            uint? size = null,
            PfnPdxva2SWGetvideoprocessorrendertargetcount? getVideoProcessorRenderTargetCount = null,
            PfnPdxva2SWGetvideoprocessorrendertargets? getVideoProcessorRenderTargets = null,
            PfnPdxva2SWGetvideoprocessorcaps? getVideoProcessorCaps = null,
            PfnPdxva2SWGetvideoprocessorsubstreamformatcount? getVideoProcessorSubStreamFormatCount = null,
            PfnPdxva2SWGetvideoprocessorsubstreamformats? getVideoProcessorSubStreamFormats = null,
            PfnPdxva2SWGetprocamprange? getProcAmpRange = null,
            PfnPdxva2SWGetprocamprange? getFilterPropertyRange = null,
            PfnPdxva2SWCreatevideoprocessdevice? createVideoProcessDevice = null,
            PfnPDXVAHDSWDestroyDevice? destroyVideoProcessDevice = null,
            PfnPDXVAHDSWDestroyDevice? videoProcessBeginFrame = null,
            PfnPdxva2SWVideoprocessendframe? videoProcessEndFrame = null,
            PfnPdxva2SWVideoprocesssetrendertarget? videoProcessSetRenderTarget = null,
            PfnPdxva2SWVideoprocessblt? videoProcessBlt = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (getVideoProcessorRenderTargetCount is not null)
            {
                GetVideoProcessorRenderTargetCount = getVideoProcessorRenderTargetCount.Value;
            }

            if (getVideoProcessorRenderTargets is not null)
            {
                GetVideoProcessorRenderTargets = getVideoProcessorRenderTargets.Value;
            }

            if (getVideoProcessorCaps is not null)
            {
                GetVideoProcessorCaps = getVideoProcessorCaps.Value;
            }

            if (getVideoProcessorSubStreamFormatCount is not null)
            {
                GetVideoProcessorSubStreamFormatCount = getVideoProcessorSubStreamFormatCount.Value;
            }

            if (getVideoProcessorSubStreamFormats is not null)
            {
                GetVideoProcessorSubStreamFormats = getVideoProcessorSubStreamFormats.Value;
            }

            if (getProcAmpRange is not null)
            {
                GetProcAmpRange = getProcAmpRange.Value;
            }

            if (getFilterPropertyRange is not null)
            {
                GetFilterPropertyRange = getFilterPropertyRange.Value;
            }

            if (createVideoProcessDevice is not null)
            {
                CreateVideoProcessDevice = createVideoProcessDevice.Value;
            }

            if (destroyVideoProcessDevice is not null)
            {
                DestroyVideoProcessDevice = destroyVideoProcessDevice.Value;
            }

            if (videoProcessBeginFrame is not null)
            {
                VideoProcessBeginFrame = videoProcessBeginFrame.Value;
            }

            if (videoProcessEndFrame is not null)
            {
                VideoProcessEndFrame = videoProcessEndFrame.Value;
            }

            if (videoProcessSetRenderTarget is not null)
            {
                VideoProcessSetRenderTarget = videoProcessSetRenderTarget.Value;
            }

            if (videoProcessBlt is not null)
            {
                VideoProcessBlt = videoProcessBlt.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "PDXVA2SW_GETVIDEOPROCESSORRENDERTARGETCOUNT")]
        [NativeName("Type.Name", "PDXVA2SW_GETVIDEOPROCESSORRENDERTARGETCOUNT")]
        [NativeName("Name", "GetVideoProcessorRenderTargetCount")]
        public PfnPdxva2SWGetvideoprocessorrendertargetcount GetVideoProcessorRenderTargetCount;

        [NativeName("Type", "PDXVA2SW_GETVIDEOPROCESSORRENDERTARGETS")]
        [NativeName("Type.Name", "PDXVA2SW_GETVIDEOPROCESSORRENDERTARGETS")]
        [NativeName("Name", "GetVideoProcessorRenderTargets")]
        public PfnPdxva2SWGetvideoprocessorrendertargets GetVideoProcessorRenderTargets;

        [NativeName("Type", "PDXVA2SW_GETVIDEOPROCESSORCAPS")]
        [NativeName("Type.Name", "PDXVA2SW_GETVIDEOPROCESSORCAPS")]
        [NativeName("Name", "GetVideoProcessorCaps")]
        public PfnPdxva2SWGetvideoprocessorcaps GetVideoProcessorCaps;

        [NativeName("Type", "PDXVA2SW_GETVIDEOPROCESSORSUBSTREAMFORMATCOUNT")]
        [NativeName("Type.Name", "PDXVA2SW_GETVIDEOPROCESSORSUBSTREAMFORMATCOUNT")]
        [NativeName("Name", "GetVideoProcessorSubStreamFormatCount")]
        public PfnPdxva2SWGetvideoprocessorsubstreamformatcount GetVideoProcessorSubStreamFormatCount;

        [NativeName("Type", "PDXVA2SW_GETVIDEOPROCESSORSUBSTREAMFORMATS")]
        [NativeName("Type.Name", "PDXVA2SW_GETVIDEOPROCESSORSUBSTREAMFORMATS")]
        [NativeName("Name", "GetVideoProcessorSubStreamFormats")]
        public PfnPdxva2SWGetvideoprocessorsubstreamformats GetVideoProcessorSubStreamFormats;

        [NativeName("Type", "PDXVA2SW_GETPROCAMPRANGE")]
        [NativeName("Type.Name", "PDXVA2SW_GETPROCAMPRANGE")]
        [NativeName("Name", "GetProcAmpRange")]
        public PfnPdxva2SWGetprocamprange GetProcAmpRange;

        [NativeName("Type", "PDXVA2SW_GETFILTERPROPERTYRANGE")]
        [NativeName("Type.Name", "PDXVA2SW_GETFILTERPROPERTYRANGE")]
        [NativeName("Name", "GetFilterPropertyRange")]
        public PfnPdxva2SWGetprocamprange GetFilterPropertyRange;

        [NativeName("Type", "PDXVA2SW_CREATEVIDEOPROCESSDEVICE")]
        [NativeName("Type.Name", "PDXVA2SW_CREATEVIDEOPROCESSDEVICE")]
        [NativeName("Name", "CreateVideoProcessDevice")]
        public PfnPdxva2SWCreatevideoprocessdevice CreateVideoProcessDevice;

        [NativeName("Type", "PDXVA2SW_DESTROYVIDEOPROCESSDEVICE")]
        [NativeName("Type.Name", "PDXVA2SW_DESTROYVIDEOPROCESSDEVICE")]
        [NativeName("Name", "DestroyVideoProcessDevice")]
        public PfnPDXVAHDSWDestroyDevice DestroyVideoProcessDevice;

        [NativeName("Type", "PDXVA2SW_VIDEOPROCESSBEGINFRAME")]
        [NativeName("Type.Name", "PDXVA2SW_VIDEOPROCESSBEGINFRAME")]
        [NativeName("Name", "VideoProcessBeginFrame")]
        public PfnPDXVAHDSWDestroyDevice VideoProcessBeginFrame;

        [NativeName("Type", "PDXVA2SW_VIDEOPROCESSENDFRAME")]
        [NativeName("Type.Name", "PDXVA2SW_VIDEOPROCESSENDFRAME")]
        [NativeName("Name", "VideoProcessEndFrame")]
        public PfnPdxva2SWVideoprocessendframe VideoProcessEndFrame;

        [NativeName("Type", "PDXVA2SW_VIDEOPROCESSSETRENDERTARGET")]
        [NativeName("Type.Name", "PDXVA2SW_VIDEOPROCESSSETRENDERTARGET")]
        [NativeName("Name", "VideoProcessSetRenderTarget")]
        public PfnPdxva2SWVideoprocesssetrendertarget VideoProcessSetRenderTarget;

        [NativeName("Type", "PDXVA2SW_VIDEOPROCESSBLT")]
        [NativeName("Type.Name", "PDXVA2SW_VIDEOPROCESSBLT")]
        [NativeName("Name", "VideoProcessBlt")]
        public PfnPdxva2SWVideoprocessblt VideoProcessBlt;
    }
}
