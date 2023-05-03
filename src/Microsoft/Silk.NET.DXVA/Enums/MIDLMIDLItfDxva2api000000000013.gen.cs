// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0000_0013")]
    public enum MIDLMIDLItfDxva2api000000000013 : int
    {
        [Obsolete("Deprecated in favour of \"DecoderRenderTarget\"")]
        [NativeName("Name", "DXVA2_VideoDecoderRenderTarget")]
        DXVA2VideoDecoderRenderTarget = 0x0,
        [Obsolete("Deprecated in favour of \"ProcessorRenderTarget\"")]
        [NativeName("Name", "DXVA2_VideoProcessorRenderTarget")]
        DXVA2VideoProcessorRenderTarget = 0x1,
        [Obsolete("Deprecated in favour of \"SoftwareRenderTarget\"")]
        [NativeName("Name", "DXVA2_VideoSoftwareRenderTarget")]
        DXVA2VideoSoftwareRenderTarget = 0x2,
        [NativeName("Name", "DXVA2_VideoDecoderRenderTarget")]
        DecoderRenderTarget = 0x0,
        [NativeName("Name", "DXVA2_VideoProcessorRenderTarget")]
        ProcessorRenderTarget = 0x1,
        [NativeName("Name", "DXVA2_VideoSoftwareRenderTarget")]
        SoftwareRenderTarget = 0x2,
        [Obsolete("Deprecated in favour of \"DecoderRenderTarget\"")]
        [NativeName("Name", "DXVA2_VideoDecoderRenderTarget")]
        VideoDecoderRenderTarget = 0x0,
        [Obsolete("Deprecated in favour of \"ProcessorRenderTarget\"")]
        [NativeName("Name", "DXVA2_VideoProcessorRenderTarget")]
        VideoProcessorRenderTarget = 0x1,
        [Obsolete("Deprecated in favour of \"SoftwareRenderTarget\"")]
        [NativeName("Name", "DXVA2_VideoSoftwareRenderTarget")]
        VideoSoftwareRenderTarget = 0x2,
    }
}
