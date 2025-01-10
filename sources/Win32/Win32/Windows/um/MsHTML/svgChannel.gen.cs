// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum svgChannel
{
    SVG_CHANNEL_UNKNOWN = 0,
    SVG_CHANNEL_R = 1,
    SVG_CHANNEL_G = 2,
    SVG_CHANNEL_B = 3,
    SVG_CHANNEL_A = 4,
    svgChannel_Max = 2147483647,
}
