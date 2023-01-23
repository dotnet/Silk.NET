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
    [NativeName("Name", "_DXVAHDSW_CALLBACKS")]
    public unsafe partial struct HdswCallbacks
    {
        public HdswCallbacks
        (
            PfnPDXVAHDSWCreateDevice? createDevice = null,
            PfnPDXVAHDSWProposeVideoPrivateFormat? proposeVideoPrivateFormat = null,
            PfnPDXVAHDSWGetVideoProcessorDeviceCaps? getVideoProcessorDeviceCaps = null,
            PfnPDXVAHDSWGetVideoProcessorOutputFormats? getVideoProcessorOutputFormats = null,
            PfnPDXVAHDSWGetVideoProcessorOutputFormats? getVideoProcessorInputFormats = null,
            PfnPDXVAHDSWGetVideoProcessorCaps? getVideoProcessorCaps = null,
            PfnPDXVAHDSWGetVideoProcessorCustomRates? getVideoProcessorCustomRates = null,
            PfnPDXVAHDSWGetVideoProcessorFilterRange? getVideoProcessorFilterRange = null,
            PfnPDXVAHDSWDestroyDevice? destroyDevice = null,
            PfnPDXVAHDSWCreateVideoProcessor? createVideoProcessor = null,
            PfnPDXVAHDSWSetVideoProcessBltState? setVideoProcessBltState = null,
            PfnPDXVAHDSWGetVideoProcessBltStatePrivate? getVideoProcessBltStatePrivate = null,
            PfnPDXVAHDSWSetVideoProcessStreamState? setVideoProcessStreamState = null,
            PfnPDXVAHDSWGetVideoProcessStreamStatePrivate? getVideoProcessStreamStatePrivate = null,
            PfnPDXVAHDSWVideoProcessBltHD? videoProcessBltHD = null,
            PfnPDXVAHDSWDestroyDevice? destroyVideoProcessor = null
        ) : this()
        {
            if (createDevice is not null)
            {
                CreateDevice = createDevice.Value;
            }

            if (proposeVideoPrivateFormat is not null)
            {
                ProposeVideoPrivateFormat = proposeVideoPrivateFormat.Value;
            }

            if (getVideoProcessorDeviceCaps is not null)
            {
                GetVideoProcessorDeviceCaps = getVideoProcessorDeviceCaps.Value;
            }

            if (getVideoProcessorOutputFormats is not null)
            {
                GetVideoProcessorOutputFormats = getVideoProcessorOutputFormats.Value;
            }

            if (getVideoProcessorInputFormats is not null)
            {
                GetVideoProcessorInputFormats = getVideoProcessorInputFormats.Value;
            }

            if (getVideoProcessorCaps is not null)
            {
                GetVideoProcessorCaps = getVideoProcessorCaps.Value;
            }

            if (getVideoProcessorCustomRates is not null)
            {
                GetVideoProcessorCustomRates = getVideoProcessorCustomRates.Value;
            }

            if (getVideoProcessorFilterRange is not null)
            {
                GetVideoProcessorFilterRange = getVideoProcessorFilterRange.Value;
            }

            if (destroyDevice is not null)
            {
                DestroyDevice = destroyDevice.Value;
            }

            if (createVideoProcessor is not null)
            {
                CreateVideoProcessor = createVideoProcessor.Value;
            }

            if (setVideoProcessBltState is not null)
            {
                SetVideoProcessBltState = setVideoProcessBltState.Value;
            }

            if (getVideoProcessBltStatePrivate is not null)
            {
                GetVideoProcessBltStatePrivate = getVideoProcessBltStatePrivate.Value;
            }

            if (setVideoProcessStreamState is not null)
            {
                SetVideoProcessStreamState = setVideoProcessStreamState.Value;
            }

            if (getVideoProcessStreamStatePrivate is not null)
            {
                GetVideoProcessStreamStatePrivate = getVideoProcessStreamStatePrivate.Value;
            }

            if (videoProcessBltHD is not null)
            {
                VideoProcessBltHD = videoProcessBltHD.Value;
            }

            if (destroyVideoProcessor is not null)
            {
                DestroyVideoProcessor = destroyVideoProcessor.Value;
            }
        }


        [NativeName("Type", "PDXVAHDSW_CreateDevice")]
        [NativeName("Type.Name", "PDXVAHDSW_CreateDevice")]
        [NativeName("Name", "CreateDevice")]
        public PfnPDXVAHDSWCreateDevice CreateDevice;

        [NativeName("Type", "PDXVAHDSW_ProposeVideoPrivateFormat")]
        [NativeName("Type.Name", "PDXVAHDSW_ProposeVideoPrivateFormat")]
        [NativeName("Name", "ProposeVideoPrivateFormat")]
        public PfnPDXVAHDSWProposeVideoPrivateFormat ProposeVideoPrivateFormat;

        [NativeName("Type", "PDXVAHDSW_GetVideoProcessorDeviceCaps")]
        [NativeName("Type.Name", "PDXVAHDSW_GetVideoProcessorDeviceCaps")]
        [NativeName("Name", "GetVideoProcessorDeviceCaps")]
        public PfnPDXVAHDSWGetVideoProcessorDeviceCaps GetVideoProcessorDeviceCaps;

        [NativeName("Type", "PDXVAHDSW_GetVideoProcessorOutputFormats")]
        [NativeName("Type.Name", "PDXVAHDSW_GetVideoProcessorOutputFormats")]
        [NativeName("Name", "GetVideoProcessorOutputFormats")]
        public PfnPDXVAHDSWGetVideoProcessorOutputFormats GetVideoProcessorOutputFormats;

        [NativeName("Type", "PDXVAHDSW_GetVideoProcessorInputFormats")]
        [NativeName("Type.Name", "PDXVAHDSW_GetVideoProcessorInputFormats")]
        [NativeName("Name", "GetVideoProcessorInputFormats")]
        public PfnPDXVAHDSWGetVideoProcessorOutputFormats GetVideoProcessorInputFormats;

        [NativeName("Type", "PDXVAHDSW_GetVideoProcessorCaps")]
        [NativeName("Type.Name", "PDXVAHDSW_GetVideoProcessorCaps")]
        [NativeName("Name", "GetVideoProcessorCaps")]
        public PfnPDXVAHDSWGetVideoProcessorCaps GetVideoProcessorCaps;

        [NativeName("Type", "PDXVAHDSW_GetVideoProcessorCustomRates")]
        [NativeName("Type.Name", "PDXVAHDSW_GetVideoProcessorCustomRates")]
        [NativeName("Name", "GetVideoProcessorCustomRates")]
        public PfnPDXVAHDSWGetVideoProcessorCustomRates GetVideoProcessorCustomRates;

        [NativeName("Type", "PDXVAHDSW_GetVideoProcessorFilterRange")]
        [NativeName("Type.Name", "PDXVAHDSW_GetVideoProcessorFilterRange")]
        [NativeName("Name", "GetVideoProcessorFilterRange")]
        public PfnPDXVAHDSWGetVideoProcessorFilterRange GetVideoProcessorFilterRange;

        [NativeName("Type", "PDXVAHDSW_DestroyDevice")]
        [NativeName("Type.Name", "PDXVAHDSW_DestroyDevice")]
        [NativeName("Name", "DestroyDevice")]
        public PfnPDXVAHDSWDestroyDevice DestroyDevice;

        [NativeName("Type", "PDXVAHDSW_CreateVideoProcessor")]
        [NativeName("Type.Name", "PDXVAHDSW_CreateVideoProcessor")]
        [NativeName("Name", "CreateVideoProcessor")]
        public PfnPDXVAHDSWCreateVideoProcessor CreateVideoProcessor;

        [NativeName("Type", "PDXVAHDSW_SetVideoProcessBltState")]
        [NativeName("Type.Name", "PDXVAHDSW_SetVideoProcessBltState")]
        [NativeName("Name", "SetVideoProcessBltState")]
        public PfnPDXVAHDSWSetVideoProcessBltState SetVideoProcessBltState;

        [NativeName("Type", "PDXVAHDSW_GetVideoProcessBltStatePrivate")]
        [NativeName("Type.Name", "PDXVAHDSW_GetVideoProcessBltStatePrivate")]
        [NativeName("Name", "GetVideoProcessBltStatePrivate")]
        public PfnPDXVAHDSWGetVideoProcessBltStatePrivate GetVideoProcessBltStatePrivate;

        [NativeName("Type", "PDXVAHDSW_SetVideoProcessStreamState")]
        [NativeName("Type.Name", "PDXVAHDSW_SetVideoProcessStreamState")]
        [NativeName("Name", "SetVideoProcessStreamState")]
        public PfnPDXVAHDSWSetVideoProcessStreamState SetVideoProcessStreamState;

        [NativeName("Type", "PDXVAHDSW_GetVideoProcessStreamStatePrivate")]
        [NativeName("Type.Name", "PDXVAHDSW_GetVideoProcessStreamStatePrivate")]
        [NativeName("Name", "GetVideoProcessStreamStatePrivate")]
        public PfnPDXVAHDSWGetVideoProcessStreamStatePrivate GetVideoProcessStreamStatePrivate;

        [NativeName("Type", "PDXVAHDSW_VideoProcessBltHD")]
        [NativeName("Type.Name", "PDXVAHDSW_VideoProcessBltHD")]
        [NativeName("Name", "VideoProcessBltHD")]
        public PfnPDXVAHDSWVideoProcessBltHD VideoProcessBltHD;

        [NativeName("Type", "PDXVAHDSW_DestroyVideoProcessor")]
        [NativeName("Type.Name", "PDXVAHDSW_DestroyVideoProcessor")]
        [NativeName("Name", "DestroyVideoProcessor")]
        public PfnPDXVAHDSWDestroyDevice DestroyVideoProcessor;
    }
}
