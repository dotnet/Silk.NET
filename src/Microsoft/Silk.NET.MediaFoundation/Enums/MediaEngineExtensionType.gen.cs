// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MEDIA_ENGINE_EXTENSION_TYPE")]
    public enum MediaEngineExtensionType : int
    {
        [NativeName("Name", "MF_MEDIA_ENGINE_EXTENSION_TYPE_MEDIASOURCE")]
        Mediasource = 0x0,
        [NativeName("Name", "MF_MEDIA_ENGINE_EXTENSION_TYPE_BYTESTREAM")]
        Bytestream = 0x1,
    }
}
