// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0000_0013")]
    public enum MIDLMIDLItfDxva2api000000000013 : int
    {
        [NativeName("Name", "DXVA2_VideoDecoderRenderTarget")]
        DXVA2VideoDecoderRenderTarget = 0x0,
        [NativeName("Name", "DXVA2_VideoProcessorRenderTarget")]
        DXVA2VideoProcessorRenderTarget = 0x1,
        [NativeName("Name", "DXVA2_VideoSoftwareRenderTarget")]
        DXVA2VideoSoftwareRenderTarget = 0x2,
    }
}
