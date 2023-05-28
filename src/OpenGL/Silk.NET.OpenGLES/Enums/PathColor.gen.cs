// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PathColor")]
    public enum PathColor : int
    {
        [NativeName("Name", "GL_PRIMARY_COLOR_NV")]
        PrimaryColorNV = 0x852C,
        [NativeName("Name", "GL_SECONDARY_COLOR_NV")]
        SecondaryColorNV = 0x852D,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PRIMARY_COLOR")]
        PrimaryColor = 0x8577,
    }
}
