// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICComponentType")]
    public enum WICComponentType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Decoder\"")]
        [NativeName("Name", "WICDecoder")]
        Wicdecoder = 0x1,
        [Obsolete("Deprecated in favour of \"Encoder\"")]
        [NativeName("Name", "WICEncoder")]
        Wicencoder = 0x2,
        [Obsolete("Deprecated in favour of \"PixelFormatConverter\"")]
        [NativeName("Name", "WICPixelFormatConverter")]
        WicpixelFormatConverter = 0x4,
        [Obsolete("Deprecated in favour of \"MetadataReader\"")]
        [NativeName("Name", "WICMetadataReader")]
        WicmetadataReader = 0x8,
        [Obsolete("Deprecated in favour of \"MetadataWriter\"")]
        [NativeName("Name", "WICMetadataWriter")]
        WicmetadataWriter = 0x10,
        [Obsolete("Deprecated in favour of \"PixelFormat\"")]
        [NativeName("Name", "WICPixelFormat")]
        WicpixelFormat = 0x20,
        [Obsolete("Deprecated in favour of \"AllComponents\"")]
        [NativeName("Name", "WICAllComponents")]
        WicallComponents = 0x3F,
        [Obsolete("Deprecated in favour of \"OmponenttypeForceDword\"")]
        [NativeName("Name", "WICCOMPONENTTYPE_FORCE_DWORD")]
        WiccomponenttypeForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICDecoder")]
        Decoder = 0x1,
        [NativeName("Name", "WICEncoder")]
        Encoder = 0x2,
        [NativeName("Name", "WICPixelFormatConverter")]
        PixelFormatConverter = 0x4,
        [NativeName("Name", "WICMetadataReader")]
        MetadataReader = 0x8,
        [NativeName("Name", "WICMetadataWriter")]
        MetadataWriter = 0x10,
        [NativeName("Name", "WICPixelFormat")]
        PixelFormat = 0x20,
        [NativeName("Name", "WICAllComponents")]
        AllComponents = 0x3F,
        [NativeName("Name", "WICCOMPONENTTYPE_FORCE_DWORD")]
        OmponenttypeForceDword = 0x7FFFFFFF,
    }
}
