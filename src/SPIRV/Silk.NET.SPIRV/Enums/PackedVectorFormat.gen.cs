// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvPackedVectorFormat_")]
    public enum PackedVectorFormat : int
    {
        [NativeName("Name", "SpvPackedVectorFormatPackedVectorFormat4x8Bit")]
        PackedVectorFormat4x8Bit = 0x0,
        [NativeName("Name", "SpvPackedVectorFormatPackedVectorFormat4x8BitKHR")]
        PackedVectorFormat4x8BitKhr = 0x0,
        [NativeName("Name", "SpvPackedVectorFormatMax")]
        Max = 0x7FFFFFFF,
    }
}
