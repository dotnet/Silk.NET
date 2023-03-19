// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_DPICOMPENSATION_PROP")]
    public enum DpicompensationProp : int
    {
        [Obsolete("Deprecated in favour of \"InterpolationMode\"")]
        [NativeName("Name", "D2D1_DPICOMPENSATION_PROP_INTERPOLATION_MODE")]
        DpicompensationPropInterpolationMode = 0x0,
        [Obsolete("Deprecated in favour of \"BorderMode\"")]
        [NativeName("Name", "D2D1_DPICOMPENSATION_PROP_BORDER_MODE")]
        DpicompensationPropBorderMode = 0x1,
        [Obsolete("Deprecated in favour of \"InputDpi\"")]
        [NativeName("Name", "D2D1_DPICOMPENSATION_PROP_INPUT_DPI")]
        DpicompensationPropInputDpi = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_DPICOMPENSATION_PROP_FORCE_DWORD")]
        DpicompensationPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_DPICOMPENSATION_PROP_INTERPOLATION_MODE")]
        InterpolationMode = 0x0,
        [NativeName("Name", "D2D1_DPICOMPENSATION_PROP_BORDER_MODE")]
        BorderMode = 0x1,
        [NativeName("Name", "D2D1_DPICOMPENSATION_PROP_INPUT_DPI")]
        InputDpi = 0x2,
        [NativeName("Name", "D2D1_DPICOMPENSATION_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
