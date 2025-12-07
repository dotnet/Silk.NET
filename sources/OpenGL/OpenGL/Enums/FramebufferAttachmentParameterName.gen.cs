// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FramebufferAttachmentParameterName : uint
{
    ColorEncoding = unchecked((uint)0x8210),
    ComponentType = unchecked((uint)0x8211),
    RedSize = unchecked((uint)0x8212),
    GreenSize = unchecked((uint)0x8213),
    BlueSize = unchecked((uint)0x8214),
    AlphaSize = unchecked((uint)0x8215),
    DepthSize = unchecked((uint)0x8216),
    StencilSize = unchecked((uint)0x8217),
    ObjectType = unchecked((uint)0x8CD0),
    ObjectName = unchecked((uint)0x8CD1),
    TextureLevel = unchecked((uint)0x8CD2),
    TextureCubeMapFace = unchecked((uint)0x8CD3),
    TextureLayer = unchecked((uint)0x8CD4),
    Layered = unchecked((uint)0x8DA7),
    LayeredARB = unchecked((uint)0x8DA7),
    ObjectTypeEXT = unchecked((uint)0x8CD0),
    ObjectNameEXT = unchecked((uint)0x8CD1),
    TextureLevelEXT = unchecked((uint)0x8CD2),
    TextureCubeMapFaceEXT = unchecked((uint)0x8CD3),
    Texture3DZoffsetEXT = unchecked((uint)0x8CD4),
    LayeredEXT = unchecked((uint)0x8DA7),
    TextureLayerEXT = unchecked((uint)0x8CD4),
    TextureNumViewsOVR = unchecked((uint)0x9630),
    TextureBaseViewIndexOVR = unchecked((uint)0x9632),
    LayeredOES = unchecked((uint)0x8DA7),
    Texture3DZoffsetOES = unchecked((uint)0x8CD4),
    ComponentTypeEXT = unchecked((uint)0x8211),
    TextureSamplesEXT = unchecked((uint)0x8D6C),
    ColorEncodingEXT = unchecked((uint)0x8210),
    TextureScaleIMG = unchecked((uint)0x913F),
    ObjectTypeOES = unchecked((uint)0x8CD0),
    ObjectNameOES = unchecked((uint)0x8CD1),
    TextureLevelOES = unchecked((uint)0x8CD2),
    TextureCubeMapFaceOES = unchecked((uint)0x8CD3),
}
