// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL
{
    public enum GetFramebufferParameter
    {
        Doublebuffer = 0xC32,
        Stereo = 0xC33,
        SampleBuffers = 0x80A8,
        Samples = 0x80A9,
        ImplementationColorReadType = 0x8B9A,
        ImplementationColorReadFormat = 0x8B9B,
        FramebufferDefaultWidth = 0x9310,
        FramebufferDefaultHeight = 0x9311,
        FramebufferDefaultLayers = 0x9312,
        FramebufferDefaultSamples = 0x9313,
        FramebufferDefaultFixedSampleLocations = 0x9314,
    }
}
