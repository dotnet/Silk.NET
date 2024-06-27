// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagVIEWSTATUS")]
    public enum ViewStatus : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VIEWSTATUS_OPAQUE")]
        ViewstatusOpaque = 0x1,
        [NativeName("Name", "VIEWSTATUS_SOLIDBKGND")]
        ViewstatusSolidbkgnd = 0x2,
        [NativeName("Name", "VIEWSTATUS_DVASPECTOPAQUE")]
        ViewstatusDvaspectopaque = 0x4,
        [NativeName("Name", "VIEWSTATUS_DVASPECTTRANSPARENT")]
        ViewstatusDvaspecttransparent = 0x8,
        [NativeName("Name", "VIEWSTATUS_SURFACE")]
        ViewstatusSurface = 0x10,
        [NativeName("Name", "VIEWSTATUS_3DSURFACE")]
        Viewstatus3Dsurface = 0x20,
    }
}
