// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICBitmapDecoderCapabilities")]
    public enum BitmapDecoderCapabilities : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "WICBitmapDecoderCapabilitySameEncoder")]
        BitmapDecoderCapabilitySameEncoder = 0x1,
        [NativeName("Name", "WICBitmapDecoderCapabilityCanDecodeAllImages")]
        BitmapDecoderCapabilityCanDecodeAllImages = 0x2,
        [NativeName("Name", "WICBitmapDecoderCapabilityCanDecodeSomeImages")]
        BitmapDecoderCapabilityCanDecodeSomeImages = 0x4,
        [NativeName("Name", "WICBitmapDecoderCapabilityCanEnumerateMetadata")]
        BitmapDecoderCapabilityCanEnumerateMetadata = 0x8,
        [NativeName("Name", "WICBitmapDecoderCapabilityCanDecodeThumbnail")]
        BitmapDecoderCapabilityCanDecodeThumbnail = 0x10,
        [NativeName("Name", "WICBITMAPDECODERCAPABILITIES_FORCE_DWORD")]
        ItmapdecodercapabilitiesForceDword = 0x7FFFFFFF,
    }
}
