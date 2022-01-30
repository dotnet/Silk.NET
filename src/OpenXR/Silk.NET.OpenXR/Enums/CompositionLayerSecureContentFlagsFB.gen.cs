// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrCompositionLayerSecureContentFlagsFB")]
    public enum CompositionLayerSecureContentFlagsFB : long
    {
        [NativeName("Name", "XR_COMPOSITION_LAYER_SECURE_CONTENT_EXCLUDE_LAYER_BIT_FB")]
        CompositionLayerSecureContentExcludeLayerBitFB = 1,
        [NativeName("Name", "XR_COMPOSITION_LAYER_SECURE_CONTENT_REPLACE_LAYER_BIT_FB")]
        CompositionLayerSecureContentReplaceLayerBitFB = 2,
    }
}
