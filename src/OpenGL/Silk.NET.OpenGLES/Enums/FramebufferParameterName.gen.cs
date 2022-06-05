// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FramebufferParameterName")]
    public enum FramebufferParameterName : int
    {
        [Obsolete("Deprecated in favour of \"Width\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_WIDTH")]
        FramebufferDefaultWidth = 0x9310,
        [Obsolete("Deprecated in favour of \"Height\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_HEIGHT")]
        FramebufferDefaultHeight = 0x9311,
        [Obsolete("Deprecated in favour of \"Layers\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_LAYERS")]
        FramebufferDefaultLayers = 0x9312,
        [Obsolete("Deprecated in favour of \"Samples\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_SAMPLES")]
        FramebufferDefaultSamples = 0x9313,
        [Obsolete("Deprecated in favour of \"FixedSampleLocations\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS")]
        FramebufferDefaultFixedSampleLocations = 0x9314,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_WIDTH")]
        Width = 0x9310,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_HEIGHT")]
        Height = 0x9311,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_LAYERS")]
        Layers = 0x9312,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_SAMPLES")]
        Samples = 0x9313,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS")]
        FixedSampleLocations = 0x9314,
    }
}
