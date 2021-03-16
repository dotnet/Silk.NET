// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ObjectTypeAPPLE")]
    public enum ObjectTypeAPPLE : int
    {
        [NativeName("Name", "GL_DRAW_PIXELS_APPLE")]
        DrawPixelsApple = 0x8A0A,
        [NativeName("Name", "GL_FENCE_APPLE")]
        FenceApple = 0x8A0B,
    }
}
