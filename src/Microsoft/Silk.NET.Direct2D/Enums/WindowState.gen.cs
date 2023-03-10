// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_WINDOW_STATE")]
    public enum WindowState : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_WINDOW_STATE_NONE")]
        WindowStateNone = 0x0,
        [Obsolete("Deprecated in favour of \"Occluded\"")]
        [NativeName("Name", "D2D1_WINDOW_STATE_OCCLUDED")]
        WindowStateOccluded = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_WINDOW_STATE_FORCE_DWORD")]
        WindowStateForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_WINDOW_STATE_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_WINDOW_STATE_OCCLUDED")]
        Occluded = 0x1,
        [NativeName("Name", "D2D1_WINDOW_STATE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
