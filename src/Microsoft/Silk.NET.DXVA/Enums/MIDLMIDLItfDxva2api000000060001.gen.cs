// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0006_0001")]
    public enum MIDLMIDLItfDxva2api000000060001 : int
    {
        [NativeName("Name", "DXVA2_SurfaceType_DecoderRenderTarget")]
        DXVA2SurfaceTypeDecoderRenderTarget = 0x0,
        [NativeName("Name", "DXVA2_SurfaceType_ProcessorRenderTarget")]
        DXVA2SurfaceTypeProcessorRenderTarget = 0x1,
        [NativeName("Name", "DXVA2_SurfaceType_D3DRenderTargetTexture")]
        DXVA2SurfaceTypeD3DRenderTargetTexture = 0x2,
    }
}
