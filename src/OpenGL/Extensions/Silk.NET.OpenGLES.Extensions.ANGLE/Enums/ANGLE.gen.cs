// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.ANGLE
{
    [NativeName("Name", "GLenum")]
    public enum ANGLE : int
    {
        [NativeName("Name", "GL_DEPTH_COMPONENT")]
        DepthComponent = 0x1902,
        [NativeName("Name", "GL_DEPTH_STENCIL_OES")]
        DepthStencilOes = 0x84F9,
        [NativeName("Name", "GL_UNSIGNED_SHORT")]
        UnsignedShort = 0x1403,
        [NativeName("Name", "GL_UNSIGNED_INT")]
        UnsignedInt = 0x1405,
        [NativeName("Name", "GL_UNSIGNED_INT_24_8_OES")]
        UnsignedInt248Oes = 0x84FA,
        [NativeName("Name", "GL_DEPTH_COMPONENT16")]
        DepthComponent16 = 0x81A5,
        [NativeName("Name", "GL_DEPTH_COMPONENT32_OES")]
        DepthComponent32Oes = 0x81A7,
        [NativeName("Name", "GL_DEPTH24_STENCIL8_OES")]
        Depth24Stencil8Oes = 0x88F0,
        [NativeName("Name", "GL_READ_FRAMEBUFFER_ANGLE")]
        ReadFramebufferAngle = 0x8CA8,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER_ANGLE")]
        DrawFramebufferAngle = 0x8CA9,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER_BINDING_ANGLE")]
        DrawFramebufferBindingAngle = 0x8CA6,
        [NativeName("Name", "GL_READ_FRAMEBUFFER_BINDING_ANGLE")]
        ReadFramebufferBindingAngle = 0x8CAA,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_ANGLE")]
        RenderbufferSamplesAngle = 0x8CAB,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE")]
        FramebufferIncompleteMultisampleAngle = 0x8D56,
        [NativeName("Name", "GL_MAX_SAMPLES_ANGLE")]
        MaxSamplesAngle = 0x8D57,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE")]
        VertexAttribArrayDivisorAngle = 0x88FE,
        [NativeName("Name", "GL_PACK_REVERSE_ROW_ORDER_ANGLE")]
        PackReverseRowOrderAngle = 0x93A4,
        [NativeName("Name", "GL_PROGRAM_BINARY_ANGLE")]
        ProgramBinaryAngle = 0x93A6,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT3_ANGLE")]
        CompressedRgbaS3TCDxt3Angle = 0x83F2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT5_ANGLE")]
        CompressedRgbaS3TCDxt5Angle = 0x83F3,
        [NativeName("Name", "GL_TEXTURE_USAGE_ANGLE")]
        TextureUsageAngle = 0x93A2,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_ANGLE")]
        FramebufferAttachmentAngle = 0x93A3,
        [NativeName("Name", "GL_TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE")]
        TranslatedShaderSourceLengthAngle = 0x93A0,
    }
}
