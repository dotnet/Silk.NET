// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ShadingModel")]
    public enum ShadingModel : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FLAT")]
        Flat = 0x1D00,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SMOOTH")]
        Smooth = 0x1D01,
    }
}
