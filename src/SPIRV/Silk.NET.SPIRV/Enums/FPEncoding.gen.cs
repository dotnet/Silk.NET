// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvFPEncoding_")]
    public enum FPEncoding : int
    {
        [NativeName("Name", "SpvFPEncodingBFloat16KHR")]
        BFloat16Khr = 0x0,
        [NativeName("Name", "SpvFPEncodingFloat8E4M3EXT")]
        Float8E4M3Ext = 0x1076,
        [NativeName("Name", "SpvFPEncodingFloat8E5M2EXT")]
        Float8E5M2Ext = 0x1077,
        [NativeName("Name", "SpvFPEncodingMax")]
        Max = 0x7FFFFFFF,
    }
}
