// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagXFORMCOORDS")]
    public enum XFormCoords : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Position\"")]
        [NativeName("Name", "XFORMCOORDS_POSITION")]
        XformcoordsPosition = 0x1,
        [Obsolete("Deprecated in favour of \"Size\"")]
        [NativeName("Name", "XFORMCOORDS_SIZE")]
        XformcoordsSize = 0x2,
        [Obsolete("Deprecated in favour of \"Himetrictocontainer\"")]
        [NativeName("Name", "XFORMCOORDS_HIMETRICTOCONTAINER")]
        XformcoordsHimetrictocontainer = 0x4,
        [Obsolete("Deprecated in favour of \"Containertohimetric\"")]
        [NativeName("Name", "XFORMCOORDS_CONTAINERTOHIMETRIC")]
        XformcoordsContainertohimetric = 0x8,
        [Obsolete("Deprecated in favour of \"Eventcompat\"")]
        [NativeName("Name", "XFORMCOORDS_EVENTCOMPAT")]
        XformcoordsEventcompat = 0x10,
        [NativeName("Name", "XFORMCOORDS_POSITION")]
        Position = 0x1,
        [NativeName("Name", "XFORMCOORDS_SIZE")]
        Size = 0x2,
        [NativeName("Name", "XFORMCOORDS_HIMETRICTOCONTAINER")]
        Himetrictocontainer = 0x4,
        [NativeName("Name", "XFORMCOORDS_CONTAINERTOHIMETRIC")]
        Containertohimetric = 0x8,
        [NativeName("Name", "XFORMCOORDS_EVENTCOMPAT")]
        Eventcompat = 0x10,
    }
}
