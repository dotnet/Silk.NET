// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_LAYER_OPTIONS1")]
    public enum LayerOptions1 : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_LAYER_OPTIONS1_NONE")]
        LayerOptions1None = 0x0,
        [Obsolete("Deprecated in favour of \"InitializeFromBackground\"")]
        [NativeName("Name", "D2D1_LAYER_OPTIONS1_INITIALIZE_FROM_BACKGROUND")]
        LayerOptions1InitializeFromBackground = 0x1,
        [Obsolete("Deprecated in favour of \"IgnoreAlpha\"")]
        [NativeName("Name", "D2D1_LAYER_OPTIONS1_IGNORE_ALPHA")]
        LayerOptions1IgnoreAlpha = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_LAYER_OPTIONS1_FORCE_DWORD")]
        LayerOptions1ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_LAYER_OPTIONS1_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_LAYER_OPTIONS1_INITIALIZE_FROM_BACKGROUND")]
        InitializeFromBackground = 0x1,
        [NativeName("Name", "D2D1_LAYER_OPTIONS1_IGNORE_ALPHA")]
        IgnoreAlpha = 0x2,
        [NativeName("Name", "D2D1_LAYER_OPTIONS1_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
