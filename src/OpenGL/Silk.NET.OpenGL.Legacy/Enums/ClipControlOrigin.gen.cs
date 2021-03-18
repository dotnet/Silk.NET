// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ClipControlOrigin")]
    public enum ClipControlOrigin : int
    {
        [NativeName("Name", "GL_LOWER_LEFT")]
        LowerLeft = 0x8CA1,
        [NativeName("Name", "GL_UPPER_LEFT")]
        UpperLeft = 0x8CA2,
    }
}
