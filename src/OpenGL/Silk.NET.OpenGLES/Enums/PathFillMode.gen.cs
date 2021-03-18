// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PathFillMode")]
    public enum PathFillMode : int
    {
        [NativeName("Name", "GL_INVERT")]
        Invert = 0x150A,
        [NativeName("Name", "GL_PATH_FILL_MODE_NV")]
        PathFillModeNV = 0x9080,
        [NativeName("Name", "GL_COUNT_UP_NV")]
        CountUpNV = 0x9088,
        [NativeName("Name", "GL_COUNT_DOWN_NV")]
        CountDownNV = 0x9089,
    }
}
