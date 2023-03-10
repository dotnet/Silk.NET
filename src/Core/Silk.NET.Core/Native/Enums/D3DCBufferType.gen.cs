// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [Flags]
    [NativeName("Name", "_D3D_CBUFFER_TYPE")]
    public enum D3DCBufferType : int
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
        D3D11CTCbuffer = 0x0,
        [NativeName("Name", "D3D11_CT_TBUFFER")]
        D3D11CTTbuffer = 0x1,
        [NativeName("Name", "D3D11_CT_INTERFACE_POINTERS")]
        D3D11CTInterfacePointers = 0x2,
        [NativeName("Name", "D3D11_CT_RESOURCE_BIND_INFO")]
        D3D11CTResourceBindInfo = 0x3,
    }
}
