// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "GetFramebufferParameter")]
    public enum GetFramebufferParameter
    {
        [NativeName("Name", "GL_DOUBLEBUFFER")]
        Doublebuffer = 0xC32,
        [NativeName("Name", "GL_STEREO")]
        Stereo = 0xC33,
        [NativeName("Name", "GL_SAMPLE_BUFFERS")]
        SampleBuffers = 0x80A8,
        [NativeName("Name", "GL_SAMPLES")]
        Samples = 0x80A9,
        [NativeName("Name", "GL_IMPLEMENTATION_COLOR_READ_TYPE")]
        ImplementationColorReadType = 0x8B9A,
        [NativeName("Name", "GL_IMPLEMENTATION_COLOR_READ_FORMAT")]
        ImplementationColorReadFormat = 0x8B9B,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_WIDTH")]
        FramebufferDefaultWidth = 0x9310,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_HEIGHT")]
        FramebufferDefaultHeight = 0x9311,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_LAYERS")]
        FramebufferDefaultLayers = 0x9312,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_SAMPLES")]
        FramebufferDefaultSamples = 0x9313,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS")]
        FramebufferDefaultFixedSampleLocations = 0x9314,
    }
}
