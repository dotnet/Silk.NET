// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "_D3D_SHADER_INPUT_TYPE")]
    public enum ShaderInputType
    {
        [NativeName("Name", "D3D_SIT_CBUFFER")]
        SitCbuffer = 0x0,
        [NativeName("Name", "D3D_SIT_TBUFFER")]
        SitTbuffer = 0x1,
        [NativeName("Name", "D3D_SIT_TEXTURE")]
        SitTexture = 0x2,
        [NativeName("Name", "D3D_SIT_SAMPLER")]
        SitSampler = 0x3,
        [NativeName("Name", "D3D_SIT_UAV_RWTYPED")]
        SitUavRwtyped = 0x4,
        [NativeName("Name", "D3D_SIT_STRUCTURED")]
        SitStructured = 0x5,
        [NativeName("Name", "D3D_SIT_UAV_RWSTRUCTURED")]
        SitUavRwstructured = 0x6,
        [NativeName("Name", "D3D_SIT_BYTEADDRESS")]
        SitByteaddress = 0x7,
        [NativeName("Name", "D3D_SIT_UAV_RWBYTEADDRESS")]
        SitUavRwbyteaddress = 0x8,
        [NativeName("Name", "D3D_SIT_UAV_APPEND_STRUCTURED")]
        SitUavAppendStructured = 0x9,
        [NativeName("Name", "D3D_SIT_UAV_CONSUME_STRUCTURED")]
        SitUavConsumeStructured = 0xA,
        [NativeName("Name", "D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER")]
        SitUavRwstructuredWithCounter = 0xB,
        [NativeName("Name", "D3D_SIT_RTACCELERATIONSTRUCTURE")]
        SitRtaccelerationstructure = 0xC,
        [NativeName("Name", "D3D_SIT_UAV_FEEDBACKTEXTURE")]
        SitUavFeedbacktexture = 0xD,
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
