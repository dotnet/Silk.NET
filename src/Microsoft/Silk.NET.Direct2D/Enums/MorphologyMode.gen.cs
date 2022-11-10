// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_MORPHOLOGY_MODE")]
    public enum MorphologyMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Erode\"")]
        [NativeName("Name", "D2D1_MORPHOLOGY_MODE_ERODE")]
        MorphologyModeErode = 0x0,
        [Obsolete("Deprecated in favour of \"Dilate\"")]
        [NativeName("Name", "D2D1_MORPHOLOGY_MODE_DILATE")]
        MorphologyModeDilate = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_MORPHOLOGY_MODE_FORCE_DWORD")]
        MorphologyModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_MORPHOLOGY_MODE_ERODE")]
        Erode = 0x0,
        [NativeName("Name", "D2D1_MORPHOLOGY_MODE_DILATE")]
        Dilate = 0x1,
        [NativeName("Name", "D2D1_MORPHOLOGY_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
