// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ClampColorTargetARB")]
    public enum ClampColorTargetARB : int
    {
        [NativeName("Name", "GL_CLAMP_VERTEX_COLOR_ARB")]
        ClampVertexColorArb = 0x891A,
        [NativeName("Name", "GL_CLAMP_FRAGMENT_COLOR_ARB")]
        ClampFragmentColorArb = 0x891B,
        [NativeName("Name", "GL_CLAMP_READ_COLOR")]
        ClampReadColor = 0x891C,
        [NativeName("Name", "GL_CLAMP_READ_COLOR_ARB")]
        ClampReadColorArb = 0x891C,
    }
}
