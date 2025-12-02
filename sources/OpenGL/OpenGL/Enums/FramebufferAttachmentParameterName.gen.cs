// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FramebufferAttachmentParameterName")]
public enum FramebufferAttachmentParameterName : uint
{
    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES")]
    ObjectTypeOES = unchecked((uint)0x8CD0),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES")]
    ObjectNameOES = unchecked((uint)0x8CD1),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES")]
    TextureLevelOES = unchecked((uint)0x8CD2),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES")]
    TextureCubeMapFaceOES = unchecked((uint)0x8CD3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT")]
    TextureSamplesEXT = unchecked((uint)0x8D6C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT")]
    ColorEncodingEXT = unchecked((uint)0x8210),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING")]
    ColorEncoding = unchecked((uint)0x8210),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE")]
    ComponentType = unchecked((uint)0x8211),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE")]
    RedSize = unchecked((uint)0x8212),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE")]
    GreenSize = unchecked((uint)0x8213),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE")]
    BlueSize = unchecked((uint)0x8214),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE")]
    AlphaSize = unchecked((uint)0x8215),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE")]
    DepthSize = unchecked((uint)0x8216),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE")]
    StencilSize = unchecked((uint)0x8217),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
    ObjectType = unchecked((uint)0x8CD0),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
    ObjectName = unchecked((uint)0x8CD1),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
    TextureLevel = unchecked((uint)0x8CD2),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
    TextureCubeMapFace = unchecked((uint)0x8CD3),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER")]
    TextureLayer = unchecked((uint)0x8CD4),

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED")]
    Layered = unchecked((uint)0x8DA7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB")]
    LayeredARB = unchecked((uint)0x8DA7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT")]
    ObjectTypeEXT = unchecked((uint)0x8CD0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT")]
    ObjectNameEXT = unchecked((uint)0x8CD1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT")]
    TextureLevelEXT = unchecked((uint)0x8CD2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT")]
    TextureCubeMapFaceEXT = unchecked((uint)0x8CD3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT")]
    Texture3DZoffsetEXT = unchecked((uint)0x8CD4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
    LayeredEXT = unchecked((uint)0x8DA7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT")]
    TextureLayerEXT = unchecked((uint)0x8CD4),

    [NameAffix("Suffix", "OVR", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR")]
    TextureNumViewsOVR = unchecked((uint)0x9630),

    [NameAffix("Suffix", "OVR", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR")]
    TextureBaseViewIndexOVR = unchecked((uint)0x9632),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES")]
    LayeredOES = unchecked((uint)0x8DA7),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES")]
    Texture3DZoffsetOES = unchecked((uint)0x8CD4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
    ComponentTypeEXT = unchecked((uint)0x8211),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG")]
    TextureScaleIMG = unchecked((uint)0x913F),
}
