// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.ARM
{
    [NativeName("Name", "GLenum")]
    public enum ARM : int
    {
        [NativeName("Name", "GL_MALI_PROGRAM_BINARY_ARM")]
        MaliProgramBinaryArm = 0x8F61,
        [NativeName("Name", "GL_MALI_SHADER_BINARY_ARM")]
        MaliShaderBinaryArm = 0x8F60,
        [NativeName("Name", "GL_FETCH_PER_SAMPLE_ARM")]
        FetchPerSampleArm = 0x8F65,
        [NativeName("Name", "GL_FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM")]
        FragmentShaderFramebufferFetchMrtArm = 0x8F66,
        [NativeName("Name", "GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
        TextureUnnormalizedCoordinatesArm = 0x8F6A,
    }
}
