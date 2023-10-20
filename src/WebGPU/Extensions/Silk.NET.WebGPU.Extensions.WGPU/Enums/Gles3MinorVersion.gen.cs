// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUGles3MinorVersion")]
    public enum Gles3MinorVersion : int
    {
        [NativeName("Name", "WGPUGles3MinorVersion_Automatic")]
        Automatic = 0x0,
        [NativeName("Name", "WGPUGles3MinorVersion_Version0")]
        Version0 = 0x1,
        [NativeName("Name", "WGPUGles3MinorVersion_Version1")]
        Version1 = 0x2,
        [NativeName("Name", "WGPUGles3MinorVersion_Version2")]
        Version2 = 0x3,
        [NativeName("Name", "WGPUGles3MinorVersion_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
