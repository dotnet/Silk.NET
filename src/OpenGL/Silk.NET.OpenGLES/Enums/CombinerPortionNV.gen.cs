// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "CombinerPortionNV")]
    public enum CombinerPortionNV : int
    {
        [NativeName("Name", "GL_ALPHA")]
        Alpha = 0x1906,
        [NativeName("Name", "GL_RGB")]
        Rgb = 0x1907,
    }
}
