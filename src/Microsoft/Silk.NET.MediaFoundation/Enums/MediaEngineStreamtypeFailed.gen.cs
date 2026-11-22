// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MEDIA_ENGINE_STREAMTYPE_FAILED")]
    public enum MediaEngineStreamTypeFailed : int
    {
        [NativeName("Name", "MF_MEDIA_ENGINE_STREAMTYPE_FAILED_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "MF_MEDIA_ENGINE_STREAMTYPE_FAILED_AUDIO")]
        Audio = 0x1,
        [NativeName("Name", "MF_MEDIA_ENGINE_STREAMTYPE_FAILED_VIDEO")]
        Video = 0x2,
    }
}
