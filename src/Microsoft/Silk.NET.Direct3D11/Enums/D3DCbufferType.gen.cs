// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "_D3D_CBUFFER_TYPE")]
    public enum D3DCbufferType
    {
        [NativeName("Name", "D3D_CT_CBUFFER")]
        D3DCTCbuffer = 0x0,
        [NativeName("Name", "D3D_CT_TBUFFER")]
        D3DCTTbuffer = 0x1,
        [NativeName("Name", "D3D_CT_INTERFACE_POINTERS")]
        D3DCTInterfacePointers = 0x2,
        [NativeName("Name", "D3D_CT_RESOURCE_BIND_INFO")]
        D3DCTResourceBindInfo = 0x3,
        [NativeName("Name", "D3D10_CT_CBUFFER")]
        D3D10CTCbuffer = 0x0,
        [NativeName("Name", "D3D10_CT_TBUFFER")]
        D3D10CTTbuffer = 0x1,
        [NativeName("Name", "D3D11_CT_CBUFFER")]
        CTCbuffer = 0x0,
        [NativeName("Name", "D3D11_CT_TBUFFER")]
        CTTbuffer = 0x1,
        [NativeName("Name", "D3D11_CT_INTERFACE_POINTERS")]
        CTInterfacePointers = 0x2,
        [NativeName("Name", "D3D11_CT_RESOURCE_BIND_INFO")]
        CTResourceBindInfo = 0x3,
    }
}
