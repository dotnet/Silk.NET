// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVAHD_FEATURE_CAPS")]
    public enum HDFeatureCaps : int
    {
        [NativeName("Name", "DXVAHD_FEATURE_CAPS_ALPHA_FILL")]
        HDFeatureCapsAlphaFill = 0x1,
        [NativeName("Name", "DXVAHD_FEATURE_CAPS_CONSTRICTION")]
        HDFeatureCapsConstriction = 0x2,
        [NativeName("Name", "DXVAHD_FEATURE_CAPS_LUMA_KEY")]
        HDFeatureCapsLumaKey = 0x4,
        [NativeName("Name", "DXVAHD_FEATURE_CAPS_ALPHA_PALETTE")]
        HDFeatureCapsAlphaPalette = 0x8,
    }
}
