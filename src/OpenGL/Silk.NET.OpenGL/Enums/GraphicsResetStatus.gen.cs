// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "GraphicsResetStatus")]
    public enum GraphicsResetStatus : int
    {
        [NativeName("Name", "GL_NO_ERROR")]
        NoError = 0x0,
        [NativeName("Name", "GL_GUILTY_CONTEXT_RESET")]
        GuiltyContextReset = 0x8253,
        [NativeName("Name", "GL_INNOCENT_CONTEXT_RESET")]
        InnocentContextReset = 0x8254,
        [NativeName("Name", "GL_UNKNOWN_CONTEXT_RESET")]
        UnknownContextReset = 0x8255,
    }
}
