// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "SeparableTarget")]
    public enum SeparableTarget : int
    {
        [NativeName("Name", "GL_SEPARABLE_2D")]
        Separable2D = 0x8012,
    }
}
