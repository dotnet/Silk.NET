// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS")]
    public enum VideoProcessorFeatureCaps : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"AlphaFill\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ALPHA_FILL")]
        VideoProcessorFeatureCapsAlphaFill = 0x1,
        [Obsolete("Deprecated in favour of \"Constriction\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_CONSTRICTION")]
        VideoProcessorFeatureCapsConstriction = 0x2,
        [Obsolete("Deprecated in favour of \"LumaKey\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_LUMA_KEY")]
        VideoProcessorFeatureCapsLumaKey = 0x4,
        [Obsolete("Deprecated in favour of \"AlphaPalette\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ALPHA_PALETTE")]
        VideoProcessorFeatureCapsAlphaPalette = 0x8,
        [Obsolete("Deprecated in favour of \"Legacy\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_LEGACY")]
        VideoProcessorFeatureCapsLegacy = 0x10,
        [Obsolete("Deprecated in favour of \"Stereo\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_STEREO")]
        VideoProcessorFeatureCapsStereo = 0x20,
        [Obsolete("Deprecated in favour of \"Rotation\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ROTATION")]
        VideoProcessorFeatureCapsRotation = 0x40,
        [Obsolete("Deprecated in favour of \"AlphaStream\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ALPHA_STREAM")]
        VideoProcessorFeatureCapsAlphaStream = 0x80,
        [Obsolete("Deprecated in favour of \"PixelAspectRatio\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_PIXEL_ASPECT_RATIO")]
        VideoProcessorFeatureCapsPixelAspectRatio = 0x100,
        [Obsolete("Deprecated in favour of \"Mirror\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_MIRROR")]
        VideoProcessorFeatureCapsMirror = 0x200,
        [Obsolete("Deprecated in favour of \"ShaderUsage\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_SHADER_USAGE")]
        VideoProcessorFeatureCapsShaderUsage = 0x400,
        [Obsolete("Deprecated in favour of \"MetadataHdr10\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_METADATA_HDR10")]
        VideoProcessorFeatureCapsMetadataHdr10 = 0x800,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ALPHA_FILL")]
        AlphaFill = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_CONSTRICTION")]
        Constriction = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_LUMA_KEY")]
        LumaKey = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ALPHA_PALETTE")]
        AlphaPalette = 0x8,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_LEGACY")]
        Legacy = 0x10,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_STEREO")]
        Stereo = 0x20,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ROTATION")]
        Rotation = 0x40,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ALPHA_STREAM")]
        AlphaStream = 0x80,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_PIXEL_ASPECT_RATIO")]
        PixelAspectRatio = 0x100,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_MIRROR")]
        Mirror = 0x200,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_SHADER_USAGE")]
        ShaderUsage = 0x400,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_METADATA_HDR10")]
        MetadataHdr10 = 0x800,
    }
}
