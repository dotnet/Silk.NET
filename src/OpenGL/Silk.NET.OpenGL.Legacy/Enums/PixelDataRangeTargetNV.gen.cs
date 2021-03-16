// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PixelDataRangeTargetNV")]
    public enum PixelDataRangeTargetNV : int
    {
        [NativeName("Name", "GL_WRITE_PIXEL_DATA_RANGE_NV")]
        WritePixelDataRangeNV = 0x8878,
        [NativeName("Name", "GL_READ_PIXEL_DATA_RANGE_NV")]
        ReadPixelDataRangeNV = 0x8879,
    }
}
