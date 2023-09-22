// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICBitmapDecoderCapabilities")]
    public enum WICBitmapDecoderCapabilities : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"BitmapDecoderCapabilitySameEncoder\"")]
        [NativeName("Name", "WICBitmapDecoderCapabilitySameEncoder")]
        WicbitmapDecoderCapabilitySameEncoder = 0x1,
        [Obsolete("Deprecated in favour of \"BitmapDecoderCapabilityCanDecodeAllImages\"")]
        [NativeName("Name", "WICBitmapDecoderCapabilityCanDecodeAllImages")]
        WicbitmapDecoderCapabilityCanDecodeAllImages = 0x2,
        [Obsolete("Deprecated in favour of \"BitmapDecoderCapabilityCanDecodeSomeImages\"")]
        [NativeName("Name", "WICBitmapDecoderCapabilityCanDecodeSomeImages")]
        WicbitmapDecoderCapabilityCanDecodeSomeImages = 0x4,
        [Obsolete("Deprecated in favour of \"BitmapDecoderCapabilityCanEnumerateMetadata\"")]
        [NativeName("Name", "WICBitmapDecoderCapabilityCanEnumerateMetadata")]
        WicbitmapDecoderCapabilityCanEnumerateMetadata = 0x8,
        [Obsolete("Deprecated in favour of \"BitmapDecoderCapabilityCanDecodeThumbnail\"")]
        [NativeName("Name", "WICBitmapDecoderCapabilityCanDecodeThumbnail")]
        WicbitmapDecoderCapabilityCanDecodeThumbnail = 0x10,
        [Obsolete("Deprecated in favour of \"ItmapdecodercapabilitiesForceDword\"")]
        [NativeName("Name", "WICBITMAPDECODERCAPABILITIES_FORCE_DWORD")]
        WicbitmapdecodercapabilitiesForceDword = 0x7FFFFFFF,
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
