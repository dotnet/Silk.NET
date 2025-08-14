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
        [NativeName("Name", "SpvFPEncodingMax")]
        Max = 0x7FFFFFFF,
    }
}
