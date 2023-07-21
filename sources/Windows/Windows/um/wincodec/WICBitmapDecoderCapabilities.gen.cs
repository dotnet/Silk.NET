// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICBitmapDecoderCapabilities.xml' path='doc/member[@name="WICBitmapDecoderCapabilities"]/*' />
public enum WICBitmapDecoderCapabilities
{
    /// <include file='WICBitmapDecoderCapabilities.xml' path='doc/member[@name="WICBitmapDecoderCapabilities.WICBitmapDecoderCapabilitySameEncoder"]/*' />
    WICBitmapDecoderCapabilitySameEncoder = 0x1,

    /// <include file='WICBitmapDecoderCapabilities.xml' path='doc/member[@name="WICBitmapDecoderCapabilities.WICBitmapDecoderCapabilityCanDecodeAllImages"]/*' />
    WICBitmapDecoderCapabilityCanDecodeAllImages = 0x2,

    /// <include file='WICBitmapDecoderCapabilities.xml' path='doc/member[@name="WICBitmapDecoderCapabilities.WICBitmapDecoderCapabilityCanDecodeSomeImages"]/*' />
    WICBitmapDecoderCapabilityCanDecodeSomeImages = 0x4,

    /// <include file='WICBitmapDecoderCapabilities.xml' path='doc/member[@name="WICBitmapDecoderCapabilities.WICBitmapDecoderCapabilityCanEnumerateMetadata"]/*' />
    WICBitmapDecoderCapabilityCanEnumerateMetadata = 0x8,

    /// <include file='WICBitmapDecoderCapabilities.xml' path='doc/member[@name="WICBitmapDecoderCapabilities.WICBitmapDecoderCapabilityCanDecodeThumbnail"]/*' />
    WICBitmapDecoderCapabilityCanDecodeThumbnail = 0x10,

    /// <include file='WICBitmapDecoderCapabilities.xml' path='doc/member[@name="WICBitmapDecoderCapabilities.WICBITMAPDECODERCAPABILITIES_FORCE_DWORD"]/*' />
    WICBITMAPDECODERCAPABILITIES_FORCE_DWORD = 0x7fffffff,
}
