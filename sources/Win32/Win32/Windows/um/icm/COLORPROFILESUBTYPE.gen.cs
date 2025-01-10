// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum COLORPROFILESUBTYPE
{
    CPST_PERCEPTUAL = 0,
    CPST_RELATIVE_COLORIMETRIC = 1,
    CPST_SATURATION = 2,
    CPST_ABSOLUTE_COLORIMETRIC = 3,
    CPST_NONE,
    CPST_RGB_WORKING_SPACE,
    CPST_CUSTOM_WORKING_SPACE,
    CPST_STANDARD_DISPLAY_COLOR_MODE,
    CPST_EXTENDED_DISPLAY_COLOR_MODE,
}
