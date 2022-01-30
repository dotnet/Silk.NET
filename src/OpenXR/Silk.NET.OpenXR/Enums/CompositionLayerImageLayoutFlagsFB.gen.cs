// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrCompositionLayerImageLayoutFlagsFB")]
    public enum CompositionLayerImageLayoutFlagsFB : long
    {
        [NativeName("Name", "XR_COMPOSITION_LAYER_IMAGE_LAYOUT_VERTICAL_FLIP_BIT_FB")]
        CompositionLayerImageLayoutVerticalFlipBitFB = 1,
    }
}
