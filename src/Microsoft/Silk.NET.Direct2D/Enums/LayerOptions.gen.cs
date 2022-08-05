// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_LAYER_OPTIONS")]
    public enum LayerOptions : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_LAYER_OPTIONS_NONE")]
        LayerOptionsNone = 0x0,
        [Obsolete("Deprecated in favour of \"InitializeForCleartype\"")]
        [NativeName("Name", "D2D1_LAYER_OPTIONS_INITIALIZE_FOR_CLEARTYPE")]
        LayerOptionsInitializeForCleartype = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_LAYER_OPTIONS_FORCE_DWORD")]
        LayerOptionsForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_LAYER_OPTIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_LAYER_OPTIONS_INITIALIZE_FOR_CLEARTYPE")]
        InitializeForCleartype = 0x1,
        [NativeName("Name", "D2D1_LAYER_OPTIONS_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
