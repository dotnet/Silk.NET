// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvFPDenormMode_")]
    public enum FPDenormMode : int
    {
        [NativeName("Name", "SpvFPDenormModePreserve")]
        Preserve = 0x0,
        [NativeName("Name", "SpvFPDenormModeFlushToZero")]
        FlushToZero = 0x1,
        [NativeName("Name", "SpvFPDenormModeMax")]
        Max = 0x7FFFFFFF,
    }
}
