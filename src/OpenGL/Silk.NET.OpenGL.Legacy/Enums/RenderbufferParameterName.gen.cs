// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "RenderbufferParameterName")]
    public enum RenderbufferParameterName : int
    {
        [NativeName("Name", "GL_RENDERBUFFER_COVERAGE_SAMPLES_NV")]
        RenderbufferCoverageSamplesNV = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES")]
        RenderbufferSamples = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_ANGLE")]
        RenderbufferSamplesAngle = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_APPLE")]
        RenderbufferSamplesApple = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_EXT")]
        RenderbufferSamplesExt = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_NV")]
        RenderbufferSamplesNV = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_WIDTH")]
        RenderbufferWidth = 0x8D42,
        [NativeName("Name", "GL_RENDERBUFFER_WIDTH_EXT")]
        RenderbufferWidthExt = 0x8D42,
        [NativeName("Name", "GL_RENDERBUFFER_WIDTH_OES")]
        RenderbufferWidthOes = 0x8D42,
        [NativeName("Name", "GL_RENDERBUFFER_HEIGHT")]
        RenderbufferHeight = 0x8D43,
        [NativeName("Name", "GL_RENDERBUFFER_HEIGHT_EXT")]
        RenderbufferHeightExt = 0x8D43,
        [NativeName("Name", "GL_RENDERBUFFER_HEIGHT_OES")]
        RenderbufferHeightOes = 0x8D43,
        [NativeName("Name", "GL_RENDERBUFFER_INTERNAL_FORMAT")]
        RenderbufferInternalFormat = 0x8D44,
        [NativeName("Name", "GL_RENDERBUFFER_INTERNAL_FORMAT_EXT")]
        RenderbufferInternalFormatExt = 0x8D44,
        [NativeName("Name", "GL_RENDERBUFFER_INTERNAL_FORMAT_OES")]
        RenderbufferInternalFormatOes = 0x8D44,
        [NativeName("Name", "GL_RENDERBUFFER_RED_SIZE")]
        RenderbufferRedSize = 0x8D50,
        [NativeName("Name", "GL_RENDERBUFFER_RED_SIZE_EXT")]
        RenderbufferRedSizeExt = 0x8D50,
        [NativeName("Name", "GL_RENDERBUFFER_RED_SIZE_OES")]
        RenderbufferRedSizeOes = 0x8D50,
        [NativeName("Name", "GL_RENDERBUFFER_GREEN_SIZE")]
        RenderbufferGreenSize = 0x8D51,
        [NativeName("Name", "GL_RENDERBUFFER_GREEN_SIZE_EXT")]
        RenderbufferGreenSizeExt = 0x8D51,
        [NativeName("Name", "GL_RENDERBUFFER_GREEN_SIZE_OES")]
        RenderbufferGreenSizeOes = 0x8D51,
        [NativeName("Name", "GL_RENDERBUFFER_BLUE_SIZE")]
        RenderbufferBlueSize = 0x8D52,
        [NativeName("Name", "GL_RENDERBUFFER_BLUE_SIZE_EXT")]
        RenderbufferBlueSizeExt = 0x8D52,
        [NativeName("Name", "GL_RENDERBUFFER_BLUE_SIZE_OES")]
        RenderbufferBlueSizeOes = 0x8D52,
        [NativeName("Name", "GL_RENDERBUFFER_ALPHA_SIZE")]
        RenderbufferAlphaSize = 0x8D53,
        [NativeName("Name", "GL_RENDERBUFFER_ALPHA_SIZE_EXT")]
        RenderbufferAlphaSizeExt = 0x8D53,
        [NativeName("Name", "GL_RENDERBUFFER_ALPHA_SIZE_OES")]
        RenderbufferAlphaSizeOes = 0x8D53,
        [NativeName("Name", "GL_RENDERBUFFER_DEPTH_SIZE")]
        RenderbufferDepthSize = 0x8D54,
        [NativeName("Name", "GL_RENDERBUFFER_DEPTH_SIZE_EXT")]
        RenderbufferDepthSizeExt = 0x8D54,
        [NativeName("Name", "GL_RENDERBUFFER_DEPTH_SIZE_OES")]
        RenderbufferDepthSizeOes = 0x8D54,
        [NativeName("Name", "GL_RENDERBUFFER_STENCIL_SIZE")]
        RenderbufferStencilSize = 0x8D55,
        [NativeName("Name", "GL_RENDERBUFFER_STENCIL_SIZE_EXT")]
        RenderbufferStencilSizeExt = 0x8D55,
        [NativeName("Name", "GL_RENDERBUFFER_STENCIL_SIZE_OES")]
        RenderbufferStencilSizeOes = 0x8D55,
        [NativeName("Name", "GL_RENDERBUFFER_COLOR_SAMPLES_NV")]
        RenderbufferColorSamplesNV = 0x8E10,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_IMG")]
        RenderbufferSamplesImg = 0x9133,
        [NativeName("Name", "GL_RENDERBUFFER_STORAGE_SAMPLES_AMD")]
        RenderbufferStorageSamplesAmd = 0x91B2,
    }
}
