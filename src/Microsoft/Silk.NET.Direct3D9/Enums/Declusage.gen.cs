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
        [Obsolete("Deprecated in favour of \"Position\"")]
        [NativeName("Name", "D3DDECLUSAGE_POSITION")]
        DeclusagePosition = 0x0,
        [Obsolete("Deprecated in favour of \"Blendweight\"")]
        [NativeName("Name", "D3DDECLUSAGE_BLENDWEIGHT")]
        DeclusageBlendweight = 0x1,
        [Obsolete("Deprecated in favour of \"Blendindices\"")]
        [NativeName("Name", "D3DDECLUSAGE_BLENDINDICES")]
        DeclusageBlendindices = 0x2,
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "D3DDECLUSAGE_NORMAL")]
        DeclusageNormal = 0x3,
        [Obsolete("Deprecated in favour of \"Psize\"")]
        [NativeName("Name", "D3DDECLUSAGE_PSIZE")]
        DeclusagePsize = 0x4,
        [Obsolete("Deprecated in favour of \"Texcoord\"")]
        [NativeName("Name", "D3DDECLUSAGE_TEXCOORD")]
        DeclusageTexcoord = 0x5,
        [Obsolete("Deprecated in favour of \"Tangent\"")]
        [NativeName("Name", "D3DDECLUSAGE_TANGENT")]
        DeclusageTangent = 0x6,
        [Obsolete("Deprecated in favour of \"Binormal\"")]
        [NativeName("Name", "D3DDECLUSAGE_BINORMAL")]
        DeclusageBinormal = 0x7,
        [Obsolete("Deprecated in favour of \"Tessfactor\"")]
        [NativeName("Name", "D3DDECLUSAGE_TESSFACTOR")]
        DeclusageTessfactor = 0x8,
        [Obsolete("Deprecated in favour of \"Positiont\"")]
        [NativeName("Name", "D3DDECLUSAGE_POSITIONT")]
        DeclusagePositiont = 0x9,
        [Obsolete("Deprecated in favour of \"Color\"")]
        [NativeName("Name", "D3DDECLUSAGE_COLOR")]
        DeclusageColor = 0xA,
        [Obsolete("Deprecated in favour of \"Fog\"")]
        [NativeName("Name", "D3DDECLUSAGE_FOG")]
        DeclusageFog = 0xB,
        [Obsolete("Deprecated in favour of \"Depth\"")]
        [NativeName("Name", "D3DDECLUSAGE_DEPTH")]
        DeclusageDepth = 0xC,
        [Obsolete("Deprecated in favour of \"Sample\"")]
        [NativeName("Name", "D3DDECLUSAGE_SAMPLE")]
        DeclusageSample = 0xD,
        [NativeName("Name", "D3DDECLUSAGE_POSITION")]
        Position = 0x0,
        [NativeName("Name", "D3DDECLUSAGE_BLENDWEIGHT")]
        Blendweight = 0x1,
        [NativeName("Name", "D3DDECLUSAGE_BLENDINDICES")]
        Blendindices = 0x2,
        [NativeName("Name", "D3DDECLUSAGE_NORMAL")]
        Normal = 0x3,
        [NativeName("Name", "D3DDECLUSAGE_PSIZE")]
        Psize = 0x4,
        [NativeName("Name", "D3DDECLUSAGE_TEXCOORD")]
        Texcoord = 0x5,
        [NativeName("Name", "D3DDECLUSAGE_TANGENT")]
        Tangent = 0x6,
        [NativeName("Name", "D3DDECLUSAGE_BINORMAL")]
        Binormal = 0x7,
        [NativeName("Name", "D3DDECLUSAGE_TESSFACTOR")]
        Tessfactor = 0x8,
        [NativeName("Name", "D3DDECLUSAGE_POSITIONT")]
        Positiont = 0x9,
        [NativeName("Name", "D3DDECLUSAGE_COLOR")]
        Color = 0xA,
        [NativeName("Name", "D3DDECLUSAGE_FOG")]
        Fog = 0xB,
        [NativeName("Name", "D3DDECLUSAGE_DEPTH")]
        Depth = 0xC,
        [NativeName("Name", "D3DDECLUSAGE_SAMPLE")]
        Sample = 0xD,
    }
}
