// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MEDIA_ENGINE_S3D_PACKING_MODE")]
    public enum MediaEngineS3DPackingMode : int
    {
        [NativeName("Name", "MF_MEDIA_ENGINE_S3D_PACKING_MODE_NONE")]
        None = 0x0,
        [NativeName("Name", "MF_MEDIA_ENGINE_S3D_PACKING_MODE_SIDE_BY_SIDE")]
        SideBySide = 0x1,
        [NativeName("Name", "MF_MEDIA_ENGINE_S3D_PACKING_MODE_TOP_BOTTOM")]
        TopBottom = 0x2,
    }
}
