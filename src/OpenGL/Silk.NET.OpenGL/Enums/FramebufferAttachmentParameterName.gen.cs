// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FramebufferAttachmentParameterName")]
    public enum FramebufferAttachmentParameterName : int
    {
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING")]
        FramebufferAttachmentColorEncoding = 0x8210,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT")]
        FramebufferAttachmentColorEncodingExt = 0x8210,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE")]
        FramebufferAttachmentComponentType = 0x8211,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
        FramebufferAttachmentComponentTypeExt = 0x8211,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE")]
        FramebufferAttachmentRedSize = 0x8212,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE")]
        FramebufferAttachmentGreenSize = 0x8213,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE")]
        FramebufferAttachmentBlueSize = 0x8214,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE")]
        FramebufferAttachmentAlphaSize = 0x8215,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE")]
        FramebufferAttachmentDepthSize = 0x8216,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE")]
        FramebufferAttachmentStencilSize = 0x8217,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
        FramebufferAttachmentObjectType = 0x8CD0,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT")]
        FramebufferAttachmentObjectTypeExt = 0x8CD0,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES")]
        FramebufferAttachmentObjectTypeOes = 0x8CD0,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
        FramebufferAttachmentObjectName = 0x8CD1,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT")]
        FramebufferAttachmentObjectNameExt = 0x8CD1,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES")]
        FramebufferAttachmentObjectNameOes = 0x8CD1,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
        FramebufferAttachmentTextureLevel = 0x8CD2,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT")]
        FramebufferAttachmentTextureLevelExt = 0x8CD2,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES")]
        FramebufferAttachmentTextureLevelOes = 0x8CD2,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
        FramebufferAttachmentTextureCubeMapFace = 0x8CD3,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT")]
        FramebufferAttachmentTextureCubeMapFaceExt = 0x8CD3,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES")]
        FramebufferAttachmentTextureCubeMapFaceOes = 0x8CD3,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT")]
        FramebufferAttachmentTexture3DZoffsetExt = 0x8CD4,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES")]
        FramebufferAttachmentTexture3DZoffsetOes = 0x8CD4,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER")]
        FramebufferAttachmentTextureLayer = 0x8CD4,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT")]
        FramebufferAttachmentTextureLayerExt = 0x8CD4,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT")]
        FramebufferAttachmentTextureSamplesExt = 0x8D6C,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED")]
        FramebufferAttachmentLayered = 0x8DA7,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB")]
        FramebufferAttachmentLayeredArb = 0x8DA7,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
        FramebufferAttachmentLayeredExt = 0x8DA7,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES")]
        FramebufferAttachmentLayeredOes = 0x8DA7,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG")]
        FramebufferAttachmentTextureScaleImg = 0x913F,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR")]
        FramebufferAttachmentTextureNumViewsOvr = 0x9630,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR")]
        FramebufferAttachmentTextureBaseViewIndexOvr = 0x9632,
    }
}
