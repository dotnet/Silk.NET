// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MEDIA_ENGINE_SEEK_MODE")]
    public enum MediaEngineSeekMode : int
    {
        [NativeName("Name", "MF_MEDIA_ENGINE_SEEK_MODE_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "MF_MEDIA_ENGINE_SEEK_MODE_APPROXIMATE")]
        Approximate = 0x1,
    }
}
