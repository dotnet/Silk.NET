// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TransformFeedbackBufferMode")]
    public enum TransformFeedbackBufferMode : int
    {
        [NativeName("Name", "GL_INTERLEAVED_ATTRIBS")]
        InterleavedAttribs = 0x8C8C,
        [NativeName("Name", "GL_SEPARATE_ATTRIBS")]
        SeparateAttribs = 0x8C8D,
    }
}
