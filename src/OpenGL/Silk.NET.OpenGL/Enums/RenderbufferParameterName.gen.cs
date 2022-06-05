// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "RenderbufferParameterName")]
    public enum RenderbufferParameterName : int
    {
        [Obsolete("Deprecated in favour of \"CoverageSamplesNV\"")]
        [NativeName("Name", "GL_RENDERBUFFER_COVERAGE_SAMPLES_NV")]
        RenderbufferCoverageSamplesNV = 0x8CAB,
        [Obsolete("Deprecated in favour of \"Samples\"")]
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES")]
        RenderbufferSamples = 0x8CAB,
        [Obsolete("Deprecated in favour of \"SamplesAngle\"")]
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_ANGLE")]
        RenderbufferSamplesAngle = 0x8CAB,
        [Obsolete("Deprecated in favour of \"SamplesApple\"")]
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_APPLE")]
        RenderbufferSamplesApple = 0x8CAB,
        [Obsolete("Deprecated in favour of \"SamplesExt\"")]
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_EXT")]
        RenderbufferSamplesExt = 0x8CAB,
        [Obsolete("Deprecated in favour of \"SamplesNV\"")]
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_NV")]
        RenderbufferSamplesNV = 0x8CAB,
        [Obsolete("Deprecated in favour of \"Width\"")]
        [NativeName("Name", "GL_RENDERBUFFER_WIDTH")]
        RenderbufferWidth = 0x8D42,
        [Obsolete("Deprecated in favour of \"WidthExt\"")]
        [NativeName("Name", "GL_RENDERBUFFER_WIDTH_EXT")]
        RenderbufferWidthExt = 0x8D42,
        [Obsolete("Deprecated in favour of \"WidthOes\"")]
        [NativeName("Name", "GL_RENDERBUFFER_WIDTH_OES")]
        RenderbufferWidthOes = 0x8D42,
        [Obsolete("Deprecated in favour of \"Height\"")]
        [NativeName("Name", "GL_RENDERBUFFER_HEIGHT")]
        RenderbufferHeight = 0x8D43,
        [Obsolete("Deprecated in favour of \"HeightExt\"")]
        [NativeName("Name", "GL_RENDERBUFFER_HEIGHT_EXT")]
        RenderbufferHeightExt = 0x8D43,
        [Obsolete("Deprecated in favour of \"HeightOes\"")]
        [NativeName("Name", "GL_RENDERBUFFER_HEIGHT_OES")]
        RenderbufferHeightOes = 0x8D43,
        [Obsolete("Deprecated in favour of \"InternalFormat\"")]
        [NativeName("Name", "GL_RENDERBUFFER_INTERNAL_FORMAT")]
        RenderbufferInternalFormat = 0x8D44,
        [Obsolete("Deprecated in favour of \"InternalFormatExt\"")]
        [NativeName("Name", "GL_RENDERBUFFER_INTERNAL_FORMAT_EXT")]
        RenderbufferInternalFormatExt = 0x8D44,
        [Obsolete("Deprecated in favour of \"InternalFormatOes\"")]
        [NativeName("Name", "GL_RENDERBUFFER_INTERNAL_FORMAT_OES")]
        RenderbufferInternalFormatOes = 0x8D44,
        [Obsolete("Deprecated in favour of \"RedSize\"")]
        [NativeName("Name", "GL_RENDERBUFFER_RED_SIZE")]
        RenderbufferRedSize = 0x8D50,
        [Obsolete("Deprecated in favour of \"RedSizeExt\"")]
        [NativeName("Name", "GL_RENDERBUFFER_RED_SIZE_EXT")]
        RenderbufferRedSizeExt = 0x8D50,
        [Obsolete("Deprecated in favour of \"RedSizeOes\"")]
        [NativeName("Name", "GL_RENDERBUFFER_RED_SIZE_OES")]
        RenderbufferRedSizeOes = 0x8D50,
        [Obsolete("Deprecated in favour of \"GreenSize\"")]
        [NativeName("Name", "GL_RENDERBUFFER_GREEN_SIZE")]
        RenderbufferGreenSize = 0x8D51,
        [Obsolete("Deprecated in favour of \"GreenSizeExt\"")]
        [NativeName("Name", "GL_RENDERBUFFER_GREEN_SIZE_EXT")]
        RenderbufferGreenSizeExt = 0x8D51,
        [Obsolete("Deprecated in favour of \"GreenSizeOes\"")]
        [NativeName("Name", "GL_RENDERBUFFER_GREEN_SIZE_OES")]
        RenderbufferGreenSizeOes = 0x8D51,
        [Obsolete("Deprecated in favour of \"BlueSize\"")]
        [NativeName("Name", "GL_RENDERBUFFER_BLUE_SIZE")]
        RenderbufferBlueSize = 0x8D52,
        [Obsolete("Deprecated in favour of \"BlueSizeExt\"")]
        [NativeName("Name", "GL_RENDERBUFFER_BLUE_SIZE_EXT")]
        RenderbufferBlueSizeExt = 0x8D52,
        [Obsolete("Deprecated in favour of \"BlueSizeOes\"")]
        [NativeName("Name", "GL_RENDERBUFFER_BLUE_SIZE_OES")]
        RenderbufferBlueSizeOes = 0x8D52,
        [Obsolete("Deprecated in favour of \"AlphaSize\"")]
        [NativeName("Name", "GL_RENDERBUFFER_ALPHA_SIZE")]
        RenderbufferAlphaSize = 0x8D53,
        [Obsolete("Deprecated in favour of \"AlphaSizeExt\"")]
        [NativeName("Name", "GL_RENDERBUFFER_ALPHA_SIZE_EXT")]
        RenderbufferAlphaSizeExt = 0x8D53,
        [Obsolete("Deprecated in favour of \"AlphaSizeOes\"")]
        [NativeName("Name", "GL_RENDERBUFFER_ALPHA_SIZE_OES")]
        RenderbufferAlphaSizeOes = 0x8D53,
        [Obsolete("Deprecated in favour of \"DepthSize\"")]
        [NativeName("Name", "GL_RENDERBUFFER_DEPTH_SIZE")]
        RenderbufferDepthSize = 0x8D54,
        [Obsolete("Deprecated in favour of \"DepthSizeExt\"")]
        [NativeName("Name", "GL_RENDERBUFFER_DEPTH_SIZE_EXT")]
        RenderbufferDepthSizeExt = 0x8D54,
        [Obsolete("Deprecated in favour of \"DepthSizeOes\"")]
        [NativeName("Name", "GL_RENDERBUFFER_DEPTH_SIZE_OES")]
        RenderbufferDepthSizeOes = 0x8D54,
        [Obsolete("Deprecated in favour of \"StencilSize\"")]
        [NativeName("Name", "GL_RENDERBUFFER_STENCIL_SIZE")]
        RenderbufferStencilSize = 0x8D55,
        [Obsolete("Deprecated in favour of \"StencilSizeExt\"")]
        [NativeName("Name", "GL_RENDERBUFFER_STENCIL_SIZE_EXT")]
        RenderbufferStencilSizeExt = 0x8D55,
        [Obsolete("Deprecated in favour of \"StencilSizeOes\"")]
        [NativeName("Name", "GL_RENDERBUFFER_STENCIL_SIZE_OES")]
        RenderbufferStencilSizeOes = 0x8D55,
        [Obsolete("Deprecated in favour of \"ColorSamplesNV\"")]
        [NativeName("Name", "GL_RENDERBUFFER_COLOR_SAMPLES_NV")]
        RenderbufferColorSamplesNV = 0x8E10,
        [Obsolete("Deprecated in favour of \"SamplesImg\"")]
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_IMG")]
        RenderbufferSamplesImg = 0x9133,
        [Obsolete("Deprecated in favour of \"StorageSamplesAmd\"")]
        [NativeName("Name", "GL_RENDERBUFFER_STORAGE_SAMPLES_AMD")]
        RenderbufferStorageSamplesAmd = 0x91B2,
        [NativeName("Name", "GL_RENDERBUFFER_COVERAGE_SAMPLES_NV")]
        CoverageSamplesNV = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES")]
        Samples = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_ANGLE")]
        SamplesAngle = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_APPLE")]
        SamplesApple = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_EXT")]
        SamplesExt = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_NV")]
        SamplesNV = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_WIDTH")]
        Width = 0x8D42,
        [NativeName("Name", "GL_RENDERBUFFER_WIDTH_EXT")]
        WidthExt = 0x8D42,
        [NativeName("Name", "GL_RENDERBUFFER_WIDTH_OES")]
        WidthOes = 0x8D42,
        [NativeName("Name", "GL_RENDERBUFFER_HEIGHT")]
        Height = 0x8D43,
        [NativeName("Name", "GL_RENDERBUFFER_HEIGHT_EXT")]
        HeightExt = 0x8D43,
        [NativeName("Name", "GL_RENDERBUFFER_HEIGHT_OES")]
        HeightOes = 0x8D43,
        [NativeName("Name", "GL_RENDERBUFFER_INTERNAL_FORMAT")]
        InternalFormat = 0x8D44,
        [NativeName("Name", "GL_RENDERBUFFER_INTERNAL_FORMAT_EXT")]
        InternalFormatExt = 0x8D44,
        [NativeName("Name", "GL_RENDERBUFFER_INTERNAL_FORMAT_OES")]
        InternalFormatOes = 0x8D44,
        [NativeName("Name", "GL_RENDERBUFFER_RED_SIZE")]
        RedSize = 0x8D50,
        [NativeName("Name", "GL_RENDERBUFFER_RED_SIZE_EXT")]
        RedSizeExt = 0x8D50,
        [NativeName("Name", "GL_RENDERBUFFER_RED_SIZE_OES")]
        RedSizeOes = 0x8D50,
        [NativeName("Name", "GL_RENDERBUFFER_GREEN_SIZE")]
        GreenSize = 0x8D51,
        [NativeName("Name", "GL_RENDERBUFFER_GREEN_SIZE_EXT")]
        GreenSizeExt = 0x8D51,
        [NativeName("Name", "GL_RENDERBUFFER_GREEN_SIZE_OES")]
        GreenSizeOes = 0x8D51,
        [NativeName("Name", "GL_RENDERBUFFER_BLUE_SIZE")]
        BlueSize = 0x8D52,
        [NativeName("Name", "GL_RENDERBUFFER_BLUE_SIZE_EXT")]
        BlueSizeExt = 0x8D52,
        [NativeName("Name", "GL_RENDERBUFFER_BLUE_SIZE_OES")]
        BlueSizeOes = 0x8D52,
        [NativeName("Name", "GL_RENDERBUFFER_ALPHA_SIZE")]
        AlphaSize = 0x8D53,
        [NativeName("Name", "GL_RENDERBUFFER_ALPHA_SIZE_EXT")]
        AlphaSizeExt = 0x8D53,
        [NativeName("Name", "GL_RENDERBUFFER_ALPHA_SIZE_OES")]
        AlphaSizeOes = 0x8D53,
        [NativeName("Name", "GL_RENDERBUFFER_DEPTH_SIZE")]
        DepthSize = 0x8D54,
        [NativeName("Name", "GL_RENDERBUFFER_DEPTH_SIZE_EXT")]
        DepthSizeExt = 0x8D54,
        [NativeName("Name", "GL_RENDERBUFFER_DEPTH_SIZE_OES")]
        DepthSizeOes = 0x8D54,
        [NativeName("Name", "GL_RENDERBUFFER_STENCIL_SIZE")]
        StencilSize = 0x8D55,
        [NativeName("Name", "GL_RENDERBUFFER_STENCIL_SIZE_EXT")]
        StencilSizeExt = 0x8D55,
        [NativeName("Name", "GL_RENDERBUFFER_STENCIL_SIZE_OES")]
        StencilSizeOes = 0x8D55,
        [NativeName("Name", "GL_RENDERBUFFER_COLOR_SAMPLES_NV")]
        ColorSamplesNV = 0x8E10,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_IMG")]
        SamplesImg = 0x9133,
        [NativeName("Name", "GL_RENDERBUFFER_STORAGE_SAMPLES_AMD")]
        StorageSamplesAmd = 0x91B2,
    }
}
