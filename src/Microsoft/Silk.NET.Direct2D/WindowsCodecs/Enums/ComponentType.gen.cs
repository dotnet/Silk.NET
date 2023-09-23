// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICComponentType")]
    public enum ComponentType : int
    {
        [NativeName("Name", "")]
        None = 0,
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
