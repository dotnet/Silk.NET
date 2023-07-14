// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUExternalTextureRotation")]
    public enum ExternalTextureRotation : int
    {
        [NativeName("Name", "WGPUExternalTextureRotation_Rotate0Degrees")]
        Rotate0Degrees = 0x0,
        [NativeName("Name", "WGPUExternalTextureRotation_Rotate90Degrees")]
        Rotate90Degrees = 0x1,
        [NativeName("Name", "WGPUExternalTextureRotation_Rotate180Degrees")]
        Rotate180Degrees = 0x2,
        [NativeName("Name", "WGPUExternalTextureRotation_Rotate270Degrees")]
        Rotate270Degrees = 0x3,
        [NativeName("Name", "WGPUExternalTextureRotation_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
