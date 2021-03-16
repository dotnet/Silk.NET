// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDECLUSAGE")]
    public enum Declusage : int
    {
        [NativeName("Name", "D3DDECLUSAGE_POSITION")]
        DeclusagePosition = 0x0,
        [NativeName("Name", "D3DDECLUSAGE_BLENDWEIGHT")]
        DeclusageBlendweight = 0x1,
        [NativeName("Name", "D3DDECLUSAGE_BLENDINDICES")]
        DeclusageBlendindices = 0x2,
        [NativeName("Name", "D3DDECLUSAGE_NORMAL")]
        DeclusageNormal = 0x3,
        [NativeName("Name", "D3DDECLUSAGE_PSIZE")]
        DeclusagePsize = 0x4,
        [NativeName("Name", "D3DDECLUSAGE_TEXCOORD")]
        DeclusageTexcoord = 0x5,
        [NativeName("Name", "D3DDECLUSAGE_TANGENT")]
        DeclusageTangent = 0x6,
        [NativeName("Name", "D3DDECLUSAGE_BINORMAL")]
        DeclusageBinormal = 0x7,
        [NativeName("Name", "D3DDECLUSAGE_TESSFACTOR")]
        DeclusageTessfactor = 0x8,
        [NativeName("Name", "D3DDECLUSAGE_POSITIONT")]
        DeclusagePositiont = 0x9,
        [NativeName("Name", "D3DDECLUSAGE_COLOR")]
        DeclusageColor = 0xA,
        [NativeName("Name", "D3DDECLUSAGE_FOG")]
        DeclusageFog = 0xB,
        [NativeName("Name", "D3DDECLUSAGE_DEPTH")]
        DeclusageDepth = 0xC,
        [NativeName("Name", "D3DDECLUSAGE_SAMPLE")]
        DeclusageSample = 0xD,
    }
}
