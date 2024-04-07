// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FramebufferAttachmentParameterName : uint
{
    ColorEncoding = 0x8210,
    ComponentType = 0x8211,
    RedSize = 0x8212,
    GreenSize = 0x8213,
    BlueSize = 0x8214,
    AlphaSize = 0x8215,
    DepthSize = 0x8216,
    StencilSize = 0x8217,
    ObjectType = 0x8CD0,
    ObjectName = 0x8CD1,
    TextureLevel = 0x8CD2,
    TextureCubeMapFace = 0x8CD3,
    TextureLayer = 0x8CD4,
    Layered = 0x8DA7,
    LayeredARB = 0x8DA7,
    TextureNumViewsOVR = 0x9630,
    TextureBaseViewIndexOVR = 0x9632,
    ObjectTypeEXT = 0x8CD0,
    ObjectNameEXT = 0x8CD1,
    TextureLevelEXT = 0x8CD2,
    TextureCubeMapFaceEXT = 0x8CD3,
    Texture3DZoffsetEXT = 0x8CD4,
    LayeredEXT = 0x8DA7,
    TextureLayerEXT = 0x8CD4,
    ObjectTypeOES = 0x8CD0,
    ObjectNameOES = 0x8CD1,
    TextureLevelOES = 0x8CD2,
    TextureCubeMapFaceOES = 0x8CD3,
    TextureSamplesEXT = 0x8D6C,
    ColorEncodingEXT = 0x8210,
    LayeredOES = 0x8DA7,
    Texture3DZoffsetOES = 0x8CD4,
    ComponentTypeEXT = 0x8211,
    TextureScaleIMG = 0x913F
}
