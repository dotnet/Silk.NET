// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPLAYCONFIG_COLOR_ENCODING
{
    DISPLAYCONFIG_COLOR_ENCODING_RGB = 0,
    DISPLAYCONFIG_COLOR_ENCODING_YCBCR444 = 1,
    DISPLAYCONFIG_COLOR_ENCODING_YCBCR422 = 2,
    DISPLAYCONFIG_COLOR_ENCODING_YCBCR420 = 3,
    DISPLAYCONFIG_COLOR_ENCODING_INTENSITY = 4,
    DISPLAYCONFIG_COLOR_ENCODING_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
}
