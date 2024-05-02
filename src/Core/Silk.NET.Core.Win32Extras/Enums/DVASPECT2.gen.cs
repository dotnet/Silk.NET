// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagDVASPECT2")]
    public enum DVASPECT2 : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Opaque\"")]
        [NativeName("Name", "DVASPECT_OPAQUE")]
        DvaspectOpaque = 0x10,
        [Obsolete("Deprecated in favour of \"Transparent\"")]
        [NativeName("Name", "DVASPECT_TRANSPARENT")]
        DvaspectTransparent = 0x20,
        [NativeName("Name", "DVASPECT_OPAQUE")]
        Opaque = 0x10,
        [NativeName("Name", "DVASPECT_TRANSPARENT")]
        Transparent = 0x20,
    }
}
