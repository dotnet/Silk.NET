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
    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES")]
    ObjectTypeOES = 36048,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES")]
    ObjectNameOES = 36049,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES")]
    TextureLevelOES = 36050,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES")]
    TextureCubeMapFaceOES = 36051,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT")]
    TextureSamplesEXT = 36204,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT")]
    ColorEncodingEXT = 33296,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING")]
    ColorEncoding = 33296,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE")]
    ComponentType = 33297,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE")]
    RedSize = 33298,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE")]
    GreenSize = 33299,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE")]
    BlueSize = 33300,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE")]
    AlphaSize = 33301,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE")]
    DepthSize = 33302,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE")]
    StencilSize = 33303,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
    ObjectType = 36048,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
    ObjectName = 36049,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
    TextureLevel = 36050,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
    TextureCubeMapFace = 36051,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER")]
    TextureLayer = 36052,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED")]
    Layered = 36263,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB")]
    LayeredARB = 36263,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT")]
    ObjectTypeEXT = 36048,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT")]
    ObjectNameEXT = 36049,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT")]
    TextureLevelEXT = 36050,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT")]
    TextureCubeMapFaceEXT = 36051,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT")]
    Texture3DZoffsetEXT = 36052,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
    LayeredEXT = 36263,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT")]
    TextureLayerEXT = 36052,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR")]
    TextureNumViewsOVR = 38448,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR")]
    TextureBaseViewIndexOVR = 38450,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES")]
    LayeredOES = 36263,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES")]
    Texture3DZoffsetOES = 36052,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
    ComponentTypeEXT = 33297,

    [NativeName("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG")]
    TextureScaleIMG = 37183,
}
