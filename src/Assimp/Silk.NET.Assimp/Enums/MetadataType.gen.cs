// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiMetadataType")]
    public enum MetadataType : int
    {
        [NativeName("Name", "AI_BOOL")]
        Bool = 0x0,
        [NativeName("Name", "AI_INT32")]
        Int32 = 0x1,
        [NativeName("Name", "AI_UINT64")]
        Uint64 = 0x2,
        [NativeName("Name", "AI_FLOAT")]
        Float = 0x3,
        [NativeName("Name", "AI_DOUBLE")]
        Double = 0x4,
        [NativeName("Name", "AI_AISTRING")]
        Aistring = 0x5,
        [NativeName("Name", "AI_AIVECTOR3D")]
        Aivector3D = 0x6,
        [NativeName("Name", "AI_AIMETADATA")]
        Aimetadata = 0x7,
        [NativeName("Name", "AI_INT64")]
        Int64 = 0x8,
        [NativeName("Name", "AI_UINT32")]
        Uint32 = 0x9,
        [NativeName("Name", "AI_META_MAX")]
        MetaMax = 0xA,
    }
}
