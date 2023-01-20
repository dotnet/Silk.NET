// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.NV
{
    [NativeName("Name", "GLenum")]
    public enum NV : int
    {
        [NativeName("Name", "WGL_ACCESS_READ_ONLY_NV")]
        AccessReadOnlyNV = 0x0,
        [NativeName("Name", "WGL_ACCESS_READ_WRITE_NV")]
        AccessReadWriteNV = 0x1,
        [NativeName("Name", "WGL_ACCESS_WRITE_DISCARD_NV")]
        AccessWriteDiscardNV = 0x2,
        [NativeName("Name", "WGL_FLOAT_COMPONENTS_NV")]
        FloatComponentsNV = 0x20B0,
        [NativeName("Name", "WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV")]
        BindToTextureRectangleFloatRNV = 0x20B1,
        [NativeName("Name", "WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV")]
        BindToTextureRectangleFloatRGNV = 0x20B2,
        [NativeName("Name", "WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV")]
        BindToTextureRectangleFloatRgbNV = 0x20B3,
        [NativeName("Name", "WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV")]
        BindToTextureRectangleFloatRgbaNV = 0x20B4,
        [NativeName("Name", "WGL_TEXTURE_FLOAT_R_NV")]
        TextureFloatRNV = 0x20B5,
        [NativeName("Name", "WGL_TEXTURE_FLOAT_RG_NV")]
        TextureFloatRGNV = 0x20B6,
        [NativeName("Name", "WGL_TEXTURE_FLOAT_RGB_NV")]
        TextureFloatRgbNV = 0x20B7,
        [NativeName("Name", "WGL_TEXTURE_FLOAT_RGBA_NV")]
        TextureFloatRgbaNV = 0x20B8,
        [NativeName("Name", "ERROR_INCOMPATIBLE_AFFINITY_MASKS_NV")]
        ErrorIncompatibleAffinityMasksNV = 0x20D0,
        [NativeName("Name", "ERROR_MISSING_AFFINITY_MASK_NV")]
        ErrorMissingAffinityMaskNV = 0x20D1,
        [NativeName("Name", "WGL_CONTEXT_MULTIGPU_ATTRIB_NV")]
        ContextMultigpuAttribNV = 0x20AA,
        [NativeName("Name", "WGL_CONTEXT_MULTIGPU_ATTRIB_SINGLE_NV")]
        ContextMultigpuAttribSingleNV = 0x20AB,
        [NativeName("Name", "WGL_CONTEXT_MULTIGPU_ATTRIB_AFR_NV")]
        ContextMultigpuAttribAfrNV = 0x20AC,
        [NativeName("Name", "WGL_CONTEXT_MULTIGPU_ATTRIB_MULTICAST_NV")]
        ContextMultigpuAttribMulticastNV = 0x20AD,
        [NativeName("Name", "WGL_CONTEXT_MULTIGPU_ATTRIB_MULTI_DISPLAY_MULTICAST_NV")]
        ContextMultigpuAttribMultiDisplayMulticastNV = 0x20AE,
        [NativeName("Name", "WGL_COVERAGE_SAMPLES_NV")]
        CoverageSamplesNV = 0x2042,
        [NativeName("Name", "WGL_COLOR_SAMPLES_NV")]
        ColorSamplesNV = 0x20B9,
        [NativeName("Name", "WGL_NUM_VIDEO_SLOTS_NV")]
        NumVideoSlotsNV = 0x20F0,
        [NativeName("Name", "WGL_BIND_TO_TEXTURE_DEPTH_NV")]
        BindToTextureDepthNV = 0x20A3,
        [NativeName("Name", "WGL_BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV")]
        BindToTextureRectangleDepthNV = 0x20A4,
        [NativeName("Name", "WGL_DEPTH_TEXTURE_FORMAT_NV")]
        DepthTextureFormatNV = 0x20A5,
        [NativeName("Name", "WGL_TEXTURE_DEPTH_COMPONENT_NV")]
        TextureDepthComponentNV = 0x20A6,
        [NativeName("Name", "WGL_DEPTH_COMPONENT_NV")]
        DepthComponentNV = 0x20A7,
        [NativeName("Name", "WGL_BIND_TO_TEXTURE_RECTANGLE_RGB_NV")]
        BindToTextureRectangleRgbNV = 0x20A0,
        [NativeName("Name", "WGL_BIND_TO_TEXTURE_RECTANGLE_RGBA_NV")]
        BindToTextureRectangleRgbaNV = 0x20A1,
        [NativeName("Name", "WGL_TEXTURE_RECTANGLE_NV")]
        TextureRectangleNV = 0x20A2,
        [NativeName("Name", "WGL_UNIQUE_ID_NV")]
        UniqueIDNV = 0x20CE,
        [NativeName("Name", "WGL_NUM_VIDEO_CAPTURE_SLOTS_NV")]
        NumVideoCaptureSlotsNV = 0x20CF,
        [NativeName("Name", "WGL_BIND_TO_VIDEO_RGB_NV")]
        BindToVideoRgbNV = 0x20C0,
        [NativeName("Name", "WGL_BIND_TO_VIDEO_RGBA_NV")]
        BindToVideoRgbaNV = 0x20C1,
        [NativeName("Name", "WGL_BIND_TO_VIDEO_RGB_AND_DEPTH_NV")]
        BindToVideoRgbAndDepthNV = 0x20C2,
        [NativeName("Name", "WGL_VIDEO_OUT_COLOR_NV")]
        VideoOutColorNV = 0x20C3,
        [NativeName("Name", "WGL_VIDEO_OUT_ALPHA_NV")]
        VideoOutAlphaNV = 0x20C4,
        [NativeName("Name", "WGL_VIDEO_OUT_DEPTH_NV")]
        VideoOutDepthNV = 0x20C5,
        [NativeName("Name", "WGL_VIDEO_OUT_COLOR_AND_ALPHA_NV")]
        VideoOutColorAndAlphaNV = 0x20C6,
        [NativeName("Name", "WGL_VIDEO_OUT_COLOR_AND_DEPTH_NV")]
        VideoOutColorAndDepthNV = 0x20C7,
        [NativeName("Name", "WGL_VIDEO_OUT_FRAME")]
        VideoOutFrame = 0x20C8,
        [NativeName("Name", "WGL_VIDEO_OUT_FIELD_1")]
        VideoOutField1 = 0x20C9,
        [NativeName("Name", "WGL_VIDEO_OUT_FIELD_2")]
        VideoOutField2 = 0x20CA,
        [NativeName("Name", "WGL_VIDEO_OUT_STACKED_FIELDS_1_2")]
        VideoOutStackedFields12 = 0x20CB,
        [NativeName("Name", "WGL_VIDEO_OUT_STACKED_FIELDS_2_1")]
        VideoOutStackedFields21 = 0x20CC,
    }
}
