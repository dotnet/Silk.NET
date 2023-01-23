// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "FramebufferAttachmentParameterName")]
    public enum FramebufferAttachmentParameterName : int
    {
        [Obsolete("Deprecated in favour of \"ColorEncoding\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING")]
        FramebufferAttachmentColorEncoding = 0x8210,
        [Obsolete("Deprecated in favour of \"ColorEncodingExt\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT")]
        FramebufferAttachmentColorEncodingExt = 0x8210,
        [Obsolete("Deprecated in favour of \"ComponentType\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE")]
        FramebufferAttachmentComponentType = 0x8211,
        [Obsolete("Deprecated in favour of \"ComponentTypeExt\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
        FramebufferAttachmentComponentTypeExt = 0x8211,
        [Obsolete("Deprecated in favour of \"RedSize\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE")]
        FramebufferAttachmentRedSize = 0x8212,
        [Obsolete("Deprecated in favour of \"GreenSize\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE")]
        FramebufferAttachmentGreenSize = 0x8213,
        [Obsolete("Deprecated in favour of \"BlueSize\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE")]
        FramebufferAttachmentBlueSize = 0x8214,
        [Obsolete("Deprecated in favour of \"AlphaSize\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE")]
        FramebufferAttachmentAlphaSize = 0x8215,
        [Obsolete("Deprecated in favour of \"DepthSize\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE")]
        FramebufferAttachmentDepthSize = 0x8216,
        [Obsolete("Deprecated in favour of \"StencilSize\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE")]
        FramebufferAttachmentStencilSize = 0x8217,
        [Obsolete("Deprecated in favour of \"ObjectType\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
        FramebufferAttachmentObjectType = 0x8CD0,
        [Obsolete("Deprecated in favour of \"ObjectTypeExt\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT")]
        FramebufferAttachmentObjectTypeExt = 0x8CD0,
        [Obsolete("Deprecated in favour of \"ObjectTypeOes\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES")]
        FramebufferAttachmentObjectTypeOes = 0x8CD0,
        [Obsolete("Deprecated in favour of \"ObjectName\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
        FramebufferAttachmentObjectName = 0x8CD1,
        [Obsolete("Deprecated in favour of \"ObjectNameExt\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT")]
        FramebufferAttachmentObjectNameExt = 0x8CD1,
        [Obsolete("Deprecated in favour of \"ObjectNameOes\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES")]
        FramebufferAttachmentObjectNameOes = 0x8CD1,
        [Obsolete("Deprecated in favour of \"TextureLevel\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
        FramebufferAttachmentTextureLevel = 0x8CD2,
        [Obsolete("Deprecated in favour of \"TextureLevelExt\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT")]
        FramebufferAttachmentTextureLevelExt = 0x8CD2,
        [Obsolete("Deprecated in favour of \"TextureLevelOes\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES")]
        FramebufferAttachmentTextureLevelOes = 0x8CD2,
        [Obsolete("Deprecated in favour of \"TextureCubeMapFace\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
        FramebufferAttachmentTextureCubeMapFace = 0x8CD3,
        [Obsolete("Deprecated in favour of \"TextureCubeMapFaceExt\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT")]
        FramebufferAttachmentTextureCubeMapFaceExt = 0x8CD3,
        [Obsolete("Deprecated in favour of \"TextureCubeMapFaceOes\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES")]
        FramebufferAttachmentTextureCubeMapFaceOes = 0x8CD3,
        [Obsolete("Deprecated in favour of \"Texture3DZoffsetExt\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT")]
        FramebufferAttachmentTexture3DZoffsetExt = 0x8CD4,
        [Obsolete("Deprecated in favour of \"Texture3DZoffsetOes\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES")]
        FramebufferAttachmentTexture3DZoffsetOes = 0x8CD4,
        [Obsolete("Deprecated in favour of \"TextureLayer\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER")]
        FramebufferAttachmentTextureLayer = 0x8CD4,
        [Obsolete("Deprecated in favour of \"TextureLayerExt\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT")]
        FramebufferAttachmentTextureLayerExt = 0x8CD4,
        [Obsolete("Deprecated in favour of \"TextureSamplesExt\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT")]
        FramebufferAttachmentTextureSamplesExt = 0x8D6C,
        [Obsolete("Deprecated in favour of \"Layered\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED")]
        FramebufferAttachmentLayered = 0x8DA7,
        [Obsolete("Deprecated in favour of \"LayeredArb\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB")]
        FramebufferAttachmentLayeredArb = 0x8DA7,
        [Obsolete("Deprecated in favour of \"LayeredExt\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
        FramebufferAttachmentLayeredExt = 0x8DA7,
        [Obsolete("Deprecated in favour of \"LayeredOes\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES")]
        FramebufferAttachmentLayeredOes = 0x8DA7,
        [Obsolete("Deprecated in favour of \"TextureScaleImg\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG")]
        FramebufferAttachmentTextureScaleImg = 0x913F,
        [Obsolete("Deprecated in favour of \"TextureNumViewsOvr\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR")]
        FramebufferAttachmentTextureNumViewsOvr = 0x9630,
        [Obsolete("Deprecated in favour of \"TextureBaseViewIndexOvr\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR")]
        FramebufferAttachmentTextureBaseViewIndexOvr = 0x9632,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING")]
        ColorEncoding = 0x8210,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT")]
        ColorEncodingExt = 0x8210,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE")]
        ComponentType = 0x8211,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
        ComponentTypeExt = 0x8211,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE")]
        RedSize = 0x8212,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE")]
        GreenSize = 0x8213,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE")]
        BlueSize = 0x8214,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE")]
        AlphaSize = 0x8215,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE")]
        DepthSize = 0x8216,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE")]
        StencilSize = 0x8217,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
        ObjectType = 0x8CD0,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT")]
        ObjectTypeExt = 0x8CD0,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES")]
        ObjectTypeOes = 0x8CD0,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
        ObjectName = 0x8CD1,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT")]
        ObjectNameExt = 0x8CD1,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES")]
        ObjectNameOes = 0x8CD1,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
        TextureLevel = 0x8CD2,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT")]
        TextureLevelExt = 0x8CD2,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES")]
        TextureLevelOes = 0x8CD2,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
        TextureCubeMapFace = 0x8CD3,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT")]
        TextureCubeMapFaceExt = 0x8CD3,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES")]
        TextureCubeMapFaceOes = 0x8CD3,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT")]
        Texture3DZoffsetExt = 0x8CD4,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES")]
        Texture3DZoffsetOes = 0x8CD4,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER")]
        TextureLayer = 0x8CD4,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT")]
        TextureLayerExt = 0x8CD4,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT")]
        TextureSamplesExt = 0x8D6C,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED")]
        Layered = 0x8DA7,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB")]
        LayeredArb = 0x8DA7,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
        LayeredExt = 0x8DA7,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES")]
        LayeredOes = 0x8DA7,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG")]
        TextureScaleImg = 0x913F,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR")]
        TextureNumViewsOvr = 0x9630,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR")]
        TextureBaseViewIndexOvr = 0x9632,
    }
}
