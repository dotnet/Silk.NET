// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "BufferUsageARB")]
    public enum BufferUsageARB : int
    {
        [NativeName("Name", "GL_STREAM_DRAW")]
        StreamDraw = 0x88E0,
        [NativeName("Name", "GL_STREAM_READ")]
        StreamRead = 0x88E1,
        [NativeName("Name", "GL_STREAM_COPY")]
        StreamCopy = 0x88E2,
        [NativeName("Name", "GL_STATIC_DRAW")]
        StaticDraw = 0x88E4,
        [NativeName("Name", "GL_STATIC_READ")]
        StaticRead = 0x88E5,
        [NativeName("Name", "GL_STATIC_COPY")]
        StaticCopy = 0x88E6,
        [NativeName("Name", "GL_DYNAMIC_DRAW")]
        DynamicDraw = 0x88E8,
        [NativeName("Name", "GL_DYNAMIC_READ")]
        DynamicRead = 0x88E9,
        [NativeName("Name", "GL_DYNAMIC_COPY")]
        DynamicCopy = 0x88EA,
    }
}
