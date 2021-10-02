// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "_D3D_SHADER_INPUT_TYPE")]
    public enum D3DShaderInputType : int
    {
        [NativeName("Name", "D3D_SIT_CBUFFER")]
        D3DSitCbuffer = 0x0,
        [NativeName("Name", "D3D_SIT_TBUFFER")]
        D3DSitTbuffer = 0x1,
        [NativeName("Name", "D3D_SIT_TEXTURE")]
        D3DSitTexture = 0x2,
        [NativeName("Name", "D3D_SIT_SAMPLER")]
        D3DSitSampler = 0x3,
        [NativeName("Name", "D3D_SIT_UAV_RWTYPED")]
        D3DSitUavRwtyped = 0x4,
        [NativeName("Name", "D3D_SIT_STRUCTURED")]
        D3DSitStructured = 0x5,
        [NativeName("Name", "D3D_SIT_UAV_RWSTRUCTURED")]
        D3DSitUavRwstructured = 0x6,
        [NativeName("Name", "D3D_SIT_BYTEADDRESS")]
        D3DSitByteaddress = 0x7,
        [NativeName("Name", "D3D_SIT_UAV_RWBYTEADDRESS")]
        D3DSitUavRwbyteaddress = 0x8,
        [NativeName("Name", "D3D_SIT_UAV_APPEND_STRUCTURED")]
        D3DSitUavAppendStructured = 0x9,
        [NativeName("Name", "D3D_SIT_UAV_CONSUME_STRUCTURED")]
        D3DSitUavConsumeStructured = 0xA,
        [NativeName("Name", "D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER")]
        D3DSitUavRwstructuredWithCounter = 0xB,
        [NativeName("Name", "D3D_SIT_RTACCELERATIONSTRUCTURE")]
        D3DSitRtaccelerationstructure = 0xC,
        [NativeName("Name", "D3D_SIT_UAV_FEEDBACKTEXTURE")]
        D3DSitUavFeedbacktexture = 0xD,
        [NativeName("Name", "D3D10_SIT_CBUFFER")]
        D3D10SitCbuffer = 0x0,
        [NativeName("Name", "D3D10_SIT_TBUFFER")]
        D3D10SitTbuffer = 0x1,
        [NativeName("Name", "D3D10_SIT_TEXTURE")]
        D3D10SitTexture = 0x2,
        [NativeName("Name", "D3D10_SIT_SAMPLER")]
        D3D10SitSampler = 0x3,
        [NativeName("Name", "D3D11_SIT_UAV_RWTYPED")]
        D3D11SitUavRwtyped = 0x4,
        [NativeName("Name", "D3D11_SIT_STRUCTURED")]
        D3D11SitStructured = 0x5,
        [NativeName("Name", "D3D11_SIT_UAV_RWSTRUCTURED")]
        D3D11SitUavRwstructured = 0x6,
        [NativeName("Name", "D3D11_SIT_BYTEADDRESS")]
        D3D11SitByteaddress = 0x7,
        [NativeName("Name", "D3D11_SIT_UAV_RWBYTEADDRESS")]
        D3D11SitUavRwbyteaddress = 0x8,
        [NativeName("Name", "D3D11_SIT_UAV_APPEND_STRUCTURED")]
        D3D11SitUavAppendStructured = 0x9,
        [NativeName("Name", "D3D11_SIT_UAV_CONSUME_STRUCTURED")]
        D3D11SitUavConsumeStructured = 0xA,
        [NativeName("Name", "D3D11_SIT_UAV_RWSTRUCTURED_WITH_COUNTER")]
        D3D11SitUavRwstructuredWithCounter = 0xB,
    }
}
