// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "_MF_MEDIA_ENGINE_KEYERR")]
    public enum MediaEngineKeyError : int
    {
        [NativeName("Name", "MF_MEDIAENGINE_KEYERR_UNKNOWN")]
        Unknown = 0x1,
        [NativeName("Name", "MF_MEDIAENGINE_KEYERR_CLIENT")]
        Client = 0x2,
        [NativeName("Name", "MF_MEDIAENGINE_KEYERR_SERVICE")]
        Service = 0x3,
        [NativeName("Name", "MF_MEDIAENGINE_KEYERR_OUTPUT")]
        Output = 0x4,
        [NativeName("Name", "MF_MEDIAENGINE_KEYERR_HARDWARECHANGE")]
        Hardwarechange = 0x5,
        [NativeName("Name", "MF_MEDIAENGINE_KEYERR_DOMAIN")]
        Domain = 0x6,
    }
}
