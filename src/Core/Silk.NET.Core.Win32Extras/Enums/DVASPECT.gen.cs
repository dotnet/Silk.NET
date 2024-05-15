// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagDVASPECT")]
    public enum DVASPECT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Content\"")]
        [NativeName("Name", "DVASPECT_CONTENT")]
        DvaspectContent = 0x1,
        [Obsolete("Deprecated in favour of \"Thumbnail\"")]
        [NativeName("Name", "DVASPECT_THUMBNAIL")]
        DvaspectThumbnail = 0x2,
        [Obsolete("Deprecated in favour of \"Icon\"")]
        [NativeName("Name", "DVASPECT_ICON")]
        DvaspectIcon = 0x4,
        [Obsolete("Deprecated in favour of \"Docprint\"")]
        [NativeName("Name", "DVASPECT_DOCPRINT")]
        DvaspectDocprint = 0x8,
        [NativeName("Name", "DVASPECT_CONTENT")]
        Content = 0x1,
        [NativeName("Name", "DVASPECT_THUMBNAIL")]
        Thumbnail = 0x2,
        [NativeName("Name", "DVASPECT_ICON")]
        Icon = 0x4,
        [NativeName("Name", "DVASPECT_DOCPRINT")]
        Docprint = 0x8,
    }
}
