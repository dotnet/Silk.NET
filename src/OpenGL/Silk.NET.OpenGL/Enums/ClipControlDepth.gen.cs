// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ClipControlDepth")]
    public enum ClipControlDepth : int
    {
        [NativeName("Name", "GL_NEGATIVE_ONE_TO_ONE")]
        NegativeOneToOne = 0x935E,
        [NativeName("Name", "GL_ZERO_TO_ONE")]
        ZeroToOne = 0x935F,
    }
}
